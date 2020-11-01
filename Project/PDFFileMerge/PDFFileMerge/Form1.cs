using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDFFileMerge.FileHelper;
using System.IO;
using Spire.Pdf;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PDFFileMerge
{
    public partial class Form1 : Form
    {
        private string currentSelectImagePath;
        private string currentSelectFilePath;
        private string exportImageDirPath;
        private string exportFileDirPath;
        private object obj = new object();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //UnionPDF();
            EventHandlers();
        }

        private void UnionPDF()
        {
            var pdf1 = @"D:\WorkDocument\MyRepository\CommonRepository\MyToolProjects\Project\ConvertTool\ConvertTool\bin\Debug\pdf\pdf1.pdf";
            var pdf2 = @"D:\WorkDocument\MyRepository\CommonRepository\MyToolProjects\Project\ConvertTool\ConvertTool\bin\Debug\pdf\pdf2.pdf";
            string[] files = new string[] { pdf1, pdf2 };
            string outputFile = @"D:\WorkDocument\MyRepository\CommonRepository\MyToolProjects\Project\ConvertTool\ConvertTool\bin\Debug\pdf\pdf3.pdf";
            Spire.Pdf.PdfDocumentBase doc = Spire.Pdf.PdfDocument.MergeFiles(files);
            doc.Save(outputFile, FileFormat.PDF);
            System.Diagnostics.Process.Start(outputFile);
        }

        private void EventHandlers()
        {
            #region image event 
            this.btn_exportPathImg.Click += Btn_exportPathImg_Click;
            this.btn_imgMerge.Click += Btn_imgMerge_Click;
            this.btn_selectImg.Click += Btn_selectImg_Click;
            this.btn_startMergeDir.Click += Btn_startMergeDir_Click;
            this.check_imgOrder.CheckedChanged += Check_imgOrder_CheckedChanged;
            this.check_imgReOrder.CheckedChanged += Check_imgReOrder_CheckedChanged;
            #endregion

            #region pdf file
            this.btn_exportPathFile.Click += Btn_exportPathFile_Click;
            this.btn_FileMerge.Click += Btn_FileMerge_Click;
            this.btn_selectFile.Click += Btn_selectFile_Click;
            this.btn_startMergeFileDir.Click += Btn_startMergeFileDir_Click;
            this.check_fileOrdr.CheckedChanged += Check_fileOrdr_CheckedChanged;
            this.check_fileReOrder.CheckedChanged += Check_fileReOrder_CheckedChanged;
            #endregion
        }

        private void Check_imgReOrder_CheckedChanged(object sender, EventArgs e)
        {
            this.check_imgOrder.Checked = !this.check_imgReOrder.Checked;
        }

        private void Check_imgOrder_CheckedChanged(object sender, EventArgs e)
        {
            this.check_imgReOrder.Checked = !this.check_imgOrder.Checked;
        }

        private void Check_fileOrdr_CheckedChanged(object sender, EventArgs e)
        {
            this.check_fileReOrder.Checked = !this.check_fileOrdr.Checked;
        }

        private void Check_fileReOrder_CheckedChanged(object sender, EventArgs e)
        {
            this.check_fileOrdr.Checked = !this.check_fileReOrder.Checked;
        }

        #region pdf file
        private void Btn_startMergeFileDir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.exportFileDirPath))
            {
                MessageBox.Show("当前路径为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            System.Diagnostics.Process.Start(this.exportFileDirPath);
        }

        private void Btn_selectFile_Click(object sender, EventArgs e)
        {
            this.currentSelectFilePath = FileSelect.GetDirectorPath();
            this.lbx_selectFile.Text = this.currentSelectFilePath;
        }

        private void Btn_FileMerge_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.currentSelectFilePath))
            {
                MessageBox.Show("文件夹路径不能为空！请重新选择要转换的文件目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(this.exportFileDirPath))
            {
                MessageBox.Show("保存路径不能为空！请重新合并后的文件路径！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.btn_FileMerge.Enabled = false;
            Task.Run(new Action(()=>
            {
                MergePDFFile(this.currentSelectFilePath, this.exportFileDirPath);
            })).Wait();
            this.btn_FileMerge.Enabled = true;
        }

        private void Btn_exportPathFile_Click(object sender, EventArgs e)
        {
            this.exportFileDirPath = FileSelect.GetDirectorPath();
            this.lbx_exportPathFile.Text = this.exportFileDirPath;
        }

        private void MergePDFFile(string sourceFilePath, string outPutPath)
        {
            var filePathList = ReadFile2List(sourceFilePath, 1);
            if (filePathList.Count <= 0)
            {
                MessageBox.Show("当前文件夹下没有可以合并的PDF文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var mergeFileName = this.tb_mergeFileName.Text.Trim();
            if (mergeFileName == "")
                mergeFileName = "00001";
            int mergeIndex = GetFileNameLastChar(mergeFileName);
            
            for (int i = 0; i < filePathList.Count; i += 2)
            {
                string[] files = new string[] { filePathList[i], filePathList[i + 1]};
                MergePDF(files, outPutPath + "\\" + mergeFileName + ".pdf");
                var oldMergeIndex = mergeIndex;
                if (this.check_fileOrdr.Checked)
                {
                    mergeIndex++;
                    mergeFileName = ReplaceNewFileNameByRaise(mergeFileName, mergeIndex);
                }
                else
                {
                    mergeIndex--;
                    mergeFileName = ReplaceNewFileNameByReserve(mergeFileName, oldMergeIndex, mergeIndex);
                }
            }
        }

        private string ReplaceNewFileNameByRaise(string mergeFileName, int newIndex)
        {
            mergeFileName = mergeFileName.Substring(0, mergeFileName.Length - newIndex.ToString().Length);
            mergeFileName += newIndex.ToString();
            return mergeFileName;
        }

        private string ReplaceNewFileNameByReserve(string mergeFileName,int oldIndex, int newIndex)
        {
            mergeFileName = mergeFileName.Substring(0, mergeFileName.Length - oldIndex.ToString().Length);
            mergeFileName += newIndex.ToString().PadLeft(oldIndex.ToString().Length, '0');
            return mergeFileName;
        }

        private int GetFileNameLastChar(string fileName)
        {
            if (fileName == "")
                return 1;
            var nameChar = fileName.ToArray();
            string valStr = "";
            for (int i = nameChar.Length - 1; i >= 0; i--)
            {
                int value;
                if (int.TryParse(nameChar[i].ToString(), out value))
                {
                    valStr += value.ToString();
                }
                else
                {
                    break;
                }
            }

            string startValStr = "";
            for (int i = valStr.Length - 1; i >= 0; i--)
            {
                startValStr += valStr[i];
            }
            int startValue;
            int.TryParse(startValStr, out startValue);
            return startValue;
        }

        private void MergePDF(string[] files, string outPutPath)
        {
            Spire.Pdf.PdfDocumentBase doc = Spire.Pdf.PdfDocument.MergeFiles(files);
            doc.Save(outPutPath, FileFormat.PDF);
        }

        #endregion

        #region image event
        private void Btn_startMergeDir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.exportImageDirPath))
            {
                MessageBox.Show("当前路径为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            System.Diagnostics.Process.Start(this.exportImageDirPath);
        }

        private void Btn_selectImg_Click(object sender, EventArgs e)
        {
            this.currentSelectImagePath = FileSelect.GetDirectorPath();
            this.lbx_selectImg.Text = this.currentSelectImagePath;
        }

        private void Btn_imgMerge_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.currentSelectImagePath))
            {
                MessageBox.Show("文件夹路径不能为空！请重新选择要转换的图片目录！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(this.exportImageDirPath))
            {
                MessageBox.Show("保存路径不能为空！请重新合并后的文件路径！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.btn_imgMerge.Enabled = false;
            Task.Run(new Action(()=>
            {
                ConvertMulJPG2PDF(this.currentSelectImagePath, this.exportImageDirPath);
            })).Wait();
            this.btn_imgMerge.Enabled = true;
        }

        private void Btn_exportPathImg_Click(object sender, EventArgs e)
        {
            this.exportImageDirPath = FileSelect.GetDirectorPath();
            this.lbx_exportPathImg.Text = this.exportImageDirPath;
        }

        private void ConvertMulJPG2PDF(string sourceImgPath, string targePdfFile)
        {
            var list = ReadFile2List(sourceImgPath, 0);
            if (list.Count <= 0)
            {
                MessageBox.Show("当前文件夹下没有可以合并的JPG图片！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var mergeFileName = this.tb_mergeImgName.Text.Trim();
            if (mergeFileName == "")
                mergeFileName = "00001";
            int mergeIndex = GetFileNameLastChar(mergeFileName);
            for (int i = 0; i < list.Count; i += 2)
            {
                Convert2JPG2PDF(targePdfFile + "\\" + mergeFileName + ".pdf", list[i], list[i + 1]);
                var oldMergeIndex = mergeIndex;
                if (this.check_imgOrder.Checked)
                {
                    mergeIndex++;
                    mergeFileName = ReplaceNewFileNameByRaise(mergeFileName, mergeIndex);
                }
                else
                {
                    mergeIndex--;
                    mergeFileName = ReplaceNewFileNameByReserve(mergeFileName, oldMergeIndex, mergeIndex);
                }
            }
        }

        private List<string> ReadFile2List(string fileName, int fileType)
        {
            List<string> list = new List<string>();
            DirectoryInfo dirInfo = new DirectoryInfo(fileName);
            FileInfo[] fileInfos = dirInfo.GetFiles("*.*");
            if (fileInfos.Length <= 0)
            {
                MessageBox.Show("文件夹内容为空！没有可以转换的文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return list;
            }
            //fileInfos = fileInfos.OrderBy(y => y.Name, new FileComparer()).ToArray();
            //SortAsFileName(ref fileInfos);
            List<FileInfo> lists = new List<FileInfo>();
            lists.AddRange(fileInfos);
            lists.Sort(CompareFilename);

            foreach (var file in lists)
            {
                if (fileType == 0)//image
                {
                    if (file.Extension.ToLower() == ".jpg")
                    {
                        list.Add(file.FullName);
                    }
                }
                else if (fileType == 1)//pdf
                {
                    if (file.Extension.ToLower() == ".pdf")
                    {
                        list.Add(file.FullName);
                    }
                }
            }

            return list;
        }

        /// <summary>
        　　/// C#按文件名排序（顺序）
        　　/// </summary>
        　　/// <param name="arrFi">待排序数组</param>
        private void SortAsFileName(ref FileInfo[] arrFi)
        {
            Array.Sort(arrFi, delegate (FileInfo x, FileInfo y) { return x.Name.CompareTo(y.Name); });
        }

        [System.Runtime.InteropServices.DllImport("Shlwapi.dll", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
        private static extern int StrCmpLogicalW(string psz1, string psz2);

        public int CompareFilename(FileInfo obj1, FileInfo obj2)
        {
            int res = 0;
            if ((obj1 == null) && (obj2 == null))
            {
                return 0;
            }
            else if ((obj1 != null) && (obj2 == null))
            {
                return 1;
            }
            else if ((obj1 == null) && (obj2 != null))
            {
                return -1;
            }
            if (obj1.DirectoryName == obj2.DirectoryName)
            {
                res = StrCmpLogicalW(obj1.Name, obj2.Name);
            }
            else
            {
                res = obj1.DirectoryName.CompareTo(obj2.DirectoryName);
            }
            return res;
        }

        private void Convert2JPG2PDF(string targePdfFile, string imgFile1, string imgFile2)
        {
            iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 25, 25, 25, 25);
            using (var stream = new FileStream(targePdfFile, FileMode.Create))
            {
                PdfWriter.GetInstance(document, stream);
                document.Open();
                AddImgToPDFDocument(imgFile1, document);
                AddImgToPDFDocument(imgFile2, document);
                document.Close();
            }
        }

        private void AddImgToPDFDocument(string jpgfile, iTextSharp.text.Document document)
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

        #endregion
    }
}
