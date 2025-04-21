using dms.pages.Utils;
using dms.pages.Utils.DMSdbDataSetTableAdapters;

namespace dms.pages.Mass.Dialogs
{
     partial class BidVersionView
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BidVersionView));
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
               this.dmsMass = new DMSdbDataSet();
               this.dmsMassBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.mass_data_bidTableAdapter = new mass_data_bidTableAdapter();
               this.gb_sum = new System.Windows.Forms.GroupBox();
               this.lbl_Mz = new System.Windows.Forms.Label();
               this.lbl_My = new System.Windows.Forms.Label();
               this.lbl_Mx = new System.Windows.Forms.Label();
               this.lbl_Z = new System.Windows.Forms.Label();
               this.lbl_Y = new System.Windows.Forms.Label();
               this.lbl_X = new System.Windows.Forms.Label();
               this.lbl_M = new System.Windows.Forms.Label();
               this.label8 = new System.Windows.Forms.Label();
               this.label7 = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.dg_data)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.massdatabidBindingSource)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dmsMass)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dmsMassBindingSource)).BeginInit();
               this.gb_sum.SuspendLayout();
               this.SuspendLayout();
               // 
               // dg_data
               // 
               this.dg_data.AllowUserToAddRows = false;
               this.dg_data.AllowUserToDeleteRows = false;
               this.dg_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
               this.dg_data.Location = new System.Drawing.Point(0, 0);
               this.dg_data.MultiSelect = false;
               this.dg_data.Name = "dg_data";
               this.dg_data.ReadOnly = true;
               this.dg_data.RowHeadersVisible = false;
               this.dg_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dg_data.Size = new System.Drawing.Size(994, 434);
               this.dg_data.TabIndex = 11;
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
               this.codeDataGridViewTextBoxColumn.Width = 80;
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
               this.mzDataGridViewTextBoxColumn.DataPropertyName = "mz";
               dataGridViewCellStyle7.Format = "N3";
               dataGridViewCellStyle7.NullValue = "0";
               this.mzDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
               this.mzDataGridViewTextBoxColumn.HeaderText = "Mz";
               this.mzDataGridViewTextBoxColumn.Name = "mzDataGridViewTextBoxColumn";
               this.mzDataGridViewTextBoxColumn.ReadOnly = true;
               this.mzDataGridViewTextBoxColumn.Width = 80;
               // 
               // massdatabidBindingSource
               // 
               this.massdatabidBindingSource.DataMember = "mass_data_bid";
               this.massdatabidBindingSource.DataSource = this.dmsMass;
               // 
               // dmsMass
               // 
               this.dmsMass.DataSetName = "dmsMass";
               this.dmsMass.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
               // 
               // dmsMassBindingSource
               // 
               this.dmsMassBindingSource.DataSource = this.dmsMass;
               this.dmsMassBindingSource.Position = 0;
               // 
               // mass_data_bidTableAdapter
               // 
               this.mass_data_bidTableAdapter.ClearBeforeFill = true;
               // 
               // gb_sum
               // 
               this.gb_sum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
               this.gb_sum.Controls.Add(this.lbl_Mz);
               this.gb_sum.Controls.Add(this.lbl_My);
               this.gb_sum.Controls.Add(this.lbl_Mx);
               this.gb_sum.Controls.Add(this.lbl_Z);
               this.gb_sum.Controls.Add(this.lbl_Y);
               this.gb_sum.Controls.Add(this.lbl_X);
               this.gb_sum.Controls.Add(this.lbl_M);
               this.gb_sum.Controls.Add(this.label8);
               this.gb_sum.Controls.Add(this.label7);
               this.gb_sum.Controls.Add(this.label6);
               this.gb_sum.Controls.Add(this.label5);
               this.gb_sum.Controls.Add(this.label4);
               this.gb_sum.Controls.Add(this.label3);
               this.gb_sum.Controls.Add(this.label2);
               this.gb_sum.Location = new System.Drawing.Point(0, 440);
               this.gb_sum.Name = "gb_sum";
               this.gb_sum.Size = new System.Drawing.Size(994, 35);
               this.gb_sum.TabIndex = 12;
               this.gb_sum.TabStop = false;
               this.gb_sum.Text = "Cуммы:";
               // 
               // lbl_Mz
               // 
               this.lbl_Mz.AutoSize = true;
               this.lbl_Mz.BackColor = System.Drawing.SystemColors.Info;
               this.lbl_Mz.Location = new System.Drawing.Point(846, 14);
               this.lbl_Mz.Name = "lbl_Mz";
               this.lbl_Mz.Size = new System.Drawing.Size(13, 13);
               this.lbl_Mz.TabIndex = 16;
               this.lbl_Mz.Text = "0";
               // 
               // lbl_My
               // 
               this.lbl_My.AutoSize = true;
               this.lbl_My.BackColor = System.Drawing.SystemColors.Info;
               this.lbl_My.Location = new System.Drawing.Point(731, 14);
               this.lbl_My.Name = "lbl_My";
               this.lbl_My.Size = new System.Drawing.Size(13, 13);
               this.lbl_My.TabIndex = 15;
               this.lbl_My.Text = "0";
               // 
               // lbl_Mx
               // 
               this.lbl_Mx.AutoSize = true;
               this.lbl_Mx.BackColor = System.Drawing.SystemColors.Info;
               this.lbl_Mx.Location = new System.Drawing.Point(616, 14);
               this.lbl_Mx.Name = "lbl_Mx";
               this.lbl_Mx.Size = new System.Drawing.Size(13, 13);
               this.lbl_Mx.TabIndex = 14;
               this.lbl_Mx.Text = "0";
               // 
               // lbl_Z
               // 
               this.lbl_Z.AutoSize = true;
               this.lbl_Z.BackColor = System.Drawing.SystemColors.Info;
               this.lbl_Z.Location = new System.Drawing.Point(501, 14);
               this.lbl_Z.Name = "lbl_Z";
               this.lbl_Z.Size = new System.Drawing.Size(13, 13);
               this.lbl_Z.TabIndex = 13;
               this.lbl_Z.Text = "0";
               // 
               // lbl_Y
               // 
               this.lbl_Y.AutoSize = true;
               this.lbl_Y.BackColor = System.Drawing.SystemColors.Info;
               this.lbl_Y.Location = new System.Drawing.Point(386, 14);
               this.lbl_Y.Name = "lbl_Y";
               this.lbl_Y.Size = new System.Drawing.Size(13, 13);
               this.lbl_Y.TabIndex = 12;
               this.lbl_Y.Text = "0";
               // 
               // lbl_X
               // 
               this.lbl_X.AutoSize = true;
               this.lbl_X.BackColor = System.Drawing.SystemColors.Info;
               this.lbl_X.Location = new System.Drawing.Point(271, 14);
               this.lbl_X.Name = "lbl_X";
               this.lbl_X.Size = new System.Drawing.Size(13, 13);
               this.lbl_X.TabIndex = 11;
               this.lbl_X.Text = "0";
               // 
               // lbl_M
               // 
               this.lbl_M.AutoSize = true;
               this.lbl_M.BackColor = System.Drawing.SystemColors.Info;
               this.lbl_M.Location = new System.Drawing.Point(162, 14);
               this.lbl_M.Name = "lbl_M";
               this.lbl_M.Size = new System.Drawing.Size(13, 13);
               this.lbl_M.TabIndex = 10;
               this.lbl_M.Text = "0";
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.Location = new System.Drawing.Point(816, 14);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(24, 13);
               this.label8.TabIndex = 7;
               this.label8.Text = "Mz:";
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Location = new System.Drawing.Point(705, 14);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(24, 13);
               this.label7.TabIndex = 6;
               this.label7.Text = "My:";
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Location = new System.Drawing.Point(586, 14);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(24, 13);
               this.label6.TabIndex = 5;
               this.label6.Text = "Mx:";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(478, 14);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(17, 13);
               this.label5.TabIndex = 4;
               this.label5.Text = "Z:";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(363, 14);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(17, 13);
               this.label4.TabIndex = 3;
               this.label4.Text = "Y:";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(248, 14);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(17, 13);
               this.label3.TabIndex = 2;
               this.label3.Text = "X:";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(113, 14);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(43, 13);
               this.label2.TabIndex = 1;
               this.label2.Text = "Масса:";
               // 
               // BidVersionView
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(994, 475);
               this.Controls.Add(this.gb_sum);
               this.Controls.Add(this.dg_data);
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MaximizeBox = false;
               this.Name = "BidVersionView";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "BidVersionView";
               this.Load += new System.EventHandler(this.BidVersionView_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dg_data)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.massdatabidBindingSource)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dmsMass)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dmsMassBindingSource)).EndInit();
               this.gb_sum.ResumeLayout(false);
               this.gb_sum.PerformLayout();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.DataGridView dg_data;
          private System.Windows.Forms.BindingSource dmsMassBindingSource;
          private DMSdbDataSet dmsMass;
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
          protected System.Windows.Forms.GroupBox gb_sum;
          protected System.Windows.Forms.Label lbl_Mz;
          protected System.Windows.Forms.Label lbl_My;
          protected System.Windows.Forms.Label lbl_Mx;
          protected System.Windows.Forms.Label lbl_Z;
          protected System.Windows.Forms.Label lbl_Y;
          protected System.Windows.Forms.Label lbl_X;
          protected System.Windows.Forms.Label lbl_M;
          protected System.Windows.Forms.Label label8;
          protected System.Windows.Forms.Label label7;
          protected System.Windows.Forms.Label label6;
          protected System.Windows.Forms.Label label5;
          protected System.Windows.Forms.Label label4;
          protected System.Windows.Forms.Label label3;
          protected System.Windows.Forms.Label label2;
     }
}