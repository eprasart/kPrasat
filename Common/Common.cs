﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kBit
{
    class Common
    {
        public static string RemoveLastDotZero(string v)
        {
            string s = v;
            if (v.EndsWith(".0"))
                return RemoveLastDotZero(v.Substring(0, v.Length - 2));
            else
                return s;
        }

        public static void ShowMsg(string msg, string title = "", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information)
        {
            var fMsg = new frmMsg(msg);
            fMsg.Title = title;
            fMsg.ShowDialog();
        }

        public static bool IsFileLocked(string path)
        {
            if (!File.Exists(path)) return false;
            FileStream stream = null;
            try
            {
                stream = File.Open(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            //file is not locked
            return false;
        }
    }


}
