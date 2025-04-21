using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dms.pages.Utils;

namespace dms.pages.Mass
{
    public partial class VariantsPanel : UserControl
    {
        public VariantsPanel(DMSdbDataSet.mass_data_bidDataTable dt)
        {
            InitializeComponent();
            InitBidsDataDataGridView(dg_data);
            dt.DefaultView.Sort = "code ASC";
            this.dg_data.DataSource = dt;
            CalcSum(ref dt);
            this.Dock = DockStyle.Fill;
            this.Load += new EventHandler(VariantsPanel_Load);
        }

        void VariantsPanel_Load(object sender, EventArgs e)
        {

            this.gb_sum.Width = this.Width;
            this.gb_sum.Location = new Point(0, this.Height - this.gb_sum.Height);
            this.gb_sum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left))));
            dg_data.Location = new Point(0, 0);
            dg_data.Width = this.gb_sum.Width;
            dg_data.Height = this.gb_sum.Top;
            this.dg_data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | System.Windows.Forms.AnchorStyles.Left))));
        }

        protected virtual void CalcSum(ref DMSdbDataSet.mass_data_bidDataTable dt)
        {
            int count = dt.Rows.Count;
            if (count == 0) return;
            gb_sum.Text = "Суммы";
            float M = 0, X = 0, Y = 0, Z = 0, Mx = 0, My = 0, Mz = 0;
            foreach (DMSdbDataSet.mass_data_bidRow r in dt)
            {
                M += (float)r.m; Mx += (float)r.mx; My += (float)r.my; Mz += (float)r.mz;
            }

            if (M > 0)
            { X = Mx / M; Y = My / M; Z = Mz / M; }
            else
            { X = 0; Y = 0; Z = 0; }

            lbl_M.Text = M.ToString("N3");
            lbl_X.Text = X.ToString("N3");
            lbl_Y.Text = Y.ToString("N3");
            lbl_Z.Text = Z.ToString("N3");
            lbl_Mx.Text = Mx.ToString("N3");
            lbl_My.Text = My.ToString("N3");
            lbl_Mz.Text = Mz.ToString("N3");


        }
        protected virtual void InitBidsDataDataGridView(DataGridView dg)
        {
            DMSdbDataSet.mass_data_bidDataTable dt = new DMSdbDataSet.mass_data_bidDataTable();
            dg.DataSource = dt;
            dg.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dg.RowHeadersVisible = false;
            dg.AllowUserToAddRows = false;
            dg.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            DataGridViewColumnCollection cols = dg.Columns;
            DataGridViewColumn col;
            DataGridViewCellStyle N3Style = new DataGridViewCellStyle();
            N3Style.Format = "N3";
            N3Style.NullValue = "0";
            //id,bid_id,code,name_code,m,x,y,z,mx,my,mz
            col = cols["id"];
            col.DataPropertyName = "id";
            col.Visible = false;
            col = cols["bid_id"];
            col.DataPropertyName = "bid_id";
            col.Visible = false;
            //
            col = cols["code"];
            col.DataPropertyName = "code";
            col.Width = 80;
            col.HeaderText = "Код";
            col.DisplayIndex = 0;
            col.ReadOnly = true;
            col.ValueType = typeof(string);
            //
            col = cols["name_code"];
            col.DataPropertyName = "name_code";
            col.Width = 350;
            col.HeaderText = "Наименование";
            col.DisplayIndex = 1;
            col.ReadOnly = false;
            col.ValueType = typeof(string);
            //
            col = cols["m"];
            col.DataPropertyName = "m";
            col.Width = 80;
            col.HeaderText = "М, т.";
            col.DisplayIndex = 2;
            col.ReadOnly = false;
            col.DefaultCellStyle = N3Style;
            col.ValueType = typeof(Single);
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //
            col = cols["x"];
            col.DataPropertyName = "x";
            col.Width = 80;
            col.HeaderText = "X, м.";
            col.DisplayIndex = 3;
            col.ReadOnly = false;
            col.DefaultCellStyle = N3Style;
            col.ValueType = typeof(Single);
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //
            col = cols["y"];
            col.DataPropertyName = "y";
            col.Width = 80;
            col.HeaderText = "Y, м.";
            col.DisplayIndex = 4;
            col.ReadOnly = false;
            col.DefaultCellStyle = N3Style;
            col.ValueType = typeof(Single);
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //
            col = cols["z"];
            col.DataPropertyName = "z";
            col.Width = 80;
            col.HeaderText = "Z, м.";
            col.DisplayIndex = 5;
            col.ReadOnly = false;
            col.DefaultCellStyle = N3Style;
            col.ValueType = typeof(Single);
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //
            col = cols["mx"];
            col.DataPropertyName = "mx";
            col.Width = 80;
            col.HeaderText = "Мx, т*м.";
            col.DisplayIndex = 6;
            col.ReadOnly = true;
            col.DefaultCellStyle = N3Style;
            col.ValueType = typeof(Single);
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //
            col = cols["my"];
            col.DataPropertyName = "my";
            col.Width = 80;
            col.HeaderText = "Мy, т*м.";
            col.DisplayIndex = 7;
            col.ReadOnly = true;
            col.DefaultCellStyle = N3Style;
            col.ValueType = typeof(Single);
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //
            col = cols["mz"];
            col.DataPropertyName = "mz";
            col.Width = 80;
            col.HeaderText = "Мz, т*м.";
            col.DisplayIndex = 8;
            col.ReadOnly = true;
            col.DefaultCellStyle = N3Style;
            col.ValueType = typeof(Single);
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }
}
