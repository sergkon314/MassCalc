using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dms.pages.Mass.Dialogs;
using dms.pages.Utils;

namespace dms.pages.Main
{
    public class MassClaim : MassFilling
    {
        private System.Windows.Forms.CheckBox chk_claim2;
        private System.Windows.Forms.Button btn_changeUser;
        private System.Windows.Forms.Label lbl_claim1;
        private System.Windows.Forms.Label lbl_claim2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.Label label1;
        private Button btn_view;
        private System.Windows.Forms.CheckBox chk_claim1;

        public MassClaim(MainPage o, string name) : base(o, name) { InitializeComponent(); }

        new private void InitializeComponent()
        {
            this.chk_claim2 = new System.Windows.Forms.CheckBox();
            this.btn_changeUser = new System.Windows.Forms.Button();
            this.chk_claim1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_note = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_claim2 = new System.Windows.Forms.Label();
            this.lbl_claim1 = new System.Windows.Forms.Label();
            this.btn_view = new System.Windows.Forms.Button();
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
            this.gb_fillBid.Controls.Add(this.btn_view);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_claim1);
            this.groupBox2.Controls.Add(this.lbl_claim2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lbl_note);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_changeUser);
            this.groupBox2.Controls.Add(this.chk_claim2);
            this.groupBox2.Controls.Add(this.chk_claim1);
            this.groupBox2.Controls.SetChildIndex(this.cb_status, 0);
            this.groupBox2.Controls.SetChildIndex(this.label17, 0);
            this.groupBox2.Controls.SetChildIndex(this.chk_claim1, 0);
            this.groupBox2.Controls.SetChildIndex(this.chk_claim2, 0);
            this.groupBox2.Controls.SetChildIndex(this.btn_changeUser, 0);
            this.groupBox2.Controls.SetChildIndex(this.label1, 0);
            this.groupBox2.Controls.SetChildIndex(this.lbl_note, 0);
            this.groupBox2.Controls.SetChildIndex(this.label10, 0);
            this.groupBox2.Controls.SetChildIndex(this.lbl_claim2, 0);
            this.groupBox2.Controls.SetChildIndex(this.lbl_claim1, 0);
            // 
            // chk_claim2
            // 
            this.chk_claim2.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.chk_claim2.Image = global::dms.pages.Properties.Resources.user_edit;
            this.chk_claim2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chk_claim2.Location = new System.Drawing.Point(9, 138);
            this.chk_claim2.Name = "chk_claim2";
            this.chk_claim2.Size = new System.Drawing.Size(120, 20);
            this.chk_claim2.TabIndex = 30;
            this.chk_claim2.Text = "гл.конструктор";
            this.chk_claim2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chk_claim2.UseVisualStyleBackColor = true;
            // 
            // btn_changeUser
            // 
            this.btn_changeUser.Image = global::dms.pages.Properties.Resources.user_go;
            this.btn_changeUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_changeUser.Location = new System.Drawing.Point(4, 63);
            this.btn_changeUser.Name = "btn_changeUser";
            this.btn_changeUser.Size = new System.Drawing.Size(148, 23);
            this.btn_changeUser.TabIndex = 33;
            this.btn_changeUser.Text = "Сменить исполнителя";
            this.btn_changeUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_changeUser.UseVisualStyleBackColor = true;
            this.btn_changeUser.Click += new System.EventHandler(this.btn_changeUser_Click);
            // 
            // chk_claim1
            // 
            this.chk_claim1.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.chk_claim1.Image = global::dms.pages.Properties.Resources.user_edit;
            this.chk_claim1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chk_claim1.Location = new System.Drawing.Point(8, 112);
            this.chk_claim1.Name = "chk_claim1";
            this.chk_claim1.Size = new System.Drawing.Size(120, 20);
            this.chk_claim1.TabIndex = 29;
            this.chk_claim1.Text = "подразделение";
            this.chk_claim1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chk_claim1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Image = global::dms.pages.Properties.Resources.pencil;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "       Утверждение:";
            // 
            // lbl_note
            // 
            this.lbl_note.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_note.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_note.Location = new System.Drawing.Point(6, 184);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(252, 53);
            this.lbl_note.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.Info;
            this.label10.Image = global::dms.pages.Properties.Resources.error;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(6, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 22);
            this.label10.TabIndex = 36;
            this.label10.Text = "       Примечание:";
            // 
            // lbl_claim2
            // 
            this.lbl_claim2.AutoSize = true;
            this.lbl_claim2.Location = new System.Drawing.Point(134, 139);
            this.lbl_claim2.Name = "lbl_claim2";
            this.lbl_claim2.Size = new System.Drawing.Size(0, 13);
            this.lbl_claim2.TabIndex = 38;
            // 
            // lbl_claim1
            // 
            this.lbl_claim1.AutoSize = true;
            this.lbl_claim1.Location = new System.Drawing.Point(134, 113);
            this.lbl_claim1.Name = "lbl_claim1";
            this.lbl_claim1.Size = new System.Drawing.Size(0, 13);
            this.lbl_claim1.TabIndex = 39;
            // 
            // btn_view
            // 
            this.btn_view.Image = global::dms.pages.Properties.Resources.application1;
            this.btn_view.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_view.Location = new System.Drawing.Point(9, 29);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(162, 23);
            this.btn_view.TabIndex = 36;
            this.btn_view.Text = "В отдельном окне";
            this.btn_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_view.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // MassClaim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "MassClaim";
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

        protected override void FillCustomFields(DMSdbDataSet.mass_bidDataTable dt)
        {
            foreach (DMSdbDataSet.mass_bidRow r in dt.Rows)
            {
                r.hclaim = getHClaim(r.claim);
                r.huid = getHUid(r.uid);
                r.hgid = getHGid(r.uid);
                r.hdatetime = getHDateTime(r.date_time);
                r.beditable = false;
            }
        }


        protected override void MassFilling_Load(object sender, EventArgs e)
        {
            base.MassFilling_Load(sender, e);
            //SetProjectMasterLabelText();
            chk_claim1.Click += new EventHandler(chk_claim1_Click);
            chk_claim2.Click += new EventHandler(chk_claim2_Click);
            lbl_note.Text = "Заявка сначала утверждается начальником подразделения отправителя, затем главным конструктором проекта.  Снять флажок \"подразделение\", если заявка была одобрена главным конструкторм, может только руководитель расчетного сектора.";
        }

        protected override void FilterBidsByProject(object sender, EventArgs e)
        {
            base.FilterBidsByProject(sender, e);
            //SetProjectMasterLabelText();
            SetBidMasterLabelText();
        }

        protected override void dg_bids_SelectionChanged(object sender, EventArgs e)
        {
            base.dg_bids_SelectionChanged(sender, e);
            SetBidMasterLabelText();
        }

        //protected void SetProjectMasterLabelText()
        //{
        //    string uid = GetSelectedProject().master;
        //    User2 u = User2.UserByUid2(uid);
        //    lbl_claim2.Text = u.ShortName;
        //    chk_claim1.Checked = chk_claim2.Checked = false;
        //    chk_claim1.Enabled = chk_claim2.Enabled = false;
        //}
        protected void SetBidMasterLabelText()
        {
            if (dg_bids.SelectedRows.Count == 0)
            {
                lbl_claim1.Text = "(выберите заявку)";
                return;
            }
            lbl_claim1.Text = "";
            DataGridViewRow r = dg_bids.SelectedRows[0];
            string uid = r.Cells["uid"].Value as string;
            //User2 user = User2.UserByUid2(uid);
            //List<Group2> deps = user.Departments;

            //foreach (User2 u in deps[0].PrimaryMembers)
            //    lbl_claim1.Text += u.ShortName + " ";

            //Group2 primary_group = Group2.GroupByGid(user.Gid);
            //foreach (User2 u in primary_group.PrimaryMembers)
            //{
            //     lbl_claim1.Text += u.ShortName + " ";
            //}
            uint version_by = Convert.ToUInt32(r.Cells["version_by"].Value);
            uint claim = Convert.ToUInt32(r.Cells["claim"].Value);
            //SetClaimCheckBoxes(version_by, claim, user);

        }

        //private void SetClaimCheckBoxes(uint version_by, uint claim, User2 user)
        //{
        //    Group2 grp = Group2.GroupByGid2(MainPage.CurrentUser2.Gid);
        //    //Group2 grp = Group2.GroupByGid2(user.Gid);
        //    //bool isMaster = grp.CheckSecondaryMember(user);// || MainPage.CurrentUser2.Uid == user.Uid;
        //    bool isMaster = grp.CheckPrimaryMember(MainPage.CurrentUser2);
        //    if (grp.Gid != "1000")// domainusers
        //    {
        //        lbl_claim1.Text = MainPage.CurrentUser2.ShortName;
        //        btn_changeUser.Enabled = isMaster && claim == 0 && version_by == 0;
        //    }
        //    chk_claim1.Checked = chk_claim2.Checked = false;
        //    chk_claim1.Enabled = chk_claim2.Enabled = false;
        //    if (claim == 0)
        //    {
        //        // утв.1 может начальник подразделения
        //        if (isMaster && version_by == 0)
        //        {
        //            chk_claim1.Enabled = true;
        //            btn_changeUser.Enabled = true;
        //        }
        //        return;
        //    }
        //    if (claim == 1)
        //    {
        //        chk_claim1.Checked = true;
        //        // утв.1 может начальник подразделения
        //        if (isMaster && version_by == 0)
        //        {
        //            chk_claim1.Enabled = true;
        //            btn_changeUser.Enabled = true;
        //        }
        //        Group2 mass_filling_claim = Group2.GroupByGid2(GROUP_CLAIM2);
        //        if (mass_filling_claim.CheckSecondaryMember(MainPage.CurrentUser2) && version_by == 0)
        //        {
        //            string master = GetSelectedProject().master;
        //            if (master == MainPage.CurrentUser2.Uid)
        //            {
        //                chk_claim2.Enabled = true;
        //            }
        //        }
        //        return;
        //    }
        //    if (claim == 2)
        //    {
        //        chk_claim1.Checked = true;
        //        chk_claim2.Checked = true;
        //        Group2 mass_filling_claim = Group2.GroupByGid2(GROUP_CLAIM2);
        //        if (mass_filling_claim.CheckSecondaryMember(MainPage.CurrentUser2) && version_by == 0)
        //        {
        //            string master = GetSelectedProject().master;
        //            if (master == MainPage.CurrentUser2.Uid)
        //            {
        //                chk_claim2.Enabled = true;
        //            }
        //        }
        //    }
        //    if (claim == 3)
        //    {
        //        chk_claim1.Checked = true;
        //        chk_claim2.Checked = true;

        //        Group2 mass_filling_claim = Group2.GroupByGid2(GROUP_CLAIM2);
        //        if (mass_filling_claim.CheckSecondaryMember(MainPage.CurrentUser2) && version_by == 0)
        //        {
        //            string master = GetSelectedProject().master;
        //            if (master == MainPage.CurrentUser2.Uid)
        //            {
        //                chk_claim2.Enabled = true;
        //            }
        //        }
        //        return;
        //    }
        //    if (claim == 4)
        //    {
        //        chk_claim1.Checked = true;
        //        //снять утв.1 может начальник department_109
        //        Group2 mass_filling = Group2.GroupByGid2(GROUP_CLAIM0);
        //        lbl_claim1.Text = "";
        //        foreach (User2 u in mass_filling.PrimaryMembers)
        //        {
        //            lbl_claim1.Text += u.ShortName + " ";
        //        }
        //        if (mass_filling.CheckPrimaryMember(MainPage.CurrentUser2) && version_by == 0)
        //        {
        //            chk_claim1.Enabled = true;
        //        }
        //        Group2 mass_filling_claim = Group2.GroupByGid2(GROUP_CLAIM2);
        //        if (mass_filling_claim.CheckSecondaryMember(MainPage.CurrentUser2) && version_by == 0)
        //        {
        //            string master = GetSelectedProject().master;
        //            if (master == MainPage.CurrentUser2.Uid)
        //            {
        //                chk_claim2.Enabled = true;
        //            }
        //        }
        //        return;
        //    }
        //}

        private void chk_claim1_Click(object sender, EventArgs e)
        {
            bool chk = chk_claim1.Checked;

            int id = (int)(dg_bids.SelectedRows[0].Cells["id"].Value);
            DMSdbDataSet.mass_bidRow row = dt_bids.FindByid(id);
            int claim = row.claim;
            row.BeginEdit();
            row.claim = chk ? (int)1 : 0;
            row.hclaim = getHClaim(row.claim);
            row.EndEdit();
            ta_bids.Update(row);
            //User2 user = User2.UserByUid2(row.uid);
            //SetClaimCheckBoxes(row.version_by, row.claim, user);
            if (row.claim == 0 && claim == 4)
            {
                MakeBidVersion(row);
            }
        }

        private void chk_claim2_Click(object sender, EventArgs e)
        {
            bool chk = chk_claim2.Checked;
            int id = (int)(dg_bids.SelectedRows[0].Cells["id"].Value);
            DMSdbDataSet.mass_bidRow row = dt_bids.FindByid(id);
            row.BeginEdit();
            row.claim = chk ? (int)2 : 4;
            row.hclaim = getHClaim(row.claim);
            if (chk)
                row.date_time = DateTime.Now;
            row.EndEdit();
            ta_bids.Update(row);
            //User2 user = User2.UserByUid2(row.uid);
            //SetClaimCheckBoxes(row.version_by, row.claim, user);
        }

        private void MakeBidVersion(DMSdbDataSet.mass_bidRow bid)
        {
            int project_id = GetSelectedProject().id;
            ta_bids.InsertBidVersion(bid.date_time.Date, (int)bid.mass_project_id, bid.uid, bid.description, "#" + bid.id + " " + bid.bid_name, 2, (int)bid.id);
            DMSdbDataSet.mass_bidDataTable t = ta_bids.GetLastInsertID();
            int new_bidid = (int)(t.Rows[0] as DMSdbDataSet.mass_bidRow).id;
            t.Dispose();
            DMSdbDataSet.mass_data_bidDataTable tmp = ta_data.GetDataForCopy((int)bid.id);
            foreach (DMSdbDataSet.mass_data_bidRow r in tmp)
            {
                r.bid_id = new_bidid;
                ta_data.InsertItemCopy(r.bid_id, r.code, r.name_code, r.m, r.x, r.y, r.z);
            }
            FillBids();
            SetBidCellAccess();
            FillData();
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

        private void btn_changeUser_Click(object sender, EventArgs e)
        {

            if (dg_bids.SelectedRows.Count == 0)
                return;
            DataGridViewRow dgrow = dg_bids.SelectedRows[0];
            string bid_name = dgrow.Cells["bid_name"].Value as string;
            ChoiseBidUser d = new ChoiseBidUser(bid_name);
            DialogResult res = d.ShowDialog();
            if (res == DialogResult.Cancel)
                return;
            string uid = d.SelectedUid;
            int id = (int)(dgrow.Cells["id"].Value);
            DMSdbDataSet.mass_bidRow row = dt_bids.FindByid(id);
            row.BeginEdit();
            row.uid = uid;
            row.huid = getHUid(row.uid);
            row.EndEdit();
            ta_bids.Update(row);
        }

    }
}
