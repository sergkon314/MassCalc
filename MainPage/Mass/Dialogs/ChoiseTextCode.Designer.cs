using dms.pages.Utils;
using dms.pages.Utils.DMSdbDataSetTableAdapters;

namespace dms.pages.Mass.Dialogs
{
     partial class ChoiseTextCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiseTextCode));
            this.dmsMass = new DMSdbDataSet();
            this.masstextcodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mass_text_codeTableAdapter = new mass_text_codeTableAdapter();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.dg_code = new System.Windows.Forms.DataGridView();
            this.ord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.tree = new dms.pages.Controls.TreeViewFlickerFree();
            ((System.ComponentModel.ISupportInitialize)(this.dmsMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masstextcodeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_code)).BeginInit();
            this.SuspendLayout();
            // 
            // dmsMass
            // 
            this.dmsMass.DataSetName = "dmsMass";
            this.dmsMass.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masstextcodeBindingSource
            // 
            this.masstextcodeBindingSource.DataMember = "mass_text_code";
            this.masstextcodeBindingSource.DataSource = this.dmsMass;
            // 
            // mass_text_codeTableAdapter
            // 
            this.mass_text_codeTableAdapter.ClearBeforeFill = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(753, 549);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(862, 549);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(8, 19);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(193, 20);
            this.txt_search.TabIndex = 3;
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // btn_search
            // 
            this.btn_search.Image = global::dms.pages.Properties.Resources.zoom;
            this.btn_search.Location = new System.Drawing.Point(207, 17);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(29, 23);
            this.btn_search.TabIndex = 5;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 49);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск:";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(454, 17);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Очистить";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // dg_code
            // 
            this.dg_code.AllowUserToAddRows = false;
            this.dg_code.AllowUserToDeleteRows = false;
            this.dg_code.AutoGenerateColumns = false;
            this.dg_code.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_code.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ord,
            this.codeDataGridViewTextBoxColumn,
            this.codenameDataGridViewTextBoxColumn});
            this.dg_code.DataSource = this.masstextcodeBindingSource;
            this.dg_code.Location = new System.Drawing.Point(563, 67);
            this.dg_code.Name = "dg_code";
            this.dg_code.ReadOnly = true;
            this.dg_code.RowHeadersVisible = false;
            this.dg_code.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_code.Size = new System.Drawing.Size(372, 470);
            this.dg_code.TabIndex = 8;
            this.dg_code.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dg_code_KeyUp);
            // 
            // ord
            // 
            this.ord.DataPropertyName = "ord";
            this.ord.HeaderText = "ord";
            this.ord.Name = "ord";
            this.ord.ReadOnly = true;
            this.ord.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Код";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 60;
            // 
            // codenameDataGridViewTextBoxColumn
            // 
            this.codenameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codenameDataGridViewTextBoxColumn.DataPropertyName = "code_name";
            this.codenameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.codenameDataGridViewTextBoxColumn.Name = "codenameDataGridViewTextBoxColumn";
            this.codenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Выбранные (Del  - удалить):";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(472, 549);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Выбрать";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tree
            // 
            this.tree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tree.HideSelection = false;
            this.tree.Location = new System.Drawing.Point(12, 67);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(535, 470);
            this.tree.TabIndex = 7;
            // 
            // ChoiseTextCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 578);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_code);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoiseTextCode";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoiseTextCode";
            this.Load += new System.EventHandler(this.ChoiseTextCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dmsMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masstextcodeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_code)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

          }

          #endregion

          private DMSdbDataSet dmsMass;
          private System.Windows.Forms.BindingSource masstextcodeBindingSource;
          private mass_text_codeTableAdapter mass_text_codeTableAdapter;
          private System.Windows.Forms.Button btn_cancel;
          private System.Windows.Forms.Button btn_ok;
          private System.Windows.Forms.TextBox txt_search;
          private System.Windows.Forms.Button btn_search;
          private System.Windows.Forms.GroupBox groupBox1;
          private System.Windows.Forms.Button btn_clear;
          private Controls.TreeViewFlickerFree tree;
          private System.Windows.Forms.DataGridView dg_code;
          private System.Windows.Forms.DataGridViewTextBoxColumn ord;
          private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn codenameDataGridViewTextBoxColumn;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Button btn_add;
     }
}