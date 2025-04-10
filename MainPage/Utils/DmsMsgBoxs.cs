using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using dms.pages;
using dms.pages.Utils;

namespace dms.pages.Utils
{
     public static class DmsMsgBoxs
     {
          public static void Ok(string mess)
          {
               MessageBox.Show(mess, DmsStings.MSG_TITLE);
          }
          public static void OkFail(string mess)
          {
               MessageBox.Show(mess, DmsStings.MSG_TITLE_E, 0, MessageBoxIcon.Error);
          }
          public static void OkFailParam(string tmpl, object param)
          {
               string mess = String.Format(tmpl, param);
               MessageBox.Show(mess, DmsStings.MSG_TITLE_E, 0, MessageBoxIcon.Error);
          }
          public static bool WarningOkCancelParam(string tmpl, object param)
          {
               string mess = String.Format(tmpl, param);
               DialogResult res = MessageBox.Show(mess, DmsStings.MSG_TITLE_WARNING_ACT, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
               return res == DialogResult.OK;
          }
          public static bool WarningOkParam(string tmpl, object param)
          {
              string mess = String.Format(tmpl, param);
              DialogResult res = MessageBox.Show(mess, DmsStings.MSG_TITLE_WARNING, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return res == DialogResult.OK;
          }
          public static bool InfoOkCancelParam(string tmpl, object param)
          {
               string mess = String.Format(tmpl, param);
               DialogResult res = MessageBox.Show(mess, DmsStings.MSG_TITLE_I, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
               return res == DialogResult.OK;
          }
          public static bool InfoOkParam(string tmpl, object param)
          {
              string mess = String.Format(tmpl, param);
              DialogResult res = MessageBox.Show(mess, DmsStings.MSG_TITLE_I, MessageBoxButtons.OK, MessageBoxIcon.Information);
              return res == DialogResult.OK;
          }
     }
}
