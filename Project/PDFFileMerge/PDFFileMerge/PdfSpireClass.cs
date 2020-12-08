using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Spire.Pdf;
using Spire.Pdf.Annotations;
using Spire.Pdf.Graphics;
using Spire.Pdf.Annotations.Appearance;


namespace PdfTestApp
{
    public class PdfSealClass
    {

        //-----注意项目的 目标框架 选择： .NetFramework 4 ,不要选择其他的。
     
        public bool SealOfPdfFile( string strPath)
        {
            PdfDocument doc = new PdfDocument();
            doc.LoadFromFile(strPath);//参数 strPath ： pdf文件的路径

            //get the page
            PdfPageBase page = doc.Pages[0];  //--PDF文件要添加图片的第几页。 目前测试20几页没有问题，无水印。 
            //get the image

            PdfImage image = PdfImage.FromFile(@"D:\W\图片\Seal.png");//---需要添加的图片
            float width = image.Width * 0.70f;
            float height = image.Height * 0.70f;
            //insert image
            page.Canvas.DrawImage(image, 100, 200, width, height); //---图片需要添加的位置

            string output = @"D:\W\Image02.pdf";//添加图片后的新pdf文件的路径
            //save pdf file
            doc.SaveToFile(output);
            doc.Close();
           return true;
        }

    }
}
