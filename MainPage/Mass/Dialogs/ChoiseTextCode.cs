using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using dms.pages.Utils;

namespace dms.pages.Mass.Dialogs
{
    public partial class ChoiseTextCode : Form
    {
        private DataGridViewRowCollection _selectedItems;
        private DMSdbDataSet.mass_text_codeDataTable dt;
        public DataGridViewRowCollection SelectedItems
        {
            get { return _selectedItems; }
        }
        public ChoiseTextCode(DMSdbDataSet.mass_text_codeDataTable _dt)
        {
            InitializeComponent();
            this.Text = DmsStings.MAINFRM_TITLE + "  Выбор кода оборудования";
            dt = _dt;
        }
        int order = 1;
        Color color1 = SystemColors.GradientActiveCaption;
        Color color2 = SystemColors.Window;
        Color color;
        private void ChoiseTextCode_Load(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = "selected=1 AND is_visible=1";
            dt.DefaultView.Sort = "ord ASC";
            dg_code.DataSource = dt;
           // HighLite();
            FillTree();
            //tree.AfterSelect += new TreeViewEventHandler(tree_AfterSelect);
        }

        void tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }     

        private void HighLite()
        {
            foreach (DataGridViewRow r in dg_code.Rows)
            {
                int current_order = Convert.ToInt32(r.Cells[0].Value);
                if (order != current_order)
                {
                    if (!color.Equals(color1))
                        color = color1;
                    else
                        color = color2;
                }
                r.DefaultCellStyle.BackColor = color;
                order = current_order;
            }
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DoSearch();
        }

        private void DoSearch()
        {
            //DataView dv = new DataView(dt, "code like '" + txt_search.Text + "%' and is_visible=1", "code", DataViewRowState.CurrentRows);
            //dg_code.DataSource = dv;
            string code = txt_search.Text;
            if(code.Length == 0)
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_search.Text = "";
            tree.CollapseAll();
           // dt.DefaultView.RowFilter = "is_visible=1";
            //dg_code.DataSource = dt;
            //HighLite();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //if (dg_code.SelectedRows.Count > 0)
            //{
                _selectedItems = dg_code.Rows;//.SelectedRows;
                this.DialogResult = DialogResult.OK;
            //}
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
        private void SelectNode(TreeNode node)
        {
            DataRow r = node.Tag as DataRow;
            if (r.Field<uint>("is_visible") != 0)
            {
                int s = r.Field<int>("selected");
                s = s == 1 ? 0 : 1;
                r.SetField<int>("selected", s);

            }
        }        

        private void dg_code_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                foreach (DataGridViewRow r in dg_code.SelectedRows)
                {
                    DataRow row = (r.DataBoundItem as DataRowView).Row;
                    row.SetField<int>("selected", 0);
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tree.SelectedNode != null)
            {
                DataRow r = tree.SelectedNode.Tag as DataRow;
                r.SetField<int>("selected", 1);
            }
            
        }
      
    }
}
