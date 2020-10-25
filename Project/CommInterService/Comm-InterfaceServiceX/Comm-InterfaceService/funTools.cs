using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.IO;

namespace RC_InterfaceService
{
    public class funTools
    {
        /// <summary>
        /// 系统参数设置
        /// </summary>
        public static List<Hashtable> sysconfig;

        /// <summary>
        /// 显示错误提示对话框
        /// </summary>
        /// <param name="strinfo"></param>
        public static void ShowErrMsg(string strinfo)
        {
            MessageBox.Show(strinfo, Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        public static void Log(string info)
        {
            var path = "C:\\data\\log\\";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            path += System.DateTime.Now.ToString("yyyyMMddHH");
            using (FileStream fs = new FileStream(path, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(info);
                }
            }
        }

        /// <summary>
        /// 显示提示对话框
        /// </summary>
        /// <param name="strinfo"></param>
        public static void ShowInfoMsg(string strinfo)
        {
            MessageBox.Show(strinfo, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 关机
        /// </summary>
        public static void ShutDownComputer()
        {
            try
            {
                Process pro = new Process();
                pro.StartInfo.FileName = "shutdown.exe";
                pro.StartInfo.Arguments = "-s -t 0";//延时时间为0（马上关机）
                pro.StartInfo.UseShellExecute = false;//不使用操作系统外壳程序启动进程
                pro.StartInfo.CreateNoWindow = true;//不创建窗体
                pro.StartInfo.RedirectStandardOutput = true;
                pro.Start();
            }
            catch (Exception ex)
            {

            }
        }


        public static bool IsNumeric(string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*[.]?\d*$");
        }

        public static bool IsMoney(string value)
        {
            return Regex.IsMatch(value, @"^([1-9]\d{0,9}|0)([.]?|(\.\d{1,4})?)$");
        }

        public static string FormatMoney(string strM,string formatType) { 
            if(strM == null){
                return "";
            }else if(strM == ""){
                return "";
            }else{
                if (formatType == "4")
                {
                    return String.Format("{0:F4}", double.Parse(strM));
                }
                else {
                    return String.Format("{0:F}", double.Parse(strM));
                }
            }
        }

        public static string FormatDecimal(string strM, string formatType)
        {
            if (strM == null)
            {
                return "";
            }
            else if (strM == "")
            {
                return "";
            }
            else
            {
                if (formatType == "4")
                {
                    return String.Format("{0:F4}", double.Parse(strM));
                }
                else
                {
                    return String.Format("{0:F}", double.Parse(strM));
                }
            }
        }

        public static bool IsInt(string value)
        {
            return Regex.IsMatch(value, @"^[+-]?\d*$");
        }
        public static bool IsUnsign(string value)
        {
            return Regex.IsMatch(value, @"^\d*[.]?\d*$");
        }

        public static bool isTel(string strInput)
        {
            return Regex.IsMatch(strInput, @"\d{3}-\d{8}|\d{4}-\d{7}");
        }

        public static bool IsDateOfAddDay(string strDate, ref string strOutDate, int day)
        {
            DateTime dtDate;

            if (DateTime.TryParse(strDate, out dtDate))
            {
                strOutDate = dtDate.AddDays(day).ToString("yyyy-MM-dd");
                return true;
            }
            else
            {
                return false;
            }
        }



        /// <summary>
        /// JSON TO Object 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Hashtable getHashtableFromJson(string str)
        {
            try
            {
                Hashtable htt = JsonConvert.DeserializeObject<Hashtable>(str);

                return htt;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        /// <summary>
        /// JSON TO Object 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string getJsonFromHashtable(Hashtable htt, string success, string msg)
        {
            try
            {
                StringBuilder sb = new StringBuilder("");
                sb.Append(@"{");
                if (htt != null) {
                    sb.Append(@"'data': {");
                    foreach (string key in htt.Keys)
                    {
                        sb.AppendFormat(@"'{0}':'{1}',", key, htt[key]);
                    }
                    sb.Append(@"},");
                }
                sb.AppendFormat(@"'code':'{0}',", success);
                sb.AppendFormat(@"'msg':'{0}'", msg);
                sb.Append(@"}");
                return sb.ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
