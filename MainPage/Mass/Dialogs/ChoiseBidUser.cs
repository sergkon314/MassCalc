using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using dms.pages.Utils;

namespace dms.pages.Mass.Dialogs
{
     public partial class ChoiseBidUser : Form
     {
          private string _uid;

          public string SelectedUid
          {
               get { return _uid; }
          }

          public ChoiseBidUser(string bid_name)
          {
               InitializeComponent();
               lbl_name.Text = bid_name;
               lb.ItemHeight = 20;
          }

          private void btn_cancel_Click(object sender, EventArgs e)
          {
               this.DialogResult = DialogResult.Cancel;
          }

          private void btn_ok_Click(object sender, EventArgs e)
          {
               _uid = lb.SelectedValue as string;
               this.DialogResult = DialogResult.OK;
          }

          private void ChoiseBidUser_Load(object sender, EventArgs e)
          {

              //Group2 g = Group2.GroupByGid(MainPage.CurrentUser2.Gid);
              //List<User2> list = g.Members;
              //list.Sort(User2.SortByFullName());
              //lb.DataSource = list;
              //lb.DisplayMember = "ShortName";
              //lb.ValueMember = "Uid";
          }
          
     }
}
