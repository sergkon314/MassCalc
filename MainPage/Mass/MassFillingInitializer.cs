using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
//using MySql.Data.Types;
using System.Drawing;
using dms.pages.Utils;

namespace dms.pages.Main
{
    public partial class MassFilling : BasePage
    {
        public const string BID_CLAIM_UNDEFINED = "не изветвестно";
        public const string BID_CLAIM0 = "обработка";
        public const string BID_CLAIM1 = "утв.в подразделении";
        public const string BID_CLAIM2 = "утв.гл.конструктором";
        public const string BID_CLAIM3 = "расчет";
        public const string BID_CLAIM4 = "ожидает правки";

        //mass_filling вторичные члены этой группы имеют доступ к модулю, могут добавлять и редактировать свои заявки
        // руководитель этой группы может "разутвердить" заявку.
        public const string GROUP_CLAIM0 = "1010";
        //mass_filling_claim вторичные члены этой группы утверждают проекты
        public const string GROUP_CLAIM2 = "1016";
        //mass_filling_admins вторичные члены этой группы управляют проектами и расчетами
        public const string GROUP_CLAIM3 = "1017";

        protected virtual void InitBidsDataGridView(DataGridView dg)
        {
            dg.BackgroundColor = SystemColors.Control;
            //dg.DataSource = new dmsMass.mass_bidDataTable();
            dg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dg.RowHeadersVisible = false;
            dg.AllowUserToAddRows = false;
            DataGridViewColumnCollection cols = dg.Columns;
            DataGridViewColumn col;
            //id,uid,date_time,description,bid_name,mass_project_id,claim,version_by,hclaim,huid,hgid,hdatetime,beditable               
            col = cols["uid"];
            col.DataPropertyName = "uid";
            col.Visible = false;

            col = cols["date_time"];
            col.DataPropertyName = "date_time";
            col.Visible = true;
            col.DisplayIndex = 0;
            //col.ValueType = typeof(MySqlDateTime);
            col.ValueType = typeof(DateTime);
            col.DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
            col.Width = 150;
            col.HeaderText = "Создана";
            col.DisplayIndex = 5;
            col.ReadOnly = true;

            col = cols["mass_project_id"];
            col.DataPropertyName = "mass_project_id";
            col.Visible = false;
            col = cols["claim"];
            col.DataPropertyName = "claim";
            col.Visible = false;
            col = cols["version_by"];
            col.DataPropertyName = "version_by";
            col.Visible = false;
            col = cols["beditable"];
            col.DataPropertyName = "beditable";
            col.Visible = false;
            //
            col = cols["id"];
            col.DataPropertyName = "id";
            col.Width = 50;
            col.HeaderText = "Номер";
            col.DisplayIndex = 0;
            col.ReadOnly = true;
            //
            col = cols["bid_name"];
            col.DataPropertyName = "bid_name";
            col.Width = 250;
            col.HeaderText = "Название";
            col.DisplayIndex = 1;
            col.ReadOnly = false;
            //
            col = cols["hclaim"];
            col.DataPropertyName = "hclaim";
            col.Width = 100;
            col.HeaderText = "Статус";
            col.DisplayIndex = 2;
            col.ReadOnly = true;
            //
            col = cols["huid"];
            col.DataPropertyName = "huid";
            col.Width = 100;
            col.HeaderText = "Автор";
            col.DisplayIndex = 3;
            col.ReadOnly = true;
            //
            col = cols["hgid"];
            col.Width = 150;
            col.HeaderText = "Подразделение";
            col.DisplayIndex = 4;
            col.ReadOnly = true;
            //
            col = cols["hdatetime"];
            col.DataPropertyName = "hdatetime";
            col.Width = 150;
            col.HeaderText = "Создана";
            //col.DisplayIndex = 5;
            col.Visible = false;
            col.ReadOnly = true;
            //
            col = cols["description"];
            col.DataPropertyName = "description";
            col.Width = 300;
            col.HeaderText = "Комментарий";
            col.DisplayIndex = 5;
            col.ReadOnly = false;
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        protected virtual void InitBidsDataDataGridView(DataGridView dg)
        {
            dg.BackgroundColor = SystemColors.Control;
            //dmsMass.mass_data_bidDataTable dt = new dmsMass.mass_data_bidDataTable();
            //dg.DataSource = dt;
            dg.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dg.RowHeadersVisible = false;
            dg.AllowUserToAddRows = false;
            dg.EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            DataGridViewColumnCollection cols = dg.Columns;
            DataGridViewColumn col;
            DataGridViewCellStyle N3Style = new DataGridViewCellStyle();
            N3Style.Format = "N3";
            N3Style.NullValue = "0.0";
            //id,bid_id,code,name_code,m,x,y,z,mx,my,mz
            col = cols["id"];
            col.DataPropertyName = "id";
            col.Visible = false;
            col = cols["bid_id"];
            col.DataPropertyName = "bid_id";
            col.Visible = false;
            //
            col = cols["code"];
            col.DataPropertyName = "code";
            col.Width = 80;
            col.HeaderText = "Код";
            col.DisplayIndex = 0;
            col.ReadOnly = true;
            col.ValueType = typeof(string);
            //
            col = cols["name_code"];
            col.DataPropertyName = "name_code";
            col.Width = 450;
            col.HeaderText = "Наименование";
            col.DisplayIndex = 1;
            col.ReadOnly = false;
            col.ValueType = typeof(string);
            //
            col = cols["m"];
            col.DataPropertyName = "m";
            col.Width = 80;
            col.HeaderText = "М, т.";
            col.DisplayIndex = 2;
            col.ReadOnly = false;
            col.DefaultCellStyle = N3Style;
            col.ValueType = typeof(Single);
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //
            col = cols["x"];
            col.DataPropertyName = "x";
            col.Width = 80;
            col.HeaderText = "X, м.";
            col.DisplayIndex = 3;
            col.ReadOnly = false;
            col.DefaultCellStyle = N3Style;
            col.ValueType = typeof(Single);
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //
            col = cols["y"];
            col.DataPropertyName = "y";
            col.Width = 80;
            col.HeaderText = "Y, м.";
            col.DisplayIndex = 4;
            col.ReadOnly = false;
            col.DefaultCellStyle = N3Style;
            col.ValueType = typeof(Single);
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //
            col = cols["z"];
            col.DataPropertyName = "z";
            col.Width = 80;
            col.HeaderText = "Z, м.";
            col.DisplayIndex = 5;
            col.ReadOnly = false;
            col.DefaultCellStyle = N3Style;
            col.ValueType = typeof(Single);
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //
            col = cols["mx"];
            col.DataPropertyName = "mx";
            col.Width = 80;
            col.HeaderText = "Мx, т*м.";
            col.DisplayIndex = 6;
            col.ReadOnly = true;
            col.DefaultCellStyle = N3Style;
            col.ValueType = typeof(Single);
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //
            col = cols["my"];
            col.DataPropertyName = "my";
            col.Width = 80;
            col.HeaderText = "Мy, т*м.";
            col.DisplayIndex = 7;
            col.ReadOnly = true;
            col.DefaultCellStyle = N3Style;
            col.ValueType = typeof(Single);
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //
            col = cols["mz"];
            col.DataPropertyName = "mz";
            col.Width = 80;
            col.HeaderText = "Мz, т*м.";
            col.DisplayIndex = 8;
            col.ReadOnly = true;
            col.DefaultCellStyle = N3Style;
            col.ValueType = typeof(Single);
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected virtual void InitProjectsComboBox()
        {
            cb_projects.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_projects.Sorted = true;
            //cb_projects.DataSource = dt_projects;
            cb_projects.DisplayMember = "name";
            cb_projects.ValueMember = "id";
            //cb_projects.SelectedIndex = 0;
        }

        protected virtual void InitBidsStatusFilterComboBox()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] { new DataColumn("Key", typeof(string)), new DataColumn("Value", typeof(string)) });
            //dt.Rows.Add(new object[] { "мои заявки", "uid='" + MainPage.CurrentUser2.Uid + "'" });
            dt.Rows.Add(new object[] { BID_CLAIM0, "claim=0" });
            dt.Rows.Add(new object[] { BID_CLAIM1, "claim=1" });
            dt.Rows.Add(new object[] { BID_CLAIM2, "claim=2" });
            dt.Rows.Add(new object[] { BID_CLAIM3, "claim=3" });
            dt.Rows.Add(new object[] { "все", "" });
            cb_status.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_status.DataSource = dt;
            cb_status.DisplayMember = "Key";
            cb_status.ValueMember = "Value";
            //cb_status.SelectedValue = "";
        }

        protected virtual void InitProjectsGroupComboBox(ref ComboBox cb)
        {
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.Items.AddRange(new object[] { "все проекты", "доки", "причалы ж/б", "причалы металл.", "дебаркадеры", "плавгостиницы", "суда", "прочее", "проработки" });
            //cb.SelectedIndex = 7;
        }



        //protected virtual int ApplyProjectFilter(ComboBox cb_filter, ComboBox cb_target, dmsMass.mass_projectDataTable dt, bool onlyMyProjects)
        //{
        //    int ind = cb_filter.SelectedIndex;
        //    //dmsMass.mass_projectRow[] dtf;

        //    if (ind == 0)
        //    {
        //        if (onlyMyProjects)
        //        {
        //            dtf = dt.Select("master=" + MainPage.CurrentUser2.Uid) as dmsMass.mass_projectRow[];

        //        }
        //        else
        //        {
        //            dtf = dt.Select() as dmsMass.mass_projectRow[];
        //        }
        //    }
        //    else
        //    {

        //        if (onlyMyProjects)
        //        {
        //            dtf = dt.Select("project_group=" + Convert.ToString(ind) + " and master=" + MainPage.CurrentUser2.Uid) as dmsMass.mass_projectRow[];

        //        }
        //        else
        //        {
        //            dtf = dt.Select("project_group=" + Convert.ToString(ind)) as dmsMass.mass_projectRow[];
        //        }
        //    }
        //    if (dtf.Length == 0)
        //    {
        //        DmsMsgBoxs.OkFail("Проектов в группе " + cb_filter.Text + " не найдено.");
        //    }
        //    cb_target.DataSource = dtf;
        //    cb_target.DisplayMember = "name";
        //    cb_target.ValueMember = "id";

        //    return cb_target.Items.Count;
        //}

        //protected virtual dmsMass.mass_projectRow GetSelectedProject()
        //{
        //    return cb_projects.SelectedItem as dmsMass.mass_projectRow;
        //}

        //protected virtual int ApplyBidFilter(ComboBox cb_filter, DataGridView dg, dmsMass.mass_bidDataTable dt)
        //{
        //    string filter = cb_filter.SelectedValue as string;
        //    (dg.DataSource as DataTable).DefaultView.RowFilter = filter;
        //    return dg.Rows.Count;
        //}

        protected virtual bool IsEditableByCurrntUser(string uid, uint claim, uint version_by)
        {
            //if (claim == 0 && version_by == 0 && User2.IsCurrentUser(User2.UserByUid(uid)))
            //{
            //    return true;
            //}
            return false;
        }

        protected virtual string getHClaim(uint claim)
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
                case 4:
                    sanction = BID_CLAIM4;
                    break;
            }
            return sanction;
        }

        protected virtual string getHUid(string uid)
        {
            //User2 u = User2.UserByUid2(uid);
            //if (u == null)
            //    return "???";
            //return u.ShortName;
            return "";
        }

        protected virtual string getHGid(string uid)
        {
            //User2 u = User2.UserByUid2(uid);
            //if (u == null)
            //    return "???";
            //List<Group2> deps = u.Departments;
            ////string gid = u.Gid;
            //// string depstr = "";
            //// foreach (Group2 g in deps)
            ////     depstr += g.NumCommentString + " ";
            //return deps[0].NumCommentString;
            return "";
        }

        //protected virtual string getHDateTime(MySqlDateTime datetime)
        //{
        //    DateTime dt = datetime.GetDateTime();
        //    return dt.ToLongDateString() + " " + dt.ToShortTimeString();
        //}
        //protected virtual void FillCustomFields(dmsMass.mass_bidDataTable dt)
        //{
        //    foreach (dmsMass.mass_bidRow r in dt.Rows)
        //    {
        //        r.hclaim = getHClaim(r.claim);
        //        r.huid = getHUid(r.uid);
        //        r.hgid = getHGid(r.uid);
        //        r.hdatetime = getHDateTime(r.date_time);
        //        r.beditable = IsEditableByCurrntUser(r.uid, r.claim, r.version_by);
        //    }
        //}
        protected virtual void SetBidsTableTitle(GroupBox gb, int num, string name, int count)
        {
            gb.Text = "Заявки по проекту '" + name + "' (" + num + "/" + count + ")";
        }
        protected virtual void SetBidsDataTableTitle(GroupBox gb, DataGridView dg, string name)
        {
            int num = dg.Rows.Count;
            gb.Text = "Данные заявки '" + name + "' (" + num + ")";
        }
    }
}
