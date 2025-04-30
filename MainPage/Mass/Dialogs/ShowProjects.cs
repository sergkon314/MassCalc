using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dms.pages.Utils;

namespace dms.pages.Mass.Dialogs
{
    public partial class ShowProjects : Form
    {   
        public ShowProjects()
        {
            InitializeComponent();
        }

        private void ShowProjects_Load(object sender, EventArgs e)
        {
            //this.mass_projectTableAdapter.Connection.ConnectionString = MainPage.ConnectionStringMysql;
            //server=debian;User Id=dms;password=210672;database=dms;Integrated Security=False;Allow User Variables=True;Allow Zero Datetime=True;Character Set=cp1251;Convert Zero Datetime=True
            //server=debian;User Id=dmsadmin;password=98130777;Persist Security Info=True;database=dms
            this.mass_projectTableAdapter.FillAll(this.dmsMass.mass_project);
            Colorize();
        }
        private void Colorize()
        {
            int i = 0;
            foreach (DataRow row in this.dmsMass.mass_project.Rows)
            {
                int status = row.Field<int>("deleted");
                Color c = Color.White;
                switch (status)
                {
                    case 0:
                        c = Color.White;
                        break;
                    case 1:
                        c = Color.LightGray;
                        break;
                    case 2:
                        c = Color.Honeydew;
                        break;
                }
                dg.Rows[i].DefaultCellStyle.BackColor = c;
                i++;
            }
        }
        void dg_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tx = e.Control as TextBox;
            if (tx != null)
            {
                if (dg.CurrentCell.ColumnIndex == 9)
                {
                    if (tx.Tag == null)
                    {
                        tx.KeyPress += new KeyPressEventHandler(tx_KeyPress);
                        tx.Tag = true;
                    }
                }
                else
                {
                    if (tx.Tag != null)
                    {
                        tx.KeyPress -= new KeyPressEventHandler(tx_KeyPress);
                        tx.Tag = null;
                    }
                }

            }
        }
        void tx_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox t = sender as TextBox;
            string val = t.Text;
            if (t.Text.Length <= 1)
            {

                if (e.KeyChar != (char)Keys.D0 && e.KeyChar != (char)Keys.D1 && e.KeyChar != (char)Keys.D2 && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
                t.Text = val.Substring(0, 1);
            }
            
            

        }
        

        private void dg_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow drow = dg.Rows[e.RowIndex];
            DataRowView vrow = drow.DataBoundItem as DataRowView;
            DMSdbDataSet.mass_projectRow row = vrow.Row as DMSdbDataSet.mass_projectRow;
            //DataRow row = this.dmsMass.mass_project.Rows[e.RowIndex];
            int d = row.deleted;
            int id = row.id;
            int res = 0;
            //this.mass_projectTableAdapter.Update1(row.name, row.id);
            string action = "";
            if (d == 0)
                action = "активный";
            if (d == 1)
                action = "удален";
            if (d == 2)
                action = "не активный";
            if (res == 1)
            {
                lblSave.Text = "Сохранено \"" + row.name + "\" - " + action;
                Colorize();
            }
            else
            {
                lblSave.Text = "Ошибка при сохранении \"" + row.name + "\"";
            }
        }
        
        private void dg_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dg_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            lblSave.Text = "";
        }

    }
}
