using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dms.pages.Mass.Dialogs;
using System.Windows.Forms;
using dms.pages.Utils;

namespace dms.pages.Main
{
    public class MassBids : MassFilling
    {
        private System.Windows.Forms.Button btn_copyFrom;
        private System.Windows.Forms.Button btn_copyTo;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_delBid;
        private System.Windows.Forms.Button btn_changeCode;
        private System.Windows.Forms.Button btn_delCode;
        private System.Windows.Forms.Button btn_choiseCode;
        private Button btn_view;
        private Button btn_dup;
        private Button btn_print;
        private System.Windows.Forms.Button btn_addbid;

        public MassBids(MainPage o, string name) : base(o, name) { InitializeComponent(); }

        new private void InitializeComponent()
        {
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_dup = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_changeCode = new System.Windows.Forms.Button();
            this.btn_delCode = new System.Windows.Forms.Button();
            this.btn_choiseCode = new System.Windows.Forms.Button();
            this.btn_copyFrom = new System.Windows.Forms.Button();
            this.btn_copyTo = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_delBid = new System.Windows.Forms.Button();
            this.btn_addbid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_data.SuspendLayout();
            this.gb_fillBid.SuspendLayout();
            this.gb_sum.SuspendLayout();
            this.gb_bids.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_projects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_codes)).BeginInit();
            this.SuspendLayout();
            // 
            // split
            // 
            // 
            // gb_fillBid
            // 
            this.gb_fillBid.Controls.Add(this.btn_print);
            this.gb_fillBid.Controls.Add(this.btn_dup);
            this.gb_fillBid.Controls.Add(this.btn_view);
            this.gb_fillBid.Controls.Add(this.btn_changeCode);
            this.gb_fillBid.Controls.Add(this.btn_delCode);
            this.gb_fillBid.Controls.Add(this.btn_choiseCode);
            // 
            // cb_status
            // 
            this.cb_status.Size = new System.Drawing.Size(167, 21);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_copyFrom);
            this.groupBox2.Controls.Add(this.btn_copyTo);
            this.groupBox2.Controls.Add(this.btn_copy);
            this.groupBox2.Controls.Add(this.btn_delBid);
            this.groupBox2.Controls.Add(this.btn_addbid);
            this.groupBox2.Controls.SetChildIndex(this.cb_status, 0);
            this.groupBox2.Controls.SetChildIndex(this.label17, 0);
            this.groupBox2.Controls.SetChildIndex(this.btn_addbid, 0);
            this.groupBox2.Controls.SetChildIndex(this.btn_delBid, 0);
            this.groupBox2.Controls.SetChildIndex(this.btn_copy, 0);
            this.groupBox2.Controls.SetChildIndex(this.btn_copyTo, 0);
            this.groupBox2.Controls.SetChildIndex(this.btn_copyFrom, 0);
            // 
            // btn_print
            // 
            this.btn_print.Image = global::dms.pages.Properties.Resources.printer;
            this.btn_print.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_print.Location = new System.Drawing.Point(9, 246);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(162, 23);
            this.btn_print.TabIndex = 37;
            this.btn_print.Text = "Печать";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_dup
            // 
            this.btn_dup.Image = global::dms.pages.Properties.Resources.table_row_insert;
            this.btn_dup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dup.Location = new System.Drawing.Point(9, 151);
            this.btn_dup.Name = "btn_dup";
            this.btn_dup.Size = new System.Drawing.Size(162, 23);
            this.btn_dup.TabIndex = 36;
            this.btn_dup.Text = "Копировать КОД";
            this.btn_dup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dup.UseVisualStyleBackColor = true;
            this.btn_dup.Click += new System.EventHandler(this.btn_dup_Click);
            // 
            // btn_view
            // 
            this.btn_view.Image = global::dms.pages.Properties.Resources.application1;
            this.btn_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_view.Location = new System.Drawing.Point(9, 208);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(162, 23);
            this.btn_view.TabIndex = 35;
            this.btn_view.Text = "В отдельном окне";
            this.btn_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_view.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_changeCode
            // 
            this.btn_changeCode.Image = global::dms.pages.Properties.Resources.table_edit;
            this.btn_changeCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_changeCode.Location = new System.Drawing.Point(9, 109);
            this.btn_changeCode.Name = "btn_changeCode";
            this.btn_changeCode.Size = new System.Drawing.Size(162, 23);
            this.btn_changeCode.TabIndex = 13;
            this.btn_changeCode.Text = "Изменить КОД";
            this.btn_changeCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_changeCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_changeCode.UseVisualStyleBackColor = true;
            this.btn_changeCode.Click += new System.EventHandler(this.btn_changeCode_Click);
            // 
            // btn_delCode
            // 
            this.btn_delCode.Image = global::dms.pages.Properties.Resources.table_row_delete;
            this.btn_delCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delCode.Location = new System.Drawing.Point(9, 69);
            this.btn_delCode.Name = "btn_delCode";
            this.btn_delCode.Size = new System.Drawing.Size(162, 23);
            this.btn_delCode.TabIndex = 12;
            this.btn_delCode.Text = "Удалить КОД";
            this.btn_delCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delCode.UseVisualStyleBackColor = true;
            this.btn_delCode.Click += new System.EventHandler(this.btn_delCode_Click);
            // 
            // btn_choiseCode
            // 
            this.btn_choiseCode.Image = global::dms.pages.Properties.Resources.table_row_insert;
            this.btn_choiseCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_choiseCode.Location = new System.Drawing.Point(9, 29);
            this.btn_choiseCode.Name = "btn_choiseCode";
            this.btn_choiseCode.Size = new System.Drawing.Size(162, 23);
            this.btn_choiseCode.TabIndex = 11;
            this.btn_choiseCode.Text = "Добавить КОД";
            this.btn_choiseCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_choiseCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_choiseCode.UseVisualStyleBackColor = true;
            this.btn_choiseCode.Click += new System.EventHandler(this.btn_choiseCode_Click);
            // 
            // btn_copyFrom
            // 
            this.btn_copyFrom.Image = global::dms.pages.Properties.Resources.table_relationship;
            this.btn_copyFrom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_copyFrom.Location = new System.Drawing.Point(9, 217);
            this.btn_copyFrom.Name = "btn_copyFrom";
            this.btn_copyFrom.Size = new System.Drawing.Size(162, 23);
            this.btn_copyFrom.TabIndex = 33;
            this.btn_copyFrom.Text = "Копировать из  проекта";
            this.btn_copyFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_copyFrom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_copyFrom.UseVisualStyleBackColor = true;
            this.btn_copyFrom.Click += new System.EventHandler(this.btn_copyFrom_Click);
            // 
            // btn_copyTo
            // 
            this.btn_copyTo.Image = global::dms.pages.Properties.Resources.table_go;
            this.btn_copyTo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_copyTo.Location = new System.Drawing.Point(9, 180);
            this.btn_copyTo.Name = "btn_copyTo";
            this.btn_copyTo.Size = new System.Drawing.Size(162, 23);
            this.btn_copyTo.TabIndex = 32;
            this.btn_copyTo.Text = "Копировать в проект";
            this.btn_copyTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_copyTo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_copyTo.UseVisualStyleBackColor = true;
            this.btn_copyTo.Click += new System.EventHandler(this.btn_copyTo_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.Image = global::dms.pages.Properties.Resources.table_multiple;
            this.btn_copy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_copy.Location = new System.Drawing.Point(9, 144);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(162, 23);
            this.btn_copy.TabIndex = 31;
            this.btn_copy.Text = "Создать копию";
            this.btn_copy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_copy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_delBid
            // 
            this.btn_delBid.Image = global::dms.pages.Properties.Resources.table_delete;
            this.btn_delBid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delBid.Location = new System.Drawing.Point(9, 108);
            this.btn_delBid.Name = "btn_delBid";
            this.btn_delBid.Size = new System.Drawing.Size(162, 23);
            this.btn_delBid.TabIndex = 30;
            this.btn_delBid.Text = "Удалить заявку";
            this.btn_delBid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delBid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delBid.UseVisualStyleBackColor = true;
            this.btn_delBid.Click += new System.EventHandler(this.btn_delBid_Click);
            // 
            // btn_addbid
            // 
            this.btn_addbid.Image = global::dms.pages.Properties.Resources.table_add;
            this.btn_addbid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addbid.Location = new System.Drawing.Point(9, 72);
            this.btn_addbid.Name = "btn_addbid";
            this.btn_addbid.Size = new System.Drawing.Size(162, 23);
            this.btn_addbid.TabIndex = 29;
            this.btn_addbid.Text = "Добавить заявку";
            this.btn_addbid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addbid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addbid.UseVisualStyleBackColor = true;
            this.btn_addbid.Click += new System.EventHandler(this.btn_addbid_Click);
            // 
            // MassBids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "MassBids";
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_data.ResumeLayout(false);
            this.gb_fillBid.ResumeLayout(false);
            this.gb_sum.ResumeLayout(false);
            this.gb_sum.PerformLayout();
            this.gb_bids.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_projects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_codes)).EndInit();
            this.ResumeLayout(false);

        }

        public override void LoadData(object extData)
        {
            base.LoadData(extData);
            chk_myprojects.Visible = false;
            cb_status.SelectedIndex = 0;
        }
        protected override void dg_bids_SelectionChanged(object sender, EventArgs e)
        {
            base.dg_bids_SelectionChanged(sender, e);
            if (dg_bids.SelectedRows.Count == 0)
                return;
            int id = (int)(dg_bids.SelectedRows[0].Cells["id"].Value);
            DMSdbDataSet.mass_bidRow row = dt_bids.FindByid(id);
            int claim = GetBidCurrentClaim(row);

            //if (row.uid != MainPage.CurrentUser2.Uid)
            //    btn_delBid.Enabled = false;
            //else
            //{
                if (row.claim > 0)
                    btn_delBid.Enabled = false;
                else
                    btn_delBid.Enabled = true;
            //}
        }


        protected override void ViewBidData(int bid_id, int version_by, string name, bool isEdit)
        {
            base.ViewBidData(bid_id, version_by, name, isEdit);
            btn_dup.Enabled = btn_choiseCode.Enabled = btn_delCode.Enabled = btn_changeCode.Enabled = isEdit;
        }

        private void btn_choiseCode_Click(object sender, EventArgs e)
        {
            if (dg_bids.SelectedRows.Count == 0)
                return;
            int bid = (int)(dg_bids.SelectedRows[0].Cells["id"].Value);
            if (GetBidCurrentClaim(dt_bids.FindByid(bid)) != 0)
                return;
            ChoiseTextCode d = new ChoiseTextCode(dt_codes);
            DialogResult res = d.ShowDialog();
            if (res == DialogResult.Cancel)
                return;
            DataGridViewRowCollection rows = d.SelectedItems;
            foreach (DataGridViewRow r in rows)
            {
                string code = r.Cells[1].Value as string;
                string code_name = r.Cells[2].Value as string;
                ta_data.Insert1((int)bid, code, code_name);
            }
            FillData();
        }

        private void btn_delCode_Click(object sender, EventArgs e)
        {
            if (dg_bids.SelectedCells.Count == 0)
                return;
            int bid = (int)(dg_bids.SelectedRows[0].Cells["id"].Value);
            if (GetBidCurrentClaim(dt_bids.FindByid(bid)) != 0)
                return;
            int rid = dg_data.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dg_data.Rows[rid].Cells["id"].Value);
            DMSdbDataSet.mass_data_bidRow row = dt_data.FindByid((int)id);
            if (!DmsMsgBoxs.WarningOkCancelParam("Строка '{0}' будет полностью удалена. Продолжить?", row.code + " " + row.name_code)) return;
            ta_data.DeleteBidItemData(id);
            FillData();
        }

        private void btn_changeCode_Click(object sender, EventArgs e)
        {
            if (dg_bids.SelectedCells.Count == 0)
                return;
            int bid = (int)(dg_bids.SelectedRows[0].Cells["id"].Value);
            if (GetBidCurrentClaim(dt_bids.FindByid(bid)) != 0)
                return;
            int rid = dg_data.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dg_data.Rows[rid].Cells["id"].Value);
            ChoiseTextCode d = new ChoiseTextCode(dt_codes);
            DialogResult res = d.ShowDialog();
            if (res == DialogResult.Cancel)
                return;
            DataGridViewRowCollection rows = d.SelectedItems;
            DataGridViewRow item = rows[0];
            string code = item.Cells[1].Value as string;
            string name_code = item.Cells[2].Value as string;
            DMSdbDataSet.mass_data_bidRow r = dt_data.FindByid(id);
            r.code = code;
            r.name_code = name_code;
            ta_data.UpdateBidItem(r.code, r.name_code, r.m, r.x, r.y, r.z, r.id);
        }
        private bool CheckActiveProject()
        {
            DMSdbDataSet.mass_projectRow row = GetSelectedProject();
            if (row.deleted == 2)
            {
                DmsMsgBoxs.InfoOkParam("Проект {0} закрыт для добавления заявок.", row.name);
                return false;
            }
            return true;
        }
        private void btn_addbid_Click(object sender, EventArgs e)
        {
            if (!CheckActiveProject())
                return;
            int project_id = GetSelectedProject().id;
            //ta_bids.Insert(MainPage.CurrentUser2.Uid, DateTime.Now, project_id);
            ta_bids.Insert1("1000", DateTime.Now, project_id);
            FillBids();
            SetBidCellAccess();
            FillData();
        }

        private void btn_delBid_Click(object sender, EventArgs e)
        {

            if (!CheckActiveProject())
                return;
            if (dg_bids.SelectedRows.Count == 0)
                return;
            DMSdbDataSet.mass_projectRow rowp = GetSelectedProject();
            if (rowp.deleted == 2)
            {
                DmsMsgBoxs.InfoOkParam("Проект {0} закрыт для добавления заявок.", rowp.name);
                return;
            }
            int id = (int)(dg_bids.SelectedRows[0].Cells["id"].Value);
            DMSdbDataSet.mass_bidRow row = dt_bids.FindByid(id);
            if (GetBidCurrentClaim(row) != 0)
                return;

            if (!DmsMsgBoxs.WarningOkCancelParam("Заявка '{0}' будет полностью удалена. Продолжить?", row.bid_name))
                return;
            ta_bids.DeleteBidById((int)id);
            ta_data.DeleteBidData((int)id);
            int pos = dg_bids.SelectedRows[0].Index;
            gb_data.Text = "Данные:";
            dg_bids.Rows.RemoveAt(pos);
            FillData();
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            if (!CheckActiveProject())
                return;
            if (dg_bids.SelectedRows.Count == 0)
                return;
            DataGridViewRow row = dg_bids.SelectedRows[0];
            int project_id = GetSelectedProject().id;
            int bid = Convert.ToInt32(row.Cells["id"].Value);
            CopyBid(project_id, bid);
            FillBids();
            SetBidCellAccess();
            FillData();
        }

        private void btn_copyTo_Click(object sender, EventArgs e)
        {
            if (dg_bids.SelectedRows.Count == 0)
                return;
            DataGridViewRow row = dg_bids.SelectedRows[0];
            string bidInfo = "№" + row.Cells["id"].Value + " " + row.Cells["bid_name"].Value;
            ProjectCopyTo d = new ProjectCopyTo(bidInfo);
            DialogResult res = d.ShowDialog();
            if (res == DialogResult.Cancel)
                return;
            int project_id = d.SelectedProjectId;
            int bid = Convert.ToInt32(row.Cells["id"].Value);
            CopyBid(project_id, bid);
        }

        private void btn_copyFrom_Click(object sender, EventArgs e)
        {
            string projectInfo = GetSelectedProject().name;
            ProjectCopyFrom d = new ProjectCopyFrom(projectInfo);
            DialogResult res = d.ShowDialog();
            if (res == DialogResult.Cancel)
                return;
            int bid = d.SelectedBidId;
            int project_id = GetSelectedProject().id;
            CopyBid(project_id, bid);
            FillBids();
            SetBidCellAccess();
            FillData();
        }
        private void CopyBid(int target_project_id, int bid_id_to_copy)
        {
            //ta_bids.Insert(MainPage.CurrentUser2.Uid, DateTime.Now, target_project_id);
            ta_bids.Insert1("1000", DateTime.Now, target_project_id);
            DMSdbDataSet.mass_bidDataTable bid_tmp = ta_bids.GetDataByProjectId(target_project_id);
            int new_bidid = Convert.ToInt32(bid_tmp.Compute("max(id)", string.Empty));
            //int new_bidid = Convert.ToInt32(ta_bids.LastInsertId());
            DMSdbDataSet.mass_data_bidDataTable tmp = ta_data.GetDataForCopy(bid_id_to_copy);
            foreach (DMSdbDataSet.mass_data_bidRow r in tmp)
            {
                r.bid_id = new_bidid;
                ta_data.InsertItemCopy(r.bid_id, r.code, r.name_code, r.m, r.x, r.y, r.z);
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            if (dg_bids.SelectedRows.Count == 0)
                return;
            DataGridViewRow row = dg_bids.SelectedRows[0];
            uint bid_id = Convert.ToUInt32(row.Cells["id"].Value);
            string name = row.Cells["bid_name"].Value as string;
            BidVersionView d = new BidVersionView(name, (int)bid_id);
            d.Show();
        }

        private void btn_dup_Click(object sender, EventArgs e)
        {
            if (dg_data.SelectedCells.Count == 0)
                return;
            int ind = dg_data.SelectedCells[0].RowIndex;
            int id = Convert.ToInt32(dg_data.Rows[ind].Cells["id"].Value);
            DMSdbDataSet.mass_data_bidRow r = dt_data.FindByid(id);
            ta_data.InsertItemCopy(r.bid_id, r.code, r.name_code, r.m, r.x, r.y, r.z);
            FillData();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (dg_bids.SelectedRows.Count == 0)
                return;
            DataGridViewRow row = dg_bids.SelectedRows[0];
            uint bid_id = Convert.ToUInt32(row.Cells["id"].Value);
            string name = row.Cells["bid_name"].Value as string;
            string autor = row.Cells["huid"].Value as string;
            PrintDGV.Print_DataGridView(dg_data, "Проект: " + GetSelectedProject().name + ".   Заявка №" + bid_id + " \"" + name + "\".   Автор: " + autor);
        }
    }
}
