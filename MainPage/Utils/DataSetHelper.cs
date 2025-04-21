using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Globalization;

namespace dms.pages.Utils
{
    public class DataTableHelper
    {
        private static bool ColumnEqual(object A, object B)
        {

            // Compares two values to see if they are equal. Also compares DBNULL.Value.
            // Note: If your DataTable contains object fields, then you must extend this
            // function to handle them in a meaningful way if you intend to group on them.

            if (A == DBNull.Value && B == DBNull.Value) //  both are DBNull.Value
                return true;
            if (A == DBNull.Value || B == DBNull.Value) //  only one is DBNull.Value
                return false;
            return (A.Equals(B));  // value type standard comparison
        }
        private static bool ColumnEqualYear(DateTime A, DateTime B)
        {
            int YA = A.Year;
            int YB = B.Year;
            if (YA == 0 && YB == 0) //  both are DBNull.Value
                return true;
            if (YA == 0 || YB == 0) //  only one is DBNull.Value
                return false;
            return (YA.Equals(YB));  // value type standard comparison
        }

        public static DataTable SelectDistinct(DataTable SourceTable, string FieldName, bool AddEmpty = true)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(FieldName, SourceTable.Columns[FieldName].DataType);

            object LastValue = null;
            foreach (DataRow dr in SourceTable.Select("", FieldName))
            {
                if (LastValue == null || !(ColumnEqual(LastValue, dr[FieldName])))
                {
                    if (AddEmpty)
                    {
                        LastValue = dr[FieldName];
                        dt.Rows.Add(new object[] { LastValue });
                    }
                    else
                    {
                        if (dr[FieldName] != null)
                        {
                            LastValue = dr[FieldName];
                            dt.Rows.Add(new object[] { LastValue });
                        }
                    }
                }
            }
            return dt;
        }
        public static DataTable SelectDistinctYear(DataTable SourceTable, string FieldName)
        {

            if (SourceTable.Columns[FieldName].DataType.Equals(typeof(DateTime)))
            {
                DataTable dt = new DataTable();
                dt.Columns.Add(FieldName, typeof(string));

                DateTime LastValue = new DateTime();
                foreach (DataRow dr in SourceTable.Select("", FieldName))
                {
                    DateTime NextValue = (DateTime)dr[FieldName];
                    if (!(ColumnEqualYear(LastValue, NextValue)))
                    {
                        LastValue = NextValue;
                        dt.Rows.Add(new object[] { LastValue.Year.ToString() });
                    }
                }
                SortDataTable(dt, FieldName + " DESC");
                return dt;
            }
            return new DataTable();
        }
        public static DataTable SelectDistinctYarMonth(DataTable SourceTable, string FieldName, int year)
        {

            if (SourceTable.Columns[FieldName].DataType.Equals(typeof(DateTime)))
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("num", typeof(int));
                dt.Columns.Add("month", typeof(string));

                int LastValue = 0;

                DateTime yearMax = new DateTime(year + 1, 1, 1);
                DateTime yearMin = new DateTime(year, 1, 1);
                string filter = string.Format(CultureInfo.InvariantCulture, FieldName + " >= #{0}# AND " + FieldName + " < #{1}#", yearMin, yearMax);
                DataRow[] rows = SourceTable.Select(filter);

                foreach (DataRow dr in rows)
                {
                    DateTime NextValue = (DateTime)dr[FieldName];
                    if (!(LastValue.Equals(NextValue.Month)))
                    {
                        LastValue = NextValue.Month;
                        dt.Rows.Add(new object[] { LastValue, GetMonthName(NextValue) });
                    }
                }
                SortDataTable(dt, "num ASC");
                return dt;
            }
            return new DataTable();
        }
        public static string GetMonthName(DateTime givenDate)
        {
            var formatInfoinfo = new DateTimeFormatInfo();
            string[] monthName = formatInfoinfo.MonthNames;
            return monthName[givenDate.Month - 1];
        }
        public static void SortDataTable(DataTable dt, string sort)
        {
            DataTable newDT = dt.Clone();
            int rowCount = dt.Rows.Count;
            DataRow[] foundRows = dt.Select(null, sort); // Sort with Column label
            for (int i = 0; i < rowCount; i++)
            {
                object[] arr = new object[dt.Columns.Count];
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    arr[j] = foundRows[i][j];
                }
                DataRow data_row = newDT.NewRow();
                data_row.ItemArray = arr;
                newDT.Rows.Add(data_row);
            }
            //clear the incoming dt
            dt.Rows.Clear();
            for (int i = 0; i < newDT.Rows.Count; i++)
            {
                object[] arr = new object[dt.Columns.Count];
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    arr[j] = newDT.Rows[i][j];
                }
                DataRow data_row = dt.NewRow();
                data_row.ItemArray = arr;
                dt.Rows.Add(data_row);
            }
        }
        public static string[] GetDistinctStrings(DataTable src, string field, bool addEmpty = false)
        {
            DataTable tmp = DataTableHelper.SelectDistinct(src, field, false);
            string[] res = new string[tmp.Rows.Count];
            int i = 0;
            foreach (DataRow r in tmp.Rows)
            {
                res[i] = r.ItemArray[0].ToString();
                i++;
            }
            return res;
        }
    }
}
