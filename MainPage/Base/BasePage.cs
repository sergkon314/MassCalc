using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dms.pages.Utils;
namespace dms.pages.Main
{
    public partial class BasePage : UserControl
    {
        protected static MainPage main = null;
        //test comment
        //protected static dmsDataSet.smbusersDataTable dt_smbusers;
        //protected static dmsDataSet.usersDataTable dt_dmsusers;
        //protected static dmsDataSet.smbgroupsDataTable dt_smbgroups;
        //protected static dmsDataSet.pagesDataTable dt_pages;
        //protected static dmsDataSet.stihDataTable dt_stih;
        protected string StatusText = "";
        protected internal string MysglConString = null;
        public BasePage() { }
        public BasePage(MainPage o, string name)
        {
            main = o;
            //dt_smbusers = main.dmsDS.smbusers;
            //dt_smbgroups = main.dmsDS.smbgroups;
            //dt_dmsusers = main.dmsDS.users;
            //dt_pages = main.dmsDS.pages;
            //dt_stih = main.dmsDS.stih;
            this.Dock = DockStyle.Fill;
            this.Name = name;
            //MysglConString = MainPage.ConnectionStringMysql;

        }

        public virtual void BeforeUp(object parm = null)
        {
            //MainPage.StatusText = this.StatusText;
        }
        public virtual void BeforeDown()
        {
            //this.StatusText = MainPage.StatusText;
        }
        public virtual void Reload() { }
        public virtual void LoadData(object extData = null)
        {
            Label info = new Label();
            info.Location = new Point(10, 10);
            info.BackColor = SystemColors.Info;
            info.AutoSize = true;
            info.Text = DmsStings.PAGE_INFO;
            this.Controls.Add(info);
        }

    }
}