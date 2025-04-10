using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dms.pages.SavedData
{
    public class MassSettings
    {
        public MassSettings()
        {
            cbProjectSelectedIndex = 0;
            cbProjectsGroupSelectedIndex = 7;
            cbStatusSelectedIndex = 5;
            chkOnlyMyProjectChecked = false;
        }
        public int cbProjectSelectedIndex { get; set; }
        public int cbProjectsGroupSelectedIndex { get; set; }
        public int cbStatusSelectedIndex { get; set; }
        public bool chkOnlyMyProjectChecked { get; set; }
    }
}
