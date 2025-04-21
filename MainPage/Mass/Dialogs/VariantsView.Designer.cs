namespace dms.pages.Mass.Dialogs
{
     partial class VariantsView
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VariantsView));
               this.tabs = new System.Windows.Forms.TabControl();
               this.SuspendLayout();
               // 
               // tabs
               // 
               this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
               this.tabs.Location = new System.Drawing.Point(0, 0);
               this.tabs.Name = "tabs";
               this.tabs.SelectedIndex = 0;
               this.tabs.Size = new System.Drawing.Size(886, 447);
               this.tabs.TabIndex = 0;
               // 
               // VariantsView
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(886, 447);
               this.Controls.Add(this.tabs);
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MaximizeBox = false;
               this.Name = "VariantsView";
               this.Text = "VariantsView";
               this.Load += new System.EventHandler(this.VariantsView_Load);
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.TabControl tabs;
     }
}