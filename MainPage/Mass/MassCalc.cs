using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dms.pages.Utils;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Globalization;
using System.Threading;
using dms.pages.Utils.DMSdbDataSetTableAdapters;
using dms.pages.Mass.Dialogs;
namespace dms.pages.Main
{
    public partial class MassCalc : MassFilling
    {
        private System.Windows.Forms.GroupBox gb_projectAction;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rb_typeShip;
        private System.Windows.Forms.RadioButton rb_typeDock;
        private System.Windows.Forms.Button btn_psave;
        private System.Windows.Forms.Button btn_pdelete;
        private System.Windows.Forms.Button btn_padd;
        private System.Windows.Forms.TextBox txt_pname;
        private System.Windows.Forms.Label label10;

        protected DMSdbDataSet.mass_stp_21DataTable dt_stp = new DMSdbDataSet.mass_stp_21DataTable();
        protected DMSdbDataSet.mass_data_bidDataTable dt_assembly;
        protected mass_stp_21TableAdapter ta_stp = new mass_stp_21TableAdapter();
        private Button btn_report1;
        private Button btn_calc;
        private Button btn_alldata;
        private GroupBox groupBox6;
        private CheckBox _18;
        private CheckBox _17;
        private CheckBox _16;
        private CheckBox _15;
        private CheckBox _14;
        private CheckBox _13;
        private CheckBox _11;
        private CheckBox _10;
        private CheckBox _09;
        private CheckBox _08;
        private CheckBox _07;
        private CheckBox _06;
        private CheckBox _05;
        private CheckBox _04;
        private CheckBox _03;
        private CheckBox _02;
        private CheckBox _12;
        private CheckBox _01;
        private Label label40;
        private Label label39;
        private Label label38;
        private Label label37;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label33;
        private Label label32;
        private Label label31;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label25;
        private Label label24;
        private Label label23;
        private Label label22;
        private Button btn_editstp;
        private Button btn_report2;
        private Button btn_calc2;
        private Panel panel1;
        private RadioButton rb_mute0;
        private RadioButton rb_mute1;
        private TextBox txt_pdescription;
        private Label label11;
        private GroupBox groupBox5;
        private RadioButton rb_proto0;
        private RadioButton rb_proto1;
        private ComboBox cb_pdescr;
        private Label label20;
        private ComboBox cb_pmasters;
        private ComboBox cb_projectgroup;
        private Label label13;
        private Label label12;
        private Label label14;
        private TextBox txt_gbH;
        private Label label9;
        private TextBox txt_gbB;
        private Label label1;
        private TextBox txt_gbL;
        private CheckBox chk_claim3;
        private Label label16;
        private Label label15;
        private TextBox txtCustomZ;
        private TextBox txtCustomM;
        private CheckBox chkCustomStp;
        private Label label21;
        private CheckBox chkActive;
        protected mass_variantsTableAdapter ta_variants = new mass_variantsTableAdapter();


        private float[, ,] PrecTable;
        private float[, ,] PrecTable2;
        private float[, ,] PrecTable3;
        public MassCalc(MainPage o, string name)
            : base(o, name)
        {
            InitializeComponent();
            //ta_variants.Connection.ConnectionString = MysglConString;
            //ta_stp.Connection.ConnectionString = MysglConString;
        }

        new private void InitializeComponent()
        {
            this.gb_projectAction = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_gbH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_gbB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_gbL = new System.Windows.Forms.TextBox();
            this.txt_pdescription = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb_mute0 = new System.Windows.Forms.RadioButton();
            this.rb_mute1 = new System.Windows.Forms.RadioButton();
            this.rb_typeShip = new System.Windows.Forms.RadioButton();
            this.rb_typeDock = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCustomZ = new System.Windows.Forms.TextBox();
            this.txtCustomM = new System.Windows.Forms.TextBox();
            this.chkCustomStp = new System.Windows.Forms.CheckBox();
            this.rb_proto0 = new System.Windows.Forms.RadioButton();
            this.rb_proto1 = new System.Windows.Forms.RadioButton();
            this.cb_pdescr = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btn_psave = new System.Windows.Forms.Button();
            this.btn_pdelete = new System.Windows.Forms.Button();
            this.btn_padd = new System.Windows.Forms.Button();
            this.cb_pmasters = new System.Windows.Forms.ComboBox();
            this.cb_projectgroup = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_pname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_report1 = new System.Windows.Forms.Button();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_alldata = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this._18 = new System.Windows.Forms.CheckBox();
            this._17 = new System.Windows.Forms.CheckBox();
            this._16 = new System.Windows.Forms.CheckBox();
            this._15 = new System.Windows.Forms.CheckBox();
            this._14 = new System.Windows.Forms.CheckBox();
            this._13 = new System.Windows.Forms.CheckBox();
            this._11 = new System.Windows.Forms.CheckBox();
            this._10 = new System.Windows.Forms.CheckBox();
            this._09 = new System.Windows.Forms.CheckBox();
            this._08 = new System.Windows.Forms.CheckBox();
            this._07 = new System.Windows.Forms.CheckBox();
            this._06 = new System.Windows.Forms.CheckBox();
            this._05 = new System.Windows.Forms.CheckBox();
            this._04 = new System.Windows.Forms.CheckBox();
            this._03 = new System.Windows.Forms.CheckBox();
            this._02 = new System.Windows.Forms.CheckBox();
            this._12 = new System.Windows.Forms.CheckBox();
            this._01 = new System.Windows.Forms.CheckBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btn_editstp = new System.Windows.Forms.Button();
            this.btn_report2 = new System.Windows.Forms.Button();
            this.btn_calc2 = new System.Windows.Forms.Button();
            this.chk_claim3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb_data.SuspendLayout();
            this.gb_fillBid.SuspendLayout();
            this.gb_sum.SuspendLayout();
            this.gb_bids.SuspendLayout();
            this.groupBox2.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.dt_projects)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.dt_codes)).BeginInit();
            this.gb_projectAction.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // split
            // 
            this.split.SplitterDistance = 454;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Size = new System.Drawing.Size(264, 72);
            // 
            // gb_data
            // 
            this.gb_data.Controls.Add(this.groupBox6);
            this.gb_data.Size = new System.Drawing.Size(1279, 542);
            this.gb_data.Controls.SetChildIndex(this.gb_fillBid, 0);
            this.gb_data.Controls.SetChildIndex(this.gb_sum, 0);
            this.gb_data.Controls.SetChildIndex(this.groupBox6, 0);
            // 
            // gb_fillBid
            // 
            this.gb_fillBid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_fillBid.Controls.Add(this.btn_report1);
            this.gb_fillBid.Controls.Add(this.btn_calc);
            this.gb_fillBid.Controls.Add(this.btn_alldata);
            this.gb_fillBid.Size = new System.Drawing.Size(264, 46);
            this.gb_fillBid.Text = "Расчеты";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(8, 48);
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(6, 21);
            // 
            // cb_pgroup
            // 
            this.cb_pgroup.Location = new System.Drawing.Point(107, 17);
            this.cb_pgroup.Size = new System.Drawing.Size(114, 21);
            // 
            // cb_projects
            // 
            this.cb_projects.Location = new System.Drawing.Point(62, 46);
            this.cb_projects.Size = new System.Drawing.Size(193, 21);
            // 
            // chk_myprojects
            // 
            this.chk_myprojects.Location = new System.Drawing.Point(55, 73);
            // 
            // lbl_num_projects
            // 
            this.lbl_num_projects.Location = new System.Drawing.Point(235, 30);
            this.lbl_num_projects.DoubleClick += new System.EventHandler(this.lbl_num_projects_DoubleClick);
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(3, 22);
            // 
            // cb_status
            // 
            this.cb_status.Location = new System.Drawing.Point(55, 19);
            this.cb_status.Size = new System.Drawing.Size(112, 21);
            // 
            // gb_sum
            // 
            this.gb_sum.Location = new System.Drawing.Point(3, 504);
            // 
            // gb_bids
            // 
            this.gb_bids.Controls.Add(this.gb_projectAction);
            this.gb_bids.Size = new System.Drawing.Size(1279, 454);
            this.gb_bids.Controls.SetChildIndex(this.groupBox2, 0);
            this.gb_bids.Controls.SetChildIndex(this.gb_projectAction, 0);
            this.gb_bids.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chk_claim3);
            this.groupBox2.Location = new System.Drawing.Point(1009, 87);
            this.groupBox2.Size = new System.Drawing.Size(264, 49);
            this.groupBox2.Controls.SetChildIndex(this.chkFilterCopy, 0);
            this.groupBox2.Controls.SetChildIndex(this.cb_status, 0);
            this.groupBox2.Controls.SetChildIndex(this.label17, 0);
            this.groupBox2.Controls.SetChildIndex(this.chk_claim3, 0);
            // 
            // chkFilterCopy
            // 
            this.chkFilterCopy.Location = new System.Drawing.Point(176, 29);
            // 
            // gb_projectAction
            // 
            this.gb_projectAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_projectAction.Controls.Add(this.label21);
            this.gb_projectAction.Controls.Add(this.chkActive);
            this.gb_projectAction.Controls.Add(this.label14);
            this.gb_projectAction.Controls.Add(this.txt_gbH);
            this.gb_projectAction.Controls.Add(this.label9);
            this.gb_projectAction.Controls.Add(this.txt_gbB);
            this.gb_projectAction.Controls.Add(this.label1);
            this.gb_projectAction.Controls.Add(this.txt_gbL);
            this.gb_projectAction.Controls.Add(this.txt_pdescription);
            this.gb_projectAction.Controls.Add(this.label11);
            this.gb_projectAction.Controls.Add(this.groupBox4);
            this.gb_projectAction.Controls.Add(this.groupBox5);
            this.gb_projectAction.Controls.Add(this.cb_pdescr);
            this.gb_projectAction.Controls.Add(this.label20);
            this.gb_projectAction.Controls.Add(this.btn_psave);
            this.gb_projectAction.Controls.Add(this.btn_pdelete);
            this.gb_projectAction.Controls.Add(this.btn_padd);
            this.gb_projectAction.Controls.Add(this.cb_pmasters);
            this.gb_projectAction.Controls.Add(this.cb_projectgroup);
            this.gb_projectAction.Controls.Add(this.label13);
            this.gb_projectAction.Controls.Add(this.label12);
            this.gb_projectAction.Controls.Add(this.txt_pname);
            this.gb_projectAction.Controls.Add(this.label10);
            this.gb_projectAction.Location = new System.Drawing.Point(1009, 138);
            this.gb_projectAction.Name = "gb_projectAction";
            this.gb_projectAction.Size = new System.Drawing.Size(264, 313);
            this.gb_projectAction.TabIndex = 13;
            this.gb_projectAction.TabStop = false;
            this.gb_projectAction.Text = "Действия над проектом:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(195, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "Активный:";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(198, 31);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(43, 17);
            this.chkActive.TabIndex = 26;
            this.chkActive.Text = "нет";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(174, 259);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Hгб:";
            // 
            // txt_gbH
            // 
            this.txt_gbH.Location = new System.Drawing.Point(204, 256);
            this.txt_gbH.Name = "txt_gbH";
            this.txt_gbH.Size = new System.Drawing.Size(51, 20);
            this.txt_gbH.TabIndex = 24;

            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Bгб:";
            // 
            // txt_gbB
            // 
            this.txt_gbB.Location = new System.Drawing.Point(119, 256);
            this.txt_gbB.Name = "txt_gbB";
            this.txt_gbB.Size = new System.Drawing.Size(51, 20);
            this.txt_gbB.TabIndex = 22;
            //this.txt_gbB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gb_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Lгб:";
            // 
            // txt_gbL
            // 
            this.txt_gbL.Location = new System.Drawing.Point(33, 256);
            this.txt_gbL.Name = "txt_gbL";
            this.txt_gbL.Size = new System.Drawing.Size(51, 20);
            this.txt_gbL.TabIndex = 18;
            //this.txt_gbL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gb_KeyPress);
            // 
            // txt_pdescription
            // 
            this.txt_pdescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pdescription.Location = new System.Drawing.Point(5, 68);
            this.txt_pdescription.Name = "txt_pdescription";
            this.txt_pdescription.Size = new System.Drawing.Size(253, 20);
            this.txt_pdescription.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Комментарий:";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Controls.Add(this.rb_typeShip);
            this.groupBox4.Controls.Add(this.rb_typeDock);
            this.groupBox4.Location = new System.Drawing.Point(5, 210);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 38);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Тип:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_mute0);
            this.panel1.Controls.Add(this.rb_mute1);
            this.panel1.Location = new System.Drawing.Point(113, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 18);
            this.panel1.TabIndex = 34;
            // 
            // rb_mute0
            // 
            this.rb_mute0.AutoSize = true;
            this.rb_mute0.Location = new System.Drawing.Point(5, 2);
            this.rb_mute0.Name = "rb_mute0";
            this.rb_mute0.Size = new System.Drawing.Size(59, 17);
            this.rb_mute0.TabIndex = 35;
            this.rb_mute0.TabStop = true;
            this.rb_mute0.Text = "гражд.";
            this.rb_mute0.UseVisualStyleBackColor = true;
            // 
            // rb_mute1
            // 
            this.rb_mute1.AutoSize = true;
            this.rb_mute1.Location = new System.Drawing.Point(70, 3);
            this.rb_mute1.Name = "rb_mute1";
            this.rb_mute1.Size = new System.Drawing.Size(60, 17);
            this.rb_mute1.TabIndex = 34;
            this.rb_mute1.TabStop = true;
            this.rb_mute1.Text = "вспом.";
            this.rb_mute1.UseVisualStyleBackColor = true;
            // 
            // rb_typeShip
            // 
            this.rb_typeShip.AutoSize = true;
            this.rb_typeShip.Location = new System.Drawing.Point(53, 15);
            this.rb_typeShip.Name = "rb_typeShip";
            this.rb_typeShip.Size = new System.Drawing.Size(54, 17);
            this.rb_typeShip.TabIndex = 30;
            this.rb_typeShip.TabStop = true;
            this.rb_typeShip.Text = "судно";
            this.rb_typeShip.UseVisualStyleBackColor = true;
            // 
            // rb_typeDock
            // 
            this.rb_typeDock.AutoSize = true;
            this.rb_typeDock.Location = new System.Drawing.Point(6, 14);
            this.rb_typeDock.Name = "rb_typeDock";
            this.rb_typeDock.Size = new System.Drawing.Size(43, 17);
            this.rb_typeDock.TabIndex = 29;
            this.rb_typeDock.TabStop = true;
            this.rb_typeDock.Text = "док";
            this.rb_typeDock.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.txtCustomZ);
            this.groupBox5.Controls.Add(this.txtCustomM);
            this.groupBox5.Controls.Add(this.chkCustomStp);
            this.groupBox5.Controls.Add(this.rb_proto0);
            this.groupBox5.Controls.Add(this.rb_proto1);
            this.groupBox5.Location = new System.Drawing.Point(5, 173);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(250, 38);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Наличие прототипа:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(190, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Z:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(129, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(19, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "M:";
            // 
            // txtCustomZ
            // 
            this.txtCustomZ.Location = new System.Drawing.Point(207, 14);
            this.txtCustomZ.Name = "txtCustomZ";
            this.txtCustomZ.Size = new System.Drawing.Size(37, 20);
            this.txtCustomZ.TabIndex = 29;
            //this.txtCustomZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gb_KeyPress);
            // 
            // txtCustomM
            // 
            this.txtCustomM.Location = new System.Drawing.Point(147, 14);
            this.txtCustomM.Name = "txtCustomM";
            this.txtCustomM.Size = new System.Drawing.Size(37, 20);
            this.txtCustomM.TabIndex = 28;
            //this.txtCustomM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gb_KeyPress);
            // 
            // chkCustomStp
            // 
            this.chkCustomStp.AutoSize = true;
            this.chkCustomStp.Location = new System.Drawing.Point(95, 16);
            this.chkCustomStp.Name = "chkCustomStp";
            this.chkCustomStp.Size = new System.Drawing.Size(32, 17);
            this.chkCustomStp.TabIndex = 27;
            this.chkCustomStp.Text = "?";
            this.chkCustomStp.UseVisualStyleBackColor = true;
            // 
            // rb_proto0
            // 
            this.rb_proto0.AutoSize = true;
            this.rb_proto0.Location = new System.Drawing.Point(53, 14);
            this.rb_proto0.Name = "rb_proto0";
            this.rb_proto0.Size = new System.Drawing.Size(42, 17);
            this.rb_proto0.TabIndex = 26;
            this.rb_proto0.TabStop = true;
            this.rb_proto0.Text = "нет";
            this.rb_proto0.UseVisualStyleBackColor = true;
            // 
            // rb_proto1
            // 
            this.rb_proto1.AutoSize = true;
            this.rb_proto1.Location = new System.Drawing.Point(11, 14);
            this.rb_proto1.Name = "rb_proto1";
            this.rb_proto1.Size = new System.Drawing.Size(37, 17);
            this.rb_proto1.TabIndex = 25;
            this.rb_proto1.TabStop = true;
            this.rb_proto1.Text = "да";
            this.rb_proto1.UseVisualStyleBackColor = true;
            // 
            // cb_pdescr
            // 
            this.cb_pdescr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_pdescr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pdescr.FormattingEnabled = true;
            this.cb_pdescr.Location = new System.Drawing.Point(5, 146);
            this.cb_pdescr.Name = "cb_pdescr";
            this.cb_pdescr.Size = new System.Drawing.Size(252, 21);
            this.cb_pdescr.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 130);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "Описание:";
            // 
            // btn_psave
            // 
            this.btn_psave.Location = new System.Drawing.Point(182, 286);
            this.btn_psave.Name = "btn_psave";
            this.btn_psave.Size = new System.Drawing.Size(75, 23);
            this.btn_psave.TabIndex = 11;
            this.btn_psave.Text = "Сохранить";
            this.btn_psave.UseVisualStyleBackColor = true;
            this.btn_psave.Click += new System.EventHandler(this.btn_psave_Click);
            // 
            // btn_pdelete
            // 
            this.btn_pdelete.Location = new System.Drawing.Point(93, 286);
            this.btn_pdelete.Name = "btn_pdelete";
            this.btn_pdelete.Size = new System.Drawing.Size(75, 23);
            this.btn_pdelete.TabIndex = 10;
            this.btn_pdelete.Text = "Удалить";
            this.btn_pdelete.UseVisualStyleBackColor = true;
            this.btn_pdelete.Click += new System.EventHandler(this.btn_pdelete_Click);
            // 
            // btn_padd
            // 
            this.btn_padd.Location = new System.Drawing.Point(4, 286);
            this.btn_padd.Name = "btn_padd";
            this.btn_padd.Size = new System.Drawing.Size(75, 23);
            this.btn_padd.TabIndex = 9;
            this.btn_padd.Text = "Добавить";
            this.btn_padd.UseVisualStyleBackColor = true;
            this.btn_padd.Click += new System.EventHandler(this.btn_padd_Click);
            // 
            // cb_pmasters
            // 
            this.cb_pmasters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_pmasters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pmasters.FormattingEnabled = true;
            this.cb_pmasters.Location = new System.Drawing.Point(137, 106);
            this.cb_pmasters.Name = "cb_pmasters";
            this.cb_pmasters.Size = new System.Drawing.Size(121, 21);
            this.cb_pmasters.TabIndex = 8;
            // 
            // cb_projectgroup
            // 
            this.cb_projectgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_projectgroup.FormattingEnabled = true;
            this.cb_projectgroup.Location = new System.Drawing.Point(5, 106);
            this.cb_projectgroup.Name = "cb_projectgroup";
            this.cb_projectgroup.Size = new System.Drawing.Size(125, 21);
            this.cb_projectgroup.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(134, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Руководитель:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Группа:";
            // 
            // txt_pname
            // 
            this.txt_pname.Location = new System.Drawing.Point(6, 30);
            this.txt_pname.Name = "txt_pname";
            this.txt_pname.Size = new System.Drawing.Size(183, 20);
            this.txt_pname.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Название:";
            // 
            // btn_report1
            // 
            this.btn_report1.Location = new System.Drawing.Point(184, 16);
            this.btn_report1.Name = "btn_report1";
            this.btn_report1.Size = new System.Drawing.Size(75, 23);
            this.btn_report1.TabIndex = 7;
            this.btn_report1.Text = "Отчет";
            this.btn_report1.UseVisualStyleBackColor = true;
            //this.btn_report1.Click += new System.EventHandler(this.btn_report1_Click);
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(95, 16);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 6;
            this.btn_calc.Text = "Расчет";
            this.btn_calc.UseVisualStyleBackColor = true;
            //this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btn_alldata
            // 
            this.btn_alldata.Location = new System.Drawing.Point(5, 16);
            this.btn_alldata.Name = "btn_alldata";
            this.btn_alldata.Size = new System.Drawing.Size(75, 23);
            this.btn_alldata.TabIndex = 5;
            this.btn_alldata.Text = "Сводная";
            this.btn_alldata.UseVisualStyleBackColor = true;
            //this.btn_alldata.Click += new System.EventHandler(this.btn_alldata_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this._18);
            this.groupBox6.Controls.Add(this._17);
            this.groupBox6.Controls.Add(this._16);
            this.groupBox6.Controls.Add(this._15);
            this.groupBox6.Controls.Add(this._14);
            this.groupBox6.Controls.Add(this._13);
            this.groupBox6.Controls.Add(this._11);
            this.groupBox6.Controls.Add(this._10);
            this.groupBox6.Controls.Add(this._09);
            this.groupBox6.Controls.Add(this._08);
            this.groupBox6.Controls.Add(this._07);
            this.groupBox6.Controls.Add(this._06);
            this.groupBox6.Controls.Add(this._05);
            this.groupBox6.Controls.Add(this._04);
            this.groupBox6.Controls.Add(this._03);
            this.groupBox6.Controls.Add(this._02);
            this.groupBox6.Controls.Add(this._12);
            this.groupBox6.Controls.Add(this._01);
            this.groupBox6.Controls.Add(this.label40);
            this.groupBox6.Controls.Add(this.label39);
            this.groupBox6.Controls.Add(this.label38);
            this.groupBox6.Controls.Add(this.label37);
            this.groupBox6.Controls.Add(this.label36);
            this.groupBox6.Controls.Add(this.label35);
            this.groupBox6.Controls.Add(this.label34);
            this.groupBox6.Controls.Add(this.label33);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.label30);
            this.groupBox6.Controls.Add(this.label29);
            this.groupBox6.Controls.Add(this.label28);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.btn_editstp);
            this.groupBox6.Controls.Add(this.btn_report2);
            this.groupBox6.Controls.Add(this.btn_calc2);
            this.groupBox6.Location = new System.Drawing.Point(1009, 62);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(264, 477);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Варианты нагрузки:";
            // 
            // _18
            // 
            this._18.AutoSize = true;
            this._18.Location = new System.Drawing.Point(28, 373);
            this._18.Name = "_18";
            this._18.Size = new System.Drawing.Size(88, 17);
            this._18.TabIndex = 46;
            this._18.Text = "наибольшее";
            this._18.UseVisualStyleBackColor = true;
            // 
            // _17
            // 
            this._17.AutoSize = true;
            this._17.Location = new System.Drawing.Point(28, 352);
            this._17.Name = "_17";
            this._17.Size = new System.Drawing.Size(62, 17);
            this._17.TabIndex = 45;
            this._17.Text = "полное";
            this._17.UseVisualStyleBackColor = true;
            // 
            // _16
            // 
            this._16.AutoSize = true;
            this._16.Location = new System.Drawing.Point(28, 331);
            this._16.Name = "_16";
            this._16.Size = new System.Drawing.Size(82, 17);
            this._16.TabIndex = 44;
            this._16.Text = "номальное";
            this._16.UseVisualStyleBackColor = true;
            // 
            // _15
            // 
            this._15.AutoSize = true;
            this._15.Location = new System.Drawing.Point(28, 310);
            this._15.Name = "_15";
            this._15.Size = new System.Drawing.Size(90, 17);
            this._15.TabIndex = 43;
            this._15.Text = "стандартное";
            this._15.UseVisualStyleBackColor = true;
            // 
            // _14
            // 
            this._14.AutoSize = true;
            this._14.Location = new System.Drawing.Point(28, 289);
            this._14.Name = "_14";
            this._14.Size = new System.Drawing.Size(96, 17);
            this._14.TabIndex = 42;
            this._14.Text = "строительное";
            this._14.UseVisualStyleBackColor = true;
            // 
            // _13
            // 
            this._13.AutoSize = true;
            this._13.Location = new System.Drawing.Point(28, 268);
            this._13.Name = "_13";
            this._13.Size = new System.Drawing.Size(143, 17);
            this._13.TabIndex = 41;
            this._13.Text = "100% с полным грузом";
            this._13.UseVisualStyleBackColor = true;
            // 
            // _11
            // 
            this._11.AutoSize = true;
            this._11.Location = new System.Drawing.Point(28, 226);
            this._11.Name = "_11";
            this._11.Size = new System.Drawing.Size(179, 17);
            this._11.TabIndex = 40;
            this._11.Text = "100% запасов с пассажирами";
            this._11.UseVisualStyleBackColor = true;
            // 
            // _10
            // 
            this._10.AutoSize = true;
            this._10.Location = new System.Drawing.Point(28, 205);
            this._10.Name = "_10";
            this._10.Size = new System.Drawing.Size(145, 17);
            this._10.TabIndex = 39;
            this._10.Text = "100% запасов с грузом";
            this._10.UseVisualStyleBackColor = true;
            // 
            // _09
            // 
            this._09.AutoSize = true;
            this._09.Location = new System.Drawing.Point(28, 184);
            this._09.Name = "_09";
            this._09.Size = new System.Drawing.Size(97, 17);
            this._09.TabIndex = 38;
            this._09.Text = "100% запасов";
            this._09.UseVisualStyleBackColor = true;
            // 
            // _08
            // 
            this._08.AutoSize = true;
            this._08.Location = new System.Drawing.Point(28, 163);
            this._08.Name = "_08";
            this._08.Size = new System.Drawing.Size(199, 17);
            this._08.TabIndex = 37;
            this._08.Text = "100% запасов в пред. погружении";
            this._08.UseVisualStyleBackColor = true;
            // 
            // _07
            // 
            this._07.AutoSize = true;
            this._07.Location = new System.Drawing.Point(28, 142);
            this._07.Name = "_07";
            this._07.Size = new System.Drawing.Size(140, 17);
            this._07.TabIndex = 36;
            this._07.Text = "10% с полным грузом ";
            this._07.UseVisualStyleBackColor = true;
            // 
            // _06
            // 
            this._06.AutoSize = true;
            this._06.Location = new System.Drawing.Point(28, 121);
            this._06.Name = "_06";
            this._06.Size = new System.Drawing.Size(221, 17);
            this._06.TabIndex = 35;
            this._06.Text = "10% запасов с грузом и пассажирами";
            this._06.UseVisualStyleBackColor = true;
            // 
            // _05
            // 
            this._05.AutoSize = true;
            this._05.Location = new System.Drawing.Point(28, 100);
            this._05.Name = "_05";
            this._05.Size = new System.Drawing.Size(176, 17);
            this._05.TabIndex = 34;
            this._05.Text = "10% запасов с  пассажирами";
            this._05.UseVisualStyleBackColor = true;
            // 
            // _04
            // 
            this._04.AutoSize = true;
            this._04.Location = new System.Drawing.Point(28, 79);
            this._04.Name = "_04";
            this._04.Size = new System.Drawing.Size(139, 17);
            this._04.TabIndex = 33;
            this._04.Text = "10% запасов с грузом";
            this._04.UseVisualStyleBackColor = true;
            // 
            // _03
            // 
            this._03.AutoSize = true;
            this._03.Location = new System.Drawing.Point(28, 58);
            this._03.Name = "_03";
            this._03.Size = new System.Drawing.Size(91, 17);
            this._03.TabIndex = 32;
            this._03.Text = "10% запасов";
            this._03.UseVisualStyleBackColor = true;
            // 
            // _02
            // 
            this._02.AutoSize = true;
            this._02.Location = new System.Drawing.Point(28, 37);
            this._02.Name = "_02";
            this._02.Size = new System.Drawing.Size(193, 17);
            this._02.TabIndex = 31;
            this._02.Text = "10% запасов в пред. погружении";
            this._02.UseVisualStyleBackColor = true;
            // 
            // _12
            // 
            this._12.AutoSize = true;
            this._12.Location = new System.Drawing.Point(28, 246);
            this._12.Name = "_12";
            this._12.Size = new System.Drawing.Size(227, 17);
            this._12.TabIndex = 30;
            this._12.Text = "100% запасов с грузом и пассажирами";
            this._12.UseVisualStyleBackColor = true;
            // 
            // _01
            // 
            this._01.AutoSize = true;
            this._01.Location = new System.Drawing.Point(28, 16);
            this._01.Name = "_01";
            this._01.Size = new System.Drawing.Size(78, 17);
            this._01.TabIndex = 29;
            this._01.Text = "порожнем";
            this._01.UseVisualStyleBackColor = true;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(3, 374);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(19, 13);
            this.label40.TabIndex = 28;
            this.label40.Text = "18";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(3, 353);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(19, 13);
            this.label39.TabIndex = 27;
            this.label39.Text = "17";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(3, 332);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(19, 13);
            this.label38.TabIndex = 26;
            this.label38.Text = "16";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(3, 227);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(19, 13);
            this.label37.TabIndex = 25;
            this.label37.Text = "11";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(3, 311);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(19, 13);
            this.label36.TabIndex = 24;
            this.label36.Text = "15";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(3, 290);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(19, 13);
            this.label35.TabIndex = 23;
            this.label35.Text = "14";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(3, 269);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(19, 13);
            this.label34.TabIndex = 22;
            this.label34.Text = "13";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(3, 248);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(19, 13);
            this.label33.TabIndex = 21;
            this.label33.Text = "12";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(3, 206);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(19, 13);
            this.label32.TabIndex = 20;
            this.label32.Text = "10";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 185);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(13, 13);
            this.label31.TabIndex = 19;
            this.label31.Text = "9";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(3, 164);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(13, 13);
            this.label30.TabIndex = 18;
            this.label30.Text = "8";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(3, 143);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(13, 13);
            this.label29.TabIndex = 17;
            this.label29.Text = "7";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 122);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(13, 13);
            this.label28.TabIndex = 16;
            this.label28.Text = "6";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(3, 101);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(13, 13);
            this.label27.TabIndex = 15;
            this.label27.Text = "5";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(3, 59);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(13, 13);
            this.label25.TabIndex = 13;
            this.label25.Text = "3";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 80);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 13);
            this.label24.TabIndex = 12;
            this.label24.Text = "4";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 38);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(13, 13);
            this.label23.TabIndex = 11;
            this.label23.Text = "2";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 17);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 13);
            this.label22.TabIndex = 10;
            this.label22.Text = "1";
            // 
            // btn_editstp
            // 
            this.btn_editstp.Location = new System.Drawing.Point(180, 393);
            this.btn_editstp.Name = "btn_editstp";
            this.btn_editstp.Size = new System.Drawing.Size(75, 23);
            this.btn_editstp.TabIndex = 7;
            this.btn_editstp.Text = "СТП";
            this.btn_editstp.UseVisualStyleBackColor = true;
            //this.btn_editstp.Click += new System.EventHandler(this.btn_editstp_Click);
            // 
            // btn_report2
            // 
            this.btn_report2.Location = new System.Drawing.Point(93, 393);
            this.btn_report2.Name = "btn_report2";
            this.btn_report2.Size = new System.Drawing.Size(75, 23);
            this.btn_report2.TabIndex = 6;
            this.btn_report2.Text = "Отчет";
            this.btn_report2.UseVisualStyleBackColor = true;
            //this.btn_report2.Click += new System.EventHandler(this.btn_report2_Click);
            // 
            // btn_calc2
            // 
            this.btn_calc2.Location = new System.Drawing.Point(5, 393);
            this.btn_calc2.Name = "btn_calc2";
            this.btn_calc2.Size = new System.Drawing.Size(75, 23);
            this.btn_calc2.TabIndex = 5;
            this.btn_calc2.Text = "Расчет";
            this.btn_calc2.UseVisualStyleBackColor = true;
            //this.btn_calc2.Click += new System.EventHandler(this.btn_calc2_Click);
            // 
            // chk_claim3
            // 
            this.chk_claim3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chk_claim3.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chk_claim3.Location = new System.Drawing.Point(176, 7);
            this.chk_claim3.Name = "chk_claim3";
            this.chk_claim3.Size = new System.Drawing.Size(60, 16);
            this.chk_claim3.TabIndex = 30;
            this.chk_claim3.Text = "расчет";
            this.chk_claim3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chk_claim3.UseVisualStyleBackColor = true;
            //this.chk_claim3.CheckedChanged += new System.EventHandler(this.chk_claim3_Click);
            // 
            // MassCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "MassCalc";
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_data.ResumeLayout(false);
            this.gb_fillBid.ResumeLayout(false);
            this.gb_sum.ResumeLayout(false);
            this.gb_sum.PerformLayout();
            this.gb_bids.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            //((System.ComponentModel.ISupportInitialize)(this.dt_projects)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.dt_codes)).EndInit();
            this.gb_projectAction.ResumeLayout(false);
            this.gb_projectAction.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
        }

        protected override void FillCustomFields(DMSdbDataSet.mass_bidDataTable dt)
        {
            foreach (DMSdbDataSet.mass_bidRow r in dt.Rows)
            {
                r.hclaim = getHClaim(r.claim);
                r.huid = getHUid(r.uid);
                r.hgid = getHGid(r.uid);
                r.hdatetime = getHDateTime(r.date_time);
                r.beditable = false;
            }
        }

        protected override void dg_bids_SelectionChanged(object sender, EventArgs e)
        {
            base.dg_bids_SelectionChanged(sender, e);
            SetClaim3State();
        }

        private void SetClaim3State()
        {
            if (dg_bids.SelectedRows.Count == 0)
                return;
            int id = (int)(dg_bids.SelectedRows[0].Cells["id"].Value);
            DMSdbDataSet.mass_bidRow row = dt_bids.FindByid(id);
            chk_claim3.Enabled = (row.claim == 2 || row.claim == 3);
            chk_claim3.Checked = row.claim == 3;
            if (cb_pgroup.SelectedIndex == 8)// проработка
            {
                chk_claim3.Enabled = true;
            }
        }

        public override void LoadData(object extData)
        {
            base.LoadData(extData);
            dg_data.Height = 460;
            ta_stp.Fill(dt_stp);
            dt_variants_koeff = ta_variants.GetData();
            InitProjectsGroupComboBox(ref cb_projectgroup);
            InitProjectsDescriptionComboBox(ref cb_pdescr);
            //InitMastersComboBox(ref cb_pmasters);
            BinaryFormatter b = new BinaryFormatter();
            if (File.Exists("mass\\A3.tb"))
            {
                try
                {
                    using (var s = File.Open("mass\\A3.tb", FileMode.Open, FileAccess.Read))
                    {
                        PrecTable = (float[, ,])b.Deserialize(s);
                        s.Close();
                    }
                }
                catch (Exception ex) { MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            }
            else { DmsMsgBoxs.OkFail("Файл mass\\A3.tb не найден"); }
            if (File.Exists("mass\\A4.tb"))
            {
                try
                {
                    using (var s = File.Open("mass\\A4.tb", FileMode.Open, FileAccess.Read))
                    {
                        PrecTable2 = (float[, ,])b.Deserialize(s);
                        s.Close();
                    }
                }
                catch (Exception ex) { MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            }
            else { DmsMsgBoxs.OkFail("Файл mass\\A4.tb не найден"); }
            if (File.Exists("mass\\A5.tb"))
            {
                try
                {
                    using (var s = File.Open("mass\\A5.tb", FileMode.Open, FileAccess.Read))
                    {
                        PrecTable3 = (float[, ,])b.Deserialize(s);
                        s.Close();
                    }
                }
                catch (Exception ex) { MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            }
            else { DmsMsgBoxs.OkFail("Файл mass\\A5.tb не найден"); }
            //q();
        }

        public void q()
        {

            float[, ,] arr = new float[5, 1, 7]//A5
              {
                   {// до 100
                      // М         X         Y         Z        Mx        My        Mz
                        {0.1f,     0.01f,    0.01f,    0.01f,   1f,       1f,       1f  }
                   },
                   {// от 100 до 1000
                      // М         X         Y         Z        Mx        My        Mz
                        {1f,       0.01f,    0.01f,    0.01f,   1f,       1f,       1f  }
                   },
                   {// от 1000 до 10 000
                      // М         X         Y         Z        Mx        My        Mz
                        {1f,       0.01f/*0.05f*/,    0.01f,    0.01f,   10f,      1f,       1f }
                   },
                   {// от 10 000 до 100 000
                      // М         X         Y         Z        Mx        My        Mz
                        {10f,      0.01f/*0.1f*/,     0.01f,    0.01f,   10f,      10f,      10f  }
                   },
                   {// свыше 100 000
                      // М         X         Y         Z        Mx        My        Mz
                        {10f,      0.01f/*0.1f*/,     0.01f,    0.01f,   100f,     10f,      10f }
                   }
              };
            using (var stream = File.Create("c:\\a5.tb"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, arr);
            }
            //var s = File.Open("a5.tb", FileMode.Open, FileAccess.Read);
            //BinaryFormatter b = new BinaryFormatter();
            //float[, ,] a = b.Deserialize(s) as float[, ,];
            //int i = a.GetLength(0);

        }

        protected void InitProjectsDescriptionComboBox(ref ComboBox cb)
        {
            cb.Items.Clear();
            cb.Items.AddRange(new object[] { "техническое предложение", "эскизный проект", "технический проект", "рабочий проект" });
        }
        //protected void InitMastersComboBox(ref ComboBox cb)
        //{
        //    cb.Items.Clear();
        //    Group2 gm = Group2.GroupByGid(GROUP_CLAIM2);
        //    List<User2> list = gm.SecondaryMembers;
        //    list.Sort(User2.SortByFullName());
        //    foreach (User2 u in list)
        //    {
        //        cb.Items.Add(u);
        //    }
        //    cb.DisplayMember = "ShortName";
        //    cb.ValueMember = "Uid";
        //}

        protected override void MassFilling_Load(object sender, EventArgs e)
        {
            base.MassFilling_Load(sender, e);
            FillProjectForm();
        }

        protected override void FilterBidsByProject(object sender, EventArgs e)
        {
            base.FilterBidsByProject(sender, e);
            FillProjectForm();
        }

        protected override void FilterProject(object sender, EventArgs e)
        {
            base.FilterProject(sender, e);
            FillProjectForm();
        }

        private void FillProjectForm()
        {
            DMSdbDataSet.mass_projectRow p = GetSelectedProject();
            if (p == null) return;
            txt_pname.Text = p.name;
            txt_pdescription.Text = p.description;
            cb_projectgroup.SelectedIndex = (int)p.project_group;
            //User2 u = User2.UserByUid(p.master);
            //cb_pmasters.Text = u.ShortName;
            //cb_pmasters.SelectedItem = u;
            cb_pdescr.SelectedIndex = p.type;
            rb_mute0.Checked = p.num_type2 == 0;
            rb_mute1.Checked = p.num_type2 == 1;
            rb_typeShip.Checked = p.num_type1 == 1;
            rb_typeDock.Checked = p.num_type1 == 0;
            rb_proto0.Checked = p.prototype == 0;
            rb_proto1.Checked = p.prototype == 1;
            txt_gbL.Text = p.lgb.ToString();
            txt_gbB.Text = p.bgb.ToString();
            txt_gbH.Text = p.hgb.ToString();
            chkCustomStp.Checked = p.custom_stp == 1;
            txtCustomM.Text = p.custom_stp_m.ToString();
            txtCustomZ.Text = p.custom_stp_z.ToString();
            chkActive.Checked = p.deleted == 2;
        }

        private void btn_padd_Click(object sender, EventArgs e)
        {
            if (!DmsMsgBoxs.InfoOkCancelParam("Создаваемый проект будет доступен в разделе 'прочее' под названием '{0}'. Продолжить?", "новый проект"))
                return;
            ta_projects.AddProject();
            //int id = (int)ta_projects.LastInsertId();
            ta_projects.Fill(dt_projects);
            int id = Convert.ToInt32(dt_projects.Compute("max(id)", string.Empty));
            ApplyProjectFilter(cb_pgroup, cb_projects, dt_projects, chk_myprojects.Checked);
            if (cb_pgroup.SelectedIndex == 7)//прочее
            {
                cb_projects.SelectedValue = id;
                FillProjectForm();
            }


        }

        private void btn_pdelete_Click(object sender, EventArgs e)
        {
            DMSdbDataSet.mass_projectRow row = GetSelectedProject();
            if (!DmsMsgBoxs.WarningOkCancelParam(DmsStings.MASS_PROGECT_CANDELETE, row.name))
                return;

            row.BeginEdit();
            row.deleted = 1;
            row.EndEdit();
            ta_projects.Update((DMSdbDataSet.mass_projectRow)row);
            ta_projects.Fill(dt_projects);
            ApplyProjectFilter(cb_pgroup, cb_projects, dt_projects, chk_myprojects.Checked);
            FillProjectForm();
        }

        private void btn_psave_Click(object sender, EventArgs e)
        {
            DMSdbDataSet.mass_projectRow row = GetSelectedProject();
            row.BeginEdit();
            row.name = txt_pname.Text;
            row.description = txt_pdescription.Text;
            row.project_group = (int)cb_projectgroup.SelectedIndex;
            //row.master = (cb_pmasters.SelectedItem as User2).Uid;
            row.prototype = rb_proto0.Checked ? 0 : 1;
            row.num_type1 = rb_typeDock.Checked ? 0 : 1;
            row.num_type2 = rb_mute0.Checked ? 0 : 1;
            row.type = cb_pdescr.SelectedIndex;
            row.deleted = chkActive.Checked ? 2 : 0;
            try
            {
                row.lgb = (decimal)Convert.ToSingle(txt_gbL.Text);
                row.bgb = (decimal)Convert.ToSingle(txt_gbB.Text);
                row.hgb = (decimal)Convert.ToSingle(txt_gbH.Text);
                row.custom_stp = chkCustomStp.Checked ? (int)1 : 0;
                row.custom_stp_m = (decimal)Convert.ToSingle(txtCustomM.Text);
                row.custom_stp_z = (decimal)Convert.ToSingle(txtCustomZ.Text);
                row.EndEdit();
            }
            catch (Exception ex)
            {
                DmsMsgBoxs.OkFail(ex.Message);
            }
            int i = ta_projects.Update((DMSdbDataSet.mass_projectRow)row);
        }

        private void btn_alldata_Click(object sender, EventArgs e)
        {
            cb_status.SelectedValue = "claim=3";
            //ApplyBidFilter();
            LoadAssembledData();
        }

        private void btn_editstp_Click(object sender, EventArgs e)
        {
            StpEdit d = new StpEdit(ref dt_variants_koeff);
            d.ShowDialog();
        }

        private void LoadAssembledData()
        {
            DMSdbDataSet.mass_projectRow row = GetSelectedProject();
            dt_assembly = ta_data.GetAssemblyData(row.id);
            DataTableHelper.SortDataTable(dt_assembly, "code ASC");
            //dt_assembly.DefaultView.Sort = "code ASC";
            dg_data.DataSource = dt_assembly;
            dg_data.ReadOnly = true;
            gb_data.Text = "Сводные данные: проект '" + row.name + "' (только чтение) ";
            full_mass = CalcSum(ref dt_assembly);

        }

        private void chk_claim3_Click(object sender, EventArgs e)
        {
            if (dg_bids.SelectedRows.Count == 0)
            {
                chk_claim3.Checked = false;
                return;
            }
            bool chk = chk_claim3.Checked;
            int id = (int)(dg_bids.SelectedRows[0].Cells["id"].Value);
            DMSdbDataSet.mass_bidRow row = dt_bids.FindByid(id);

            row.BeginEdit();
            if (cb_pgroup.SelectedIndex == 8)// проработка
            {
                //if (GetBidCurrentClaim(row) != 0)
                //    return;
                row.claim = chk ? (int)3 : 0;
            }
            else
            {
                if (GetBidCurrentClaim(row) < 2)
                    return;
                row.claim = chk ? (int)3 : 2;
            }
            row.hclaim = getHClaim(row.claim);
            row.EndEdit();
            ta_bids.Update(row);
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            //CalcEntry();
        }

        private void btn_calc2_Click(object sender, EventArgs e)
        {
            FillingCalcEntry();
        }

        //private void btn_report1_Click(object sender, EventArgs e)
        //{
        //    Report1Entry();
        //}

        //private void btn_report2_Click(object sender, EventArgs e)
        //{
        //    Report2Entry();
        //}

        private void txt_gb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ',')
            {
                e.Handled = true;
            }

        }

        private void lbl_num_projects_DoubleClick(object sender, EventArgs e)
        {
            ShowProjects dlg = new ShowProjects();
            dlg.ShowDialog();
        }


    }
}
