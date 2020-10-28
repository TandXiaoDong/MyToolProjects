using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SpirePdfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //加载PDF文档
            var path = AppDomain.CurrentDomain.BaseDirectory + "pdftest.pdf";
            Spire.Pdf.PdfDocument sourceDocument = new Spire.Pdf.PdfDocument(path);
            //创建新PDF文档
            Spire.Pdf.PdfDocument newDocument = new Spire.Pdf.PdfDocument();
            //设置新文档页边距0
            newDocument.PageSettings.Margins.All = 0;
            //设置文档尺寸和源文件一样
            newDocument.PageSettings.Width = sourceDocument.Pages[0].Size.Width;
            newDocument.PageSettings.Height = sourceDocument.Pages[0].Size.Height;
            //删除第一页，破解水印
            newDocument.Pages.Add();
            newDocument.Pages.RemoveAt(0);
            //页面格式
            Spire.Pdf.Graphics.PdfTextLayout format = new Spire.Pdf.Graphics.PdfTextLayout();
            format.Break = Spire.Pdf.Graphics.PdfLayoutBreakType.FitPage;
            format.Layout = Spire.Pdf.Graphics.PdfLayoutType.Paginate;
            //将源文档每一页绘制到新文档
            foreach (Spire.Pdf.PdfPageBase sourcePage in sourceDocument.Pages)
            {
                //添加新页
                Spire.Pdf.PdfPageBase newPage = newDocument.Pages.Add();
                //创建绘制模板
                var template = sourcePage.CreateTemplate();
                //绘制源内容
                template.Draw(newPage, new PointF(0, 0), format);
                ////可以自由在新页绘制矩形、文字等信息
                //newPage.Canvas.DrawRectangle(Spire.Pdf.Graphics.PdfBrushes.White, new RectangleF(0, 0, 100, 100));
                //newPage.Canvas.DrawString("文字", new Spire.Pdf.Graphics.PdfFont(Spire.Pdf.Graphics.PdfFontFamily.Courier, 20f), Spire.Pdf.Graphics.PdfBrushes.White, new PointF(0, 0));
            }

            newDocument.SaveToFile(path.Replace("pdf", "docx"), Spire.Pdf.FileFormat.DOC);
        }
    }
}
