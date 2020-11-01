using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Spire.Pdf;
using CommonUtils.FileHelper;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Interop;
using Microsoft.Office;
using Microsoft.Office.Core;
using System.Web;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing;

namespace ConvertTool
{
    public partial class MainForm : Telerik.WinControls.UI.RadForm
    {
        private string sourchFilePath;
        private string currentSaveFilePath;
        private DocumentType documentType;
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        enum DocumentType
        {
            PdfToWord,
            PdfToExcel,
            PdfToPPT,
            WordToPDF,
            ExcelToPDF,
            PptToPDF
        }

        private void PDFToWord(string sourchFilePath)
        {
            if (sourchFilePath.Contains(".pdf"))
            {
                currentSaveFilePath = sourchFilePath.Replace(".pdf", "") + ".doc";
            }
            Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument();
            doc.LoadFromFile(sourchFilePath);
            doc.SaveToFile(currentSaveFilePath, FileFormat.DOCX);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ConvertJPG2PDF();
            //UnionPDF();
            this.menu_addFile.Click += Menu_addFile_Click;
            this.btn_startConvert.Click += Btn_startConvert_Click;
            this.radDock1.ActiveWindowChanged += RadDock1_ActiveWindowChanged;
        }

        private void UnionPDF()
        {
            var pdf1 = @"D:\WorkDocument\MyRepository\CommonRepository\MyToolProjects\Project\ConvertTool\ConvertTool\bin\Debug\pdf\pdf1.pdf";
            var pdf2 = @"D:\WorkDocument\MyRepository\CommonRepository\MyToolProjects\Project\ConvertTool\ConvertTool\bin\Debug\pdf\pdf2.pdf";
            string[] files = new string[] {pdf1, pdf2};
            string outputFile = @"D:\WorkDocument\MyRepository\CommonRepository\MyToolProjects\Project\ConvertTool\ConvertTool\bin\Debug\pdf\pdf3.pdf";
            Spire.Pdf.PdfDocumentBase doc = Spire.Pdf.PdfDocument.MergeFiles(files);
            doc.Save(outputFile, FileFormat.PDF);
            System.Diagnostics.Process.Start(outputFile);
        }

        void ConvertJPG2PDF()
        {
            var jpgfile = @"D:\WorkDocument\MyRepository\CommonRepository\MyToolProjects\Project\ConvertTool\ConvertTool\bin\Debug\pdf\img1.jpg";
            var pdffile = @"D:\WorkDocument\MyRepository\CommonRepository\MyToolProjects\Project\ConvertTool\ConvertTool\bin\Debug\pdf\img1.pdf";
            var document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 25, 25, 25, 25);
            using (var stream = new FileStream(pdffile, FileMode.Create))//, FileAccess.Write, FileShare.None
            {
                PdfWriter.GetInstance(document, stream);
                document.Open();
                AddImage2Document(document, jpgfile);
                document.Close();
            }
        }

        private void AddImage2Document(iTextSharp.text.Document document, string jpgfile)
        {
            using (var imageStream = new FileStream(jpgfile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                var image = iTextSharp.text.Image.GetInstance(imageStream);
                if (image.Height > iTextSharp.text.PageSize.A4.Height - 25)
                {
                    image.ScaleToFit(iTextSharp.text.PageSize.A4.Width - 25, iTextSharp.text.PageSize.A4.Height - 25);
                }
                else if (image.Width > iTextSharp.text.PageSize.A4.Width - 25)
                {
                    image.ScaleToFit(iTextSharp.text.PageSize.A4.Width - 25, iTextSharp.text.PageSize.A4.Height - 25);
                }
                image.Alignment = iTextSharp.text.Image.ALIGN_MIDDLE;
                document.Add(image);
            }
        }

        private void RadDock1_ActiveWindowChanged(object sender, Telerik.WinControls.UI.Docking.DockWindowEventArgs e)
        {
            if (this.radDock1.ActiveWindow == this.dtwordtopdf)
                this.documentType = DocumentType.WordToPDF;
            else if (this.radDock1.ActiveWindow == this.dtexceltopdf)
                this.documentType = DocumentType.ExcelToPDF;
            else if (this.radDock1.ActiveWindow == this.dtppttopdf)
                this.documentType = DocumentType.PptToPDF;
            else if (this.radDock1.ActiveWindow == this.dt_pdftoexcel)
                this.documentType = DocumentType.PdfToExcel;
            else if (this.radDock1.ActiveWindow == this.dt_pdftoppt)
                this.documentType = DocumentType.PdfToPPT;
            else if (this.radDock1.ActiveWindow == this.dt_pdftoword)
                this.documentType = DocumentType.PdfToWord;
        }

        private void Btn_startConvert_Click(object sender, EventArgs e)
        {
            if (this.documentType == DocumentType.PdfToWord)
                PDFToWord(sourchFilePath);
            else if (this.documentType == DocumentType.WordToPDF)
            {
                if (sourchFilePath.Contains(".doc"))
                {
                    currentSaveFilePath = sourchFilePath.Replace(".doc", "") + ".pdf";
                }
                else if (sourchFilePath.Contains(".docx"))
                {
                    currentSaveFilePath = sourchFilePath.Replace(".docx", "") + ".pdf";
                }
                WordConvertPDF(sourchFilePath,currentSaveFilePath,WdExportFormat.wdExportFormatPDF);
            }

            //是否启动
            if (MessageBox.Show("是否立即打开转换后的文件", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
                return;
            System.Diagnostics.Process.Start(currentSaveFilePath);
        }

        private void Menu_addFile_Click(object sender, EventArgs e)
        {
            FileContent fileContent = FileSelect.GetSelectFileContent("(*.*)|*.*","选择文件");
            sourchFilePath = fileContent.FileName;
        }

        #region office文件转换为pdf文件

        /// <summary>
        /// 将word文档转换成PDF格式
        /// </summary>
        /// <param name="sourcePath">源文件路径</param>
        /// <param name="targetPath">目标文件路径</param> 
        /// <param name="exportFormat"></param>
        /// <returns></returns>
        private bool WordConvertPDF(string sourcePath, string targetPath, Microsoft.Office.Interop.Word.WdExportFormat exportFormat)
        {
            bool result;
            object paramMissing = Type.Missing;
            Microsoft.Office.Interop.Word.ApplicationClass wordApplication = new Microsoft.Office.Interop.Word.ApplicationClass();
            Microsoft.Office.Interop.Word.Document wordDocument = null;
            try
            {
                object paramSourceDocPath = sourcePath;
                string paramExportFilePath = targetPath;

                Microsoft.Office.Interop.Word.WdExportFormat paramExportFormat = exportFormat;
                bool paramOpenAfterExport = false;
                Microsoft.Office.Interop.Word.WdExportOptimizeFor paramExportOptimizeFor =
                        Microsoft.Office.Interop.Word.WdExportOptimizeFor.wdExportOptimizeForPrint;
                Microsoft.Office.Interop.Word.WdExportRange paramExportRange = Microsoft.Office.Interop.Word.WdExportRange.wdExportAllDocument;
                int paramStartPage = 0;
                int paramEndPage = 0;
                Microsoft.Office.Interop.Word.WdExportItem paramExportItem = Microsoft.Office.Interop.Word.WdExportItem.wdExportDocumentContent;
                bool paramIncludeDocProps = true;
                bool paramKeepIRM = true;
                Microsoft.Office.Interop.Word.WdExportCreateBookmarks paramCreateBookmarks =
                        Microsoft.Office.Interop.Word.WdExportCreateBookmarks.wdExportCreateWordBookmarks;
                bool paramDocStructureTags = true;
                bool paramBitmapMissingFonts = true;
                bool paramUseISO19005_1 = false;

                wordDocument = wordApplication.Documents.Open(
                        ref paramSourceDocPath, ref paramMissing, ref paramMissing,
                        ref paramMissing, ref paramMissing, ref paramMissing,
                        ref paramMissing, ref paramMissing, ref paramMissing,
                        ref paramMissing, ref paramMissing, ref paramMissing,
                        ref paramMissing, ref paramMissing, ref paramMissing,
                        ref paramMissing);

                if (wordDocument != null)
                    wordDocument.ExportAsFixedFormat(paramExportFilePath,
                            paramExportFormat, paramOpenAfterExport,
                            paramExportOptimizeFor, paramExportRange, paramStartPage,
                            paramEndPage, paramExportItem, paramIncludeDocProps,
                            paramKeepIRM, paramCreateBookmarks, paramDocStructureTags,
                            paramBitmapMissingFonts, paramUseISO19005_1,
                            ref paramMissing);
                result = true;
            }
            finally
            {
                if (wordDocument != null)
                {
                    wordDocument.Close(ref paramMissing, ref paramMissing, ref paramMissing);
                    wordDocument = null;
                }
                if (wordApplication != null)
                {
                    wordApplication.Quit(ref paramMissing, ref paramMissing, ref paramMissing);
                    wordApplication = null;
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            return result;
        }

        /// <summary>
        /// 将excel文档转换成PDF格式
        /// </summary>
        /// <param name="sourcePath">源文件路径</param>
        /// <param name="targetPath">目标文件路径</param> 
        /// <param name="targetType"></param>
        /// <returns></returns>
        private bool ExcelConvertPDF(string sourcePath, string targetPath, XlFixedFormatType targetType)
        {
            bool result;
            object missing = Type.Missing;
            Microsoft.Office.Interop.Excel.ApplicationClass application = null;
            Workbook workBook = null;
            try
            {
                application = new Microsoft.Office.Interop.Excel.ApplicationClass();
                object target = targetPath;
                object type = targetType;
                workBook = application.Workbooks.Open(sourcePath, missing, missing, missing, missing, missing,
                        missing, missing, missing, missing, missing, missing, missing, missing, missing);

                workBook.ExportAsFixedFormat(targetType, target, XlFixedFormatQuality.xlQualityStandard, true, false, missing, missing, missing, missing);
                result = true;
            }
            catch
            {
                result = false;
            }
            finally
            {
                if (workBook != null)
                {
                    workBook.Close(true, missing, missing);
                    workBook = null;
                }
                if (application != null)
                {
                    application.Quit();
                    application = null;
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            return result;
        }

        /// <summary>
        /// 将ppt文档转换成pdf格式
        /// </summary>
        /// <param name="sourcePath">源文件路径</param>
        /// <param name="targetPath">目标文件路径</param> 
        /// <param name="targetFileType"></param>
        /// <returns></returns>
        private bool PPTConvertPDF(string sourcePath, string targetPath, PpSaveAsFileType targetFileType)
        {
            bool result;
            object missing = Type.Missing;
            Microsoft.Office.Interop.PowerPoint.ApplicationClass application = null;
            Presentation persentation = null;
            try
            {
                application = new Microsoft.Office.Interop.PowerPoint.ApplicationClass();
                //persentation = application.Presentations.Open(sourcePath, MsoTriState.msoTrue, MsoTriState.msoFalse, MsoTriState.msoFalse);
                //persentation.SaveAs(targetPath, targetFileType, Microsoft.Office.Core.MsoTriState.msoTrue);

                result = true;
            }
            catch
            {
                result = false;
            }
            finally
            {
                if (persentation != null)
                {
                    persentation.Close();
                    persentation = null;
                }
                if (application != null)
                {
                    application.Quit();
                    application = null;
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            return result;
        }

        #endregion
    }
}
