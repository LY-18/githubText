namespace DataDetectionSystem
{
    partial class ResultUserControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TopMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ConventionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNullPage = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CatalogDes = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.HookCatalog = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.FullHook = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FileSusSize = new System.Windows.Forms.Label();
            this.lblFailLength = new System.Windows.Forms.Label();
            this.LackPage = new System.Windows.Forms.Label();
            this.lblDPI = new System.Windows.Forms.Label();
            this.lblShortOfPages = new System.Windows.Forms.Label();
            this.FilePassSize = new System.Windows.Forms.Label();
            this.lblPassedLength = new System.Windows.Forms.Label();
            this.FileRepeat = new System.Windows.Forms.Label();
            this.lblRepeatCount = new System.Windows.Forms.Label();
            this.FilePassNun = new System.Windows.Forms.Label();
            this.FileFailNum = new System.Windows.Forms.Label();
            this.lblPassedCount = new System.Windows.Forms.Label();
            this.lblFailCount = new System.Windows.Forms.Label();
            this.FileSize = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.FileNum = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopMenuStrip
            // 
            this.TopMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(128)))), ((int)(((byte)(172)))));
            this.TopMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TopMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConventionalToolStripMenuItem,
            this.VideoToolStripMenuItem,
            this.DetailToolStripMenuItem,
            this.PrintToolStripMenuItem});
            this.TopMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TopMenuStrip.Name = "TopMenuStrip";
            this.TopMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.TopMenuStrip.Size = new System.Drawing.Size(1109, 28);
            this.TopMenuStrip.TabIndex = 0;
            this.TopMenuStrip.Text = "menuStrip1";
            // 
            // ConventionalToolStripMenuItem
            // 
            this.ConventionalToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.ConventionalToolStripMenuItem.Name = "ConventionalToolStripMenuItem";
            this.ConventionalToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.ConventionalToolStripMenuItem.Text = "常规";
            this.ConventionalToolStripMenuItem.Visible = false;
            // 
            // VideoToolStripMenuItem
            // 
            this.VideoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.VideoToolStripMenuItem.Name = "VideoToolStripMenuItem";
            this.VideoToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.VideoToolStripMenuItem.Text = "视频";
            this.VideoToolStripMenuItem.Visible = false;
            // 
            // DetailToolStripMenuItem
            // 
            this.DetailToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.DetailToolStripMenuItem.Name = "DetailToolStripMenuItem";
            this.DetailToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.DetailToolStripMenuItem.Text = "详细报告";
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.PrintToolStripMenuItem.Text = "打印报表";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNullPage);
            this.panel1.Controls.Add(this.chart);
            this.panel1.Controls.Add(this.CatalogDes);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.HookCatalog);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.FullHook);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.FileSusSize);
            this.panel1.Controls.Add(this.lblFailLength);
            this.panel1.Controls.Add(this.LackPage);
            this.panel1.Controls.Add(this.lblDPI);
            this.panel1.Controls.Add(this.lblShortOfPages);
            this.panel1.Controls.Add(this.FilePassSize);
            this.panel1.Controls.Add(this.lblPassedLength);
            this.panel1.Controls.Add(this.FileRepeat);
            this.panel1.Controls.Add(this.lblRepeatCount);
            this.panel1.Controls.Add(this.FilePassNun);
            this.panel1.Controls.Add(this.FileFailNum);
            this.panel1.Controls.Add(this.lblPassedCount);
            this.panel1.Controls.Add(this.lblFailCount);
            this.panel1.Controls.Add(this.FileSize);
            this.panel1.Controls.Add(this.lblLength);
            this.panel1.Controls.Add(this.FileNum);
            this.panel1.Controls.Add(this.lblCount);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 638);
            this.panel1.TabIndex = 1;
            // 
            // lblNullPage
            // 
            this.lblNullPage.AutoSize = true;
            this.lblNullPage.Location = new System.Drawing.Point(816, 159);
            this.lblNullPage.Name = "lblNullPage";
            this.lblNullPage.Size = new System.Drawing.Size(67, 15);
            this.lblNullPage.TabIndex = 3;
            this.lblNullPage.Text = "空白页：";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(343, 58);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(438, 252);
            this.chart.TabIndex = 2;
            this.chart.Text = "异常文件占比";
            // 
            // CatalogDes
            // 
            this.CatalogDes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CatalogDes.AutoSize = true;
            this.CatalogDes.Location = new System.Drawing.Point(918, 240);
            this.CatalogDes.Name = "CatalogDes";
            this.CatalogDes.Size = new System.Drawing.Size(0, 15);
            this.CatalogDes.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(816, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "条目检查情况：";
            // 
            // HookCatalog
            // 
            this.HookCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HookCatalog.AutoSize = true;
            this.HookCatalog.Location = new System.Drawing.Point(918, 214);
            this.HookCatalog.Name = "HookCatalog";
            this.HookCatalog.Size = new System.Drawing.Size(0, 15);
            this.HookCatalog.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(816, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "挂接条目情况：正常";
            // 
            // FullHook
            // 
            this.FullHook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FullHook.AutoSize = true;
            this.FullHook.Location = new System.Drawing.Point(918, 188);
            this.FullHook.Name = "FullHook";
            this.FullHook.Size = new System.Drawing.Size(0, 15);
            this.FullHook.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(816, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "全文挂接情况：正常";
            // 
            // FileSusSize
            // 
            this.FileSusSize.AutoSize = true;
            this.FileSusSize.Location = new System.Drawing.Point(240, 254);
            this.FileSusSize.Name = "FileSusSize";
            this.FileSusSize.Size = new System.Drawing.Size(0, 15);
            this.FileSusSize.TabIndex = 1;
            // 
            // lblFailLength
            // 
            this.lblFailLength.AutoSize = true;
            this.lblFailLength.Location = new System.Drawing.Point(134, 254);
            this.lblFailLength.Name = "lblFailLength";
            this.lblFailLength.Size = new System.Drawing.Size(112, 15);
            this.lblFailLength.TabIndex = 1;
            this.lblFailLength.Text = "疑似文件容量：";
            // 
            // LackPage
            // 
            this.LackPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LackPage.AutoSize = true;
            this.LackPage.Location = new System.Drawing.Point(918, 162);
            this.LackPage.Name = "LackPage";
            this.LackPage.Size = new System.Drawing.Size(0, 15);
            this.LackPage.TabIndex = 1;
            // 
            // lblDPI
            // 
            this.lblDPI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDPI.AutoSize = true;
            this.lblDPI.Location = new System.Drawing.Point(816, 182);
            this.lblDPI.Name = "lblDPI";
            this.lblDPI.Size = new System.Drawing.Size(121, 15);
            this.lblDPI.TabIndex = 1;
            this.lblDPI.Text = "DPI未通过数量：";
            // 
            // lblShortOfPages
            // 
            this.lblShortOfPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShortOfPages.AutoSize = true;
            this.lblShortOfPages.Location = new System.Drawing.Point(816, 205);
            this.lblShortOfPages.Name = "lblShortOfPages";
            this.lblShortOfPages.Size = new System.Drawing.Size(142, 15);
            this.lblShortOfPages.TabIndex = 1;
            this.lblShortOfPages.Text = "缺页漏页情况：正常";
            // 
            // FilePassSize
            // 
            this.FilePassSize.AutoSize = true;
            this.FilePassSize.Location = new System.Drawing.Point(240, 218);
            this.FilePassSize.Name = "FilePassSize";
            this.FilePassSize.Size = new System.Drawing.Size(0, 15);
            this.FilePassSize.TabIndex = 1;
            // 
            // lblPassedLength
            // 
            this.lblPassedLength.AutoSize = true;
            this.lblPassedLength.Location = new System.Drawing.Point(134, 218);
            this.lblPassedLength.Name = "lblPassedLength";
            this.lblPassedLength.Size = new System.Drawing.Size(112, 15);
            this.lblPassedLength.TabIndex = 1;
            this.lblPassedLength.Text = "通过文件容量：";
            // 
            // FileRepeat
            // 
            this.FileRepeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileRepeat.AutoSize = true;
            this.FileRepeat.Location = new System.Drawing.Point(918, 136);
            this.FileRepeat.Name = "FileRepeat";
            this.FileRepeat.Size = new System.Drawing.Size(0, 15);
            this.FileRepeat.TabIndex = 1;
            // 
            // lblRepeatCount
            // 
            this.lblRepeatCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRepeatCount.AutoSize = true;
            this.lblRepeatCount.Location = new System.Drawing.Point(816, 136);
            this.lblRepeatCount.Name = "lblRepeatCount";
            this.lblRepeatCount.Size = new System.Drawing.Size(82, 15);
            this.lblRepeatCount.TabIndex = 1;
            this.lblRepeatCount.Text = "重复文件：";
            // 
            // FilePassNun
            // 
            this.FilePassNun.AutoSize = true;
            this.FilePassNun.Location = new System.Drawing.Point(240, 182);
            this.FilePassNun.Name = "FilePassNun";
            this.FilePassNun.Size = new System.Drawing.Size(0, 15);
            this.FilePassNun.TabIndex = 1;
            // 
            // FileFailNum
            // 
            this.FileFailNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileFailNum.AutoSize = true;
            this.FileFailNum.Location = new System.Drawing.Point(918, 110);
            this.FileFailNum.Name = "FileFailNum";
            this.FileFailNum.Size = new System.Drawing.Size(0, 15);
            this.FileFailNum.TabIndex = 1;
            // 
            // lblPassedCount
            // 
            this.lblPassedCount.AutoSize = true;
            this.lblPassedCount.Location = new System.Drawing.Point(134, 182);
            this.lblPassedCount.Name = "lblPassedCount";
            this.lblPassedCount.Size = new System.Drawing.Size(97, 15);
            this.lblPassedCount.TabIndex = 1;
            this.lblPassedCount.Text = "通过文件数：";
            // 
            // lblFailCount
            // 
            this.lblFailCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFailCount.AutoSize = true;
            this.lblFailCount.Location = new System.Drawing.Point(816, 110);
            this.lblFailCount.Name = "lblFailCount";
            this.lblFailCount.Size = new System.Drawing.Size(97, 15);
            this.lblFailCount.TabIndex = 1;
            this.lblFailCount.Text = "失败文件数：";
            // 
            // FileSize
            // 
            this.FileSize.AutoSize = true;
            this.FileSize.Location = new System.Drawing.Point(240, 146);
            this.FileSize.Name = "FileSize";
            this.FileSize.Size = new System.Drawing.Size(0, 15);
            this.FileSize.TabIndex = 1;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(134, 146);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(82, 15);
            this.lblLength.TabIndex = 1;
            this.lblLength.Text = "文件容量：";
            // 
            // FileNum
            // 
            this.FileNum.AutoSize = true;
            this.FileNum.Location = new System.Drawing.Point(240, 110);
            this.FileNum.Name = "FileNum";
            this.FileNum.Size = new System.Drawing.Size(0, 15);
            this.FileNum.TabIndex = 1;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(134, 110);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(82, 15);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "文件总数：";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::DataDetectionSystem.Properties.Resources.errfiles;
            this.pictureBox2.Location = new System.Drawing.Point(787, 58);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(229, 252);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataDetectionSystem.Properties.Resources.allfiles;
            this.pictureBox1.Location = new System.Drawing.Point(108, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ResultUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopMenuStrip);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ResultUserControl";
            this.Size = new System.Drawing.Size(1109, 666);
            this.Load += new System.EventHandler(this.ResultUserControl_Load);
            this.TopMenuStrip.ResumeLayout(false);
            this.TopMenuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TopMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ConventionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblFailLength;
        private System.Windows.Forms.Label lblShortOfPages;
        private System.Windows.Forms.Label lblPassedLength;
        private System.Windows.Forms.Label lblRepeatCount;
        private System.Windows.Forms.Label lblPassedCount;
        private System.Windows.Forms.Label lblFailCount;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label HookCatalog;
        private System.Windows.Forms.Label FullHook;
        private System.Windows.Forms.Label FileSusSize;
        private System.Windows.Forms.Label LackPage;
        private System.Windows.Forms.Label FilePassSize;
        private System.Windows.Forms.Label FileRepeat;
        private System.Windows.Forms.Label FilePassNun;
        private System.Windows.Forms.Label FileFailNum;
        private System.Windows.Forms.Label FileSize;
        private System.Windows.Forms.Label FileNum;
        private System.Windows.Forms.Label CatalogDes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label lblNullPage;
        private System.Windows.Forms.Label lblDPI;
    }
}
