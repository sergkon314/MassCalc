namespace dms.pages.Mass.Dialogs
{
     partial class ChoiseBidUser
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiseBidUser));
               this.label1 = new System.Windows.Forms.Label();
               this.lbl_name = new System.Windows.Forms.Label();
               this.lb = new System.Windows.Forms.ListBox();
               this.btn_cancel = new System.Windows.Forms.Button();
               this.btn_ok = new System.Windows.Forms.Button();
               this.label2 = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(12, 9);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(47, 13);
               this.label1.TabIndex = 0;
               this.label1.Text = "Заявка:";
               // 
               // lbl_name
               // 
               this.lbl_name.AutoSize = true;
               this.lbl_name.BackColor = System.Drawing.SystemColors.Info;
               this.lbl_name.Location = new System.Drawing.Point(65, 9);
               this.lbl_name.Name = "lbl_name";
               this.lbl_name.Size = new System.Drawing.Size(10, 13);
               this.lbl_name.TabIndex = 1;
               this.lbl_name.Text = "-";
               // 
               // lb
               // 
               this.lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
               this.lb.FormattingEnabled = true;
               this.lb.Location = new System.Drawing.Point(12, 47);
               this.lb.Name = "lb";
               this.lb.Size = new System.Drawing.Size(268, 340);
               this.lb.TabIndex = 2;
               // 
               // btn_cancel
               // 
               this.btn_cancel.Location = new System.Drawing.Point(107, 402);
               this.btn_cancel.Name = "btn_cancel";
               this.btn_cancel.Size = new System.Drawing.Size(75, 23);
               this.btn_cancel.TabIndex = 3;
               this.btn_cancel.Text = "Отмена";
               this.btn_cancel.UseVisualStyleBackColor = true;
               this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
               // 
               // btn_ok
               // 
               this.btn_ok.Location = new System.Drawing.Point(205, 402);
               this.btn_ok.Name = "btn_ok";
               this.btn_ok.Size = new System.Drawing.Size(75, 23);
               this.btn_ok.TabIndex = 4;
               this.btn_ok.Text = "ОК";
               this.btn_ok.UseVisualStyleBackColor = true;
               this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(12, 32);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(121, 13);
               this.label2.TabIndex = 5;
               this.label2.Text = "Список исполнителей:";
               // 
               // ChoiseBidUser
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(292, 432);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.btn_ok);
               this.Controls.Add(this.btn_cancel);
               this.Controls.Add(this.lb);
               this.Controls.Add(this.lbl_name);
               this.Controls.Add(this.label1);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.MaximizeBox = false;
               this.MinimizeBox = false;
               this.Name = "ChoiseBidUser";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Сменить исполнителя заявки";
               this.Load += new System.EventHandler(this.ChoiseBidUser_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label lbl_name;
          private System.Windows.Forms.ListBox lb;
          private System.Windows.Forms.Button btn_cancel;
          private System.Windows.Forms.Button btn_ok;
          private System.Windows.Forms.Label label2;
     }
}