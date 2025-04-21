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
     public partial class ProjectCopyFrom : Form
     {
          private DMSdbDataSet.mass_bidDataTable bids = new DMSdbDataSet.mass_bidDataTable();
          public DMSdbDataSet.mass_data_bidDataTable bid_data;
          public const string BID_CLAIM_UNDEFINED = "не изветвестно";
          public const string BID_CLAIM0 = "обработка";
          public const string BID_CLAIM1 = "утв.в подразделении";
          public const string BID_CLAIM2 = "утв.гл.конструктором";
          public const string BID_CLAIM3 = "расчет";

          private int _project_id;

          public int SelectedProjectId
          {
               get { return _project_id; }
          }
          private int _bid;

          public int SelectedBidId
          {
               get { return _bid; }
          }


          public ProjectCopyFrom(string projectInfo)
          {
               InitializeComponent();
               this.lbl_projectInfo.Text = "заявка будет скопирована в проект '" + projectInfo + "'";
               //this.mass_bidTableAdapter.Connection.ConnectionString = MainPage.ConnectionStringMysql;
               //this.mass_projectTableAdapter.Connection.ConnectionString = MainPage.ConnectionStringMysql;
               //this.mass_data_bidTableAdapter.Connection.ConnectionString = MainPage.ConnectionStringMysql;
          }

          private void ProjectCopyFrom_Load(object sender, EventArgs e)
          {
               // TODO: данная строка кода позволяет загрузить данные в таблицу "dmsMass.mass_data_bid". При необходимости она может быть перемещена или удалена.
               //this.mass_data_bidTableAdapter.Fill(this.dmsMass.mass_data_bid);
               // TODO: данная строка кода позволяет загрузить данные в таблицу "dmsMass.mass_bid". При необходимости она может быть перемещена или удалена.
               bids = this.mass_bidTableAdapter.GetDataByProjectId(Convert.ToInt32(cb.SelectedValue));
               // TODO: данная строка кода позволяет загрузить данные в таблицу "dmsMass.mass_project". При необходимости она может быть перемещена или удалена.
               this.mass_projectTableAdapter.Fill(this.dmsMass.mass_project);
               dg_bids.DataSource = bids;
               dg_data.DataSource = bid_data;
               FillCustomFields();
          }
          private void FillCustomFields()
          {
               int count = bids.Rows.Count;
               foreach (DMSdbDataSet.mass_bidRow r in bids.Rows)
               {
                    if (count > 0)
                    {
                         r.hclaim = getHClaim(r.claim);
                         //r.huid = getHUid(r.uid);
                         //r.hgid = getHGid(r.uid);
                         r.hdatetime = getHDateTime(r.date_time);
                         r.beditable = false;
                         count--;
                    }
               }
          }
          private string getHClaim(int claim)
          {
               string sanction = BID_CLAIM_UNDEFINED;
               switch (claim)
               {
                    case 0:
                         sanction = BID_CLAIM0;
                         break;
                    case 1:
                         sanction = BID_CLAIM1;
                         break;
                    case 2:
                         sanction = BID_CLAIM2;
                         break;
                    case 3:
                         sanction = BID_CLAIM3;
                         break;
               }
               return sanction;
          }

          //private string getHUid(string uid)
          //{
          //     User2 u = User2.UserByUid(uid);
          //     return u.ShortName;
          //}

          //private string getHGid(string uid)
          //{
          //    User2 u = User2.UserByUid(uid);
          //    List<Group2> deps = u.Departments;
          //    //string gid = u.Gid;
          //    // string depstr = "";
          //    // foreach (Group2 g in deps)
          //    //     depstr += g.NumCommentString + " ";
          //    return deps[0].NumCommentString;
          //}

          private string getHDateTime(DateTime datetime)
          {
              return datetime.ToLongDateString() + " " + datetime.ToShortTimeString();
          }

          private int GetSelectedBidId()
          {
               if (dg_bids.SelectedRows.Count == 0)
               {
                    //DmsMsgBoxs.OkFail("Не выбрана заявка.");
                    return -1;
               }
               if (dg_bids.SelectedRows[0].Cells["bid"].Value == null)
               {
                    //DmsMsgBoxs.OkFail("Не выбрана заявка.");
                    return -1;
               }
               int bid_id = Convert.ToInt32(dg_bids.SelectedRows[0].Cells["bid"].Value);
               return bid_id;
          }

          private void cb_SelectedIndexChanged(object sender, EventArgs e)
          {
               FillBids(Convert.ToInt32(cb.SelectedValue));
          }
          private void FillBids(int project_id)
          {
               bids = this.mass_bidTableAdapter.GetDataByProjectId(project_id);
               dg_bids.DataSource = bids;
               FillCustomFields();
               dg_bids.Select();
          }

          private void btn_cancel_Click(object sender, EventArgs e)
          {
               this.DialogResult = DialogResult.Cancel;
          }

          private void btn_ok_Click(object sender, EventArgs e)
          {
               if (dg_bids.SelectedRows.Count == 0)
                    return;
               _bid = Convert.ToInt32(dg_bids.SelectedRows[0].Cells["bid"].Value);
               _project_id = Convert.ToInt32(cb.SelectedValue);
               this.DialogResult = DialogResult.OK;
          }

          private void dg_bids_SelectionChanged(object sender, EventArgs e)
          {
               ViewBidData();
          }

          private void ViewBidData()
          {
               int bid_id = GetSelectedBidId();
               if (bid_id < 0) return;
               bid_data = this.mass_data_bidTableAdapter.GetBidData(bid_id);
               dg_data.DataSource = bid_data;

          }
     }
}
