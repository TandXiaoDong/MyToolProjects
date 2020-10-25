using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using WindowsFormTelerik.GridViewExportData;

namespace PDF2Word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var path = @"F:\pdftest\20200718竞赛题库（仅供参考）已查.pdf";
            if (!System.IO.File.Exists(path))
                return;
            PDFHelper pdf = new PDFHelper();
            pdf.PDF2Word(path);
        }
    }
}
