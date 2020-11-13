using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronOcr;
using System.Drawing.Imaging;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using asprise_ocr_api;
using Tesseract;
using Tesseract.Interop;
using System.IO;

namespace OCRDemo
{
    public partial class LigatureForm : Form
    {
        public LigatureForm()
        {
            InitializeComponent();
        }

        private void LigatureForm_Load(object sender, EventArgs e)
        {

        }

        private Bitmap GetBinaryzationImage1(Bitmap image)
        {
            Bitmap result = image.Clone() as Bitmap;
            // 计算灰度平均值
            List<int> tempList = new List<int>();
            for (int i = 0; i < result.Width; i++)
            {
                for (int j = 0; j < result.Height; j++)
                {
                    tempList.Add(result.GetPixel(i, j).R);
                }
            }
            double average = tempList.Average();


            Color color = new Color();
            for (int i = 0; i < result.Width; i++)
            {
                for (int j = 0; j < result.Height; j++)
                {
                    color = result.GetPixel(i, j);
                    if ((color.R + color.G + color.B) / 3 > average)
                    {
                        result.SetPixel(i, j, Color.White);
                    }
                    else
                    {
                        result.SetPixel(i, j, Color.Black);
                    }
                }
            }

            return result;
        }

        public static Bitmap ToGray(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    //获取该点的像素的RGB的颜色
                    Color color = bmp.GetPixel(i, j);
                    //利用公式计算灰度值
                    int gray = (int)(color.R * 0.3 + color.G * 0.59 + color.B * 0.11);
                    Color newColor = Color.FromArgb(gray, gray, gray);
                    bmp.SetPixel(i, j, newColor);
                }
            }
            return bmp;
        }

        public static Bitmap GrayReverse(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    //获取该点的像素的RGB的颜色
                    Color color = bmp.GetPixel(i, j);
                    Color newColor = Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
                    bmp.SetPixel(i, j, newColor);
                }
            }
            return bmp;
        }

        public static Bitmap ConvertTo1Bpp1(Bitmap bmp)
        {
            int average = 0;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    average += color.B;
                }
            }
            average = (int)average / (bmp.Width * bmp.Height);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    //获取该点的像素的RGB的颜色
                    Color color = bmp.GetPixel(i, j);
                    int value = 255 - color.B;
                    Color newColor = value > average ? Color.FromArgb(0, 0, 0) : Color.FromArgb(255, 255, 255);
                    bmp.SetPixel(i, j, newColor);
                }
            }
            return bmp;
        }

        public static Bitmap ConvertTo1Bpp2(Bitmap img)
        {
            int w = img.Width;
            int h = img.Height;
            Bitmap bmp = new Bitmap(w, h, PixelFormat.Format1bppIndexed);
            BitmapData data = bmp.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.ReadWrite, PixelFormat.Format1bppIndexed);
            for (int y = 0; y < h; y++)
            {
                byte[] scan = new byte[(w + 7) / 8];
                for (int x = 0; x < w; x++)
                {
                    Color c = img.GetPixel(x, y);
                    if (c.GetBrightness() >= 0.5) scan[x / 8] |= (byte)(0x80 >> (x % 8));
                }

                Marshal.Copy(scan, 0, (IntPtr)((int)data.Scan0 + data.Stride * y), scan.Length);
            }
            return bmp;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Bitmap a = new Bitmap(@"F:\files\tou\test.png");
            Bitmap b = ToGray(a);
            Bitmap c = GrayReverse(b);
            //Bitmap d = ConvertTo1Bpp1(c);
            Bitmap d = GetBinaryzationImage1(c);
            //d.Save(@"F:\files\tou\test.bmp");

            //string s = ocr.Recognize(@"d:\3.bmp", -1, -1, -1, -1, -1, AspriseOCR.RECOGNIZE_TYPE_ALL, AspriseOCR.OUTPUT_FORMAT_PLAINTEXT);
            //var Ocr = new AdvancedOcr()
            //{
            //    CleanBackgroundNoise = true,
            //    EnhanceContrast = true,
            //    EnhanceResolution = true,
            //    Language = IronOcr.Languages.English.OcrLanguagePack,
            //    Strategy = IronOcr.AdvancedOcr.OcrStrategy.Advanced,
            //    ColorSpace = AdvancedOcr.OcrColorSpace.Color,
            //    DetectWhiteTextOnDarkBackgrounds = true,
            //    InputImageType = AdvancedOcr.InputTypes.AutoDetect,
            //    RotateAndStraighten = true,
            //    ReadBarCodes = true,
            //    ColorDepth = 4
            //};
            var ocr = new AutoOcr();
            var Results = ocr.Read(d);
            Results.SaveAsTextFile(@"F:\files\tou\result.txt");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //识别英文效果好，中文不行
            AspriseOCR.SetUp();
            AspriseOCR ocr = new AspriseOCR();
            ocr.StartEngine("eng", AspriseOCR.SPEED_FASTEST);
            var jpgFile = @"F:\files\tou\test1.png";
            string s = ocr.Recognize(jpgFile, -1, -1, -1, -1, -1,
              AspriseOCR.RECOGNIZE_TYPE_ALL, AspriseOCR.OUTPUT_FORMAT_PLAINTEXT);
            // AspriseOCR.saveAocrXslTo("OCR Result: " + s);
            // process more images here ...
            MessageBox.Show(s);
            ocr.StopEngine();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TesseractEngine ocr;
            ocr = new TesseractEngine("./tessdata", "chi_sim");//设置语言   中文
            //ocr = new TesseractEngine("./tessdata", "eng", EngineMode.TesseractAndCube);//设置语言   英文
            //ocr = new TesseractEngine("./tessdata", "jpn");//设置语言   日语

            var jpgFile = @"F:\files\tou\test.png";
            Bitmap bit = new Bitmap(Image.FromFile(jpgFile));
            //bit = PreprocesImage(bit);//进行图像处理,如果识别率低可试试
            Page page = ocr.Process(bit);
            string str = page.GetText();//识别后的内容
            MessageBox.Show(str);
            page.Dispose();
        }

        //选图片并调用ocr识别方法
        private void btnRec_Click()
        {
            //OpenFileDialog1.Filter = "";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var imgPath = openFileDialog.FileName;
                //pictureBox1.Image = Image.FromFile(imgPath);
                string strResult = ImageToText(imgPath);
                if (string.IsNullOrEmpty(strResult))
                {
                    //txtResult.Text = "无法识别";
                }
                else
                {
                    //txtResult.Text = strResult;
                    MessageBox.Show(strResult);
                }
            }
        }
        //调用tesseract实现OCR识别
        public string ImageToText(string imgPath)
        {
            var tessdataPath = @"F:\work\MyRepository\CommonRepository\MyToolProjects\Project\OCRDemo-master\OCRDemo-master\OCRDemo\bin\Debug\tessdata";
            using (var engine = new TesseractEngine(tessdataPath, "chi_sim", EngineMode.Default))
            {
                using (var img = Pix.LoadFromFile(imgPath))
                {
                    using (var page = engine.Process(img))
                    {
                        return page.GetText();
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnRec_Click();
        }
    }
}
