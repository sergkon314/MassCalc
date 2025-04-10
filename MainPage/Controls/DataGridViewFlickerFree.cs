using System.Windows.Forms;
using System.Drawing;

namespace dms.pages.Controls
{
    public class DataGridViewFlickerFree : System.Windows.Forms.DataGridView
    {
        public DataGridViewFlickerFree():base()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }
        protected override void OnCellFormatting(DataGridViewCellFormattingEventArgs e)
        {
            base.OnCellFormatting(e);
            if (Columns[e.ColumnIndex].GetType() == typeof(DataGridViewLinkColumn))
            {
                DataGridViewLinkCell cell = ((DataGridViewLinkCell)Rows[e.RowIndex].Cells[e.ColumnIndex]);
                if (cell.Selected == true)
                {
                    cell.LinkColor = Color.White;
                    if (cell.LinkVisited)
                        cell.VisitedLinkColor = Color.White;
                }
                else
                {
                    cell.LinkColor = ((DataGridViewLinkColumn)Columns[e.ColumnIndex]).LinkColor;
                    cell.VisitedLinkColor = Color.Green;
                }
            }
        }
    }
}
