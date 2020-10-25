namespace PDF2Word
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
            this.materialTheme1 = new Telerik.WinControls.Themes.MaterialTheme();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radDock1 = new Telerik.WinControls.UI.Docking.RadDock();
            this.documentWindow1 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radPanorama1 = new Telerik.WinControls.UI.RadPanorama();
            this.tileGroupElement1 = new Telerik.WinControls.UI.TileGroupElement();
            this.radTileElement1 = new Telerik.WinControls.UI.RadTileElement();
            this.radTileElement2 = new Telerik.WinControls.UI.RadTileElement();
            this.radTileElement3 = new Telerik.WinControls.UI.RadTileElement();
            this.radTileElement4 = new Telerik.WinControls.UI.RadTileElement();
            this.documentContainer2 = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.documentTabStrip1 = new Telerik.WinControls.UI.Docking.DocumentTabStrip();
            this.documentWindow4 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.documentWindow3 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            this.documentWindow2 = new Telerik.WinControls.UI.Docking.DocumentWindow();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).BeginInit();
            this.radDock1.SuspendLayout();
            this.documentWindow1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer2)).BeginInit();
            this.documentContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).BeginInit();
            this.documentTabStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radMenu1
            // 
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(1008, 20);
            this.radMenu1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 588);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 141);
            this.panel1.TabIndex = 4;
            // 
            // radDock1
            // 
            this.radDock1.ActiveWindow = this.documentWindow2;
            this.radDock1.Controls.Add(this.documentContainer2);
            this.radDock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDock1.IsCleanUpTarget = true;
            this.radDock1.Location = new System.Drawing.Point(0, 20);
            this.radDock1.MainDocumentContainer = this.documentContainer2;
            this.radDock1.Name = "radDock1";
            this.radDock1.Padding = new System.Windows.Forms.Padding(0);
            // 
            // 
            // 
            this.radDock1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radDock1.Size = new System.Drawing.Size(1008, 568);
            this.radDock1.SplitterWidth = 8;
            this.radDock1.TabIndex = 5;
            this.radDock1.TabStop = false;
            this.radDock1.ThemeName = "MaterialTeal";
            // 
            // documentWindow1
            // 
            this.documentWindow1.Controls.Add(this.panel2);
            this.documentWindow1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.documentWindow1.Location = new System.Drawing.Point(4, 54);
            this.documentWindow1.Name = "documentWindow1";
            this.documentWindow1.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.documentWindow1.Size = new System.Drawing.Size(1000, 510);
            this.documentWindow1.Text = "PDF转换";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radPanorama1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 510);
            this.panel2.TabIndex = 0;
            // 
            // radPanorama1
            // 
            this.radPanorama1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.radPanorama1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanorama1.Groups.AddRange(new Telerik.WinControls.RadItem[] {
            this.tileGroupElement1});
            this.radPanorama1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radTileElement1,
            this.radTileElement2,
            this.radTileElement3,
            this.radTileElement4});
            this.radPanorama1.Location = new System.Drawing.Point(0, 0);
            this.radPanorama1.Name = "radPanorama1";
            this.radPanorama1.RowsCount = 2;
            this.radPanorama1.Size = new System.Drawing.Size(1000, 510);
            this.radPanorama1.TabIndex = 0;
            // 
            // tileGroupElement1
            // 
            this.tileGroupElement1.Name = "tileGroupElement1";
            this.tileGroupElement1.Text = "tileGroupElement1";
            // 
            // radTileElement1
            // 
            this.radTileElement1.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radTileElement1.CustomFontSize = 11F;
            this.radTileElement1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radTileElement1.Name = "radTileElement1";
            this.radTileElement1.Row = 1;
            this.radTileElement1.Text = "PDF转Word";
            // 
            // radTileElement2
            // 
            this.radTileElement2.Column = 1;
            this.radTileElement2.CustomFontSize = 11F;
            this.radTileElement2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radTileElement2.Name = "radTileElement2";
            this.radTileElement2.Row = 1;
            this.radTileElement2.Text = "PDF转Excel";
            // 
            // radTileElement3
            // 
            this.radTileElement3.Column = 2;
            this.radTileElement3.Name = "radTileElement3";
            this.radTileElement3.Row = 1;
            this.radTileElement3.Text = "radTileElement3";
            // 
            // radTileElement4
            // 
            this.radTileElement4.Column = 3;
            this.radTileElement4.Name = "radTileElement4";
            this.radTileElement4.Row = 1;
            this.radTileElement4.Text = "radTileElement4";
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
            this.documentContainer2.SplitterWidth = 8;
            this.documentContainer2.ThemeName = "MaterialTeal";
            // 
            // documentTabStrip1
            // 
            this.documentTabStrip1.CanUpdateChildIndex = true;
            this.documentTabStrip1.Controls.Add(this.documentWindow4);
            this.documentTabStrip1.Controls.Add(this.documentWindow3);
            this.documentTabStrip1.Controls.Add(this.documentWindow2);
            this.documentTabStrip1.Controls.Add(this.documentWindow1);
            this.documentTabStrip1.Location = new System.Drawing.Point(0, 0);
            this.documentTabStrip1.Name = "documentTabStrip1";
            // 
            // 
            // 
            this.documentTabStrip1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentTabStrip1.SelectedIndex = 2;
            this.documentTabStrip1.Size = new System.Drawing.Size(1008, 568);
            this.documentTabStrip1.TabIndex = 0;
            this.documentTabStrip1.TabStop = false;
            this.documentTabStrip1.ThemeName = "MaterialTeal";
            // 
            // documentWindow4
            // 
            this.documentWindow4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.documentWindow4.Location = new System.Drawing.Point(4, 54);
            this.documentWindow4.Name = "documentWindow4";
            this.documentWindow4.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.documentWindow4.Size = new System.Drawing.Size(1000, 510);
            this.documentWindow4.Text = "PDF编辑";
            // 
            // documentWindow3
            // 
            this.documentWindow3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.documentWindow3.Location = new System.Drawing.Point(4, 54);
            this.documentWindow3.Name = "documentWindow3";
            this.documentWindow3.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.documentWindow3.Size = new System.Drawing.Size(1000, 510);
            this.documentWindow3.Text = "PDF处理";
            // 
            // documentWindow2
            // 
            this.documentWindow2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.documentWindow2.Location = new System.Drawing.Point(4, 54);
            this.documentWindow2.Name = "documentWindow2";
            this.documentWindow2.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.TabbedDocument;
            this.documentWindow2.Size = new System.Drawing.Size(1000, 510);
            this.documentWindow2.Text = "转为PDF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.radDock1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radMenu1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDock1)).EndInit();
            this.radDock1.ResumeLayout(false);
            this.documentWindow1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanorama1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainer2)).EndInit();
            this.documentContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentTabStrip1)).EndInit();
            this.documentTabStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.MaterialTheme materialTheme1;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.Docking.RadDock radDock1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow4;
        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainer2;
        private Telerik.WinControls.UI.Docking.DocumentTabStrip documentTabStrip1;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow3;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow2;
        private Telerik.WinControls.UI.Docking.DocumentWindow documentWindow1;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadPanorama radPanorama1;
        private Telerik.WinControls.UI.RadTileElement radTileElement1;
        private Telerik.WinControls.UI.TileGroupElement tileGroupElement1;
        private Telerik.WinControls.UI.RadTileElement radTileElement2;
        private Telerik.WinControls.UI.RadTileElement radTileElement3;
        private Telerik.WinControls.UI.RadTileElement radTileElement4;
    }
}

