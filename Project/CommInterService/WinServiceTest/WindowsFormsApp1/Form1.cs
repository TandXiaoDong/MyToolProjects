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
            List<byte> list = new List<byte>();
            for (int i = 0; i < 22;i++)
            {
                if (i == 0)
                {
                    list.Add(0x02);
                }
                else if (i == 10)
                {
                    list.Add(0x03);
                }
                else if (i == 11)
                {
                    list.Add(0x02);
                }
                else if (i == 21)
                {
                    list.Add(0x03);
                }
                else
                {
                    list.Add((byte)i);
                }
            }
            this.revDataBuffer.AddRange(list);
            ProcessRevData(this.revDataBuffer.ToArray());
        }

        private void ProcessRevData(byte[] buffer)
        {
            lock (this.obj)
            {
                if (buffer.Length < this.revDataLen)
                    return;
                if (buffer[0] != 0x02 && buffer[10] != 0x03)
                    return;
                byte[] data = new byte[this.revDataLen];
                Array.Copy(buffer, 0, data, 0, data.Length);
                this.revDataBuffer.RemoveRange(0, data.Length);

                //转发数据
                Hashtable ht = new Hashtable();
                ht.Add("data", data);

                if (this.revDataBuffer.Count >= this.revDataLen)
                {
                    ProcessRevData(this.revDataBuffer.ToArray());
                }
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
