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
     public partial class VariantsView : Form
     {

          public VariantsView(DataSet ds)
          {
               InitializeComponent();
               this.Text = ds.DataSetName;
               foreach(DataTable dt in ds.Tables)
               {
                   VariantsPanel panel = new VariantsPanel(dt as DMSdbDataSet.mass_data_bidDataTable);
                    TabPage page = new TabPage(dt.TableName);
                    this.tabs.TabPages.Add(page);
                    page.Controls.Add(panel);

               }
          }

          private void VariantsView_Load(object sender, EventArgs e)
          {

          }
     }
}
