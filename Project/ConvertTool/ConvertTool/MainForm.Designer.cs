namespace ConvertTool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn1 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_startConvert = new Telerik.WinControls.UI.RadButton();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radCheckBox1 = new Telerik.WinControls.UI.RadCheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.menu_addFile = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            this.dtexceltopdf = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.documentContainer2 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.dtppttopdf = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.dtwordtopdf = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.dt_pdftoppt = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.dt_pdftoexcel = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.dt_pdftoword = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radCheckBoxElement1 = new Telerik.WinControls.UI.RadCheckBoxElement();
            this.radProgressBarElement1 = new Telerik.WinControls.UI.RadProgressBarElement();
            this.breezeTheme1 = new Telerik.WinControls.Themes.BreezeTheme();
            this.crystalTheme1 = new Telerik.WinControls.Themes.CrystalTheme();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_startConvert)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
            this.radDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer2)).BeginInit();
            this.documentContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
            this.documentTabStrip1.SuspendLayout();
            this.dt_pdftoword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_startConvert);
            this.panel1.Controls.Add(this.radButton1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radCheckBox1);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 100);
            this.panel1.TabIndex = 1;
            // 
            // btn_startConvert
            // 
            this.btn_startConvert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startConvert.Location = new System.Drawing.Point(674, 31);
            this.btn_startConvert.Name = "btn_startConvert";
            this.btn_startConvert.Size = new System.Drawing.Size(110, 39);
            this.btn_startConvert.TabIndex = 8;
            this.btn_startConvert.Text = "开始转换";
            this.btn_startConvert.ThemeName = "Breeze";
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(428, 50);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(55, 24);
            this.radButton1.TabIndex = 7;
            this.radButton1.Text = "选择";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "路径";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(90, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(263, 20);
            this.comboBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "输出目录：";
            // 
            // radCheckBox1
            // 
            this.radCheckBox1.Location = new System.Drawing.Point(428, 18);
            this.radCheckBox1.Name = "radCheckBox1";
            this.radCheckBox1.Size = new System.Drawing.Size(115, 18);
            this.radCheckBox1.TabIndex = 3;
            this.radCheckBox1.Text = "提取图片中的文字";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(370, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(33, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "设置";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "输出格式：";
            // 
            // radMenu1
            // 
            this.radMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.menu_addFile,
            this.radMenuItem1});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(927, 36);
            this.radMenu1.TabIndex = 3;
            // 
            // menu_addFile
            // 
            this.menu_addFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menu_addFile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_addFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menu_addFile.Image = global::ConvertTool.Properties.Resources.bullet_add;
            this.menu_addFile.Name = "menu_addFile";
            this.menu_addFile.Text = "添加文件";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "视图管理器";
            // 
            // radDock1
            // 
            this.radDock1.ActiveWindow = this.dt_pdftoword;
            this.radDock1.Controls.Add(this.documentContainer2);
            this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDock1.IsCleanUpTarget = true;
            this.radDock1.Location = new System.Drawing.Point(0, 36);
            this.radDock1.MainDocumentContainer = this.documentContainer2;
            this.radDock1.Name = "radDock1";
            this.radDock1.Padding = new System.Windows.Forms.Padding(0);
            // 
            // 
            // 
            this.radDock1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radDock1.Size = new System.Drawing.Size(927, 411);
            this.radDock1.TabIndex = 4;
            this.radDock1.TabStop = false;
            this.radDock1.ThemeName = "Breeze";
            // 
            // dtexceltopdf
            // 
            this.dtexceltopdf.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtexceltopdf.Location = new System.Drawing.Point(5, 27);
            this.dtexceltopdf.Name = "dtexceltopdf";
            this.dtexceltopdf.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.dtexceltopdf.Size = new System.Drawing.Size(917, 379);
            this.dtexceltopdf.Text = "EXCEL转PDF";
            // 
            // documentContainer2
            // 
            this.documentContainer2.Controls.Add(this.documentTabStrip1);
            this.documentContainer2.Name = "documentContainer2";
            // 
            // 
            // 
            this.documentContainer2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentContainer2.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainer2.ThemeName = "Breeze";
            // 
            // documentTabStrip1
            // 
            this.documentTabStrip1.CanUpdateChildIndex = true;
            this.documentTabStrip1.Controls.Add(this.dtexceltopdf);
            this.documentTabStrip1.Controls.Add(this.dtppttopdf);
            this.documentTabStrip1.Controls.Add(this.dtwordtopdf);
            this.documentTabStrip1.Controls.Add(this.dt_pdftoppt);
            this.documentTabStrip1.Controls.Add(this.dt_pdftoexcel);
            this.documentTabStrip1.Controls.Add(this.dt_pdftoword);
            this.documentTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            this.documentTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentTabStrip1.SelectedIndex = 5;
            this.documentTabStrip1.Size = new System.Drawing.Size(927, 411);
            this.documentTabStrip1.TabIndex = 0;
            this.documentTabStrip1.TabStop = false;
            this.documentTabStrip1.ThemeName = "Breeze";
            // 
            // dtppttopdf
            // 
            this.dtppttopdf.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtppttopdf.Location = new System.Drawing.Point(5, 27);
            this.dtppttopdf.Name = "dtppttopdf";
            this.dtppttopdf.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.dtppttopdf.Size = new System.Drawing.Size(917, 379);
            this.dtppttopdf.Text = "PPT转PDF";
            // 
            // dtwordtopdf
            // 
            this.dtwordtopdf.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtwordtopdf.Location = new System.Drawing.Point(5, 27);
            this.dtwordtopdf.Name = "dtwordtopdf";
            this.dtwordtopdf.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.dtwordtopdf.Size = new System.Drawing.Size(917, 379);
            this.dtwordtopdf.Text = "Word转PDF";
            // 
            // dt_pdftoppt
            // 
            this.dt_pdftoppt.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dt_pdftoppt.Location = new System.Drawing.Point(5, 27);
            this.dt_pdftoppt.Name = "dt_pdftoppt";
            this.dt_pdftoppt.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.dt_pdftoppt.Size = new System.Drawing.Size(917, 379);
            this.dt_pdftoppt.Text = "PDF转PPT";
            // 
            // dt_pdftoexcel
            // 
            this.dt_pdftoexcel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dt_pdftoexcel.Location = new System.Drawing.Point(5, 27);
            this.dt_pdftoexcel.Name = "dt_pdftoexcel";
            this.dt_pdftoexcel.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.dt_pdftoexcel.Size = new System.Drawing.Size(917, 379);
            this.dt_pdftoexcel.Text = "PDF转Excel";
            // 
            // dt_pdftoword
            // 
            this.dt_pdftoword.Controls.Add(this.radGridView1);
            this.dt_pdftoword.Controls.Add(this.radStatusStrip1);
            this.dt_pdftoword.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dt_pdftoword.Location = new System.Drawing.Point(5, 27);
            this.dt_pdftoword.Name = "dt_pdftoword";
            this.dt_pdftoword.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.dt_pdftoword.Size = new System.Drawing.Size(917, 379);
            this.dt_pdftoword.Text = "PDF转Word";
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.Color.White;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.Color.White;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(0, 24);
            // 
            // 
            // 
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.HeaderText = "选择";
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "columnCheck";
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.HeaderText = "文件名";
            gridViewTextBoxColumn1.Name = "columnFilaName";
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.HeaderText = "总页数";
            gridViewTextBoxColumn2.Name = "columnTotalPage";
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.HeaderText = "操作起始页";
            gridViewTextBoxColumn3.Name = "columnStartPage";
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.HeaderText = "操作结束页";
            gridViewTextBoxColumn4.Name = "columnEndPage";
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.HeaderText = "状态";
            gridViewTextBoxColumn5.Name = "columnStatus";
            gridViewImageColumn1.EnableExpressionEditor = false;
            gridViewImageColumn1.HeaderText = "操作";
            gridViewImageColumn1.Name = "columnDelete";
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewImageColumn1});
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(917, 355);
            this.radGridView1.TabIndex = 2;
            this.radGridView1.ThemeName = "Breeze";
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radCheckBoxElement1,
            this.radProgressBarElement1});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 0);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(917, 24);
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.ThemeName = "Breeze";
            // 
            // radCheckBoxElement1
            // 
            this.radCheckBoxElement1.Checked = false;
            this.radCheckBoxElement1.Name = "radCheckBoxElement1";
            this.radCheckBoxElement1.ReadOnly = false;
            this.radStatusStrip1.SetSpring(this.radCheckBoxElement1, false);
            this.radCheckBoxElement1.Text = "全选";
            // 
            // radProgressBarElement1
            // 
            this.radProgressBarElement1.Name = "radProgressBarElement1";
            this.radProgressBarElement1.SeparatorColor1 = System.Drawing.Color.White;
            this.radProgressBarElement1.SeparatorColor2 = System.Drawing.Color.White;
            this.radProgressBarElement1.SeparatorColor3 = System.Drawing.Color.White;
            this.radProgressBarElement1.SeparatorColor4 = System.Drawing.Color.White;
            this.radProgressBarElement1.SeparatorGradientAngle = 0;
            this.radProgressBarElement1.SeparatorGradientPercentage1 = 0.4F;
            this.radProgressBarElement1.SeparatorGradientPercentage2 = 0.6F;
            this.radProgressBarElement1.SeparatorNumberOfColors = 2;
            this.radStatusStrip1.SetSpring(this.radProgressBarElement1, false);
            this.radProgressBarElement1.StepWidth = 14;
            this.radProgressBarElement1.SweepAngle = 90;
            this.radProgressBarElement1.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(927, 547);
            this.Controls.Add(this.radDock1);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "文档格式转换工具";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_startConvert)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCheckBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
            this.radDock1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer2)).EndInit();
            this.documentContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
            this.documentTabStrip1.ResumeLayout(false);
            this.dt_pdftoword.ResumeLayout(false);
            this.dt_pdftoword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadCheckBox radCheckBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem menu_addFile;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentWindow dtexceltopdf;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer2;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.DocumentWindow dtppttopdf;
        private Telerik.WinControls.UI.Docking.DocumentWindow dtwordtopdf;
        private Telerik.WinControls.UI.Docking.DocumentWindow dt_pdftoppt;
        private Telerik.WinControls.UI.Docking.DocumentWindow dt_pdftoexcel;
        private Telerik.WinControls.UI.Docking.DocumentWindow dt_pdftoword;
        private Telerik.WinControls.Themes.BreezeTheme breezeTheme1;
        private Telerik.WinControls.Themes.CrystalTheme crystalTheme1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadCheckBoxElement radCheckBoxElement1;
        private Telerik.WinControls.UI.RadProgressBarElement radProgressBarElement1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadButton btn_startConvert;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
    }
}
