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
     public partial class ProjectCopyTo : Form
     {
          private int _project_id;

          public int SelectedProjectId
          {
               get { return _project_id; }
          }
          public ProjectCopyTo(string bidInfo)
          {
               InitializeComponent();
               this.Text = "Копировать заявку в проект";
               this.lbl_bidName.Text = bidInfo;
          }

          private void ProjectCopyTo_Load(object sender, EventArgs e)
          {
              
              //this.mass_projectTableAdapter.Connection.ConnectionString = MainPage.ConnectionStringMysql;
             
               this.mass_projectTableAdapter.Fill(this.dmsMass.mass_project);
          }

          private void btn_cancel_Click(object sender, EventArgs e)
          {
               this.DialogResult = DialogResult.Cancel;
          }

          private void btn_ok_Click(object sender, EventArgs e)
          {
               if (dg.SelectedRows.Count == 0)
               {
                    return;
               }
               _project_id = Convert.ToInt32(dg.SelectedRows[0].Cells["id"].Value);
               DMSdbDataSet.mass_projectRow row = this.dmsMass.mass_project.FindByid(_project_id);
               
               if (row.deleted == 2)
               {
                   DmsMsgBoxs.InfoOkParam("Выбранный проект {0} закрыт для добавления заявок.", row.name);
                   return;
               }
               _project_id = Convert.ToInt32(dg.SelectedRows[0].Cells["id"].Value);
               this.DialogResult = DialogResult.OK;
          }
     }
}
