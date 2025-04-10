using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace dms.pages
{
    public partial class MainFrm : Form
    {
        private const int WM_USER = 0x400;
        private string mainModule = "MainPage.dll";
        private string mainClass = "dms.pages.Main.MainPage";
        private UserControl mainPage = null;
        public MainFrm()
        {
            InitializeComponent();
            mainModule = Directory.GetCurrentDirectory() + "\\" + mainModule;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_USER + 1000:
                    ReloadMain();
                    break;
            }
            base.WndProc(ref m);
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            InitializeMainPage();
        }
        private void InitializeMainPage()
        {
            if (!File.Exists(mainModule))
            {
                MessageBox.Show("Can't find module Main in '" + mainModule + "'", "Монолит.NET- Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            byte[] rawAssembly = File.ReadAllBytes(mainModule);
            Assembly asm = Assembly.Load(rawAssembly);
            if (asm == null)
            {
                MessageBox.Show("Can't load module Main.", "Монолит.NET- Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            Type actClass = asm.GetType(mainClass, true, true);
            if (actClass == null)
            {
                MessageBox.Show("Can't find class Main.", "Монолит.NET- Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            CreateMain(actClass);
        }
        private void CreateMain(Type actClass)
        {
            ConstructorInfo ci = actClass.GetConstructor(new Type[] { typeof(object) });
            try
            {
                mainPage = (UserControl)ci.Invoke(new object[] { this });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Монолит.NET- Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (mainPage == null)
            {
                MessageBox.Show("Can't create Main.", "Монолит.NET- Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            this.Controls.Add(mainPage);
        }
        public void ReloadMain()
        {
            this.Controls.Remove(mainPage);
            //mainPage.Dispose();
            //mainPage = null;
            InitializeMainPage();
        }
    }
}
