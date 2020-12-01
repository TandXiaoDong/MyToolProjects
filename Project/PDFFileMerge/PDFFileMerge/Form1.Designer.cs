namespace PDFFileMerge
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_selectImg = new System.Windows.Forms.Button();
            this.btn_imgMerge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_mergeImgName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Image = new System.Windows.Forms.TabPage();
            this.btn_startMergeDir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.check_imgReOrder = new System.Windows.Forms.CheckBox();
            this.check_imgOrder = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_exportPathImg = new System.Windows.Forms.Button();
            this.lbx_exportPathImg = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbx_selectImg = new System.Windows.Forms.Label();
            this.tab_File = new System.Windows.Forms.TabPage();
            this.btn_startMergeFileDir = new System.Windows.Forms.Button();
            this.btn_FileMerge = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.check_fileReOrder = new System.Windows.Forms.CheckBox();
            this.check_fileOrdr = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_mergeFileName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_exportPathFile = new System.Windows.Forms.Button();
            this.lbx_exportPathFile = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_selectFile = new System.Windows.Forms.Button();
            this.lbx_selectFile = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_Image.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tab_File.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_selectImg
            // 
            this.btn_selectImg.Location = new System.Drawing.Point(207, 36);
            this.btn_selectImg.Name = "btn_selectImg";
            this.btn_selectImg.Size = new System.Drawing.Size(75, 23);
            this.btn_selectImg.TabIndex = 0;
            this.btn_selectImg.Text = "选择";
            this.btn_selectImg.UseVisualStyleBackColor = true;
            // 
            // btn_imgMerge
            // 
            this.btn_imgMerge.Location = new System.Drawing.Point(210, 302);
            this.btn_imgMerge.Name = "btn_imgMerge";
            this.btn_imgMerge.Size = new System.Drawing.Size(75, 23);
            this.btn_imgMerge.TabIndex = 1;
            this.btn_imgMerge.Text = "合并";
            this.btn_imgMerge.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "合并文件名：";
            // 
            // tb_mergeImgName
            // 
            this.tb_mergeImgName.Location = new System.Drawing.Point(103, 37);
            this.tb_mergeImgName.Name = "tb_mergeImgName";
            this.tb_mergeImgName.Size = new System.Drawing.Size(179, 21);
            this.tb_mergeImgName.TabIndex = 3;
            this.tb_mergeImgName.Text = "000001";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Image);
            this.tabControl1.Controls.Add(this.tab_File);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 398);
            this.tabControl1.TabIndex = 4;
            // 
            // tab_Image
            // 
            this.tab_Image.BackColor = System.Drawing.SystemColors.Control;
            this.tab_Image.Controls.Add(this.btn_startMergeDir);
            this.tab_Image.Controls.Add(this.groupBox3);
            this.tab_Image.Controls.Add(this.groupBox2);
            this.tab_Image.Controls.Add(this.groupBox1);
            this.tab_Image.Controls.Add(this.btn_imgMerge);
            this.tab_Image.Location = new System.Drawing.Point(4, 24);
            this.tab_Image.Name = "tab_Image";
            this.tab_Image.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Image.Size = new System.Drawing.Size(628, 370);
            this.tab_Image.TabIndex = 0;
            this.tab_Image.Text = "合并图片";
            // 
            // btn_startMergeDir
            // 
            this.btn_startMergeDir.Location = new System.Drawing.Point(375, 302);
            this.btn_startMergeDir.Name = "btn_startMergeDir";
            this.btn_startMergeDir.Size = new System.Drawing.Size(128, 23);
            this.btn_startMergeDir.TabIndex = 10;
            this.btn_startMergeDir.Text = "打开合并目录";
            this.btn_startMergeDir.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.check_imgReOrder);
            this.groupBox3.Controls.Add(this.check_imgOrder);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tb_mergeImgName);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(3, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(622, 106);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "自定义合并参数";
            // 
            // check_imgReOrder
            // 
            this.check_imgReOrder.AutoSize = true;
            this.check_imgReOrder.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check_imgReOrder.Location = new System.Drawing.Point(459, 46);
            this.check_imgReOrder.Name = "check_imgReOrder";
            this.check_imgReOrder.Size = new System.Drawing.Size(54, 18);
            this.check_imgReOrder.TabIndex = 7;
            this.check_imgReOrder.Text = "倒叙";
            this.check_imgReOrder.UseVisualStyleBackColor = true;
            // 
            // check_imgOrder
            // 
            this.check_imgOrder.AutoSize = true;
            this.check_imgOrder.Checked = true;
            this.check_imgOrder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_imgOrder.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check_imgOrder.Location = new System.Drawing.Point(372, 46);
            this.check_imgOrder.Name = "check_imgOrder";
            this.check_imgOrder.Size = new System.Drawing.Size(54, 18);
            this.check_imgOrder.TabIndex = 6;
            this.check_imgOrder.Text = "正序";
            this.check_imgOrder.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(20, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 10);
            this.label2.TabIndex = 4;
            this.label2.Text = "说明：自定义合并后的起始文件名，后续文件名依次增加序号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_exportPathImg);
            this.groupBox2.Controls.Add(this.lbx_exportPathImg);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(3, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(622, 78);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置合并后的路径";
            // 
            // btn_exportPathImg
            // 
            this.btn_exportPathImg.Location = new System.Drawing.Point(207, 36);
            this.btn_exportPathImg.Name = "btn_exportPathImg";
            this.btn_exportPathImg.Size = new System.Drawing.Size(75, 23);
            this.btn_exportPathImg.TabIndex = 7;
            this.btn_exportPathImg.Text = "浏览";
            this.btn_exportPathImg.UseVisualStyleBackColor = true;
            // 
            // lbx_exportPathImg
            // 
            this.lbx_exportPathImg.AutoSize = true;
            this.lbx_exportPathImg.Location = new System.Drawing.Point(288, 47);
            this.lbx_exportPathImg.Name = "lbx_exportPathImg";
            this.lbx_exportPathImg.Size = new System.Drawing.Size(41, 12);
            this.lbx_exportPathImg.TabIndex = 6;
            this.lbx_exportPathImg.Text = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_selectImg);
            this.groupBox1.Controls.Add(this.lbx_selectImg);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 82);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择要合并的图片文件夹";
            // 
            // lbx_selectImg
            // 
            this.lbx_selectImg.AutoSize = true;
            this.lbx_selectImg.Location = new System.Drawing.Point(288, 47);
            this.lbx_selectImg.Name = "lbx_selectImg";
            this.lbx_selectImg.Size = new System.Drawing.Size(41, 12);
            this.lbx_selectImg.TabIndex = 5;
            this.lbx_selectImg.Text = "label3";
            // 
            // tab_File
            // 
            this.tab_File.BackColor = System.Drawing.SystemColors.Control;
            this.tab_File.Controls.Add(this.btn_startMergeFileDir);
            this.tab_File.Controls.Add(this.btn_FileMerge);
            this.tab_File.Controls.Add(this.groupBox6);
            this.tab_File.Controls.Add(this.groupBox5);
            this.tab_File.Controls.Add(this.groupBox4);
            this.tab_File.Location = new System.Drawing.Point(4, 24);
            this.tab_File.Name = "tab_File";
            this.tab_File.Padding = new System.Windows.Forms.Padding(3);
            this.tab_File.Size = new System.Drawing.Size(628, 370);
            this.tab_File.TabIndex = 1;
            this.tab_File.Text = "合并PDF文件";
            // 
            // btn_startMergeFileDir
            // 
            this.btn_startMergeFileDir.Location = new System.Drawing.Point(375, 302);
            this.btn_startMergeFileDir.Name = "btn_startMergeFileDir";
            this.btn_startMergeFileDir.Size = new System.Drawing.Size(128, 23);
            this.btn_startMergeFileDir.TabIndex = 12;
            this.btn_startMergeFileDir.Text = "打开合并目录";
            this.btn_startMergeFileDir.UseVisualStyleBackColor = true;
            // 
            // btn_FileMerge
            // 
            this.btn_FileMerge.Location = new System.Drawing.Point(210, 302);
            this.btn_FileMerge.Name = "btn_FileMerge";
            this.btn_FileMerge.Size = new System.Drawing.Size(75, 23);
            this.btn_FileMerge.TabIndex = 11;
            this.btn_FileMerge.Text = "合并";
            this.btn_FileMerge.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.check_fileReOrder);
            this.groupBox6.Controls.Add(this.check_fileOrdr);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.tb_mergeFileName);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.Location = new System.Drawing.Point(3, 163);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(622, 106);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "自定义合并参数";
            // 
            // check_fileReOrder
            // 
            this.check_fileReOrder.AutoSize = true;
            this.check_fileReOrder.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check_fileReOrder.Location = new System.Drawing.Point(461, 39);
            this.check_fileReOrder.Name = "check_fileReOrder";
            this.check_fileReOrder.Size = new System.Drawing.Size(54, 18);
            this.check_fileReOrder.TabIndex = 8;
            this.check_fileReOrder.Text = "倒叙";
            this.check_fileReOrder.UseVisualStyleBackColor = true;
            // 
            // check_fileOrdr
            // 
            this.check_fileOrdr.AutoSize = true;
            this.check_fileOrdr.Checked = true;
            this.check_fileOrdr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_fileOrdr.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.check_fileOrdr.Location = new System.Drawing.Point(372, 39);
            this.check_fileOrdr.Name = "check_fileOrdr";
            this.check_fileOrdr.Size = new System.Drawing.Size(54, 18);
            this.check_fileOrdr.TabIndex = 5;
            this.check_fileOrdr.Text = "正序";
            this.check_fileOrdr.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "合并文件名：";
            // 
            // tb_mergeFileName
            // 
            this.tb_mergeFileName.Location = new System.Drawing.Point(103, 37);
            this.tb_mergeFileName.Name = "tb_mergeFileName";
            this.tb_mergeFileName.Size = new System.Drawing.Size(179, 21);
            this.tb_mergeFileName.TabIndex = 3;
            this.tb_mergeFileName.Text = "000001";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(20, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 10);
            this.label6.TabIndex = 4;
            this.label6.Text = "说明：自定义合并后的起始文件名，后续文件名依次增加序号";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_exportPathFile);
            this.groupBox5.Controls.Add(this.lbx_exportPathFile);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.Location = new System.Drawing.Point(3, 85);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(622, 78);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "设置合并后的路径";
            // 
            // btn_exportPathFile
            // 
            this.btn_exportPathFile.Location = new System.Drawing.Point(207, 36);
            this.btn_exportPathFile.Name = "btn_exportPathFile";
            this.btn_exportPathFile.Size = new System.Drawing.Size(75, 23);
            this.btn_exportPathFile.TabIndex = 7;
            this.btn_exportPathFile.Text = "浏览";
            this.btn_exportPathFile.UseVisualStyleBackColor = true;
            // 
            // lbx_exportPathFile
            // 
            this.lbx_exportPathFile.AutoSize = true;
            this.lbx_exportPathFile.Location = new System.Drawing.Point(288, 47);
            this.lbx_exportPathFile.Name = "lbx_exportPathFile";
            this.lbx_exportPathFile.Size = new System.Drawing.Size(41, 12);
            this.lbx_exportPathFile.TabIndex = 6;
            this.lbx_exportPathFile.Text = "label4";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_selectFile);
            this.groupBox4.Controls.Add(this.lbx_selectFile);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(622, 82);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "选择要合并的PDF文件夹";
            // 
            // btn_selectFile
            // 
            this.btn_selectFile.Location = new System.Drawing.Point(207, 36);
            this.btn_selectFile.Name = "btn_selectFile";
            this.btn_selectFile.Size = new System.Drawing.Size(75, 23);
            this.btn_selectFile.TabIndex = 0;
            this.btn_selectFile.Text = "选择";
            this.btn_selectFile.UseVisualStyleBackColor = true;
            // 
            // lbx_selectFile
            // 
            this.lbx_selectFile.AutoSize = true;
            this.lbx_selectFile.Location = new System.Drawing.Point(288, 47);
            this.lbx_selectFile.Name = "lbx_selectFile";
            this.lbx_selectFile.Size = new System.Drawing.Size(41, 12);
            this.lbx_selectFile.TabIndex = 5;
            this.lbx_selectFile.Text = "label3";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(628, 370);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "合并相同文件";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button3);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(622, 150);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "选择要合并的PDF文件夹";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "文件夹1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button2);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox8.Location = new System.Drawing.Point(3, 153);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(622, 91);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "设置合并后的路径";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(207, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "浏览";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(207, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "文件夹2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(375, 302);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "打开合并目录";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(210, 302);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "合并";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(628, 370);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "自定义合并";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(303, 88);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 398);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF文件合并";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_Image.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_File.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_selectImg;
        private System.Windows.Forms.Button btn_imgMerge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_mergeImgName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Image;
        private System.Windows.Forms.TabPage tab_File;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbx_selectImg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_exportPathImg;
        private System.Windows.Forms.Label lbx_exportPathImg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_startMergeDir;
        private System.Windows.Forms.Button btn_startMergeFileDir;
        private System.Windows.Forms.Button btn_FileMerge;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_mergeFileName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_exportPathFile;
        private System.Windows.Forms.Label lbx_exportPathFile;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_selectFile;
        private System.Windows.Forms.Label lbx_selectFile;
        private System.Windows.Forms.CheckBox check_fileOrdr;
        private System.Windows.Forms.CheckBox check_imgOrder;
        private System.Windows.Forms.CheckBox check_imgReOrder;
        private System.Windows.Forms.CheckBox check_fileReOrder;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button6;
    }
}

