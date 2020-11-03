using SuperWebSocket;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO.Ports;
using SuperSocket.SocketBase.Config;
using SuperSocket.SocketBase;
using System.ServiceModel.Channels;
using System.Text.RegularExpressions;

namespace RC_InterfaceService
{
    public partial class Service1 : ServiceBase
    {
        private readonly string _configFile = AppDomain.CurrentDomain.BaseDirectory + "\\Config.xml";
        private int revDataLen = 11;
        private List<byte> revDataBuffer = new List<byte>();
        private Object obj = new object();

        public Service1()
        {
            InitializeComponent();

            PortDataConfig config = null;
            if (!File.Exists(_configFile))
            {
                config = new PortDataConfig
                {
                    BaudRate = 9600,
                    PortName = "COM10",
                    ServerPort = 9100,
                    Parity= Parity.Even,
                    DataBits =8,
                    StopBits =StopBits.One,

                };
                Serializer.ToXml(config, _configFile);
            }
            else
            {
                config = Serializer.FromXml<PortDataConfig>(_configFile);
            }
            CodecontxtData.Config = config;
            CodecontxtData.Port = new SerialPort(config.PortName)
            {
                BaudRate = config.BaudRate,
                Encoding = Encoding.UTF8,
                Handshake = Handshake.None,
                DataBits = config.DataBits,
                StopBits = config.StopBits,
                Parity = config.Parity

            };

            CodecontxtData.Port.Open();


        }
        WebSocketServer appServer;
        protected override void OnStart(string[] args)
        {

            appServer = new WebSocketServer();             //new一个WebSocketServer 对象
            ServerConfig serverConfig = new ServerConfig                   //new serverConfig对象，设置配置信息
            {
                Security = "tls",
                Port = 2015,//set the listening port
                MaxConnectionNumber = 10000,
                Certificate = new CertificateConfig
                {
                    FilePath = "user-rsa.pfx",
                    Password = "rencheng"
                }
            };
            funTools funTool = new funTools();
            string filePath = @"log.txt";                       //往这个文件写入相关信息
            using (FileStream stream = new FileStream(filePath, FileMode.Append))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.WriteLine($"{DateTime.Now},服务启动aa！");
            }
            try
            {

                if (!appServer.Setup(serverConfig)) //Setup the appServer
                {

                    using (FileStream stream = new FileStream(filePath, FileMode.Append))
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.WriteLine($"{DateTime.Now},开启服务器失败");
                    }
                    return;
                }

                appServer.Start();
                //新的 接收串口消息
                if (CodecontxtData.Port.IsOpen)
                {
                   CodecontxtData.Port.DataReceived += NewDataReceived;
                }
                appServer.NewSessionConnected += appServer_NewSessionConnected;//客户端连接
                //appServer.SessionClosed += appServer_SessionClosed;//客户端关闭
            }
            catch (Exception ex)
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Append))
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine($"appServer启动失v败");
                }
            }
        }

        void appServer_SessionClosed(WebSocketSession session, SuperSocket.SocketBase.CloseReason value)
        {

            var sessions = appServer.GetSessions(b => true);
            foreach (var ss in sessions)
            {
                ss.Close() ;
            }
            session.Send(funTools.getJsonFromHashtable(null, "0", "连接接断开！"));
        }

        void appServer_NewSessionConnected(WebSocketSession session)
        {
            session.Send(funTools.getJsonFromHashtable(null, "1", "连接成功！"));
        }

        private void NewDataReceived2(object sender, SerialDataReceivedEventArgs e)
        {
            var data = CodecontxtData.Port.ReadExisting();
            funTools.Log("data：" + data);
            //Regex regex = new Regex(@"[STX](.*?)[ETX]", RegexOptions.IgnoreCase);
            char STX = Convert.ToChar(2);//帧开始符
            char ETX = Convert.ToChar(3);//帧结束符

            data = data.Replace(STX + "", "");
            data = data.Replace(Convert.ToChar(13) + "", "");
            data = data.Replace(Convert.ToChar(10) + "", "");

            data = data.Split(ETX)[0];

            /*
            string pattern = @"[STX](.*?)[ETX]";

            foreach (Match m in Regex.Matches(data, pattern))
            {
                data = m.Groups[1].Value;
            }  */


            var sessions = appServer.GetSessions(b => true);
            Hashtable ht = new Hashtable();
            ht.Add("data", data);
            foreach (var ss in sessions)
            {
                ss.Send(funTools.getJsonFromHashtable(ht, "1", "数据获取成功"));
            }
        }

        private void NewDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var data = CodecontxtData.Port.ReadExisting();
            if (data.Length <= 0)
                return;
            byte[] revBuffer = Encoding.ASCII.GetBytes(data);
            //完整数据 02 + data(8) + crc + 03
            //data:数据类型1 + 测量值6 + 操作类型标志1
            funTools.Log($"dataStr={data}|databyte={BitConverter.ToString(revBuffer)}");
            this.revDataBuffer.AddRange(revBuffer);
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

                //转发数据
                var sessions = appServer.GetSessions(b => true);
                Hashtable ht = new Hashtable();
                ht.Add("data", Encoding.ASCII.GetString(data));
                foreach (var ss in sessions)
                {
                    ss.Send(funTools.getJsonFromHashtable(ht, "1", "数据获取成功"));
                }

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

        protected override void OnStop()
        {
            //服务停止时没有需要做的事，放着不管，但别删除该方法，他是有系统自动生成的，删除可能会引起错误
        }
    }
}
