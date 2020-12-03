using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace SentConfig
{
    public class SerialPortDevice
    {
        private SerialPort serialPort;
        public delegate void RevSerialDataDel(byte[] buffer);
        public event RevSerialDataDel RevSerialDataEvent;
        private List<byte> revDataBuffer = new List<byte>();
        private object obj = new object();
        private int revDataLen = 11;

        public void SendRevSerialData(byte[] buffer)
        {
            RevSerialDataEvent(buffer);
        }

        public bool OpenSerialPort(string portName)
        {
            if (portName == "")
                return false;
            this.serialPort = new SerialPort();
            this.serialPort.PortName = portName;
            this.serialPort.BaudRate = 115200;
            this.serialPort.DataBits = 8;
            this.serialPort.StopBits = StopBits.One;
            this.serialPort.Parity = Parity.None;
            this.serialPort.Handshake = Handshake.None;

            this.serialPort.ReadTimeout = 100;
            this.serialPort.WriteTimeout = 100;

            if (!this.serialPort.IsOpen)
            {
                this.serialPort.Open();
                this.serialPort.DataReceived += SerialPort_DataReceived;
            }
            return this.serialPort.IsOpen;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (this.serialPort.BytesToRead <= 0)
                return;
            byte[] revBuffer = new byte[this.serialPort.BytesToRead];
            int count = this.serialPort.Read(revBuffer, 0, revBuffer.Length);
            SendRevSerialData(revBuffer);
        }

        public bool CloseSerialPort()
        {
            if (this.serialPort == null)
                return false;
            this.serialPort.Close();
            if (this.serialPort.IsOpen)
                return false;//close failed
            return true;//close success
        }

        public bool WriteSerialPort(byte[] buffer)
        {
            if (buffer.Length <= 0)
                return false;
            if (this.serialPort == null)
                return false;
            if (this.serialPort.IsOpen)
            {
                this.serialPort.Write(buffer, 0, buffer.Length);
                return true;
            }
            else
            {
                return false;
            }
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

                //转发完整数据
                SendRevSerialData(data);

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
    }
}
