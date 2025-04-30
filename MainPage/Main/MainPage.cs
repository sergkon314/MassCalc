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
            CreatePage("MassBids");
        }

        private void page2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatePage("MassCalc");
        }

        private void CreatePage(string pageName) 
        {
            if (string.IsNullOrEmpty(pageName)) return;
            if (this.Controls.ContainsKey(pageName))
            {
                BasePage page_to_down = (BasePage)this.Controls[0];
                BasePage page_to_up = (BasePage)this.Controls.Find(pageName, true)[0];
                this.Controls.SetChildIndex(page_to_up, 0);
            }
            else
            {
                BasePage page_to_add;
                if (pageName == "MassBids")
                {
                    page_to_add = new MassBids(this, pageName);
                }
                else if (pageName == "MassCalc")
                {
                    page_to_add = new MassCalc(this, pageName);

                }
                else
                {
                    dms.pages.Utils.DmsMsgBoxs.Ok("Неизвестная страница");
                    return;
                }
                if (page_to_add == null) return;
                page_to_add.Dock = DockStyle.Fill;                
                page_to_add.LoadData();
                this.Controls.Add(page_to_add);
                this.Controls.SetChildIndex(page_to_add, 0);
            }
        }
    }
}
