using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DR = dms.pages.Utils.DMSdbDataSet.mass_data_bidRow;
using DT = dms.pages.Utils.DMSdbDataSet.mass_data_bidDataTable;
using VR = dms.pages.Utils.DMSdbDataSet.mass_variantsRow;
using VT = dms.pages.Utils.DMSdbDataSet.mass_variantsDataTable;
using System.Data;
using System.Windows.Forms;
using dms.pages.Mass.Dialogs;
using dms.pages.Utils.DMSdbDataSetTableAdapters;
using dms.pages.Utils;

namespace dms.pages.Main
{
    public partial class MassCalc : MassFilling
    {
        protected DT dt_result;// результат слияния кодов сучетом 11000000
        protected DT dt_filling;// результат по нагрузке масс
        protected VT dt_variants_koeff;// массив с вариантами нагрузки
        private float koeff_m;
        private float koeff_z;
        private float full_mass;
        private float empty_mass;
        private DataSet ds_variants;// массив таблиц с вариантами нагрузки масс;
        private void CalcEntry()
        {
            if (dt_assembly == null || dt_assembly.Rows.Count == 0)
            {
                DmsMsgBoxs.OkFail("Сводная таблица не сформирована.");
                return;
            }
            if (dt_result != null) dt_result.Dispose();
            if (dt_filling != null) dt_filling.Dispose();
            // сливаем коды
            DT tmp = dt_assembly.Copy() as DT;
            dt_result = GetNewDT();
            tmp = MergeCode(ref dt_result, ref tmp, ""); // сливаем по 8 цифрам кода
            tmp = MergeCode(ref dt_result, ref tmp, "00"); // сливаем по 6 цифрам кода
            tmp = MergeCode(ref dt_result, ref tmp, "0000"); // сливаем по 4 цифрам кода
            tmp = MergeCode(ref dt_result, ref tmp, "000000");// сливаем по 2 цифрам кода
            tmp.Dispose();
            // формруем массив нагрузки масс
            dt_filling = FillFromVariants(ref dt_result);
            // вычисляем 11000000 код
            full_mass = 0;
            empty_mass = 0;
            DMSdbDataSet.mass_projectRow p = GetSelectedProject();
            int mute = p.num_type2; //  1 - вспомог., 0 - гражданский
            int type = p.type;// 0-тех.предложение,1-эскиз.проект,2-тех.проект,3-рабочий проект
            int prototype = p.prototype;
            koeff_m = 0;
            koeff_z = 0;
            if (p.custom_stp == 1)
            {
                koeff_m = (float)p.custom_stp_m / 100;
                koeff_z = (float)p.custom_stp_z;
            }
            foreach (DR r in dt_filling)
            {
                //full_mass += r.m;
                string code = r.code;
                int r12 = Convert.ToInt32(code.Substring(0, 2));
                string r28 = code.Substring(2, 6);
                if (r12 <= 12 && r28 == "000000")
                {
                    empty_mass += (float)r.m;
                }
                if (r12 == 13 && r28 == "000000" && mute == 0)
                {
                    empty_mass += (float)r.m;
                }
            }

            if (type < 3 && p.custom_stp == 0) // не рабочий проект
            {
                string field_stp = "";
                if (empty_mass <= 100) field_stp = "until_100";
                if (empty_mass <= 1000 && empty_mass > 100) field_stp = "until_1000";
                if (empty_mass <= 10000 && empty_mass > 1000) field_stp = "until_10000";
                if (empty_mass <= 100000 && empty_mass > 10000) field_stp = "until_100000";
                if (empty_mass > 100000) field_stp = "over_100000";
                DMSdbDataSet.mass_stp_21Row[] stprows = dt_stp.Select("prototype=" + prototype) as DMSdbDataSet.mass_stp_21Row[];
                string[] m_arr = (stprows[0][field_stp] as string).Replace('.', ',').Split(':');// коэффициенты для дельта m
                string[] z_arr = (stprows[1][field_stp] as string).Replace('.', ',').Split(':');// коэффициенты для дельта z

                koeff_m = Convert.ToSingle(m_arr[type]) / 100;
                koeff_z = Convert.ToSingle(z_arr[type]);
            }

            DR[] rows;
            if (mute == 0)
            {
                rows = dt_result.Select("code like '%000000' and (code like '0%' or code like '10%' or code like '12%' or code like '13%')") as DR[];
            }
            else
            {
                rows = dt_result.Select("code like '%000000' and (code like '0%' or code like '10%' or code like '12%')") as DR[];
            }
            float M = 0, X = 0, Y = 0, Z = 0, Mx = 0, My = 0, Mz = 0;
            foreach (DR r in rows)
            {
                M += (float)r.m; Mx += (float)r.mx; My += (float)r.my; Mz += (float)r.mz;
            }
            X = Mx / M; Y = My / M; Z = Mz / M;
            float M11 = 0, Z11 = 0;
            if (type < 3) // не рабочий проект добавляем искусственно 1100000
            {
                M11 = M * koeff_m;
                Z11 = ((M + M11) * (Z + koeff_z) - M * Z) / M11;

                string code11 = "11000000";
                string name_code = dt_codes.FindBycode(code11).code_name;
                dt_result.Addmass_data_bidRow(code11, name_code, M11, X, Y, Z11);
                dt_filling.Addmass_data_bidRow(code11, name_code, M11, X, Y, Z11);

            }
            M += M11; Z += koeff_z;
            //if (M > 1000)// добавляем код 01070000
            if (M > 100)// добавляем код 01070000
            {
                float M0107 = M * 0.00112f;
                float Z0107 = Z / 3;

                string code0107 = "01070000";
                string name_code = dt_codes.FindBycode(code0107).code_name;
                dt_result.Addmass_data_bidRow(code0107, name_code, M0107, X, Y, Z0107);
                //dt_filling.Addmass_data_bidRow(code0107, name_code, M0107, X, Y, Z0107);
                M = 0; X = 0; Y = 0; Z = 0; Mx = 0; My = 0; Mz = 0;
                rows = dt_result.Select("code='01000000'") as DR[];
                if (rows.Length > 0)
                {
                    M = (float)rows[0].m;
                    X = (float)rows[0].x;
                    Y = (float)rows[0].y;
                    Z = (float)rows[0].z;
                    Mx = (float)rows[0].mx;
                    My = (float)rows[0].my;
                    Mz = (float)rows[0].mz;
                    dt_result.Rows.Remove(rows[0]);

                    M += M0107;
                    Mx += M0107 * X;
                    My += M0107 * Y;
                    Mz += M0107 * Z0107;
                    X = (float)(Mx / M);
                    Y = (float)(My / M);
                    Z = (float)(Mz / M);
                    string nameCode = dt_codes.FindBycode("01000000").code_name;
                    dt_result.Addmass_data_bidRow("01000000", nameCode, M, X, Y, Z);
                }
                M = 0; X = 0; Y = 0; Z = 0; Mx = 0; My = 0; Mz = 0;
                rows = dt_filling.Select("code='01000000'") as DR[];
                if (rows.Length > 0)
                {
                    M = (float)rows[0].m;
                    X = (float)rows[0].x;
                    Y = (float)rows[0].y;
                    Z = (float)rows[0].z;
                    Mx = (float)rows[0].mx;
                    My = (float)rows[0].my;
                    Mz = (float)rows[0].mz;
                    dt_filling.Rows.Remove(rows[0]);

                    M += M0107;
                    Mx += M0107 * X;
                    My += M0107 * Y;
                    Mz += M0107 * Z0107;
                    X = (float)(Mx / M);
                    Y = (float)(My / M);
                    Z = (float)(Mz / M);
                    string nameCode = dt_codes.FindBycode("01000000").code_name;
                    DMSdbDataSet.mass_data_bidRow res = new DMSdbDataSet.mass_data_bidRow(new DataRow("01000000", nameCode, M, X, Y, Z));
                    dt_filling.Addmass_data_bidRow();
                }

            }
            // выводим результат
            gb_data.Text = "Расчетная таблица проекта '" + p.name + "'";
            dt_result.DefaultView.Sort = "code ASC";
            dg_data.DataSource = dt_result;

            full_mass = CalcFullMass(ref dt_result);

        }

        private float CalcFullMass(ref DT dt)
        {
            DR[] rows = dt.Select("code like '%000000'") as DR[];
            DT tmp = GetNewDT();
            foreach (DR r in rows)
            {
                tmp.Addmass_data_bidRow(r.code, r.name_code, r.m, r.x, r.y, r.z);
            }
            return CalcSum(ref tmp);
        }

        private void FillingCalcEntry()
        {
            if (dt_filling == null || dt_filling.Rows.Count == 0)
            {
                DmsMsgBoxs.OkFail("Не сформирована расчетная таблица.");
                return;
            }

            DMSdbDataSet.mass_projectRow p = GetSelectedProject();
            if (ds_variants != null)
                ds_variants.Dispose();
            string ds_name = "Варианты нагрузки масс проекта " + p.name;
            ds_variants = new DataSet();
            ds_variants.DataSetName = ds_name;
            int mute = p.num_type2; //mute
            string name = p.name;
            CheckBox[] chk = { _01, _02, _03, _04, _05, _06, _07, _08, _09, _10, _11, _12, _13, _14, _15, _16, _17, _18 };

            for (int i = 0; i < 18; i++)
            {
                DT dt = null;
                if (chk[i].Checked)
                {
                    string column_name = chk[i].Name;
                    dt = GetNewDT();
                    dt.TableName = chk[i].Text;
                    foreach (DR r in dt_filling)
                    {
                        string code = r.code;
                        VR[] row = dt_variants_koeff.Select("code='" + code + "'") as VR[];
                        float koeff = (float)row[0][column_name];
                        if (code == "13000000" && i == 1) koeff *= mute;
                        if (koeff != 0)
                        {
                            dt.Addmass_data_bidRow(r.code, r.name_code, (float)r.m * koeff, r.x, r.y, r.z);
                        }
                    }
                }
                if (dt != null)
                    ds_variants.Tables.Add(dt);
            }
            gb_data.Text = "Вариант нагрузки масс проекта '" + name + "'" + " (без коэффициента)";
            CalcSum(ref dt_filling);
            dt_filling.DefaultView.Sort = "code ASC";
            dg_data.DataSource = dt_filling;
            if (ds_variants.Tables.Count > 0)
            {
                VariantsView d = new VariantsView(ds_variants);
                d.ShowDialog();
            }

        }

        private DT FillFromVariants(ref DT src)
        {
            DT tmp = GetNewDT();
            foreach (DR r in src)
            {
                foreach (VR v in dt_variants_koeff)
                {
                    if (v.code == r.code)
                    {
                        tmp.Addmass_data_bidRow(r.code, r.name_code, r.m, r.x, r.y, r.z);
                    }
                }
            }
            return tmp;
        }

        private DT MergeCode(ref DT dst, ref DT src, string end)
        {
            DT tmp = GetNewDT();
            int lenOfEnd = 8 - end.Length;
            while (src.Rows.Count != 0)
            {
                DR r = src.Rows[0] as DR;
                string code = r.code.Substring(0, lenOfEnd);
                DR[] rows = src.Select("code like '" + code + "%" + "'") as DR[];
                if (rows.Length > 1)
                {
                    GenerateSum(ref rows, code, end, ref tmp, ref src);
                }
                else
                {
                    //tmp.Addmass_data_bidRow(r.code, r.name_code, r.m, r.x, r.y, r.z);
                    //src.Rows.Remove(r);
                    if (!r.code.EndsWith(end))
                    {
                        string code_with_end = code + end;
                        string name_code = dt_codes.FindBycode(code_with_end).code_name;
                        tmp.Addmass_data_bidRow(code_with_end, name_code, r.m, r.x, r.y, r.z);
                        src.Rows.Remove(r);
                    }
                    else
                    {
                        DR[] rows_with_end = dst.Select("code = '" + r.code + "'") as DR[];
                        if (rows_with_end.Length == 0)
                            tmp.Addmass_data_bidRow(r.code, r.name_code, r.m, r.x, r.y, r.z);
                        src.Rows.Remove(r);
                    } /**/
                }
            }
            foreach (DR r in tmp)
            {
                dst.Addmass_data_bidRow(r.code, r.name_code, r.m, r.x, r.y, r.z);
            }
            src.Dispose();
            return dst.Copy() as DT;
        }
        private void GenerateSum(ref DR[] rows, string code, string end, ref DT tmp, ref DT src)
        {
            float M = 0, X = 0, Y = 0, Z = 0, Mx = 0, My = 0, Mz = 0;
            code += end;
            string ends = "";
            if (end == "" || end == "00")
                ends = "";
            if (end == "0000")
                ends = "00";
            if (end == "000000")
                ends = "0000";
            foreach (DR r in rows)
            {
                if (r.code.EndsWith(ends))
                {
                    M += (float)r.m;
                    Mx += (float)r.mx;
                    My += (float)r.my;
                    Mz += (float)r.mz;
                }
                src.Rows.Remove(r);
            }
            //if (M > 0)
            //{
            X = (float)(Mx / M);
            Y = (float)(My / M);
            Z = (float)(Mz / M);
            //}
            //else
            //{
            //	X = 0;
            //	Y = 0;
            //	Z = 0;
            //}
            string name_code = dt_codes.FindBycode(code).code_name;
            DR row = tmp.Addmass_data_bidRow(code, name_code, M, X, Y, Z);
        }
        private DT GetNewDT()
        {
            DT dt = new DT();
            dt.mxColumn.Expression = "m*x";
            dt.myColumn.Expression = "m*y";
            dt.mzColumn.Expression = "m*z";
            return dt;
        }

    }
}
