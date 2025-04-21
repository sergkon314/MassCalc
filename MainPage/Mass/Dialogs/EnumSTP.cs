using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dms.pages.Utils;
using dms.pages.Utils.DMSdbDataSetTableAdapters;

namespace dms.pages.Mass.Dialogs
{
    public partial class EnumSTP : Form
    {
        protected DMSdbDataSet.mass_text_codeDataTable dt = new DMSdbDataSet.mass_text_codeDataTable();
        protected mass_text_codeTableAdapter ta = new mass_text_codeTableAdapter();
        public EnumSTP()
        {
            InitializeComponent();
            this.Text = DmsStings.MAINFRM_TITLE + ": Коды СТП";
        }

        private void EnumSTP_Load(object sender, EventArgs e)
        {
            ta.Connection.ConnectionString = "Dsn=PostgreSQL;database=DMSdb;server=localhost;port=5432;uid=postgres;sslmode=disable;readonly=0;protocol=7.4;fakeoidindex=0;showoidcolumn=0;rowversioning=0;showsystemtables=0;fetch=100;unknownsizes=0;maxvarcharsize=255;maxlongvarcharsize=8190;debug=0;commlog=0;usedeclarefetch=0;textaslongvarchar=1;unknownsaslongvarchar=0;boolsaschar=1;parse=0;lfconversion=1;updatablecursors=1;trueisminus1=0;bi=0;byteaaslongvarbinary=1;useserversideprepare=1;lowercaseidentifier=0;d6=-101;optionalerrors=0;fetchrefcursors=0;xaopt=1"; //MainPage.ConnectionStringMysql;
            ta.Fill(dt);
            FillTree();
        }
        private void FillTree()
        {
            DataTableHelper.SortDataTable(dt, "code ASC");
            string l, l1, l2, l3, text, code;
            uint v;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                text = dt.Rows[i].Field<string>("code_name");
                code = dt.Rows[i].Field<string>("code");
                v = dt.Rows[i].Field<uint>("is_visible");
                l1 = code.Substring(0, 2);
                l2 = code.Substring(2, 2);
                l3 = code.Substring(4, 2);
                l = l1 + "000000";
                TreeNode node1 = tree.Nodes[l];
                if (node1 == null)
                {
                    node1 = new TreeNode();
                    node1.Name = l;
                    node1.Text = string.Format("[{0}] {1}", l, text);
                    node1.Tag = dt.Rows[i];
                    tree.Nodes.Add(node1);
                    if (v == 0)
                    {
                        node1.ForeColor = SystemColors.GrayText;
                    }
                }
                if (l2 != "00")
                {
                    l = l1 + l2 + "0000";
                    TreeNode node2 = node1.Nodes[l];
                    if (node2 == null)
                    {
                        node2 = new TreeNode();
                        node2.Name = l;
                        node2.Text = string.Format("[{0}] {1}", l, text);
                        node2.Tag = dt.Rows[i];
                        node1.Nodes.Add(node2);
                        if (v == 0)
                        {
                            node2.ForeColor = SystemColors.GrayText;
                        }
                    }
                    if (l3 != "00")
                    {
                        l = code;
                        TreeNode node3 = node2.Nodes[l];
                        if (node3 == null)
                        {
                            node3 = new TreeNode();
                            node3.Name = l;
                            node3.Text = string.Format("[{0}] {1}", l, text);
                            node3.Tag = dt.Rows[i];
                            node2.Nodes.Add(node3);
                            if (v == 0)
                            {
                                node3.ForeColor = SystemColors.GrayText;
                            }
                        }
                    }
                }
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            tree.CollapseAll();
        }
        private void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DoSearch();
                return;
            }
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DoSearch();
        }
        private void DoSearch()
        {
            string code = txt_search.Text;
            if (code.Length == 0)
                return;
            while (code.Length < 8)
                code += "0";
            TreeNode[] tn = tree.Nodes.Find(code, true);
            for (int i = 0; i < tn.Length; i++)
            {
                tree.SelectedNode = tn[i];
                if (tn[i].Nodes.Count != 0)
                    tn[i].Expand();

            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
