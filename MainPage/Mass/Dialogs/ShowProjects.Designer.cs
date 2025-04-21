using dms.pages.Utils;
using dms.pages.Utils.DMSdbDataSetTableAdapters;

namespace dms.pages.Mass.Dialogs
{
    partial class ShowProjects
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
            this.btnClose = new System.Windows.Forms.Button();
            this.massprojectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dmsMass = new DMSdbDataSet();
            this.mass_projectTableAdapter = new mass_projectTableAdapter();
            this.dg = new dms.pages.Controls.DataGridViewFlickerFree();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prototypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectgroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numtype1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numtype2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lgbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hgbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customstpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customstpmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customstpzDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSave = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.massprojectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(698, 468);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
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
            // mass_projectTableAdapter
            // 
            this.mass_projectTableAdapter.ClearBeforeFill = true;
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AutoGenerateColumns = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.prototypeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.masterDataGridViewTextBoxColumn,
            this.projectgroupDataGridViewTextBoxColumn,
            this.numtype1DataGridViewTextBoxColumn,
            this.numtype2DataGridViewTextBoxColumn,
            this.deletedDataGridViewTextBoxColumn,
            this.lgbDataGridViewTextBoxColumn,
            this.bgbDataGridViewTextBoxColumn,
            this.hgbDataGridViewTextBoxColumn,
            this.customstpDataGridViewTextBoxColumn,
            this.customstpmDataGridViewTextBoxColumn,
            this.customstpzDataGridViewTextBoxColumn});
            this.dg.DataSource = this.massprojectBindingSource;
            this.dg.Location = new System.Drawing.Point(12, 12);
            this.dg.MultiSelect = false;
            this.dg.Name = "dg";
            this.dg.RowHeadersVisible = false;
            this.dg.Size = new System.Drawing.Size(768, 450);
            this.dg.TabIndex = 3;
            this.dg.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dg_CellBeginEdit);
            this.dg.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellEndEdit);
            this.dg.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dg_DataError);
            this.dg.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dg_EditingControlShowing);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Visible = false;
            // 
            // prototypeDataGridViewTextBoxColumn
            // 
            this.prototypeDataGridViewTextBoxColumn.DataPropertyName = "prototype";
            this.prototypeDataGridViewTextBoxColumn.HeaderText = "prototype";
            this.prototypeDataGridViewTextBoxColumn.Name = "prototypeDataGridViewTextBoxColumn";
            this.prototypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.descriptionDataGridViewTextBoxColumn.Width = 500;
            // 
            // masterDataGridViewTextBoxColumn
            // 
            this.masterDataGridViewTextBoxColumn.DataPropertyName = "master";
            this.masterDataGridViewTextBoxColumn.HeaderText = "master";
            this.masterDataGridViewTextBoxColumn.Name = "masterDataGridViewTextBoxColumn";
            this.masterDataGridViewTextBoxColumn.Visible = false;
            // 
            // projectgroupDataGridViewTextBoxColumn
            // 
            this.projectgroupDataGridViewTextBoxColumn.DataPropertyName = "project_group";
            this.projectgroupDataGridViewTextBoxColumn.HeaderText = "project_group";
            this.projectgroupDataGridViewTextBoxColumn.Name = "projectgroupDataGridViewTextBoxColumn";
            this.projectgroupDataGridViewTextBoxColumn.Visible = false;
            // 
            // numtype1DataGridViewTextBoxColumn
            // 
            this.numtype1DataGridViewTextBoxColumn.DataPropertyName = "num_type1";
            this.numtype1DataGridViewTextBoxColumn.HeaderText = "num_type1";
            this.numtype1DataGridViewTextBoxColumn.Name = "numtype1DataGridViewTextBoxColumn";
            this.numtype1DataGridViewTextBoxColumn.Visible = false;
            // 
            // numtype2DataGridViewTextBoxColumn
            // 
            this.numtype2DataGridViewTextBoxColumn.DataPropertyName = "num_type2";
            this.numtype2DataGridViewTextBoxColumn.HeaderText = "num_type2";
            this.numtype2DataGridViewTextBoxColumn.Name = "numtype2DataGridViewTextBoxColumn";
            this.numtype2DataGridViewTextBoxColumn.Visible = false;
            // 
            // deletedDataGridViewTextBoxColumn
            // 
            this.deletedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deletedDataGridViewTextBoxColumn.DataPropertyName = "deleted";
            this.deletedDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.deletedDataGridViewTextBoxColumn.Name = "deletedDataGridViewTextBoxColumn";
            this.deletedDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.deletedDataGridViewTextBoxColumn.ToolTipText = "0 - активный, 1- удален, 2- не активный";
            // 
            // lgbDataGridViewTextBoxColumn
            // 
            this.lgbDataGridViewTextBoxColumn.DataPropertyName = "Lgb";
            this.lgbDataGridViewTextBoxColumn.HeaderText = "Lgb";
            this.lgbDataGridViewTextBoxColumn.Name = "lgbDataGridViewTextBoxColumn";
            this.lgbDataGridViewTextBoxColumn.Visible = false;
            // 
            // bgbDataGridViewTextBoxColumn
            // 
            this.bgbDataGridViewTextBoxColumn.DataPropertyName = "Bgb";
            this.bgbDataGridViewTextBoxColumn.HeaderText = "Bgb";
            this.bgbDataGridViewTextBoxColumn.Name = "bgbDataGridViewTextBoxColumn";
            this.bgbDataGridViewTextBoxColumn.Visible = false;
            // 
            // hgbDataGridViewTextBoxColumn
            // 
            this.hgbDataGridViewTextBoxColumn.DataPropertyName = "Hgb";
            this.hgbDataGridViewTextBoxColumn.HeaderText = "Hgb";
            this.hgbDataGridViewTextBoxColumn.Name = "hgbDataGridViewTextBoxColumn";
            this.hgbDataGridViewTextBoxColumn.Visible = false;
            // 
            // customstpDataGridViewTextBoxColumn
            // 
            this.customstpDataGridViewTextBoxColumn.DataPropertyName = "custom_stp";
            this.customstpDataGridViewTextBoxColumn.HeaderText = "custom_stp";
            this.customstpDataGridViewTextBoxColumn.Name = "customstpDataGridViewTextBoxColumn";
            this.customstpDataGridViewTextBoxColumn.Visible = false;
            // 
            // customstpmDataGridViewTextBoxColumn
            // 
            this.customstpmDataGridViewTextBoxColumn.DataPropertyName = "custom_stp_m";
            this.customstpmDataGridViewTextBoxColumn.HeaderText = "custom_stp_m";
            this.customstpmDataGridViewTextBoxColumn.Name = "customstpmDataGridViewTextBoxColumn";
            this.customstpmDataGridViewTextBoxColumn.Visible = false;
            // 
            // customstpzDataGridViewTextBoxColumn
            // 
            this.customstpzDataGridViewTextBoxColumn.DataPropertyName = "custom_stp_z";
            this.customstpzDataGridViewTextBoxColumn.HeaderText = "custom_stp_z";
            this.customstpzDataGridViewTextBoxColumn.Name = "customstpzDataGridViewTextBoxColumn";
            this.customstpzDataGridViewTextBoxColumn.Visible = false;
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(12, 473);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(0, 13);
            this.lblSave.TabIndex = 4;
            // 
            // ShowProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(792, 497);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowProjects";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ShowProjects";
            this.Load += new System.EventHandler(this.ShowProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.massprojectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dmsMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource massprojectBindingSource;
        private DMSdbDataSet dmsMass;
        private mass_projectTableAdapter mass_projectTableAdapter;
        private Controls.DataGridViewFlickerFree dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prototypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectgroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numtype1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numtype2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lgbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bgbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hgbDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customstpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customstpmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customstpzDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblSave;
    }
}