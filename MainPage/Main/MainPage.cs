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
            this.Dock = DockStyle.Fill;
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
                    BasePage P = new MassBids(this, "test");
                    P.Dock = DockStyle.Fill;
                    P.LoadData();
                    panel.Controls.Add(P);
                    break;
                case 2:
                    BasePage P2 = new MassCalc(this, "test");
                    P2.Dock = DockStyle.Fill;
                    P2.LoadData();
                    panel.Controls.Add(P2);
                    break;
                default:
                    break;
            }   
        }
    }
}
