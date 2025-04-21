using dms.pages.Utils;
using dms.pages.Utils.DMSdbDataSetTableAdapters;

namespace dms.pages.Mass.Dialogs
{
     partial class ProjectCopyFrom
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectCopyFrom));
            this.label1 = new System.Windows.Forms.Label();
            this.cb = new System.Windows.Forms.ComboBox();
            this.massprojectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dmsMass = new DMSdbDataSet();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.mass_projectTableAdapter = new mass_projectTableAdapter();
            this.massbidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mass_bidTableAdapter = new mass_bidTableAdapter();
            this.dg_bids = new System.Windows.Forms.DataGridView();
            this.lbl_projectInfo = new System.Windows.Forms.Label();
            this.dg_data = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bididDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.myDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.massdatabidBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mass_data_bidTableAdapter = new mass_data_bidTableAdapter();
            this.bid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bidname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hclaim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.huid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hdatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.beditable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mass_project_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.version_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.massprojectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massbidBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_bids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massdatabidBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Проект";
            // 
            // cb
            // 
            this.cb.DataSource = this.massprojectBindingSource;
            this.cb.DisplayMember = "name";
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(62, 6);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(205, 21);
            this.cb.TabIndex = 1;
            this.cb.ValueMember = "id";
            this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // massprojectBindingSource
            // 
            this.massprojectBindingSource.DataMember = "mass_project";
            this.massprojectBindingSource.DataSource = this.dmsMass;
            // 
            // dmsMass
            // 
            this.dmsMass.DataSetName = "dmsMass";
            this.dmsMass.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(867, 750);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(948, 750);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "ОК";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // mass_projectTableAdapter
            // 
            this.mass_projectTableAdapter.ClearBeforeFill = true;
            // 
            // massbidBindingSource
            // 
            this.massbidBindingSource.DataMember = "mass_bid";
            this.massbidBindingSource.DataSource = this.dmsMass;
            // 
            // mass_bidTableAdapter
            // 
            this.mass_bidTableAdapter.ClearBeforeFill = true;
            // 
            // dg_bids
            // 
            this.dg_bids.AllowUserToAddRows = false;
            this.dg_bids.AllowUserToDeleteRows = false;
            this.dg_bids.AutoGenerateColumns = false;
            this.dg_bids.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_bids.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bid,
            this.bidname,
            this.hclaim,
            this.huid,
            this.hgid,
            this.hdatetime,
            this.description,
            this.beditable,
            this.uid,
            this.date_time,
            this.mass_project_id,
            this.claim,
            this.version_by});
            this.dg_bids.DataSource = this.massbidBindingSource;
            this.dg_bids.Location = new System.Drawing.Point(12, 33);
            this.dg_bids.Name = "dg_bids";
            this.dg_bids.ReadOnly = true;
            this.dg_bids.RowHeadersVisible = false;
            this.dg_bids.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_bids.Size = new System.Drawing.Size(1011, 305);
            this.dg_bids.TabIndex = 8;
            this.dg_bids.SelectionChanged += new System.EventHandler(this.dg_bids_SelectionChanged);
            // 
            // lbl_projectInfo
            // 
            this.lbl_projectInfo.AutoSize = true;
            this.lbl_projectInfo.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_projectInfo.Location = new System.Drawing.Point(309, 9);
            this.lbl_projectInfo.Name = "lbl_projectInfo";
            this.lbl_projectInfo.Size = new System.Drawing.Size(194, 13);
            this.lbl_projectInfo.TabIndex = 9;
            this.lbl_projectInfo.Text = "Заявка будет скопирована в проект ";
            // 
            // dg_data
            // 
            this.dg_data.AllowUserToAddRows = false;
            this.dg_data.AllowUserToDeleteRows = false;
            this.dg_data.AutoGenerateColumns = false;
            this.dg_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bididDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.namecodeDataGridViewTextBoxColumn,
            this.mDataGridViewTextBoxColumn,
            this.xDataGridViewTextBoxColumn,
            this.yDataGridViewTextBoxColumn,
            this.zDataGridViewTextBoxColumn,
            this.mxDataGridViewTextBoxColumn,
            this.myDataGridViewTextBoxColumn,
            this.mzDataGridViewTextBoxColumn});
            this.dg_data.DataSource = this.massdatabidBindingSource;
            this.dg_data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dg_data.Location = new System.Drawing.Point(12, 344);
            this.dg_data.MultiSelect = false;
            this.dg_data.Name = "dg_data";
            this.dg_data.ReadOnly = true;
            this.dg_data.RowHeadersVisible = false;
            this.dg_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_data.Size = new System.Drawing.Size(1011, 400);
            this.dg_data.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // bididDataGridViewTextBoxColumn
            // 
            this.bididDataGridViewTextBoxColumn.DataPropertyName = "bid_id";
            this.bididDataGridViewTextBoxColumn.HeaderText = "bid_id";
            this.bididDataGridViewTextBoxColumn.Name = "bididDataGridViewTextBoxColumn";
            this.bididDataGridViewTextBoxColumn.ReadOnly = true;
            this.bididDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Код";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namecodeDataGridViewTextBoxColumn
            // 
            this.namecodeDataGridViewTextBoxColumn.DataPropertyName = "name_code";
            this.namecodeDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.namecodeDataGridViewTextBoxColumn.Name = "namecodeDataGridViewTextBoxColumn";
            this.namecodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.namecodeDataGridViewTextBoxColumn.Width = 350;
            // 
            // mDataGridViewTextBoxColumn
            // 
            this.mDataGridViewTextBoxColumn.DataPropertyName = "m";
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = "0";
            this.mDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.mDataGridViewTextBoxColumn.HeaderText = "M";
            this.mDataGridViewTextBoxColumn.Name = "mDataGridViewTextBoxColumn";
            this.mDataGridViewTextBoxColumn.ReadOnly = true;
            this.mDataGridViewTextBoxColumn.Width = 80;
            // 
            // xDataGridViewTextBoxColumn
            // 
            this.xDataGridViewTextBoxColumn.DataPropertyName = "x";
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = "0";
            this.xDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.xDataGridViewTextBoxColumn.HeaderText = "X";
            this.xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
            this.xDataGridViewTextBoxColumn.ReadOnly = true;
            this.xDataGridViewTextBoxColumn.Width = 80;
            // 
            // yDataGridViewTextBoxColumn
            // 
            this.yDataGridViewTextBoxColumn.DataPropertyName = "y";
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = "0";
            this.yDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.yDataGridViewTextBoxColumn.HeaderText = "Y";
            this.yDataGridViewTextBoxColumn.Name = "yDataGridViewTextBoxColumn";
            this.yDataGridViewTextBoxColumn.ReadOnly = true;
            this.yDataGridViewTextBoxColumn.Width = 80;
            // 
            // zDataGridViewTextBoxColumn
            // 
            this.zDataGridViewTextBoxColumn.DataPropertyName = "z";
            dataGridViewCellStyle4.Format = "N3";
            dataGridViewCellStyle4.NullValue = "0";
            this.zDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.zDataGridViewTextBoxColumn.HeaderText = "Z";
            this.zDataGridViewTextBoxColumn.Name = "zDataGridViewTextBoxColumn";
            this.zDataGridViewTextBoxColumn.ReadOnly = true;
            this.zDataGridViewTextBoxColumn.Width = 80;
            // 
            // mxDataGridViewTextBoxColumn
            // 
            this.mxDataGridViewTextBoxColumn.DataPropertyName = "mx";
            dataGridViewCellStyle5.Format = "N3";
            dataGridViewCellStyle5.NullValue = "0";
            this.mxDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.mxDataGridViewTextBoxColumn.HeaderText = "Mx";
            this.mxDataGridViewTextBoxColumn.Name = "mxDataGridViewTextBoxColumn";
            this.mxDataGridViewTextBoxColumn.ReadOnly = true;
            this.mxDataGridViewTextBoxColumn.Width = 80;
            // 
            // myDataGridViewTextBoxColumn
            // 
            this.myDataGridViewTextBoxColumn.DataPropertyName = "my";
            dataGridViewCellStyle6.Format = "N3";
            dataGridViewCellStyle6.NullValue = "0";
            this.myDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.myDataGridViewTextBoxColumn.HeaderText = "My";
            this.myDataGridViewTextBoxColumn.Name = "myDataGridViewTextBoxColumn";
            this.myDataGridViewTextBoxColumn.ReadOnly = true;
            this.myDataGridViewTextBoxColumn.Width = 80;
            // 
            // mzDataGridViewTextBoxColumn
            // 
            this.mzDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mzDataGridViewTextBoxColumn.DataPropertyName = "mz";
            dataGridViewCellStyle7.Format = "N3";
            dataGridViewCellStyle7.NullValue = "0";
            this.mzDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.mzDataGridViewTextBoxColumn.HeaderText = "Mz";
            this.mzDataGridViewTextBoxColumn.Name = "mzDataGridViewTextBoxColumn";
            this.mzDataGridViewTextBoxColumn.ReadOnly = true;
            this.mzDataGridViewTextBoxColumn.Width = 46;
            // 
            // massdatabidBindingSource
            // 
            this.massdatabidBindingSource.DataMember = "mass_data_bid";
            this.massdatabidBindingSource.DataSource = this.dmsMass;
            // 
            // mass_data_bidTableAdapter
            // 
            this.mass_data_bidTableAdapter.ClearBeforeFill = true;
            // 
            // bid
            // 
            this.bid.DataPropertyName = "id";
            this.bid.HeaderText = "Номер";
            this.bid.Name = "bid";
            this.bid.ReadOnly = true;
            this.bid.Width = 50;
            // 
            // bidname
            // 
            this.bidname.DataPropertyName = "bid_name";
            this.bidname.HeaderText = "Название";
            this.bidname.Name = "bidname";
            this.bidname.ReadOnly = true;
            this.bidname.Width = 250;
            // 
            // hclaim
            // 
            this.hclaim.DataPropertyName = "hclaim";
            this.hclaim.HeaderText = "Статус";
            this.hclaim.Name = "hclaim";
            this.hclaim.ReadOnly = true;
            // 
            // huid
            // 
            this.huid.DataPropertyName = "huid";
            this.huid.HeaderText = "Автор";
            this.huid.Name = "huid";
            this.huid.ReadOnly = true;
            // 
            // hgid
            // 
            this.hgid.DataPropertyName = "hgid";
            this.hgid.HeaderText = "Подразделение";
            this.hgid.Name = "hgid";
            this.hgid.ReadOnly = true;
            // 
            // hdatetime
            // 
            this.hdatetime.DataPropertyName = "hdatetime";
            this.hdatetime.FillWeight = 200F;
            this.hdatetime.HeaderText = "Дата подачи";
            this.hdatetime.Name = "hdatetime";
            this.hdatetime.ReadOnly = true;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Комментарий";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 102;
            // 
            // beditable
            // 
            this.beditable.DataPropertyName = "beditable";
            this.beditable.HeaderText = "editable";
            this.beditable.Name = "beditable";
            this.beditable.ReadOnly = true;
            this.beditable.Visible = false;
            // 
            // uid
            // 
            this.uid.DataPropertyName = "uid";
            this.uid.HeaderText = "uid";
            this.uid.Name = "uid";
            this.uid.ReadOnly = true;
            this.uid.Visible = false;
            // 
            // date_time
            // 
            this.date_time.DataPropertyName = "date_time";
            this.date_time.HeaderText = "date_time";
            this.date_time.Name = "date_time";
            this.date_time.ReadOnly = true;
            this.date_time.Visible = false;
            // 
            // mass_project_id
            // 
            this.mass_project_id.DataPropertyName = "mass_project_id";
            this.mass_project_id.HeaderText = "mass_project_id";
            this.mass_project_id.Name = "mass_project_id";
            this.mass_project_id.ReadOnly = true;
            this.mass_project_id.Visible = false;
            // 
            // claim
            // 
            this.claim.DataPropertyName = "claim";
            this.claim.HeaderText = "claim";
            this.claim.Name = "claim";
            this.claim.ReadOnly = true;
            this.claim.Visible = false;
            // 
            // version_by
            // 
            this.version_by.DataPropertyName = "version_by";
            this.version_by.HeaderText = "version_by";
            this.version_by.Name = "version_by";
            this.version_by.ReadOnly = true;
            this.version_by.Visible = false;
            // 
            // ProjectCopyFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 775);
            this.Controls.Add(this.dg_data);
            this.Controls.Add(this.lbl_projectInfo);
            this.Controls.Add(this.dg_bids);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectCopyFrom";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Копировать заявку из проекта";
            this.Load += new System.EventHandler(this.ProjectCopyFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.massprojectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massbidBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_bids)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massdatabidBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.ComboBox cb;
          private System.Windows.Forms.Button btn_cancel;
          private System.Windows.Forms.Button btn_ok;
          private DMSdbDataSet dmsMass;
          private System.Windows.Forms.BindingSource massprojectBindingSource;
          private mass_projectTableAdapter mass_projectTableAdapter;
          private System.Windows.Forms.BindingSource massbidBindingSource;
          private mass_bidTableAdapter mass_bidTableAdapter;
          private System.Windows.Forms.DataGridView dg_bids;
          private System.Windows.Forms.Label lbl_projectInfo;
          private System.Windows.Forms.DataGridView dg_data;
          private System.Windows.Forms.BindingSource massdatabidBindingSource;
          private mass_data_bidTableAdapter mass_data_bidTableAdapter;
          private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn bididDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn namecodeDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn mDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn zDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn mxDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn myDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn mzDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn bid;
          private System.Windows.Forms.DataGridViewTextBoxColumn bidname;
          private System.Windows.Forms.DataGridViewTextBoxColumn hclaim;
          private System.Windows.Forms.DataGridViewTextBoxColumn huid;
          private System.Windows.Forms.DataGridViewTextBoxColumn hgid;
          private System.Windows.Forms.DataGridViewTextBoxColumn hdatetime;
          private System.Windows.Forms.DataGridViewTextBoxColumn description;
          private System.Windows.Forms.DataGridViewTextBoxColumn beditable;
          private System.Windows.Forms.DataGridViewTextBoxColumn uid;
          private System.Windows.Forms.DataGridViewTextBoxColumn date_time;
          private System.Windows.Forms.DataGridViewTextBoxColumn mass_project_id;
          private System.Windows.Forms.DataGridViewTextBoxColumn claim;
          private System.Windows.Forms.DataGridViewTextBoxColumn version_by;
     }
}