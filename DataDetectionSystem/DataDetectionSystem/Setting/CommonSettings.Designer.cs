﻿namespace DataDetectionSystem
{
    partial class CommonSettings
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numRangeEnabledError = new System.Windows.Forms.NumericUpDown();
            this.numItalicDegree = new System.Windows.Forms.NumericUpDown();
            this.numDPI = new System.Windows.Forms.NumericUpDown();
            this.numWhitePercent = new System.Windows.Forms.NumericUpDown();
            this.chkA2 = new System.Windows.Forms.CheckBox();
            this.chkA6 = new System.Windows.Forms.CheckBox();
            this.chkA5 = new System.Windows.Forms.CheckBox();
            this.chkA4 = new System.Windows.Forms.CheckBox();
            this.chkA3 = new System.Windows.Forms.CheckBox();
            this.chkA1 = new System.Windows.Forms.CheckBox();
            this.chkA0 = new System.Windows.Forms.CheckBox();
            this.chkImgRange = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkDPI = new System.Windows.Forms.CheckBox();
            this.chkWhite = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIgnoreFolders = new System.Windows.Forms.TextBox();
            this.numNoLen = new System.Windows.Forms.NumericUpDown();
            this.cmbFilenameRule = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkIgnoreFolder = new System.Windows.Forms.CheckBox();
            this.chkIgnoreHidden = new System.Windows.Forms.CheckBox();
            this.chkFileContinue = new System.Windows.Forms.CheckBox();
            this.chkFolderContinue = new System.Windows.Forms.CheckBox();
            this.chkRepeatMD5 = new System.Windows.Forms.CheckBox();
            this.chkRepeat = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_LogPathChoice = new System.Windows.Forms.Button();
            this.LogPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTestTimer = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkVideo = new System.Windows.Forms.CheckBox();
            this.chkDirectories = new System.Windows.Forms.CheckBox();
            this.chkHook = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRangeEnabledError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItalicDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDPI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWhitePercent)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNoLen)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(515, 603);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 42);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(596, 603);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 42);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择检测方案：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(139, 13);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(533, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(24, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 552);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numRangeEnabledError);
            this.groupBox1.Controls.Add(this.numItalicDegree);
            this.groupBox1.Controls.Add(this.numDPI);
            this.groupBox1.Controls.Add(this.numWhitePercent);
            this.groupBox1.Controls.Add(this.chkA2);
            this.groupBox1.Controls.Add(this.chkA6);
            this.groupBox1.Controls.Add(this.chkA5);
            this.groupBox1.Controls.Add(this.chkA4);
            this.groupBox1.Controls.Add(this.chkA3);
            this.groupBox1.Controls.Add(this.chkA1);
            this.groupBox1.Controls.Add(this.chkA0);
            this.groupBox1.Controls.Add(this.chkImgRange);
            this.groupBox1.Controls.Add(this.chkItalic);
            this.groupBox1.Controls.Add(this.chkDPI);
            this.groupBox1.Controls.Add(this.chkWhite);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(645, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图像选项";
            // 
            // numRangeEnabledError
            // 
            this.numRangeEnabledError.DecimalPlaces = 1;
            this.numRangeEnabledError.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numRangeEnabledError.Location = new System.Drawing.Point(277, 128);
            this.numRangeEnabledError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numRangeEnabledError.Name = "numRangeEnabledError";
            this.numRangeEnabledError.Size = new System.Drawing.Size(65, 25);
            this.numRangeEnabledError.TabIndex = 3;
            this.numRangeEnabledError.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numRangeEnabledError.Visible = false;
            // 
            // numItalicDegree
            // 
            this.numItalicDegree.DecimalPlaces = 1;
            this.numItalicDegree.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numItalicDegree.Location = new System.Drawing.Point(193, 95);
            this.numItalicDegree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numItalicDegree.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numItalicDegree.Name = "numItalicDegree";
            this.numItalicDegree.Size = new System.Drawing.Size(57, 25);
            this.numItalicDegree.TabIndex = 3;
            this.numItalicDegree.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numDPI
            // 
            this.numDPI.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDPI.Location = new System.Drawing.Point(131, 62);
            this.numDPI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numDPI.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDPI.Name = "numDPI";
            this.numDPI.Size = new System.Drawing.Size(67, 25);
            this.numDPI.TabIndex = 3;
            this.numDPI.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numWhitePercent
            // 
            this.numWhitePercent.DecimalPlaces = 1;
            this.numWhitePercent.Location = new System.Drawing.Point(229, 29);
            this.numWhitePercent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numWhitePercent.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numWhitePercent.Name = "numWhitePercent";
            this.numWhitePercent.Size = new System.Drawing.Size(79, 25);
            this.numWhitePercent.TabIndex = 3;
            this.numWhitePercent.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // chkA2
            // 
            this.chkA2.AutoSize = true;
            this.chkA2.Location = new System.Drawing.Point(151, 165);
            this.chkA2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkA2.Name = "chkA2";
            this.chkA2.Size = new System.Drawing.Size(45, 19);
            this.chkA2.TabIndex = 2;
            this.chkA2.Text = "A2";
            this.chkA2.UseVisualStyleBackColor = true;
            this.chkA2.Visible = false;
            // 
            // chkA6
            // 
            this.chkA6.AutoSize = true;
            this.chkA6.Location = new System.Drawing.Point(367, 165);
            this.chkA6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkA6.Name = "chkA6";
            this.chkA6.Size = new System.Drawing.Size(45, 19);
            this.chkA6.TabIndex = 2;
            this.chkA6.Text = "A6";
            this.chkA6.UseVisualStyleBackColor = true;
            this.chkA6.Visible = false;
            // 
            // chkA5
            // 
            this.chkA5.AutoSize = true;
            this.chkA5.Location = new System.Drawing.Point(313, 165);
            this.chkA5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkA5.Name = "chkA5";
            this.chkA5.Size = new System.Drawing.Size(45, 19);
            this.chkA5.TabIndex = 2;
            this.chkA5.Text = "A5";
            this.chkA5.UseVisualStyleBackColor = true;
            this.chkA5.Visible = false;
            // 
            // chkA4
            // 
            this.chkA4.AutoSize = true;
            this.chkA4.Location = new System.Drawing.Point(259, 165);
            this.chkA4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkA4.Name = "chkA4";
            this.chkA4.Size = new System.Drawing.Size(45, 19);
            this.chkA4.TabIndex = 2;
            this.chkA4.Text = "A4";
            this.chkA4.UseVisualStyleBackColor = true;
            this.chkA4.Visible = false;
            // 
            // chkA3
            // 
            this.chkA3.AutoSize = true;
            this.chkA3.Location = new System.Drawing.Point(205, 165);
            this.chkA3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkA3.Name = "chkA3";
            this.chkA3.Size = new System.Drawing.Size(45, 19);
            this.chkA3.TabIndex = 2;
            this.chkA3.Text = "A3";
            this.chkA3.UseVisualStyleBackColor = true;
            this.chkA3.Visible = false;
            // 
            // chkA1
            // 
            this.chkA1.AutoSize = true;
            this.chkA1.Location = new System.Drawing.Point(97, 165);
            this.chkA1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkA1.Name = "chkA1";
            this.chkA1.Size = new System.Drawing.Size(45, 19);
            this.chkA1.TabIndex = 2;
            this.chkA1.Text = "A1";
            this.chkA1.UseVisualStyleBackColor = true;
            this.chkA1.Visible = false;
            // 
            // chkA0
            // 
            this.chkA0.AutoSize = true;
            this.chkA0.Location = new System.Drawing.Point(43, 165);
            this.chkA0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkA0.Name = "chkA0";
            this.chkA0.Size = new System.Drawing.Size(45, 19);
            this.chkA0.TabIndex = 2;
            this.chkA0.Text = "A0";
            this.chkA0.UseVisualStyleBackColor = true;
            this.chkA0.Visible = false;
            // 
            // chkImgRange
            // 
            this.chkImgRange.AutoSize = true;
            this.chkImgRange.Location = new System.Drawing.Point(43, 132);
            this.chkImgRange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkImgRange.Name = "chkImgRange";
            this.chkImgRange.Size = new System.Drawing.Size(305, 19);
            this.chkImgRange.TabIndex = 1;
            this.chkImgRange.Text = "图像画幅检测   图像画幅容差        %";
            this.chkImgRange.UseVisualStyleBackColor = true;
            this.chkImgRange.Visible = false;
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(43, 99);
            this.chkItalic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(220, 19);
            this.chkItalic.TabIndex = 1;
            this.chkItalic.Text = "图像倾斜检测容差       度";
            this.chkItalic.UseVisualStyleBackColor = true;
            // 
            // chkDPI
            // 
            this.chkDPI.AutoSize = true;
            this.chkDPI.Location = new System.Drawing.Point(43, 66);
            this.chkDPI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkDPI.Name = "chkDPI";
            this.chkDPI.Size = new System.Drawing.Size(193, 19);
            this.chkDPI.TabIndex = 1;
            this.chkDPI.Text = "DPI低于          标记";
            this.chkDPI.UseVisualStyleBackColor = true;
            // 
            // chkWhite
            // 
            this.chkWhite.AutoSize = true;
            this.chkWhite.Location = new System.Drawing.Point(43, 32);
            this.chkWhite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkWhite.Name = "chkWhite";
            this.chkWhite.Size = new System.Drawing.Size(305, 19);
            this.chkWhite.TabIndex = 1;
            this.chkWhite.Text = "图片留白检测,内容少于          %标记";
            this.chkWhite.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.txtIgnoreFolders);
            this.groupBox2.Controls.Add(this.numNoLen);
            this.groupBox2.Controls.Add(this.cmbFilenameRule);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.chkIgnoreFolder);
            this.groupBox2.Controls.Add(this.chkIgnoreHidden);
            this.groupBox2.Controls.Add(this.chkFileContinue);
            this.groupBox2.Controls.Add(this.chkFolderContinue);
            this.groupBox2.Controls.Add(this.chkRepeatMD5);
            this.groupBox2.Controls.Add(this.chkRepeat);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(24, 267);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(648, 221);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件选项";
            // 
            // txtIgnoreFolders
            // 
            this.txtIgnoreFolders.Location = new System.Drawing.Point(203, 178);
            this.txtIgnoreFolders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIgnoreFolders.Name = "txtIgnoreFolders";
            this.txtIgnoreFolders.Size = new System.Drawing.Size(180, 25);
            this.txtIgnoreFolders.TabIndex = 4;
            // 
            // numNoLen
            // 
            this.numNoLen.Location = new System.Drawing.Point(283, 125);
            this.numNoLen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numNoLen.Name = "numNoLen";
            this.numNoLen.Size = new System.Drawing.Size(59, 25);
            this.numNoLen.TabIndex = 3;
            // 
            // cmbFilenameRule
            // 
            this.cmbFilenameRule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilenameRule.FormattingEnabled = true;
            this.cmbFilenameRule.Items.AddRange(new object[] {
            "前",
            "后",
            "最后数字"});
            this.cmbFilenameRule.Location = new System.Drawing.Point(155, 128);
            this.cmbFilenameRule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFilenameRule.Name = "cmbFilenameRule";
            this.cmbFilenameRule.Size = new System.Drawing.Size(121, 23);
            this.cmbFilenameRule.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "文件名规则：                         位是顺序号";
            // 
            // chkIgnoreFolder
            // 
            this.chkIgnoreFolder.AutoSize = true;
            this.chkIgnoreFolder.Location = new System.Drawing.Point(43, 179);
            this.chkIgnoreFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkIgnoreFolder.Name = "chkIgnoreFolder";
            this.chkIgnoreFolder.Size = new System.Drawing.Size(149, 19);
            this.chkIgnoreFolder.TabIndex = 0;
            this.chkIgnoreFolder.Text = "不检查文件夹名称";
            this.chkIgnoreFolder.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreHidden
            // 
            this.chkIgnoreHidden.AutoSize = true;
            this.chkIgnoreHidden.Location = new System.Drawing.Point(43, 152);
            this.chkIgnoreHidden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkIgnoreHidden.Name = "chkIgnoreHidden";
            this.chkIgnoreHidden.Size = new System.Drawing.Size(134, 19);
            this.chkIgnoreHidden.TabIndex = 0;
            this.chkIgnoreHidden.Text = "不检测隐藏文件";
            this.chkIgnoreHidden.UseVisualStyleBackColor = true;
            // 
            // chkFileContinue
            // 
            this.chkFileContinue.AutoSize = true;
            this.chkFileContinue.Location = new System.Drawing.Point(43, 105);
            this.chkFileContinue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFileContinue.Name = "chkFileContinue";
            this.chkFileContinue.Size = new System.Drawing.Size(344, 19);
            this.chkFileContinue.TabIndex = 0;
            this.chkFileContinue.Text = "检测文件是否连续（单文件夹内得文件名顺序）";
            this.chkFileContinue.UseVisualStyleBackColor = true;
            // 
            // chkFolderContinue
            // 
            this.chkFolderContinue.AutoSize = true;
            this.chkFolderContinue.Location = new System.Drawing.Point(43, 79);
            this.chkFolderContinue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkFolderContinue.Name = "chkFolderContinue";
            this.chkFolderContinue.Size = new System.Drawing.Size(224, 19);
            this.chkFolderContinue.TabIndex = 0;
            this.chkFolderContinue.Text = "检测最后一层文件夹是否连续";
            this.chkFolderContinue.UseVisualStyleBackColor = true;
            // 
            // chkRepeatMD5
            // 
            this.chkRepeatMD5.AutoSize = true;
            this.chkRepeatMD5.Location = new System.Drawing.Point(43, 51);
            this.chkRepeatMD5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkRepeatMD5.Name = "chkRepeatMD5";
            this.chkRepeatMD5.Size = new System.Drawing.Size(308, 19);
            this.chkRepeatMD5.TabIndex = 0;
            this.chkRepeatMD5.Text = "检测重复文件MD5校验（检测速度会变慢）";
            this.chkRepeatMD5.UseVisualStyleBackColor = true;
            // 
            // chkRepeat
            // 
            this.chkRepeat.AutoSize = true;
            this.chkRepeat.Location = new System.Drawing.Point(43, 25);
            this.chkRepeat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkRepeat.Name = "chkRepeat";
            this.chkRepeat.Size = new System.Drawing.Size(299, 19);
            this.chkRepeat.TabIndex = 0;
            this.chkRepeat.Text = "检测重复文件（根据文件大小时间检测）";
            this.chkRepeat.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.chkVideo);
            this.groupBox3.Controls.Add(this.chkDirectories);
            this.groupBox3.Controls.Add(this.chkHook);
            this.groupBox3.Controls.Add(this.Btn_LogPathChoice);
            this.groupBox3.Controls.Add(this.LogPath);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dtpTestTimer);
            this.groupBox3.Location = new System.Drawing.Point(24, 493);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(648, 104);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "文件巡检";
            // 
            // Btn_LogPathChoice
            // 
            this.Btn_LogPathChoice.Location = new System.Drawing.Point(286, 62);
            this.Btn_LogPathChoice.Name = "Btn_LogPathChoice";
            this.Btn_LogPathChoice.Size = new System.Drawing.Size(43, 25);
            this.Btn_LogPathChoice.TabIndex = 5;
            this.Btn_LogPathChoice.Text = "…";
            this.Btn_LogPathChoice.UseVisualStyleBackColor = true;
            this.Btn_LogPathChoice.Click += new System.EventHandler(this.Btn_LogPathChoice_Click);
            // 
            // LogPath
            // 
            this.LogPath.Location = new System.Drawing.Point(151, 62);
            this.LogPath.Name = "LogPath";
            this.LogPath.Size = new System.Drawing.Size(177, 25);
            this.LogPath.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "报告存放路径";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "定时检测";
            // 
            // dtpTestTimer
            // 
            this.dtpTestTimer.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTestTimer.Location = new System.Drawing.Point(151, 18);
            this.dtpTestTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTestTimer.Name = "dtpTestTimer";
            this.dtpTestTimer.ShowUpDown = true;
            this.dtpTestTimer.Size = new System.Drawing.Size(177, 25);
            this.dtpTestTimer.TabIndex = 1;
            this.dtpTestTimer.Value = new System.DateTime(2020, 10, 12, 12, 0, 0, 0);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 650);
            this.panel2.TabIndex = 5;
            // 
            // chkVideo
            // 
            this.chkVideo.AutoSize = true;
            this.chkVideo.Location = new System.Drawing.Point(367, 66);
            this.chkVideo.Margin = new System.Windows.Forms.Padding(2);
            this.chkVideo.Name = "chkVideo";
            this.chkVideo.Size = new System.Drawing.Size(89, 19);
            this.chkVideo.TabIndex = 6;
            this.chkVideo.Text = "视频检测";
            this.chkVideo.UseVisualStyleBackColor = true;
            // 
            // chkDirectories
            // 
            this.chkDirectories.AutoSize = true;
            this.chkDirectories.Location = new System.Drawing.Point(367, 46);
            this.chkDirectories.Margin = new System.Windows.Forms.Padding(2);
            this.chkDirectories.Name = "chkDirectories";
            this.chkDirectories.Size = new System.Drawing.Size(89, 19);
            this.chkDirectories.TabIndex = 7;
            this.chkDirectories.Text = "条目检测";
            this.chkDirectories.UseVisualStyleBackColor = true;
            // 
            // chkHook
            // 
            this.chkHook.AutoSize = true;
            this.chkHook.Location = new System.Drawing.Point(367, 26);
            this.chkHook.Margin = new System.Windows.Forms.Padding(2);
            this.chkHook.Name = "chkHook";
            this.chkHook.Size = new System.Drawing.Size(89, 19);
            this.chkHook.TabIndex = 8;
            this.chkHook.Text = "挂接检测";
            this.chkHook.UseVisualStyleBackColor = true;
            // 
            // CommonSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CommonSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CommonSettings";
            this.Load += new System.EventHandler(this.CommonSettings_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRangeEnabledError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItalicDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDPI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWhitePercent)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNoLen)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkA2;
        private System.Windows.Forms.CheckBox chkA6;
        private System.Windows.Forms.CheckBox chkA5;
        private System.Windows.Forms.CheckBox chkA4;
        private System.Windows.Forms.CheckBox chkA3;
        private System.Windows.Forms.CheckBox chkA1;
        private System.Windows.Forms.CheckBox chkA0;
        private System.Windows.Forms.CheckBox chkImgRange;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkDPI;
        private System.Windows.Forms.CheckBox chkWhite;
        private System.Windows.Forms.NumericUpDown numRangeEnabledError;
        private System.Windows.Forms.NumericUpDown numItalicDegree;
        private System.Windows.Forms.NumericUpDown numDPI;
        private System.Windows.Forms.NumericUpDown numWhitePercent;
        private System.Windows.Forms.TextBox txtIgnoreFolders;
        private System.Windows.Forms.NumericUpDown numNoLen;
        private System.Windows.Forms.ComboBox cmbFilenameRule;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkIgnoreFolder;
        private System.Windows.Forms.CheckBox chkIgnoreHidden;
        private System.Windows.Forms.CheckBox chkFileContinue;
        private System.Windows.Forms.CheckBox chkFolderContinue;
        private System.Windows.Forms.CheckBox chkRepeatMD5;
        private System.Windows.Forms.CheckBox chkRepeat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpTestTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_LogPathChoice;
        private System.Windows.Forms.TextBox LogPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkVideo;
        private System.Windows.Forms.CheckBox chkDirectories;
        private System.Windows.Forms.CheckBox chkHook;
    }
}