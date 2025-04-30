using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DR = dms.pages.Utils.DMSdbDataSet.mass_data_bidRow;
using DT = dms.pages.Utils.DMSdbDataSet.mass_data_bidDataTable;
using System.IO;
using System.Data;
using System.Diagnostics;
using dms.pages.Utils;
namespace dms.pages.Main
{
    public partial class MassCalc : MassFilling
    {
        string Bold = "", Bold_ = "";
        private void Report1Entry()
        {
            DT dt_src = null;
            if (dt_result == null || dt_result.Rows.Count == 0)
            {
                if (DmsMsgBoxs.WarningOkCancelParam("Расчетная таблица не сформирована. Будет сформирован отчет по сводной таблице. Продолжить?", null))
                {
                    dt_src = dt_assembly;
                }
                else
                    return;
            }
            else
                dt_src = dt_result;

            string time = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            DMSdbDataSet.mass_projectRow p = GetSelectedProject();

            string[] descr = { "техническое предложение", "эскизный проект", "технический проект", "рабочий проект", "проработка" };
            string[] shiptype = { "док", "судно" };
            string[] proto = { "нет", "есть" };
            string[] mute = { "гражданский", "вспомогательный" };
            //string master = User2.UserByUid(p.master).ShortName;
            string project_param = "<p>Проект: " + p.name + "</p>";
            project_param += "<p>Описание: " + descr[p.type] + "</p>";
            //project_param += "<p>Руководитель: " + master + "</p>";
            project_param += "<p>Тип: " + shiptype[p.num_type1] + "</p>";
            project_param += "<p>Тип: " + mute[p.num_type2] + "</p>";
            project_param += "<p>Прототип: " + proto[p.prototype] + "</p>";
            project_param += "<p>Запас водоизмещения: " + koeff_m * 100 + "%" + "</p>";
            project_param += "<p>Запас начальной остойчивости: " + koeff_z + " м." + "</p>";
            project_param += "<p>Суммарная масса: " + full_mass + " т." + "</p>";
            project_param += "<p>Масса порожнем: " + empty_mass + " т." + "</p>";

            string bids = "Использованы заявки:</br>";
            DMSdbDataSet.mass_bidDataTable dt = ta_bids.GetClaim3Bids(p.id);
            FillCustomFields(dt);
            foreach (DMSdbDataSet.mass_bidRow r in dt)
            {
                bids += "<p>" + r.id + " " + r.bid_name + " " + r.huid + " " + r.hgid + "</p>";
            }

            //string l_rowTag = "<td><div align=\"left\"><span>";
            //string r_rowTag = "</span></div></td>";
            string l_rowTag1 = "<td><div align=\"center\"><span>";
            string r_rowTag1 = "</span></div></td>";


            string header = "<html><head><meta http-equiv=\"Content-Type\" content=\"text/html\"; charset=\"windows-1251\" /><title>Отчет по расчету нагрузки масс проекта " + p.name + "</title><style type=\"text/css\"><!--.style1 { font-family: Arial, Helvetica, sans-serif;	font-size: 12pt; font-weight: normal;}--></style></head>";
            header += "<body>";
            header += time;
            header += project_param;
            header += "<p></p>";
            header += bids;
            header += "<table class=\"style1\" width=\"100%\" border=\"1\" align=\"center\" cellpadding=\"1\" cellspacing=\"0\">  <caption align=\"top\">  <span class=\"style1\">Отчет по расчету нагрузки масс проекта " + p.name + "</span></caption><tr><td width=\"6%\" scope=\"col\"><div align=\"center\">Код</div></td><td width=\"40%\" scope=\"col\"><div align=\"center\">Название</div></td><td width=\"6%\" scope=\"col\"><div align=\"center\">Масса, т</div></td><td width=\"8%\" scope=\"col\"><div align=\"center\">X, м </div></td><td width=\"8%\" scope=\"col\"><div align=\"center\">Y, м </div></td><td width=\"8%\" scope=\"col\"><div align=\"center\">Z, м </div></td><td width=\"8%\" scope=\"col\"><div align=\"center\">Mx, тм </div></td><td width=\"8%\" scope=\"col\"><div align=\"center\">My, тм </div></td><td width=\"8%\" scope=\"col\"><div align=\"center\">Mz, тм </div></td></tr>";
            string page = "";

            int mass_category = GetMassGategory(full_mass);
            if (mass_category < 0) return;
            int descr_type = p.type;
            int nameFormat = 0;
            DataTableHelper.SortDataTable(dt_src, "code ASC");
            foreach (DR r in dt_src)
            {
                page += "<tr>";
                page += l_rowTag1 + FormatCod(r.code, out nameFormat) + r_rowTag1;
                page += "<td>" + FormatName(r.name_code.ToLower(), nameFormat) + "</td>";
                page += l_rowTag1 + Bold + r.m + "(" + Format((float)r.m, mass_category, descr_type, 0, r.code) + ")" + Bold + r_rowTag1;
                page += l_rowTag1 + Bold + r.x + "(" + Format((float)r.x, mass_category, descr_type, 1, r.code) + ")" + Bold_ + r_rowTag1;
                page += l_rowTag1 + Bold + r.y + "(" + Format((float)r.y, mass_category, descr_type, 2, r.code) + ")" + Bold_ + r_rowTag1;
                page += l_rowTag1 + Bold + r.z + "(" + Format((float)r.z, mass_category, descr_type, 3, r.code) + ")" + Bold_ + r_rowTag1;
                page += l_rowTag1 + Bold + r.mx + "(" + Format((float)r.mx, mass_category, descr_type, 4, r.code) + ")" + Bold_ + r_rowTag1;
                page += l_rowTag1 + Bold + r.my + "(" + Format((float)r.my, mass_category, descr_type, 5, r.code) + ")" + Bold_ + r_rowTag1;
                page += l_rowTag1 + Bold + r.mz + "(" + Format((float)r.mz, mass_category, descr_type, 6, r.code) + ")" + Bold_ + r_rowTag1;
                page += "</tr>";
            }
            header += page + "</table></body></html>";
            string file = Path.GetTempFileName() + ".html";
            File.AppendAllText(file, header, Encoding.Default);
            //DmsAPI.ShellExecute(IntPtr.Zero, "open", file, "", "", DmsAPI.ShowCommands.SW_SHOWNORMAL);
            Process.Start(file);
            if (DmsMsgBoxs.WarningOkCancelParam("Сформировать отчет Word для {0}?", p.name))
                Word1(dt_src);
        }


        private string FormatCod(string cod, out int nameFormat)
        {

            if (cod.IndexOf("000000") == 2)
            {
                string res = "<b><u>" + cod + "</u></b>"; Bold = "<b>"; Bold_ = "</b>";
                nameFormat = 1;
                return res;
            }
            if (cod.IndexOf("0000") == 4)
            {
                string res = "<u>" + cod + "</u>";
                nameFormat = 2;
                return res;
            }
            if (cod.IndexOf("00") == 6)
            {
                string res = "<u>" + cod.Substring(0, 6) + "</u>" + "00";
                nameFormat = 3;
                return res;
            }
            nameFormat = 0;
            return cod;
        }
        private string FormatName(string name, int nameFormat)
        {
            string format_name = name.Substring(0, 1).ToUpper() + name.Substring(1);
            string res = "<div align=\"left\"><span>" + format_name + "</span></div>";
            switch (nameFormat)
            {
                case 1:
                    res = "<div align=\"center\"><span>" + "<b><u>" + format_name + "</u></b>" + "</span></div>";
                    break;
                case 2:
                    res = "<div align=\"left\"><span>" + "<u>" + format_name + "</u>" + "</span></div>";
                    break;
                case 3:
                    res = "<div align=\"left\"><span>" + format_name + "</span></div>";
                    break;
            }
            return res;
        }
        private int GetMassGategory(float m)
        {
            if (m <= 100) return 0;
            if (m <= 1000 && m > 100) return 1;
            if (m <= 10000 && m > 1000) return 2;
            if (m <= 100000 && m > 10000) return 3;
            if (m > 100000) return 4;
            DmsMsgBoxs.OkFail("Масса не входит ни в один из допустимых диапазнов.");
            return -1;
        }

        private void Report2Entry()
        {
            if (ds_variants == null || ds_variants.Tables.Count == 0)
            {
                DmsMsgBoxs.OkFail("Не сформирована расчетная таблица.");
                return;
            }
            string time = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            DMSdbDataSet.mass_projectRow p = GetSelectedProject();
            string ltag = "<td><div align=\"left\"><span>";
            string rtag = "</span></div></td>";
            string header = "<html><head><meta http-equiv=\"Content-Type\" content=\"text/html\"; charset=\"windows-1251\" /><title>Варианты нагрузки масс проекта " + p.name + "</title>";
            header += "<style type=\"text/css\"><!--.style1 { font-family: Arial, Helvetica, sans-serif;	font-size: 12pt; font-weight: normal;}--></style></head><body>";
            header += time + "</br>";
            int mass_category = GetMassGategory(full_mass);
            if (mass_category < 0) return;
            int descr_type = p.type;
            int shiptype = p.num_type1;
            foreach (DataTable dt in ds_variants.Tables)
            {
                string table_data = "";
                table_data += "<table class=\"style1\" width=\"100%\" border=\"1\" cellspacing=\"0\"><caption><span class=\"style1\">Вариант нагрузки " + dt.TableName + "</span></caption>";
                table_data += "<tr><td align=\"center\" colspan=\"2\" scope=\"col\">Раздел нагрузки</td><td  align=\"center\" colspan=\"4\" scope=\"col\">Вид водоизмещения </td></tr><tr><td width=\"6%\" rowspan=\"3\"><div align=\"center\">Шифр</div></td><td width=\"41%\" rowspan=\"3\"><div align=\"center\">Наименование</div></td><td colspan=\"4\"><div align=\"center\">" + dt.TableName + "</div></td></tr><tr><td width=\"11%\"><div align=\"center\">Масса</div></td><td width=\"41%\" colspan=\"3\"><div align=\"center\">Моменты</div></td></tr><tr><td><div align=\"center\">M, т</div></td><td><div align=\"center\">Mx, тм</div></td><td><div align=\"center\">My, тм</div></td><td><div align=\"center\">Mz, тм</div></td></tr>";
                DT table = dt as DT;
                DataTableHelper.SortDataTable(table, "code ASC");
                foreach (DR r in table)
                {
                    table_data += "<tr>";
                    table_data += ltag + r.code + rtag;
                    table_data += ltag + r.name_code.ToLower() + rtag;
                    table_data += ltag + Format((float)r.m, mass_category, descr_type, 0, r.code) + rtag;
                    table_data += ltag + Format((float)r.mx, mass_category, descr_type, 4, r.code) + rtag;
                    table_data += ltag + Format((float)r.my, mass_category, descr_type, 5, r.code) + rtag;
                    table_data += ltag + Format((float)r.mz, mass_category, descr_type, 6, r.code) + rtag;
                    table_data += "</tr>";
                }
                float M = 0, X = 0, Y = 0, Z = 0, Mx = 0, My = 0, Mz = 0;
                foreach (DR r in table.Rows)
                {
                    M += (float)r.m; Mx += (float)r.mx; My += (float)r.my; Mz += (float)r.mz;
                }
                X = Mx / M; Y = My / M; Z = Mz / M;
                switch (shiptype)
                {
                    case 0:
                        table_data += "<tr><td colspan=\"2\"><div align=\"right\">Док без балласта           </div></td><td width=\"12%\"><div align=\"center\">" + Format(M, mass_category, descr_type, 0) + "</div></td><td  width=\"14%\"><div align=\"center\">" + Format(Mx, mass_category, descr_type, 4) + "</div></td><td   width=\"14%\"><div align=\"center\">" + Format(My, mass_category, descr_type, 5) + "</div></td><td  width=\"14%\"><div align=\"center\">" + Format(Mz, mass_category, descr_type, 6) + "</div></td></tr><tr><td   colspan=\"2\">      <div align=\"right\">Отстояние центра  <br>        тяжести дока без  <br>        балласта, м  <br>        </div></td><td   colspan=\"4\"><div align=\"left\"><div align=\"left\">		От миделя  Xg = " + Format(X, mass_category, descr_type, 1) + "<br>        От ДП Yg = " + Format(Y, mass_category, descr_type, 2) + "<br>        От ОП Zg = " + Format(Z, mass_category, descr_type, 3) + "<br>        </div></div></td>        </tr><tr><td    colspan=\"2\"><div align=\"right\">	Балласт остаточный  <br></div></td><td   width=\"12%\">&nbsp;</td><td   width=\"14%\">&nbsp;</td><td  width=\"14%\">&nbsp;</td><td   width=\"14%\">&nbsp;</td></tr><tr><td   colspan=\"2\"><div align=\"right\">Балласт выравнивающий  <br></div></td><td  >&nbsp;</td><td  >&nbsp;</td><td  >&nbsp;</td><td  >&nbsp;</td></tr><tr><td   colspan=\"2\"><div align=\"right\">Док с балластом  <br></div></td><td >&nbsp;</td><td  >&nbsp;</td><td   >&nbsp;</td><td  >&nbsp;</td></tr><tr><td  colspan=\"2\"><div align=\"right\">      <div align=\"right\">Отстояние центра <br>        тяжести дока с <br>        балластом, м </div></div></td><td   colspan=\"4\"><div align=\"left\"><div align=\"left\">		От миделя  Xg = <br>        От ДП Yg = <br>        От ОП Zg = <br>        </div></div></td></tr></table><p></p>";
                        break;
                    case 1:
                        table_data += "<tr><td   colspan=\"2\"><div align=\"right\">Судно без балласта           </div></td><td  width=\"12%\"><div align=\"center\">" + Format(M, mass_category, descr_type, 0) + "</div></td><td  width=\"14%\"><div align=\"center\">" + Format(Mx, mass_category, descr_type, 4) + "</div></td><td  width=\"14%\"><div align=\"center\">" + Format(My, mass_category, descr_type, 5) + "</div></td><td  width=\"14%\"><div align=\"center\">" + Format(Mz, mass_category, descr_type, 6) + "</div></td></tr><tr><td  colspan=\"2\">      <div align=\"right\">Отстояние центра  <br>        тяжести судна без  <br>        балласта, м  <br>        </div></td><td   colspan=\"4\"><div align=\"left\"><div align=\"left\">		От миделя  Xg = " + Format(X, mass_category, descr_type, 1) + "<br>        От ДП Yg = " + Format(Y, mass_category, descr_type, 2) + "<br>        От ОП Zg = " + Format(Z, mass_category, descr_type, 3) + "<br>        </div></div></td></tr></table><p></p>";
                        break;
                }
                header += table_data;
            }
            header += "</body></html>";
            string file = Path.GetTempFileName() + ".html";
            File.AppendAllText(file, header, Encoding.Default);
            //DmsAPI.ShellExecute(IntPtr.Zero, "open", file, "", "", DmsAPI.ShowCommands.SW_SHOWNORMAL);
            Process.Start(file);
            if (DmsMsgBoxs.WarningOkCancelParam("Сформировать отчет Word для {0}?", p.name))
                Word2();

        }

        private void Word1(DT dt_src)
        {
            DMSdbDataSet.mass_projectRow p = GetSelectedProject();
            int mass_category = GetMassGategory(full_mass);
            if (mass_category < 0) return;
            int descr_type = p.type;
            int shiptype = p.num_type1;
            var vbcode = "";
            //
            //
            vbcode += "Set objWord = CreateObject(\"Word.Application\")\r\n";
            vbcode += "objWord.Visible = True\r\n";
            vbcode += "Set objDoc = objWord.Documents.Add()\r\n";
            vbcode += "objWord.Activate()\r\n";
            vbcode += "objDoc.Select\r\n";
            vbcode += "objDoc.Application.Selection.PageSetup.Orientation = 1\r\n";
            vbcode += "objDoc.Application.Selection.PageSetup.LeftMargin = 30\r\n";
            vbcode += "objDoc.Application.Selection.PageSetup.TopMargin = 80\r\n";
            vbcode += "objDoc.Application.Selection.PageSetup.BottomMargin = 30\r\n";
            //
            /*vbcode += "objDoc.Application.Selection.Font.Name = \"Arial\"\r\n";
            vbcode += "objDoc.Application.Selection.Font.Size = \"12\"\r\n";
            vbcode += "objDoc.Application.Selection.TypeText \"Network Adapter Report\"\r\n";
            vbcode += "objSelection.TypeParagraph()\r\n";*/
            // 
            vbcode += "Set objRange= objDoc.Range()\r\n";
            vbcode += "objDoc.Tables.Add objRange,1,10\r\n";
            vbcode += "Set objTable = objDoc.Tables (1)\r\n";

            vbcode += "objTable.Range.Style = \"Сетка таблицы\"\r\n";
            vbcode += "objTable.Columns(1).Width =60\r\n";
            vbcode += "objTable.Columns(2).Width =250\r\n";
            vbcode += "objTable.Columns(3).Width =60\r\n";
            vbcode += "objTable.Columns(4).Width =50\r\n";
            vbcode += "objTable.Columns(5).Width =50\r\n";
            vbcode += "objTable.Columns(6).Width =50\r\n";
            vbcode += "objTable.Columns(7).Width =50\r\n";
            vbcode += "objTable.Columns(8).Width =50\r\n";
            vbcode += "objTable.Columns(9).Width =50\r\n";
            vbcode += "objTable.Columns(10).Width =80\r\n";
            vbcode += "objTable.Rows.Height = 16\r\n";
            vbcode += "For i=1 To 10\r\n";
            vbcode += "objTable.Cell(1, i).LeftPadding = 0\r\n";
            vbcode += "objTable.Cell(1, i).RightPadding = 0\r\n";
            vbcode += "Next\r\n";
            vbcode += "objTable.Cell(1, 1).Range.Text = \"Код\"\r\n";
            vbcode += "objTable.Cell(1, 2).Range.Text = \"Название\"\r\n";
            vbcode += "objTable.Cell(1, 3).Range.Text = \"Масса, т\"\r\n";
            vbcode += "objTable.Cell(1, 4).Range.Text = \"X, м\"\r\n";
            vbcode += "objTable.Cell(1, 5).Range.Text = \"Y, м\"\r\n";
            vbcode += "objTable.Cell(1, 6).Range.Text = \"Z, м\"\r\n";
            vbcode += "objTable.Cell(1, 7).Range.Text = \"Mx, тм\"\r\n";
            vbcode += "objTable.Cell(1, 8).Range.Text = \"My, тм\"\r\n";
            vbcode += "objTable.Cell(1, 9).Range.Text = \"Mz, тм\"\r\n";
            vbcode += "objTable.Cell(1, 10).Range.Text = \"Примечание\"\r\n";
            vbcode += "objTable.Rows.Add ()\r\n";
            vbcode += "objDoc.Tables (1).Rows(1).HeadingFormat = True\r\n";
            vbcode += "objTable.Select\r\n";
            vbcode += "objDoc.Application.Selection.Font.Name = \"Arial\"\r\n";
            vbcode += "objDoc.Application.Selection.Font.Size = \"12\"\r\n";
            vbcode += "objDoc.Application.Selection.Cells.VerticalAlignment = 1\r\n";
            vbcode += "objDoc.Application.Selection.ParagraphFormat.Alignment = 1\r\n";
            vbcode += "objTable.Columns(2).Select\r\n";
            vbcode += "objDoc.Application.Selection.ParagraphFormat.Alignment = 0\r\n";
            vbcode += "objTable.Cell(1,2).Select\r\n";
            vbcode += "objDoc.Application.Selection.ParagraphFormat.Alignment = 1\r\n";
            vbcode += "objDoc.Application.Selection.EndOf\r\n";
            vbcode += "Dim aaa, ccc, bbb, ddd, iii\r\n";
            vbcode += "ddd = 0\r\n";
            vbcode += "Function Formatting ()\r\n";
            vbcode += "aaa = objTable.Cell(iii, 1).Range.Text\r\n";
            vbcode += "ccc = \"000000\"\r\n";
            vbcode += "If InStr(3,aaa,ccc,1) = 3 Then\r\n";
            vbcode += "objTable.Cell(iii, 1).Select\r\n";
            vbcode += "objDoc.Application.Selection.Font.Bold = 1\r\n";
            vbcode += "objDoc.Application.Selection.Font.Underline = 1\r\n";
            vbcode += "objTable.Cell(iii, 2).Select\r\n";
            vbcode += "objDoc.Application.Selection.Font.Bold = 1\r\n";
            vbcode += "objDoc.Application.Selection.Font.Underline = 1\r\n";
            vbcode += "objDoc.Application.Selection.ParagraphFormat.Alignment = 1\r\n";
            vbcode += "For n=3 To 9\r\n";
            vbcode += "objTable.Cell(iii, n).Select\r\n";
            vbcode += "objDoc.Application.Selection.Font.Bold = 1\r\n";
            vbcode += "Next\r\n";
            vbcode += "objDoc.Application.Selection.EndOf\r\n";
            vbcode += "ddd = 1\r\n";
            vbcode += "End If\r\n";
            vbcode += "ccc = \"0000\"\r\n";
            vbcode += "If InStr(5,aaa,ccc,1) = 5 And ddd = 0 Then\r\n";
            vbcode += "objTable.Cell(iii, 1).Select\r\n";
            vbcode += "objDoc.Application.Selection.Font.Underline = 1\r\n";
            vbcode += "objTable.Cell(iii, 2).Select\r\n";
            vbcode += "objDoc.Application.Selection.Font.Underline = 1\r\n";
            vbcode += "objDoc.Application.Selection.EndOf\r\n";
            vbcode += "ddd = 1\r\n";
            vbcode += "End If\r\n";
            vbcode += "ccc = \"00\"\r\n";
            vbcode += "If InStr(7,aaa,ccc,1) = 7  And ddd = 0 Then\r\n";
            vbcode += "objTable.Cell(iii, 1).Select\r\n";
            vbcode += "objDoc.Application.Selection.MoveLeft\r\n";
            vbcode += "bbb = objDoc.Application.Selection.MoveRight(1,6,1)\r\n";
            vbcode += "objDoc.Application.Selection.Font.Underline = 1\r\n";
            vbcode += "objDoc.Application.Selection.EndOf\r\n";
            vbcode += "End If\r\n";
            vbcode += "ddd = 0\r\n";
            vbcode += "End Function\r\n";
            DataTableHelper.SortDataTable(dt_src, "code ASC");
            int i = 0;
            foreach (DR r in dt_src)
            {
                vbcode += "objTable.Rows.Add ()\r\n";
                vbcode += "For n=1 To 9\r\n";
                vbcode += "objTable.Cell(" + (i + 2) + ", n).LeftPadding = 0\r\n";
                vbcode += "objTable.Cell(" + (i + 2) + ", n).RightPadding = 0\r\n";
                vbcode += "Next\r\n";
                vbcode += "objTable.Cell(" + (i + 2) + ", 1).Range.Text = " + "\"" + r.code + "\"" + "\r\n";
                vbcode += "objTable.Cell(" + (i + 2) + ", 2).Range.Text = " + "\"" + FormatNameWord(r.name_code) + "\"" + "\r\n";
                vbcode += "objTable.Cell(" + (i + 2) + ", 3).Range.Text = " + "\"" + Format((float)r.m, mass_category, descr_type, 0, r.code) + "\"" + "\r\n";
                vbcode += "objTable.Cell(" + (i + 2) + ", 4).Range.Text = " + "\"" + Format((float)r.x, mass_category, descr_type, 1, r.code) + "\"" + "\r\n";
                vbcode += "objTable.Cell(" + (i + 2) + ", 5).Range.Text = " + "\"" + Format((float)r.y, mass_category, descr_type, 2, r.code) + "\"" + "\r\n";
                vbcode += "objTable.Cell(" + (i + 2) + ", 6).Range.Text = " + "\"" + Format((float)r.z, mass_category, descr_type, 3, r.code) + "\"" + "\r\n";
                vbcode += "objTable.Cell(" + (i + 2) + ", 7).Range.Text = " + "\"" + Format((float)r.mx, mass_category, descr_type, 4, r.code) + "\"" + "\r\n";
                vbcode += "objTable.Cell(" + (i + 2) + ", 8).Range.Text = " + "\"" + Format((float)r.my, mass_category, descr_type, 5, r.code) + "\"" + "\r\n";
                vbcode += "objTable.Cell(" + (i + 2) + ", 9).Range.Text = " + "\"" + Format((float)r.mz, mass_category, descr_type, 6, r.code) + "\"" + "\r\n";
                vbcode += "iii = " + (i + 2) + "\r\n";
                vbcode += "Formatting()\r\n";
                i++;
            }
            string file = Path.GetTempFileName() + ".vbs";
            File.AppendAllText(file, vbcode, Encoding.Default);
            //DmsAPI.ShellExecute(IntPtr.Zero, "open", file, "", "", DmsAPI.ShowCommands.SW_SHOWNORMAL);
            Process.Start(file);
        }
        private void Word2()
        {
            DMSdbDataSet.mass_projectRow p = GetSelectedProject();
            int mass_category = GetMassGategory(full_mass);
            if (mass_category < 0) return;
            int descr_type = p.type;
            int shiptype = p.num_type1;

            string vbcode = "";
            vbcode += "Dim aaa\r\n";
            vbcode += "Set objWord = CreateObject(\"Word.Application\")\r\n";
            vbcode += "objWord.Visible = True\r\n";
            vbcode += "Set objDoc = objWord.Documents.Add()\r\n";
            vbcode += "objWord.Activate()\r\n";
            vbcode += "objDoc.Select\r\n";
            vbcode += "objDoc.Application.Selection.PageSetup.Orientation = 0\r\n";
            vbcode += "objDoc.Application.Selection.PageSetup.LeftMargin = 60\r\n";
            vbcode += "objDoc.Application.Selection.PageSetup.TopMargin = 30\r\n";
            int ti = 1;
            int si = 5;
            foreach (DataTable dt in ds_variants.Tables)
            {
                vbcode += "Set objRange = objDoc.Application.Selection.Range\r\n";
                vbcode += "objDoc.Tables.Add objRange,1,2\r\n";
                vbcode += "Set objTable = objDoc.Tables (" + ti + ")\r\n";
                vbcode += "objTable.Range.Style = \"Сетка таблицы\"\r\n";
                vbcode += "objTable.Columns(1).Width =300\r\n";
                vbcode += "objTable.Columns(2).Width =200\r\n";
                vbcode += "objTable.Rows.Height = 16\r\n";
                vbcode += "objTable.Select\r\n";
                vbcode += "objDoc.Application.Selection.Font.Name = \"Arial\"\r\n";
                vbcode += "objDoc.Application.Selection.Font.Size = \"12\"\r\n";
                vbcode += "objTable.Cell(1, 1).Range.Text = \"Раздел нагрузки\"\r\n";
                vbcode += "objTable.Cell(1, 2).Range.Text = \"Вид водоизмещения\"\r\n";
                vbcode += "objTable.Rows(1).Select\r\n";
                vbcode += "objDoc.Application.Selection.Cells.VerticalAlignment = 1\r\n";
                vbcode += "objDoc.Application.Selection.ParagraphFormat.Alignment = 1\r\n";
                vbcode += "objTable.Rows.Add()\r\n";
                vbcode += "objTable.Cell(2,1).Split 1,2\r\n";
                vbcode += "objTable.Cell(2,1).Width =70\r\n";
                vbcode += "objTable.Cell(2,2).Width =230\r\n";
                vbcode += "objTable.Cell(2,3).Split 3,1\r\n";
                vbcode += "objTable.Cell(4,3).Split 1,4\r\n";
                vbcode += "objTable.Cell(3,3).Split 1,4\r\n";
                vbcode += "objTable.Cell(3,4).Select\r\n";
                vbcode += "aaa = objDoc.Application.Selection.MoveRight(1,2,1)\r\n";
                vbcode += "objDoc.Application.Selection.Cells.Merge\r\n";
                vbcode += "objTable.Cell(2, 1).Range.Text = \"Шифр\"\r\n";
                vbcode += "objTable.Cell(2, 2).Range.Text = \"Наименование\"\r\n";
                vbcode += "objTable.Cell(2, 3).Range.Text = \"" + FormatNameWord(dt.TableName) + "\"\r\n";
                vbcode += "objTable.Cell(3, 3).Range.Text = \"Масса\"\r\n";
                vbcode += "objTable.Cell(3, 4).Range.Text = \"Моменты\"\r\n";
                vbcode += "objTable.Cell(4, 3).Range.Text = \"М, т\"\r\n";
                vbcode += "objTable.Cell(4, 4).Range.Text = \"Mx, тм\"\r\n";
                vbcode += "objTable.Cell(4, 5).Range.Text = \"My, тм\"\r\n";
                vbcode += "objTable.Cell(4, 6).Range.Text = \"Mz, тм\"\r\n";
                DT table = dt as DT;
                DataTableHelper.SortDataTable(table, "code ASC");
                foreach (DR r in table)
                {
                    vbcode += "objTable.Rows.Add()\r\n";
                    vbcode += "objTable.Cell(" + si + ", 1).Range.Text = \"" + r.code + "\"\r\n";
                    vbcode += "objTable.Cell(" + si + ", 2).Range.Text = \"" + FormatNameWord(r.name_code) + "\"\r\n";
                    vbcode += "objTable.Cell(" + si + ", 2).Select\r\n";
                    vbcode += "objDoc.Application.Selection.ParagraphFormat.Alignment = 0\r\n";
                    vbcode += "objTable.Cell(" + si + ", 3).Range.Text = \"" + Format((float)r.m, mass_category, descr_type, 0, r.code) + "\"\r\n";
                    vbcode += "objTable.Cell(" + si + ", 4).Range.Text = \"" + Format((float)r.mx, mass_category, descr_type, 4, r.code) + "\"\r\n";
                    vbcode += "objTable.Cell(" + si + ", 5).Range.Text = \"" + Format((float)r.my, mass_category, descr_type, 5, r.code) + "\"\r\n";
                    vbcode += "objTable.Cell(" + si + ", 6).Range.Text = \"" + Format((float)r.mz, mass_category, descr_type, 6, r.code) + "\"\r\n";
                    si++;
                }
                float M = 0, X = 0, Y = 0, Z = 0, Mx = 0, My = 0, Mz = 0;
                foreach (DR r in table.Rows)
                {
                    M += (float)r.m; Mx += (float)r.mx; My += (float)r.my; Mz += (float)r.mz;
                }
                X = Mx / M; Y = My / M; Z = Mz / M;
                switch (shiptype)
                {
                    case 0:
                        string wordend1 = "Док без балласта";
                        string wordend2 = "Отстояние центра тяжести дока без балласта, м";
                        vbcode += "objTable.Rows.Add()\r\n";
                        vbcode += "objTable.Cell(" + si + ", 1).Select\r\n";
                        vbcode += "aaa = objDoc.Application.Selection.MoveRight(1,1,1)\r\n";
                        vbcode += "objDoc.Application.Selection.Cells.Merge\r\n";
                        vbcode += "objDoc.Application.Selection.ParagraphFormat.Alignment = 2\r\n";
                        vbcode += "objTable.Cell(" + si + ", 1).Range.Text = \"" + wordend1 + "\"\r\n";
                        vbcode += "objTable.Cell(" + si + ", 2).Range.Text = \"" + Format(M, mass_category, descr_type, 0) + "\"\r\n";
                        vbcode += "objTable.Cell(" + si + ", 3).Range.Text = \"" + Format(Mx, mass_category, descr_type, 4) + "\"\r\n";
                        vbcode += "objTable.Cell(" + si + ", 4).Range.Text = \"" + Format(My, mass_category, descr_type, 5) + "\"\r\n";
                        vbcode += "objTable.Cell(" + si + ", 5).Range.Text = \"" + Format(Mz, mass_category, descr_type, 6) + "\"\r\n";
                        vbcode += "objTable.Cell(" + si + ", 1).Select\r\n";
                        vbcode += "objDoc.Application.Selection.Font.Bold = 1\r\n";
                        vbcode += "objTable.Cell(" + si + ", 2).Select\r\n";
                        vbcode += "objDoc.Application.Selection.Font.Bold = 1\r\n";
                        vbcode += "objTable.Cell(" + si + ", 3).Select\r\n";
                        vbcode += "objDoc.Application.Selection.Font.Bold = 1\r\n";
                        vbcode += "objTable.Cell(" + si + ", 4).Select\r\n";
                        vbcode += "objDoc.Application.Selection.Font.Bold = 1\r\n";
                        vbcode += "objTable.Cell(" + si + ", 5).Select\r\n";
                        vbcode += "objDoc.Application.Selection.Font.Bold = 1\r\n";
                        si++;
                        vbcode += "objTable.Rows.Add()\r\n";
                        vbcode += "objTable.Cell(" + si + ", 1).Select\r\n";
                        vbcode += "objDoc.Application.Selection.Font.Bold = 0\r\n";
                        vbcode += "objDoc.Application.Selection.ParagraphFormat.Alignment = 2\r\n";
                        vbcode += "objTable.Cell(" + si + ", 1).Range.Text = \"" + wordend2 + "\"\r\n";
                        vbcode += "objTable.Cell(" + si + ", 1).Select\r\n";
                        vbcode += "objDoc.Application.Selection.MoveLeft\r\n";
                        vbcode += "aaa = objDoc.Application.Selection.MoveRight(2,2,0)\r\n";
                        vbcode += "objDoc.Application.Selection.TypeParagraph\r\n";
                        vbcode += "aaa = objDoc.Application.Selection.MoveRight(2,3,0)\r\n";
                        vbcode += "objDoc.Application.Selection.TypeParagraph\r\n";
                        vbcode += "objTable.Cell(" + si + ", 2).Select\r\n";
                        vbcode += "aaa = objDoc.Application.Selection.MoveRight(1,3,1)\r\n";
                        vbcode += "objDoc.Application.Selection.Cells.Merge\r\n";
                        vbcode += "objTable.Cell(" + si + ", 2).Select\r\n";
                        vbcode += "objDoc.Application.Selection.ParagraphFormat.Alignment = 0\r\n";
                        vbcode += "objTable.Cell(" + si + ", 2).Range.Text = \"От миделя  Xg = " + Format(X, mass_category, descr_type, 1) + "\"&Chr(13)&\"От ДП Yg = " + Format(Y, mass_category, descr_type, 2) + "\"&Chr(13)&\"От ОП Zg = " + Format(Z, mass_category, descr_type, 3) + "\"\r\n";
                        vbcode += "objTable.Cell(" + si + ", 2).Select\r\n";
                        vbcode += "objDoc.Application.Selection.Font.Bold = 0\r\n";
                        //vbcode += "objDoc.Application.Selection.MoveLeft\r\n";
                        // vbcode += "aaa = objDoc.Application.Selection.MoveRight(2,8,0)\r\n";
                        //vbcode += "objDoc.Application.Selection.TypeParagraph\r\n";
                        //vbcode += "aaa = objDoc.Application.Selection.MoveRight(2,7,0)\r\n";
                        //vbcode += "objDoc.Application.Selection.TypeParagraph\r\n";
                        si++;
                        vbcode += "objTable.Rows.Add()\r\n";
                        vbcode += "objTable.Cell(" + si + ", 1).Select\r\n";
                        vbcode += "objDoc.Application.Selection.Font.Bold = 0\r\n";
                        vbcode += "objDoc.Application.Selection.ParagraphFormat.Alignment = 2\r\n";
                        vbcode += "objTable.Cell(" + si + ", 1).Range.Text = \"Балласт остаточный" + "\"&Chr(13)&\"Балласт выравнивающий\"\r\n";
                        // + редактирование: разбить на 2х4 ячейку
                        vbcode += "objTable.Cell(" + si + ", 2).Select\r\n";
                        vbcode += "objDoc.Application.Selection.Cells.Split 2,4\r\n";
                        // +
                        //vbcode += "objTable.Cell(" + si + ", 1).Select\r\n";
                        vbcode += "objTable.Cell(" + si + ", 2).Select\r\n";
                        vbcode += "objDoc.Application.Selection.MoveLeft\r\n";
                        vbcode += "aaa = objDoc.Application.Selection.MoveRight(2,2,0)\r\n";
                        //vbcode += "objDoc.Application.Selection.TypeParagraph\r\n";
                        si++;
                        wordend1 = "Док c балластом";
                        wordend2 = "Отстояние центра тяжести дока с балластом, м";
                        vbcode += "objTable.Rows.Add()\r\n";
                        si++;
                        vbcode += "objTable.Cell(" + si + ", 1).Select\r\n";
                        vbcode += "objDoc.Application.Selection.Font.Bold = 1\r\n";
                        vbcode += "objTable.Cell(" + si + ", 1).Range.Text = \"" + wordend1 + "\"\r\n";
                        // убрали из-за редактирования сверху.
                        //vbcode += "objTable.Cell("+si+", 2).Select\r\n";
                        //vbcode += "objDoc.Application.Selection.Cells.Split 1,4\r\n";
                        si++;
                        vbcode += "objTable.Rows.Add()\r\n";
                        vbcode += "objTable.Cell(" + si + ", 1).Select\r\n";
                        vbcode += "objDoc.Application.Selection.Font.Bold = 0\r\n";
                        vbcode += "objDoc.Application.Selection.ParagraphFormat.Alignment = 2\r\n";
                        vbcode += "objTable.Cell(" + si + ", 1).Range.Text = \"" + wordend2 + "\"\r\n";
                        vbcode += "objTable.Cell(" + si + ", 1).Select\r\n";
                        vbcode += "objDoc.Application.Selection.MoveLeft\r\n";
                        vbcode += "aaa = objDoc.Application.Selection.MoveRight(2,2,0)\r\n";
                        vbcode += "objDoc.Application.Selection.TypeParagraph\r\n";
                        vbcode += "aaa = objDoc.Application.Selection.MoveRight(2,3,0)\r\n";
                        vbcode += "objDoc.Application.Selection.TypeParagraph\r\n";
                        vbcode += "objTable.Cell(" + si + ", 2).Select\r\n";
                        vbcode += "aaa = objDoc.Application.Selection.MoveRight(1,3,1)\r\n";
                        vbcode += "objDoc.Application.Selection.Cells.Merge\r\n";
                        vbcode += "objTable.Cell(" + si + ", 2).Select\r\n";
                        vbcode += "objDoc.Application.Selection.ParagraphFormat.Alignment = 0\r\n";
                        vbcode += "objTable.Cell(" + si + ", 2).Range.Text = \"От миделя  Xg = \"&Chr(13)&\"От ДП Yg = \"&Chr(13)&\"От ОП Zg = \"\r\n";
                        //\"От миделя  Xg = "+ "\"&Chr(13)От ДП Yg = От ОП Zg =\"\r\n";
                        vbcode += "objTable.Cell(" + si + ", 2).Select\r\n";
                        vbcode += "objDoc.Application.Selection.Font.Bold = 0\r\n";
                        //vbcode += "objDoc.Application.Selection.MoveLeft\r\n";
                        //vbcode += "aaa = objDoc.Application.Selection.MoveRight(2,4,0)\r\n";
                        //vbcode += "objDoc.Application.Selection.TypeParagraph\r\n";
                        //vbcode += "aaa = objDoc.Application.Selection.MoveRight(2,3,0)\r\n";
                        //vbcode += "objDoc.Application.Selection.TypeParagraph\r\n";
                        //
                        vbcode += "objDoc.Application.Selection.MoveDown\r\n";
                        vbcode += "objDoc.Application.Selection.TypeParagraph\r\n";
                        vbcode += "objDoc.Application.Selection.InsertBreak\r\n";
                        break;
                    case 1:
                        wordend1 = "Итого";
                        wordend2 = "Отстояние центра тяжести судна без балласта, м";
                        vbcode += "objTable.Rows.Add()\r\n";
                        vbcode += "objTable.Cell(" + si + ", 1).Select\r\n";
                        vbcode += "aaa = objDoc.Application.Selection.MoveRight(1,1,1)\r\n";
                        vbcode += "objDoc.Application.Selection.Cells.Merge\r\n";
                        vbcode += "objDoc.Application.Selection.ParagraphFormat.Alignment = 2\r\n";
                        vbcode += "objTable.Cell(" + si + ", 1).Range.Text = \"" + wordend1 + "\"\r\n";
                        vbcode += "objTable.Cell(" + si + ", 2).Range.Text = \"" + Format(M, mass_category, descr_type, 0) + "\"\r\n";
                        vbcode += "objTable.Cell(" + si + ", 3).Range.Text = \"" + Format(Mx, mass_category, descr_type, 4) + "\"\r\n";
                        vbcode += "objTable.Cell(" + si + ", 4).Range.Text = \"" + Format(My, mass_category, descr_type, 5) + "\"\r\n";
                        vbcode += "objTable.Cell(" + si + ", 5).Range.Text = \"" + Format(Mz, mass_category, descr_type, 6) + "\"\r\n";
                        vbcode += "objTable.Cell(" + si + ", 1).Select\r\n";
                        vbcode += "objDoc.Application.Selection.Font.Bold = 1\r\n";
                        vbcode += "objTable.Cell(" + si + ", 2).Select\r\n";
                        vbcode += "objDoc.Application.Selection.Font.Bold = 1\r\n";
                        vbcode += "objTable.Cell(" + si + ", 3).Select\r\n";
                        vbcode += "objDoc.Application.Selection.Font.Bold = 1\r\n";
                        vbcode += "objTable.Cell(" + si + ", 4).Select\r\n";
                        vbcode += "objDoc.Application.Selection.Font.Bold = 1\r\n";
                        vbcode += "objTable.Cell(" + si + ", 5).Select\r\n";
                        vbcode += "objDoc.Application.Selection.Font.Bold = 1\r\n";
                        si++;
                        vbcode += "objTable.Rows.Add()\r\n";
                        vbcode += "objTable.Cell(" + si + ", 1).Select\r\n";
                        vbcode += "objDoc.Application.Selection.Font.Bold = 0\r\n";
                        vbcode += "objDoc.Application.Selection.ParagraphFormat.Alignment = 2\r\n";
                        vbcode += "objTable.Cell(" + si + ", 1).Range.Text = \"" + wordend2 + "\"\r\n";
                        vbcode += "objTable.Cell(" + si + ", 1).Select\r\n";
                        vbcode += "objDoc.Application.Selection.MoveLeft\r\n";
                        vbcode += "aaa = objDoc.Application.Selection.MoveRight(2,2,0)\r\n";
                        vbcode += "objDoc.Application.Selection.TypeParagraph\r\n";
                        vbcode += "aaa = objDoc.Application.Selection.MoveRight(2,3,0)\r\n";
                        vbcode += "objDoc.Application.Selection.TypeParagraph\r\n";
                        vbcode += "objTable.Cell(" + si + ", 2).Select\r\n";
                        vbcode += "aaa = objDoc.Application.Selection.MoveRight(1,3,1)\r\n";
                        vbcode += "objDoc.Application.Selection.Cells.Merge\r\n";
                        vbcode += "objTable.Cell(" + si + ", 2).Select\r\n";
                        vbcode += "objDoc.Application.Selection.ParagraphFormat.Alignment = 0\r\n";
                        vbcode += "objTable.Cell(" + si + ", 2).Range.Text = \"От миделя  Xg = " + Format(X, mass_category, descr_type, 1) + "\"&Chr(13)&\"От ДП Yg = " + Format(Y, mass_category, descr_type, 2) + "\"&Chr(13)&\"От ОП Zg = " + Format(Z, mass_category, descr_type, 3) + "\"\r\n";
                        vbcode += "objTable.Cell(" + si + ", 2).Select\r\n";
                        vbcode += "objDoc.Application.Selection.Font.Bold = 0\r\n";
                        //vbcode += "objDoc.Application.Selection.MoveLeft\r\n";
                        //vbcode += "aaa = objDoc.Application.Selection.MoveRight(2,8,0)\r\n";
                        //vbcode += "objDoc.Application.Selection.TypeParagraph\r\n";
                        //vbcode += "aaa = objDoc.Application.Selection.MoveRight(2,6,0)\r\n";
                        //vbcode += "objDoc.Application.Selection.TypeParagraph\r\n";
                        vbcode += "objDoc.Application.Selection.MoveDown\r\n";
                        vbcode += "objDoc.Application.Selection.TypeParagraph\r\n";
                        vbcode += "objDoc.Application.Selection.InsertBreak\r\n";
                        si = 5;
                        break;
                }
                ti++;

            }
            string file = Path.GetTempFileName() + ".vbs";
            File.AppendAllText(file, vbcode, Encoding.Default);
            //DmsAPI.ShellExecute(IntPtr.Zero, "open", file, "", "", DmsAPI.ShowCommands.SW_SHOWNORMAL);
            Process.Start(file);
        }
        private string FormatNameWord(string str)
        {
            str = str.Replace("\"", "");
            str = str.ToLower();
            return str.Substring(0, 1).ToUpper() + str.Substring(1);
        }
    }
}
