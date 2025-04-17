namespace dms.pages.Main
{
    partial class MassFilling
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        protected System.ComponentModel.IContainer components = null;

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
        protected virtual void InitializeComponent()
        {
            this.split = new System.Windows.Forms.SplitContainer();
            this.gb_bids = new System.Windows.Forms.GroupBox();
            this.dg_bids = new dms.pages.Controls.DataGridViewFlickerFree();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkFilterCopy = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_num_projects = new System.Windows.Forms.Label();
            this.chk_myprojects = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cb_pgroup = new System.Windows.Forms.ComboBox();
            this.cb_projects = new System.Windows.Forms.ComboBox();
            this.gb_data = new System.Windows.Forms.GroupBox();
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
            this.dg_data = new dms.pages.Controls.DataGridViewFlickerFree();
            this.gb_fillBid = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            this.gb_bids.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_bids)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_data.SuspendLayout();
            this.gb_sum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_data)).BeginInit();
            this.SuspendLayout();
            // 
            // split
            // 
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.Location = new System.Drawing.Point(0, 0);
            this.split.Name = "split";
            this.split.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // split.Panel1
            // 
            this.split.Panel1.Controls.Add(this.gb_bids);
            // 
            // split.Panel2
            // 
            this.split.Panel2.Controls.Add(this.gb_data);
            this.split.Size = new System.Drawing.Size(1279, 1000);
            this.split.SplitterDistance = 389;
            this.split.TabIndex = 0;
            // 
            // gb_bids
            // 
            this.gb_bids.Controls.Add(this.dg_bids);
            this.gb_bids.Controls.Add(this.groupBox2);
            this.gb_bids.Controls.Add(this.groupBox1);
            this.gb_bids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_bids.Location = new System.Drawing.Point(0, 0);
            this.gb_bids.Name = "gb_bids";
            this.gb_bids.Size = new System.Drawing.Size(1279, 389);
            this.gb_bids.TabIndex = 1;
            this.gb_bids.TabStop = false;
            this.gb_bids.Text = "Заявки";
            // 
            // dg_bids
            // 
            this.dg_bids.AllowUserToDeleteRows = false;
            this.dg_bids.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_bids.Dock = System.Windows.Forms.DockStyle.Left;
            this.dg_bids.Location = new System.Drawing.Point(3, 16);
            this.dg_bids.Name = "dg_bids";
            this.dg_bids.Size = new System.Drawing.Size(1000, 370);
            this.dg_bids.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkFilterCopy);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.cb_status);
            this.groupBox2.Location = new System.Drawing.Point(1009, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действия над заявками";
            // 
            // chkFilterCopy
            // 
            this.chkFilterCopy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkFilterCopy.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkFilterCopy.Location = new System.Drawing.Point(177, 7);
            this.chkFilterCopy.Name = "chkFilterCopy";
            this.chkFilterCopy.Size = new System.Drawing.Size(84, 17);
            this.chkFilterCopy.TabIndex = 32;
            this.chkFilterCopy.Text = "без копий";
            this.chkFilterCopy.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkFilterCopy.UseVisualStyleBackColor = true;
            this.chkFilterCopy.CheckedChanged += new System.EventHandler(this.chkFilterCopy_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Фильтр:";
            // 
            // cb_status
            // 
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "все",
            "обработка",
            "утв.в подразделении",
            "утв.гл.конструктором",
            "добавлена"});
            this.cb_status.Location = new System.Drawing.Point(4, 36);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(150, 21);
            this.cb_status.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lbl_num_projects);
            this.groupBox1.Controls.Add(this.chk_myprojects);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cb_pgroup);
            this.groupBox1.Controls.Add(this.cb_projects);
            this.groupBox1.Location = new System.Drawing.Point(1009, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор проекта";
            // 
            // lbl_num_projects
            // 
            this.lbl_num_projects.AutoSize = true;
            this.lbl_num_projects.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_num_projects.Location = new System.Drawing.Point(213, 77);
            this.lbl_num_projects.Name = "lbl_num_projects";
            this.lbl_num_projects.Size = new System.Drawing.Size(13, 13);
            this.lbl_num_projects.TabIndex = 34;
            this.lbl_num_projects.Text = "0";
            // 
            // chk_myprojects
            // 
            this.chk_myprojects.AutoSize = true;
            this.chk_myprojects.Location = new System.Drawing.Point(167, 36);
            this.chk_myprojects.Name = "chk_myprojects";
            this.chk_myprojects.Size = new System.Drawing.Size(92, 17);
            this.chk_myprojects.TabIndex = 33;
            this.chk_myprojects.Text = "мои проекты";
            this.chk_myprojects.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "Проект:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "Группа проектов:";
            // 
            // cb_pgroup
            // 
            this.cb_pgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pgroup.FormattingEnabled = true;
            this.cb_pgroup.Location = new System.Drawing.Point(6, 34);
            this.cb_pgroup.Name = "cb_pgroup";
            this.cb_pgroup.Size = new System.Drawing.Size(150, 21);
            this.cb_pgroup.TabIndex = 30;
            // 
            // cb_projects
            // 
            this.cb_projects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_projects.FormattingEnabled = true;
            this.cb_projects.Location = new System.Drawing.Point(6, 74);
            this.cb_projects.Name = "cb_projects";
            this.cb_projects.Size = new System.Drawing.Size(201, 21);
            this.cb_projects.TabIndex = 29;
            // 
            // gb_data
            // 
            this.gb_data.Controls.Add(this.gb_sum);
            this.gb_data.Controls.Add(this.dg_data);
            this.gb_data.Controls.Add(this.gb_fillBid);
            this.gb_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_data.Location = new System.Drawing.Point(0, 0);
            this.gb_data.Name = "gb_data";
            this.gb_data.Size = new System.Drawing.Size(1279, 607);
            this.gb_data.TabIndex = 2;
            this.gb_data.TabStop = false;
            this.gb_data.Text = "Данные";
            // 
            // gb_sum
            // 
            this.gb_sum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.gb_sum.Location = new System.Drawing.Point(3, 569);
            this.gb_sum.Name = "gb_sum";
            this.gb_sum.Size = new System.Drawing.Size(1000, 35);
            this.gb_sum.TabIndex = 9;
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
            // dg_data
            // 
            this.dg_data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dg_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_data.Location = new System.Drawing.Point(3, 16);
            this.dg_data.Name = "dg_data";
            this.dg_data.Size = new System.Drawing.Size(1000, 550);
            this.dg_data.TabIndex = 10;
            // 
            // gb_fillBid
            // 
            this.gb_fillBid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_fillBid.Location = new System.Drawing.Point(1009, 10);
            this.gb_fillBid.Name = "gb_fillBid";
            this.gb_fillBid.Size = new System.Drawing.Size(264, 594);
            this.gb_fillBid.TabIndex = 0;
            this.gb_fillBid.TabStop = false;
            this.gb_fillBid.Text = "Заполнение заявок";
            // 
            // MassFilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.split);
            this.DoubleBuffered = true;
            this.Name = "MassFilling";
            this.Size = new System.Drawing.Size(1279, 1000);
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.gb_bids.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_bids)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_data.ResumeLayout(false);
            this.gb_sum.ResumeLayout(false);
            this.gb_sum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.SplitContainer split;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.GroupBox gb_data;
        protected System.Windows.Forms.GroupBox gb_fillBid;
        protected System.Windows.Forms.Label label19;
        protected System.Windows.Forms.Label label18;
        protected System.Windows.Forms.ComboBox cb_pgroup;
        protected System.Windows.Forms.ComboBox cb_projects;
        protected System.Windows.Forms.CheckBox chk_myprojects;
        protected System.Windows.Forms.Label lbl_num_projects;
        protected System.Windows.Forms.Label label17;
        protected System.Windows.Forms.ComboBox cb_status;
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
        protected System.Windows.Forms.GroupBox gb_bids;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected Controls.DataGridViewFlickerFree dg_bids;
        protected Controls.DataGridViewFlickerFree dg_data;
        protected System.Windows.Forms.CheckBox chkFilterCopy;
    }
}
