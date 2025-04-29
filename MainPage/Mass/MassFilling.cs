using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using dms.pages.Utils;
using dms.pages.Utils.DMSdbDataSetTableAdapters;

namespace dms.pages.Main
{
    public partial class MassFilling : BasePage
    {

        protected DMSdbDataSet.mass_projectDataTable dt_projects = new DMSdbDataSet.mass_projectDataTable();
        protected DMSdbDataSet.mass_bidDataTable dt_bids;
        protected DMSdbDataSet.mass_data_bidDataTable dt_data;
        protected DMSdbDataSet.mass_text_codeDataTable dt_codes = new DMSdbDataSet.mass_text_codeDataTable();
        protected mass_text_codeTableAdapter ta_codes = new mass_text_codeTableAdapter();
        protected mass_data_bidTableAdapter ta_data = new mass_data_bidTableAdapter();
        protected mass_bidTableAdapter ta_bids = new mass_bidTableAdapter();
        protected mass_projectTableAdapter ta_projects = new mass_projectTableAdapter();
        

        public MassFilling()
        {
            InitializeComponent();

        }
        public MassFilling(MainPage o, string name)
            : base(o, name)
        {
            InitializeComponent();
            this.Load += new EventHandler(MassFilling_Load);

            ta_codes.Connection.ConnectionString = "Dsn=PostgreSQL;database=DMSdb;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;lfconversion=1;updatablecursors=1;trueisminus1=0;bi=0;byteaaslongvarbinary=1;useserversideprepare=1;lowercaseidentifier=0;d6=-101;optionalerrors=0;fetchrefcursors=0;xaopt=1";
            ta_data.Connection.ConnectionString = "Dsn=PostgreSQL;database=DMSdb;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;lfconversion=1;updatablecursors=1;trueisminus1=0;bi=0;byteaaslongvarbinary=1;useserversideprepare=1;lowercaseidentifier=0;d6=-101;optionalerrors=0;fetchrefcursors=0;xaopt=1";
            ta_bids.Connection.ConnectionString = "Dsn=PostgreSQL;database=DMSdb;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;lfconversion=1;updatablecursors=1;trueisminus1=0;bi=0;byteaaslongvarbinary=1;useserversideprepare=1;lowercaseidentifier=0;d6=-101;optionalerrors=0;fetchrefcursors=0;xaopt=1";
            ta_projects.Connection.ConnectionString = "Dsn=PostgreSQL;database=DMSdb;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;lfconversion=1;updatablecursors=1;trueisminus1=0;bi=0;byteaaslongvarbinary=1;useserversideprepare=1;lowercaseidentifier=0;d6=-101;optionalerrors=0;fetchrefcursors=0;xaopt=1";
             
        }

        
        public override void Reload()
        {
            /*
            MainPage.MassCalcSettingsObj.cbProjectSelectedIndex = cb_projects.SelectedIndex;
            MainPage.MassCalcSettingsObj.cbProjectsGroupSelectedIndex = cb_pgroup.SelectedIndex;
            MainPage.MassCalcSettingsObj.cbStatusSelectedIndex = cb_status.SelectedIndex;
            MainPage.MassCalcSettingsObj.chkOnlyMyProjectChecked = chk_myprojects.Checked;
             */ 
        }
        public override void LoadData(object extData)
        {
            CultureInfo inf = new CultureInfo(System.Threading.Thread.CurrentThread.CurrentCulture.Name);
            System.Threading.Thread.CurrentThread.CurrentCulture = inf;
            inf.NumberFormat.NumberDecimalSeparator = ",";
            inf.NumberFormat.NumberGroupSeparator = "";
            dg_data.Height = 550;
            this.dg_data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left))));
            split.SplitterDistance = 480;
            
            ta_codes.Fill(dt_codes);
            ta_projects.Fill(dt_projects);
            InitProjectsGroupComboBox(ref cb_pgroup);
            cb_pgroup.SelectedIndex = 0; //MainPage.MassCalcSettingsObj.cbProjectsGroupSelectedIndex;
            InitProjectsComboBox();
            ApplyGroupFilter();
            InitBidsStatusFilterComboBox();


            //cb_projects.SelectedIndex = MainPage.MassCalcSettingsObj.cbProjectSelectedIndex;
            //cb_status.SelectedIndex = MainPage.MassCalcSettingsObj.cbStatusSelectedIndex;
            //chk_myprojects.Checked = MainPage.MassCalcSettingsObj.chkOnlyMyProjectChecked;

            InitBidsDataGridView(dg_bids);
            InitBidsDataDataGridView(dg_data);

        }
        protected virtual void MassFilling_Load(object sender, EventArgs e)
        {
            cb_pgroup.SelectedIndexChanged += new EventHandler(FilterProject);
            chk_myprojects.Click += new EventHandler(FilterProject);
            FillBids();
            SetBidCellAccess();
            cb_status.SelectedIndexChanged += new EventHandler(FilterBidsByStatus);
            cb_projects.SelectedIndexChanged += new EventHandler(FilterBidsByProject);
            dg_data.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dg_data_EditingControlShowing);
            dg_data.DataError += new DataGridViewDataErrorEventHandler(dg_data_DataError);
            dg_data.CellEndEdit += new DataGridViewCellEventHandler(dg_data_CellEndEdit);
            dg_bids.SelectionChanged += new EventHandler(dg_bids_SelectionChanged);
            dg_bids.CellEndEdit += new DataGridViewCellEventHandler(dg_bids_CellEndEdit);
            dg_bids.DataError += new DataGridViewDataErrorEventHandler(dg_bids_DataError);
            dg_bids.ClearSelection();
            cb_projects.SelectedIndex = 0;
            SetChkMyProjectEnabled();
        }

        void dg_data_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tx = e.Control as TextBox;
            if (tx != null)
            {
                if (dg_data.CurrentCell.ColumnIndex > 3)
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
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
            {
                e.Handled = true;
            }

        }

        private void SetChkMyProjectEnabled()
        {
            //Group2 g = Group2.GroupByGid(GROUP_CLAIM2);
            //if (g.CheckSecondaryMember(MainPage.CurrentUser2))
            //{
                chk_myprojects.Enabled = true;
            //}
            //else
            //{
            //    chk_myprojects.Enabled = false;
            //}
        }

        void dg_data_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dg_data.Rows[e.RowIndex].Cells["id"].Value);
            DMSdbDataSet.mass_data_bidRow row = dt_data.FindByid(id);
            if (row.m < 0)
            {
                 DmsMsgBoxs.OkFail("Масса не должна задаваться отрицательным числом.");
                 dg_data.CancelEdit();
                 return;
            }
            if ((float)row.x > Lgb && e.ColumnIndex == 5)
                DmsMsgBoxs.WarningOkParam("X больше установленной для проекта величины Lгб/2={0}.", Lgb);

            if ((float)row.y > Bgb && e.ColumnIndex == 6)
                DmsMsgBoxs.WarningOkParam("Y больше установленной для проекта величины Bгб/2={0}.", Bgb);

            if ((float)row.z > Hgb && e.ColumnIndex == 7)
                DmsMsgBoxs.WarningOkParam("Z больше установленной для проекта величины Hгб={0}.", Hgb);

            if (row.z < 0 && e.ColumnIndex == 7)
                DmsMsgBoxs.WarningOkParam("Z меньше нуля: {0}.", row.z);

            ta_data.UpdateBidItem(row.code, row.name_code, row.m, row.x, row.y, row.z, row.id);
            CalcSum(ref dt_data);
        }

        protected virtual void dg_bids_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Cancel)
                DmsMsgBoxs.OkFail(e.Exception.Message);
        }

        protected virtual void dg_bids_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)(dg_bids.Rows[e.RowIndex].Cells["id"].Value);
            DMSdbDataSet.mass_bidRow row = dt_bids.FindByid(id);
            int i = ta_bids.UpdateBidItem(row.bid_name, row.description, (int)row.id);
        }

        protected virtual void dg_data_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Cancel)
                DmsMsgBoxs.OkFail(e.Exception.Message);
        }

        protected virtual void dg_bids_SelectionChanged(object sender, EventArgs e)
        {
            FillData();
        }
        protected virtual void FillData()
        {
            if (dg_bids.SelectedRows.Count == 0)
            {
                ResetDataGroupBox();
                return;
            }
            int id = (int)(dg_bids.SelectedRows[0].Cells["id"].Value);
            DMSdbDataSet.mass_bidRow row = dt_bids.FindByid(id);
            uint bid = Convert.ToUInt32(dg_bids.SelectedRows[0].Cells["id"].Value);
            GetBidCurrentClaim(row);
            ViewBidData((int)row.id, (int)row.version_by, row.bid_name, row.beditable);

        }
        protected virtual void FilterBidsByProject(object sender, EventArgs e)
        {
            FillBids();
            SetBidCellAccess();
            FillData();
        }
        protected virtual void FilterBidsByStatus(object sender, EventArgs e)
        {
            DMSdbDataSet.mass_projectRow row = GetSelectedProject();
            int num = ApplyBidFilter(cb_status, dg_bids, dt_bids);
            SetBidsTableTitle(gb_bids, num, row.name, dt_bids.Rows.Count);
            SetBidCellAccess();
            dg_bids.Select();
            FillData();
            chkFilterCopy.Checked = false;
        }
        protected virtual void FilterProject(object sender, EventArgs e)
        {
            ApplyGroupFilter();
        }

        protected virtual void ApplyGroupFilter()
        {
            if (cb_pgroup.SelectedIndex == 8)
            {
                DmsMsgBoxs.InfoOkParam("Проекты в группе '{0}' не являются действующими и предназначены для черновых расчетов. Заявки, размещенные здесь, не требуют согласования.", cb_pgroup.SelectedItem);
            }
            int num = ApplyProjectFilter(cb_pgroup, cb_projects, dt_projects, chk_myprojects.Checked);
            lbl_num_projects.Text = Convert.ToString(num);
        }
        protected float Lgb, Bgb, Hgb;
        protected virtual void FillBids()
        {
            DMSdbDataSet.mass_projectRow row = GetSelectedProject();
            if (row == null)
                return;
            Lgb = (float)row.Lgb / 2;
            Bgb = (float)row.Bgb / 2;
            Hgb = (float)row.Hgb;
            dt_bids = ta_bids.GetDataByProjectId(row.id);
            FillCustomFields(dt_bids);
            dg_bids.DataSource = dt_bids;
            int num = ApplyBidFilter(cb_status, dg_bids, dt_bids);
            SetBidsTableTitle(gb_bids, num, row.name, dt_bids.Rows.Count);
            dg_bids.Select();
            ResetDataGroupBox();
        }

        protected virtual void SetBidCellAccess()
        {
            foreach (DataGridViewRow r in dg_bids.Rows)
            {
                bool isEdit = Convert.ToBoolean(r.Cells["beditable"].Value);
                r.Cells["bid_name"].ReadOnly = !isEdit;
                if (isEdit)
                    r.DefaultCellStyle.BackColor = SystemColors.Info;
                r.Cells["description"].ReadOnly = !isEdit;
            }
        }

        protected virtual void ResetDataGroupBox()
        {
            if (dt_data != null && dt_data.Rows.Count != 0)
                dt_data.Rows.Clear();
            gb_data.Text = "Данные:";
        }
        protected virtual void ResetBidsGroupBox()
        {
            if (dt_bids != null && dt_bids.Rows.Count != 0)
                dt_bids.Rows.Clear();
            gb_bids.Text = "Заявки:";
        }
        protected virtual void ViewBidData(int bid_id, int version_by, string name, bool isEdit)
        {
            gb_data.Text = "Данные: заявка №" + bid_id + " \"" + name + "\" ";
            dt_data = ta_data.GetBidData(bid_id);
            dg_data.DataSource = dt_data;
            dg_data.ReadOnly = !isEdit;
            if (isEdit)
                gb_data.Text += "(редактирование)";
            else
                gb_data.Text += "(только чтение)";
            dg_data.Columns["code"].ReadOnly = true;
            CalcSum(ref dt_data);
        }
        protected virtual float CalcSum(ref DMSdbDataSet.mass_data_bidDataTable dt)
        {
            int count = dt.Rows.Count;
            if (count == 0) return 0;
            gb_sum.Text = "Суммы";
            float M = 0, X = 0, Y = 0, Z = 0, Mx = 0, My = 0, Mz = 0;
            foreach (DMSdbDataSet.mass_data_bidRow r in dt)
            {
                M += (float)r.m; Mx += (float)r.mx; My += (float)r.my; Mz += (float)r.mz;
            }

            //if (M > 0)
            //{ X = Mx / M; Y = My / M; Z = Mz / M; }
            //else
            //{ X = 0; Y = 0; Z = 0; }
            //float Ma = Math.Abs(M);
            X = Mx / M; Y = My / M; Z = Mz / M;

            lbl_M.Text = M.ToString("N3");
            lbl_X.Text = X.ToString("N3");
            lbl_Y.Text = Y.ToString("N3");
            lbl_Z.Text = Z.ToString("N3");
            lbl_Mx.Text = Mx.ToString("N3");
            lbl_My.Text = My.ToString("N3");
            lbl_Mz.Text = Mz.ToString("N3");

            return M;

        }
        protected virtual void chkFilterCopy_CheckedChanged(object sender, EventArgs e)
        {
            if (dt_bids.Select("version_by > 0").Length > 0)
            {
                string filter = dt_bids.DefaultView.RowFilter;
                if (chkFilterCopy.Checked)
                {
                    if (string.IsNullOrEmpty(filter))
                    {
                        filter = "version_by=0";
                    }
                    else
                    {
                        filter += " and version_by=0";
                    }
                }
                else
                {
                    if (filter.Contains("and version_by=0"))
                    {
                        int i = filter.IndexOf("and version_by=0");
                        filter = filter.Substring(0, i);
                    }
                    if (filter.Contains("version_by=0"))
                    {
                        int i = filter.IndexOf("version_by=0");
                        filter = filter.Substring(0, i);
                    }
                }
                dt_bids.DefaultView.RowFilter = filter;
            }
        }
        protected virtual int GetBidCurrentClaim(DMSdbDataSet.mass_bidRow row)
        {
            int claim = (int)ta_bids.GetBidClaim(Convert.ToInt32(row.id));
            if (claim != row.claim)
            {
                row.claim = claim;
                row.hclaim = getHClaim(claim);
                row.beditable = IsEditableByCurrntUser(row.uid, row.claim, row.version_by);
            }
            //ViewBidData((int)row.id, (int)row.version_by, row.bid_name, row.beditable);
            return claim;
        }
    }
}
