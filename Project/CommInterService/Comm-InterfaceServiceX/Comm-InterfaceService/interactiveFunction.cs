using SuperWebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading;
using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RC_InterfaceService
{
    class interactiveFunction
    {
        public enum WEBRESOLUTION : uint {
        WEBRESOLUTION_
        
        }
        internal string getResolutionJson(List<string> resolutionList)
        {
            string resolutionlist = "[";
            foreach (string i in resolutionList)
            {

                if (i.Equals(resolutionList.Last()))
                {
                    resolutionlist = resolutionlist + "\"" + i + "\"]";
                }
                else
                {
                    //MessageBox.Show(resolutionlist);
                    resolutionlist = resolutionlist + "\"" + i + "\",";
                }

            }
            string jsondata = "";
            jsondata = "{\"code\":\"1,\"msg\":\"\\u6210\\u529f\",\"data\":" + resolutionlist + "}";
            //此处jsondata带的字符都是固定的，可以自行修改
            return jsondata;
        }
        internal void getRes(IntPtr m_hCaptureDevice, SuperWebSocket.WebSocketSession session)
        {
            VIDEO_RESOLUTION VideoResolution = new VIDEO_RESOLUTION();
            VideoResolution.dwVersion = 1;
            AVerCapAPI.AVerGetVideoResolutionEx(m_hCaptureDevice, ref VideoResolution);
            //定义一个uint用于表示目前分辨率的索引
            uint m_uVideoResolution = 0;
            m_uVideoResolution = VideoResolution.dwVideoResolution;
            //定义一个uint列表，装支持的分辨率的索引
            List<uint> m_VideoResolutionList = new List<uint>();
            m_VideoResolutionList.Clear();
            //定义solutionNum，videoSource，videoFormat，调用API必要的参数共有4个，并且都放在结构体VIDEO_RESOLUTION中
            uint SolutionNum = 0;
            uint m_uVideoSource = 0;
            uint m_uVideoFormat = 0;
            AVerCapAPI.AVerGetVideoSource(m_hCaptureDevice, ref m_uVideoSource);
            AVerCapAPI.AVerGetVideoFormat(m_hCaptureDevice, ref m_uVideoFormat);
            AVerCapAPI.AVerGetVideoResolutionSupported(m_hCaptureDevice, m_uVideoSource, m_uVideoFormat, null, ref SolutionNum);
            uint[] pdwSupported = new uint[SolutionNum];
            AVerCapAPI.AVerGetVideoResolutionSupported(m_hCaptureDevice, m_uVideoSource, m_uVideoFormat, pdwSupported, ref SolutionNum);
            //定义一个string数组，装转换后的分辨率;

            List<string> resolutionList = new List<string>();

            //用下列foreach，根据索引填充list
            foreach (uint i in pdwSupported)
            {
                m_VideoResolutionList.Add(i);

                switch (i)
                {
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_640X480:
                        resolutionList.Add("640X480");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_704X576:
                        resolutionList.Add("704X576");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_720X480:
                        resolutionList.Add("720X480");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_720X576:
                        resolutionList.Add("720X576");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1920X1080:
                        resolutionList.Add("1920X1080");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_160X120:
                        resolutionList.Add("160X120");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_176X144:
                        resolutionList.Add("176X144");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_240X176:
                        resolutionList.Add("240X176");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_240X180:
                        resolutionList.Add("240X180");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_320X240:
                        resolutionList.Add("320X240");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_352X240:
                        resolutionList.Add("352X240");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_352X288:
                        resolutionList.Add("352X288");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_640X240:
                        resolutionList.Add("640X240");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_640X288:
                        resolutionList.Add("640X288");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_720X240:
                        resolutionList.Add("720X240");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_720X288:
                        resolutionList.Add("720X288");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_80X60:
                        resolutionList.Add("80X60  ");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_88X72:
                        resolutionList.Add("88X72  ");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_128X96:
                        resolutionList.Add("128X96 ");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_640X576:
                        resolutionList.Add("640X576");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_180X120:
                        resolutionList.Add("180X120");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_180X144:
                        resolutionList.Add("180X144");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_360X240:
                        resolutionList.Add("360X240");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_360X288:
                        resolutionList.Add("360X288");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_768X576:
                        resolutionList.Add("768X576");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_384x288:
                        resolutionList.Add("384x288");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_192x144:
                        resolutionList.Add("192x144 ");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1280X720:
                        resolutionList.Add("1280X720");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1024X768:
                        resolutionList.Add("1024X768");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1280X800:
                        resolutionList.Add("1280X800");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1280X1024:
                        resolutionList.Add("1280X1024");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1440X900:
                        resolutionList.Add("1440X900");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1600X1200:
                        resolutionList.Add("1600X1200");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1680X1050:
                        resolutionList.Add("1680X1050");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_800X600:
                        resolutionList.Add("800X600");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1280X768:
                        resolutionList.Add("1280X768");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1360X768:
                        resolutionList.Add("1360X768");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1152X864:
                        resolutionList.Add("1152X864");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1280X960:
                        resolutionList.Add("1280X960");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_702X576:
                        resolutionList.Add("702X576");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_720X400:
                        resolutionList.Add("720X400");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1152X900:
                        resolutionList.Add("1152X900");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1360X1024:
                        resolutionList.Add("1360X1024");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1366X768:
                        resolutionList.Add("1366X768");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1400X1050:
                        resolutionList.Add("1400X1050");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1440X480:
                        resolutionList.Add("1440X480");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1440X576:
                        resolutionList.Add("1440X576");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1600X900:
                        resolutionList.Add("1600X900");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1920X1200:
                        resolutionList.Add("1920X1200");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1440X1080:
                        resolutionList.Add("1440X1080");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1600X1024:
                        resolutionList.Add("1600X1024");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_3840X2160:
                        resolutionList.Add("3840X2160");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1152X768:
                        resolutionList.Add("1152X768");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_176X120:
                        resolutionList.Add("176X120");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_704X480:
                        resolutionList.Add("704X480");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1792X1344:
                        resolutionList.Add("1792X1344");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1856X1392:
                        resolutionList.Add("1856X1392");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_1920X1440:
                        resolutionList.Add("1920X1440");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_2048X1152:
                        resolutionList.Add("2048X1152");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_2560X1080:
                        resolutionList.Add("2560X1080");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_2560X1440:
                        resolutionList.Add("2560X1440");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_2560X1600:
                        resolutionList.Add("2560X1600");

                        break;
                    case (uint)VIDEORESOLUTION.VIDEORESOLUTION_4096X2160:
                        resolutionList.Add("4096X2160");

                        break;

                }


            }
            //之后，用辅助函数生成JSON用于传送；

            
            session.Send(getResolutionJson(resolutionList));
        }

        internal void getDevice(IntPtr m_hCaptureDevice, Hashtable htt, WebSocketSession session, uint m_uDeviceNum)
        {
            StringBuilder szDeviceName = new StringBuilder("", 260);//定义一个超过256的stringBuilder用于存放Devicename
            int a = AVerCapAPI.AVerGetDeviceName(m_uDeviceNum - 1, szDeviceName);
            session.Send("{\"value\":\"" + szDeviceName + "\"}");
        }

        //recordFile在讨论中已弃用，此处虽做保留，但在服务中未被使用
        internal void recordFile(IntPtr m_hCaptureDevice, Hashtable htt)
        {
             IntPtr m_hRecordobject = new IntPtr(0);
             string configFilePath = System.Windows.Forms.Application.StartupPath + "\\RecordConfig.ini";
            MessageBox.Show(configFilePath);
            ////打开文件
            ////FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            ////通过指定字符编码方式可以实现对汉字的支持，否则在用记事本打开查看会出现乱码
            //StreamWriter m_streamWriter = new StreamWriter(configFilePath, false, Encoding.GetEncoding("GB2312"));

            //m_streamWriter.Flush();

            //// 使用StreamWriter来往文件中写入内容

            //m_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);

            string strContent = File.ReadAllText(configFilePath);
            MessageBox.Show(strContent);
            strContent = Regex.Replace(strContent, "AVM_REC_OUTPUTINFO_FILENAME	  = "+ @"C:\Temp\Temp.mp4", "AVM_REC_OUTPUTINFO_FILENAME	  = "+@"C:\Temp\"+htt["value"]+""+DateTime.Now.Date.ToString()+".mp4");
            File.WriteAllText(configFilePath, strContent);




            //int iRetVal = AVerCapAPI.AVerStartRecordFile(m_hCaptureDevice, ref m_hRecordobject, configFilePath);


        }

        internal void setResolution(IntPtr m_hCaptureDevice, WebSocketSession session, System.Collections.Hashtable htt, uint uVideoSource)
        {
            //注意，根据圆钢SDK说明，在设置视频参数前，要调用stopsteaming API，在成功设置后，才可以调用startStreaming开始传输
            AVerCapAPI.AVerStopStreaming(m_hCaptureDevice);


            //以下为设置视频参数
            //视频源
            int lr = AVerCapAPI.AVerSetVideoSource(m_hCaptureDevice, (uint)VIDEOSOURCE.VIDEOSOURCE_SVIDEO);
            //视频制式
            int a = AVerCapAPI.AVerSetVideoFormat(m_hCaptureDevice, 1);
            //定义视频分辨率对象 VIDEO_RESOLUTION结构体
            VIDEO_RESOLUTION VideoResolution = new VIDEO_RESOLUTION();
            VideoResolution.dwVersion = 1;
            VideoResolution.bCustom = 1;
            
            //显示当前分辨率          
            //根据传输过来的htt，解析得到的分辨率，并反向定义宽高
            int index = Convert.ToInt32(htt["value"]);
            switch(index){
                case (int)VIDEORESOLUTION.VIDEORESOLUTION_176X144:
                    VideoResolution.dwWidth = 176;
                    VideoResolution.dwHeight =144;
                    break;
                case (int)VIDEORESOLUTION.VIDEORESOLUTION_240X176:
                    VideoResolution.dwWidth = 240;
                    VideoResolution.dwHeight = 176;
                    break;
                case (int)VIDEORESOLUTION.VIDEORESOLUTION_240X180:
                    VideoResolution.dwWidth = 240;
                    VideoResolution.dwHeight = 180;
                    break;
                case (int)VIDEORESOLUTION.VIDEORESOLUTION_320X240:
                    VideoResolution.dwWidth = 320;
                    VideoResolution.dwHeight =240;
                    break;
                case (int)VIDEORESOLUTION.VIDEORESOLUTION_352X240:
                    VideoResolution.dwWidth = 352;
                    VideoResolution.dwHeight = 240;
                    break;
                case (int)VIDEORESOLUTION.VIDEORESOLUTION_352X288:
                    VideoResolution.dwWidth = 352;
                    VideoResolution.dwHeight = 288;
                    break;
                case (int)VIDEORESOLUTION.VIDEORESOLUTION_640X240:
                    VideoResolution.dwWidth = 640;
                    VideoResolution.dwHeight = 240;
                    break;
                case (int)VIDEORESOLUTION.VIDEORESOLUTION_640X288:
                    VideoResolution.dwWidth = 640;
                    VideoResolution.dwHeight = 288;
                    break;
                case (int)VIDEORESOLUTION.VIDEORESOLUTION_720X240:
                    VideoResolution.dwWidth = 720;
                    VideoResolution.dwHeight = 240;
                    break;
                case (int)VIDEORESOLUTION.VIDEORESOLUTION_720X288:
                    VideoResolution.dwWidth = 720;
                    VideoResolution.dwHeight = 288;
                    break;
                case (int)VIDEORESOLUTION.VIDEORESOLUTION_720X480:
                    VideoResolution.dwWidth = 720;
                    VideoResolution.dwHeight = 480;
                    break;
                case (int)VIDEORESOLUTION.VIDEORESOLUTION_720X576:
                    VideoResolution.dwWidth = 720;
                    VideoResolution.dwHeight = 576;
                    VideoResolution.dwVideoResolution = 4;
                    break;



            }

            int b = AVerCapAPI.AVerSetVideoResolutionEx(m_hCaptureDevice, ref VideoResolution);
            
            uint dwFrameRate = 2500;
            int c = AVerCapAPI.AVerSetVideoInputFrameRate(m_hCaptureDevice, dwFrameRate);
            
            AVerCapAPI.AVerStartStreaming(m_hCaptureDevice);
            
        }
    }
}
