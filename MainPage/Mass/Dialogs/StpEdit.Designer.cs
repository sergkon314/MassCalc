namespace dms.pages.Mass.Dialogs
{
     partial class StpEdit
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StpEdit));
               this.dg = new System.Windows.Forms.DataGridView();
               ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
               this.SuspendLayout();
               // 
               // dg
               // 
               this.dg.AllowUserToAddRows = false;
               this.dg.AllowUserToDeleteRows = false;
               this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dg.Dock = System.Windows.Forms.DockStyle.Fill;
               this.dg.Location = new System.Drawing.Point(0, 0);
               this.dg.Name = "dg";
               this.dg.RowHeadersVisible = false;
               this.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
               this.dg.Size = new System.Drawing.Size(867, 653);
               this.dg.TabIndex = 0;
               // 
               // StpEdit
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(867, 653);
               this.Controls.Add(this.dg);
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MaximizeBox = false;
               this.MinimizeBox = false;
               this.Name = "StpEdit";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Изменить коэффициенты СТП";
               this.Load += new System.EventHandler(this.StpEdit_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.DataGridView dg;
     }
}