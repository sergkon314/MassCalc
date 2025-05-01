namespace dms.pages.Main
{
    partial class MainPage
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.page1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.page2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.massClaimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1221, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.page1ToolStripMenuItem,
            this.page2ToolStripMenuItem,
            this.massClaimToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // page1ToolStripMenuItem
            // 
            this.page1ToolStripMenuItem.Name = "page1ToolStripMenuItem";
            this.page1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.page1ToolStripMenuItem.Text = "MassBids";
            this.page1ToolStripMenuItem.Click += new System.EventHandler(this.massBidsToolStripMenuItem_Click);
            // 
            // page2ToolStripMenuItem
            // 
            this.page2ToolStripMenuItem.Name = "page2ToolStripMenuItem";
            this.page2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.page2ToolStripMenuItem.Text = "MassCalc";
            this.page2ToolStripMenuItem.Click += new System.EventHandler(this.massCalcToolStripMenuItem_Click);
            // 
            // massClaimToolStripMenuItem
            // 
            this.massClaimToolStripMenuItem.Name = "massClaimToolStripMenuItem";
            this.massClaimToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.massClaimToolStripMenuItem.Text = "MassClaim";
            this.massClaimToolStripMenuItem.Click += new System.EventHandler(this.massClaimToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 24);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1221, 933);
            this.panel.TabIndex = 2;
            // 
            // MainPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.mainMenu);
            this.Name = "MainPage";
            this.Size = new System.Drawing.Size(1221, 957);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem page1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem page2ToolStripMenuItem;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripMenuItem massClaimToolStripMenuItem;

    }
}
