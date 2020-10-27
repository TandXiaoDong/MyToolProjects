using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int revDataLen = 11;
        private List<byte> revDataBuffer = new List<byte>();
        private Object obj = new object();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            testRevdata();
        }

        private void testRevdata()
        {
            var list = Encoding.ASCII.GetBytes("data：20016.01�20038.01�20056.41�20060.91�20060.81�20061.01�20060.91�20060.91�20060.91�20060.91�20060.92�10166.02�60022.12�C0060.62�*******��ǰ������������*******2020��10��27��             12:00-------------------------------��� 166.0cm        ����  60.9kgBMI   22.1(����ֵ 18.5 - 23.9)��������  60.6kg**********���β������**********�000170gi");

            this.revDataBuffer.AddRange(list);
            ProcessRevData(this.revDataBuffer.ToArray());
        }

        private void ProcessRevData(byte[] buffer)
        {
            lock (this.obj)
            {
                if (buffer.Length < this.revDataLen)
                    return;
                if (!CheckStartFlag(buffer))
                    return;
                buffer = this.revDataBuffer.ToArray();
                if (buffer[0] != 0x02 && buffer[10] != 0x03)
                    return;
                byte[] data = new byte[this.revDataLen];
                Array.Copy(buffer, 0, data, 0, data.Length);
                this.revDataBuffer.RemoveRange(0, data.Length);
                Log("data="+ BitConverter.ToString(data));

                Hashtable ht = new Hashtable();
                ht.Add("data", Encoding.ASCII.GetString(data));
                getJsonFromHashtable(ht, "1", "数据获取成功");

                if (this.revDataBuffer.Count >= this.revDataLen)
                {
                    ProcessRevData(this.revDataBuffer.ToArray());
                }
            }
        }

        private bool CheckStartFlag(byte[] buffer)
        {
            if (buffer.Length <= 0)
                return false;

            if (buffer[0] != 0x02)
            {
                this.revDataBuffer.RemoveRange(0, 1);
                return CheckStartFlag(this.revDataBuffer.ToArray());
            }
            else
            {
                return true;
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            Hashtable htt = new Hashtable();
            htt.Add("data", "02 00 04 06 07 08 03");
            getJsonFromHashtable(htt, "chenggong", "msg");
        }

        public static string getJsonFromHashtable(Hashtable htt, string success, string msg)
        {
            try
            {
                StringBuilder sb = new StringBuilder("");
                sb.Append(@"{");
                if (htt != null)
                {
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
