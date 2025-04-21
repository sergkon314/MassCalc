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
     
     public partial class StpEdit : Form
     {
          private DMSdbDataSet.mass_variantsDataTable data;
          public StpEdit(ref DMSdbDataSet.mass_variantsDataTable _data)
          {
               InitializeComponent();
               data = _data;
          }

          private void StpEdit_Load(object sender, EventArgs e)
          {
               dg.DataSource = data;
               DataGridViewColumnCollection cols = dg.Columns;
               DataGridViewColumn col;
               col = cols["id"];
               col.Visible = false;
               col.ReadOnly = true;
               col = cols["code"];
               col.Width = 60;
               col.HeaderText = "Код";
               int count = cols.Count;
               for (int i = 2; i < count; i++)
               {
                    col = cols[i];
                    col.Width = 40;
                    col.DefaultCellStyle.Format = "N2";
                    col.DefaultCellStyle.NullValue = 0;
               }
               col = cols["for10"];
               col.HeaderText = "Для 10";
               col = cols["for50"];
               col.HeaderText = "Для 50";
          }
     }
}
