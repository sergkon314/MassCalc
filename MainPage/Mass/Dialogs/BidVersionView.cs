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
     public partial class BidVersionView : Form
     {
          DMSdbDataSet.mass_data_bidDataTable data;
          private int id;
          public BidVersionView(string bidName, int bid_id)
          {
               InitializeComponent();
               this.Text = "Заявка: " + bidName + " (только чтение)";
               id = bid_id;
          }

          private void BidVersionView_Load(object sender, EventArgs e)
          {
              this.mass_data_bidTableAdapter.Connection.ConnectionString = "Dsn=PostgreSQL;database=DMSdb;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;lfconversion=1;updatablecursors=1;trueisminus1=0;bi=0;byteaaslongvarbinary=1;useserversideprepare=1;lowercaseidentifier=0;d6=-101;optionalerrors=0;fetchrefcursors=0;xaopt=1"; //MainPage.ConnectionStringMysql;
               data = this.mass_data_bidTableAdapter.GetBidData(id);
               dg_data.DataSource = data;
               dg_data.ReadOnly = true;
               CalcSum();
          }
          protected void CalcSum()
          {
               int count = data.Rows.Count;
               if (count == 0) return;
               data.AcceptChanges();
               float M = 0;
               float X = 0;
               float Y = 0;
               float Z = 0;
               float Mx = 0;
               float My = 0;
               float Mz = 0;
               foreach (DMSdbDataSet.mass_data_bidRow r in data)
               {
                    M += (float)r.m;
                    Mx += (float)r.mx;
                    My += (float)r.my;
                    Mz += (float)r.mz;
               }
               if (M > 0)
               {
                    X = (float)Math.Round(Mx / M, 3);
                    Y = (float)Math.Round(My / M, 3);
                    Z = (float)Math.Round(Mz / M, 3);
               }
               else
               {
                    X = 0;
                    Y = 0;
                    Z = 0;
               }
               lbl_M.Text = M.ToString("N3");
               lbl_X.Text = X.ToString("N3");
               lbl_Y.Text = Y.ToString("N3");
               lbl_Z.Text = Z.ToString("N3");
               lbl_Mx.Text = Mx.ToString("N3");
               lbl_My.Text = My.ToString("N3");
               lbl_Mz.Text = Mz.ToString("N3");
          }
     }
}
