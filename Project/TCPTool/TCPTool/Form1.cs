using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FigKeyLoggerServer.SuperSocketServer;

namespace TCPTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //发送
            string message = this.textBox1.Text.ToString().Replace("\r\n","");
            byte[] bMessage = HexStringToBytes(message);
            SocketServerControl.SendMessage(bMessage);
            SocketServerControl.message = bMessage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //启动服务
            SocketServerControl.StartServer();
        }

        public static byte[] HexStringToBytes(string hs)
        {
            string[] strArr = hs.Trim().Split(' ');
            byte[] b = new byte[strArr.Length];
            //逐个字符变为16进制字节数据
            for (int i = 0; i < strArr.Length; i++)
            {
                b[i] = (byte)Convert.ToInt32(strArr[i],16);
            }
            return b;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SocketServerControl.StopServer();
        }
    }
}
