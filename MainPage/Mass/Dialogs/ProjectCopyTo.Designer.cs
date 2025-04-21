using dms.pages.Utils;
using dms.pages.Utils.DMSdbDataSetTableAdapters;

namespace dms.pages.Mass.Dialogs
{
     partial class ProjectCopyTo
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectCopyTo));
               this.dg = new System.Windows.Forms.DataGridView();
               this.dmsMass = new DMSdbDataSet();
               this.massprojectBindingSource = new System.Windows.Forms.BindingSource(this.components);
               this.mass_projectTableAdapter = new mass_projectTableAdapter();
               this.btn_cancel = new System.Windows.Forms.Button();
               this.btn_ok = new System.Windows.Forms.Button();
               this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.prototypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.masterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.projectgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.numtype1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.numtype2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.deletedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.label1 = new System.Windows.Forms.Label();
               this.lbl_bidName = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dmsMass)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.massprojectBindingSource)).BeginInit();
               this.SuspendLayout();
               // 
               // dg
               // 
               this.dg.AllowUserToAddRows = false;
               this.dg.AllowUserToDeleteRows = false;
               this.dg.AutoGenerateColumns = false;
               this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.prototypeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.masterDataGridViewTextBoxColumn,
            this.projectgroupDataGridViewTextBoxColumn,
            this.numtype1DataGridViewTextBoxColumn,
            this.numtype2DataGridViewTextBoxColumn,
            this.deletedDataGridViewTextBoxColumn});
               this.dg.DataSource = this.massprojectBindingSource;
               this.dg.Location = new System.Drawing.Point(12, 25);
               this.dg.MultiSelect = false;
               this.dg.Name = "dg";
               this.dg.ReadOnly = true;
               this.dg.RowHeadersVisible = false;
               this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
               this.dg.Size = new System.Drawing.Size(300, 462);
               this.dg.TabIndex = 0;
               // 
               // dmsMass
               // 
               this.dmsMass.DataSetName = "dmsMass";
               this.dmsMass.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
               // 
               // massprojectBindingSource
               // 
               this.massprojectBindingSource.DataMember = "mass_project";
               this.massprojectBindingSource.DataSource = this.dmsMass;
               // 
               // mass_projectTableAdapter
               // 
               this.mass_projectTableAdapter.ClearBeforeFill = true;
               // 
               // btn_cancel
               // 
               this.btn_cancel.Location = new System.Drawing.Point(144, 495);
               this.btn_cancel.Name = "btn_cancel";
               this.btn_cancel.Size = new System.Drawing.Size(76, 22);
               this.btn_cancel.TabIndex = 1;
               this.btn_cancel.Text = "Отмена";
               this.btn_cancel.UseVisualStyleBackColor = true;
               this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
               // 
               // btn_ok
               // 
               this.btn_ok.Location = new System.Drawing.Point(236, 495);
               this.btn_ok.Name = "btn_ok";
               this.btn_ok.Size = new System.Drawing.Size(76, 22);
               this.btn_ok.TabIndex = 2;
               this.btn_ok.Text = "ОК";
               this.btn_ok.UseVisualStyleBackColor = true;
               this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
               // 
               // id
               // 
               this.id.DataPropertyName = "id";
               this.id.HeaderText = "id";
               this.id.Name = "id";
               this.id.ReadOnly = true;
               this.id.Visible = false;
               // 
               // nameDataGridViewTextBoxColumn
               // 
               this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
               this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
               this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
               this.nameDataGridViewTextBoxColumn.ReadOnly = true;
               // 
               // typeDataGridViewTextBoxColumn
               // 
               this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
               this.typeDataGridViewTextBoxColumn.HeaderText = "type";
               this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
               this.typeDataGridViewTextBoxColumn.ReadOnly = true;
               this.typeDataGridViewTextBoxColumn.Visible = false;
               // 
               // prototypeDataGridViewTextBoxColumn
               // 
               this.prototypeDataGridViewTextBoxColumn.DataPropertyName = "prototype";
               this.prototypeDataGridViewTextBoxColumn.HeaderText = "prototype";
               this.prototypeDataGridViewTextBoxColumn.Name = "prototypeDataGridViewTextBoxColumn";
               this.prototypeDataGridViewTextBoxColumn.ReadOnly = true;
               this.prototypeDataGridViewTextBoxColumn.Visible = false;
               // 
               // descriptionDataGridViewTextBoxColumn
               // 
               this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
               this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
               this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
               this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
               this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
               // 
               // masterDataGridViewTextBoxColumn
               // 
               this.masterDataGridViewTextBoxColumn.DataPropertyName = "master";
               this.masterDataGridViewTextBoxColumn.HeaderText = "master";
               this.masterDataGridViewTextBoxColumn.Name = "masterDataGridViewTextBoxColumn";
               this.masterDataGridViewTextBoxColumn.ReadOnly = true;
               this.masterDataGridViewTextBoxColumn.Visible = false;
               // 
               // projectgroupDataGridViewTextBoxColumn
               // 
               this.projectgroupDataGridViewTextBoxColumn.DataPropertyName = "project_group";
               this.projectgroupDataGridViewTextBoxColumn.HeaderText = "project_group";
               this.projectgroupDataGridViewTextBoxColumn.Name = "projectgroupDataGridViewTextBoxColumn";
               this.projectgroupDataGridViewTextBoxColumn.ReadOnly = true;
               this.projectgroupDataGridViewTextBoxColumn.Visible = false;
               // 
               // numtype1DataGridViewTextBoxColumn
               // 
               this.numtype1DataGridViewTextBoxColumn.DataPropertyName = "num_type1";
               this.numtype1DataGridViewTextBoxColumn.HeaderText = "num_type1";
               this.numtype1DataGridViewTextBoxColumn.Name = "numtype1DataGridViewTextBoxColumn";
               this.numtype1DataGridViewTextBoxColumn.ReadOnly = true;
               this.numtype1DataGridViewTextBoxColumn.Visible = false;
               // 
               // numtype2DataGridViewTextBoxColumn
               // 
               this.numtype2DataGridViewTextBoxColumn.DataPropertyName = "num_type2";
               this.numtype2DataGridViewTextBoxColumn.HeaderText = "num_type2";
               this.numtype2DataGridViewTextBoxColumn.Name = "numtype2DataGridViewTextBoxColumn";
               this.numtype2DataGridViewTextBoxColumn.ReadOnly = true;
               this.numtype2DataGridViewTextBoxColumn.Visible = false;
               // 
               // deletedDataGridViewTextBoxColumn
               // 
               this.deletedDataGridViewTextBoxColumn.DataPropertyName = "deleted";
               this.deletedDataGridViewTextBoxColumn.HeaderText = "deleted";
               this.deletedDataGridViewTextBoxColumn.Name = "deletedDataGridViewTextBoxColumn";
               this.deletedDataGridViewTextBoxColumn.ReadOnly = true;
               this.deletedDataGridViewTextBoxColumn.Visible = false;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(12, 9);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(47, 13);
               this.label1.TabIndex = 3;
               this.label1.Text = "Заявка:";
               // 
               // lbl_bidName
               // 
               this.lbl_bidName.AutoSize = true;
               this.lbl_bidName.BackColor = System.Drawing.SystemColors.Info;
               this.lbl_bidName.Location = new System.Drawing.Point(65, 9);
               this.lbl_bidName.Name = "lbl_bidName";
               this.lbl_bidName.Size = new System.Drawing.Size(35, 13);
               this.lbl_bidName.TabIndex = 4;
               this.lbl_bidName.Text = "label2";
               // 
               // ProjectCopyTo
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(324, 529);
               this.Controls.Add(this.lbl_bidName);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.btn_ok);
               this.Controls.Add(this.btn_cancel);
               this.Controls.Add(this.dg);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MaximizeBox = false;
               this.MinimizeBox = false;
               this.Name = "ProjectCopyTo";
               this.ShowInTaskbar = false;
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "ProjectCopyTo";
               this.Load += new System.EventHandler(this.ProjectCopyTo_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dmsMass)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.massprojectBindingSource)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.DataGridView dg;
          private DMSdbDataSet dmsMass;
          private System.Windows.Forms.BindingSource massprojectBindingSource;
          private mass_projectTableAdapter mass_projectTableAdapter;
          private System.Windows.Forms.Button btn_cancel;
          private System.Windows.Forms.Button btn_ok;
          private System.Windows.Forms.DataGridViewTextBoxColumn id;
          private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn prototypeDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn masterDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn projectgroupDataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn numtype1DataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn numtype2DataGridViewTextBoxColumn;
          private System.Windows.Forms.DataGridViewTextBoxColumn deletedDataGridViewTextBoxColumn;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label lbl_bidName;
     }
}