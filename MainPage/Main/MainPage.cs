using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dms.pages.Main
{
    public partial class MainPage : BasePage
    {
        public MainPage(Object o)
        {
            InitializeComponent();
        }

        private void page1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatePage(1);
        }

        private void page2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatePage(2);
        }

        private void CreatePage(int number) 
        {
            switch (number) { 
                case 1:
                    BasePage P = new MassFilling();
                    this.Controls.Add(P);
                    break;
                case 2:
                    MessageBox.Show("Страница 2");
                    break;
                default:
                    break;
            }   
        }
    }
}
