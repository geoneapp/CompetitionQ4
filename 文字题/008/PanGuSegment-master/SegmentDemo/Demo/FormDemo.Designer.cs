﻿namespace Demo
{
    partial class FormDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDemo));
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDownRedundancy = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMultiSelect = new System.Windows.Forms.CheckBox();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.numericUpDownUnknownWordsThreshold = new System.Windows.Forms.NumericUpDown();
            this.checkBoxFreqFirst = new System.Windows.Forms.CheckBox();
            this.checkBoxDisplayPosition = new System.Windows.Forms.CheckBox();
            this.checkBoxFilterStopWords = new System.Windows.Forms.CheckBox();
            this.checkBoxMatchName = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSrcLength = new System.Windows.Forms.Label();
            this.labelRegRate = new System.Windows.Forms.Label();
            this.labelSegTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSegment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSegwords = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxForceSingleWord = new System.Windows.Forms.CheckBox();
            this.checkBoxTraditionalChs = new System.Windows.Forms.CheckBox();
            this.checkBoxST = new System.Windows.Forms.CheckBox();
            this.checkBoxUnknownWord = new System.Windows.Forms.CheckBox();
            this.checkBoxFilterEnglish = new System.Windows.Forms.CheckBox();
            this.numericUpDownFilterEnglishLength = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.labelFilterNumericLength = new System.Windows.Forms.Label();
            this.numericUpDownFilterNumericLength = new System.Windows.Forms.NumericUpDown();
            this.checkBoxFilterNumeric = new System.Windows.Forms.CheckBox();
            this.checkBoxIgnoreCapital = new System.Windows.Forms.CheckBox();
            this.checkBoxShowTimeOnly = new System.Windows.Forms.CheckBox();
            this.checkBoxEnglishSegment = new System.Windows.Forms.CheckBox();
            this.checkBoxSynonymOutput = new System.Windows.Forms.CheckBox();
            this.checkBoxWildcard = new System.Windows.Forms.CheckBox();
            this.checkBoxWildcardSegment = new System.Windows.Forms.CheckBox();
            this.checkBoxCustomRule = new System.Windows.Forms.CheckBox();
            this.checkBoxEnglishMultiSelect = new System.Windows.Forms.CheckBox();
            this.btnShowResult = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTextAnalysis = new System.Windows.Forms.Button();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRedundancy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnknownWordsThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterEnglishLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterNumericLength)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(390, 84);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 15);
            this.label14.TabIndex = 87;
            this.label14.Text = "冗余度";
            // 
            // numericUpDownRedundancy
            // 
            this.numericUpDownRedundancy.Location = new System.Drawing.Point(514, 81);
            this.numericUpDownRedundancy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownRedundancy.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownRedundancy.Name = "numericUpDownRedundancy";
            this.numericUpDownRedundancy.Size = new System.Drawing.Size(69, 25);
            this.numericUpDownRedundancy.TabIndex = 86;
            this.numericUpDownRedundancy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxMultiSelect
            // 
            this.checkBoxMultiSelect.AutoSize = true;
            this.checkBoxMultiSelect.Location = new System.Drawing.Point(253, 84);
            this.checkBoxMultiSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxMultiSelect.Name = "checkBoxMultiSelect";
            this.checkBoxMultiSelect.Size = new System.Drawing.Size(89, 19);
            this.checkBoxMultiSelect.TabIndex = 85;
            this.checkBoxMultiSelect.Text = "多元分词";
            this.checkBoxMultiSelect.UseVisualStyleBackColor = true;
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.Location = new System.Drawing.Point(119, 54);
            this.buttonSaveConfig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(100, 29);
            this.buttonSaveConfig.TabIndex = 84;
            this.buttonSaveConfig.Text = "保存配置";
            this.buttonSaveConfig.UseVisualStyleBackColor = true;
            this.buttonSaveConfig.Click += new System.EventHandler(this.buttonSaveConfig_Click);
            // 
            // numericUpDownUnknownWordsThreshold
            // 
            this.numericUpDownUnknownWordsThreshold.Location = new System.Drawing.Point(1153, 804);
            this.numericUpDownUnknownWordsThreshold.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownUnknownWordsThreshold.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownUnknownWordsThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownUnknownWordsThreshold.Name = "numericUpDownUnknownWordsThreshold";
            this.numericUpDownUnknownWordsThreshold.Size = new System.Drawing.Size(69, 25);
            this.numericUpDownUnknownWordsThreshold.TabIndex = 80;
            this.numericUpDownUnknownWordsThreshold.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // checkBoxFreqFirst
            // 
            this.checkBoxFreqFirst.AutoSize = true;
            this.checkBoxFreqFirst.Checked = true;
            this.checkBoxFreqFirst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFreqFirst.Location = new System.Drawing.Point(657, 58);
            this.checkBoxFreqFirst.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxFreqFirst.Name = "checkBoxFreqFirst";
            this.checkBoxFreqFirst.Size = new System.Drawing.Size(119, 19);
            this.checkBoxFreqFirst.TabIndex = 78;
            this.checkBoxFreqFirst.Text = "优先判断词频";
            this.checkBoxFreqFirst.UseVisualStyleBackColor = true;
            // 
            // checkBoxDisplayPosition
            // 
            this.checkBoxDisplayPosition.AutoSize = true;
            this.checkBoxDisplayPosition.Location = new System.Drawing.Point(514, 58);
            this.checkBoxDisplayPosition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxDisplayPosition.Name = "checkBoxDisplayPosition";
            this.checkBoxDisplayPosition.Size = new System.Drawing.Size(119, 19);
            this.checkBoxDisplayPosition.TabIndex = 76;
            this.checkBoxDisplayPosition.Text = "显示单词位置";
            this.checkBoxDisplayPosition.UseVisualStyleBackColor = true;
            // 
            // checkBoxFilterStopWords
            // 
            this.checkBoxFilterStopWords.AutoSize = true;
            this.checkBoxFilterStopWords.Location = new System.Drawing.Point(395, 58);
            this.checkBoxFilterStopWords.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxFilterStopWords.Name = "checkBoxFilterStopWords";
            this.checkBoxFilterStopWords.Size = new System.Drawing.Size(104, 19);
            this.checkBoxFilterStopWords.TabIndex = 74;
            this.checkBoxFilterStopWords.Text = "过滤停用词";
            this.checkBoxFilterStopWords.UseVisualStyleBackColor = true;
            // 
            // checkBoxMatchName
            // 
            this.checkBoxMatchName.AutoSize = true;
            this.checkBoxMatchName.Checked = true;
            this.checkBoxMatchName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMatchName.Location = new System.Drawing.Point(253, 58);
            this.checkBoxMatchName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxMatchName.Name = "checkBoxMatchName";
            this.checkBoxMatchName.Size = new System.Drawing.Size(119, 19);
            this.checkBoxMatchName.TabIndex = 73;
            this.checkBoxMatchName.Text = "识别中文人名";
            this.checkBoxMatchName.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 69;
            this.label3.Text = "chars";
            // 
            // labelSrcLength
            // 
            this.labelSrcLength.AutoSize = true;
            this.labelSrcLength.Location = new System.Drawing.Point(147, 23);
            this.labelSrcLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSrcLength.Name = "labelSrcLength";
            this.labelSrcLength.Size = new System.Drawing.Size(15, 15);
            this.labelSrcLength.TabIndex = 68;
            this.labelSrcLength.Text = "0";
            // 
            // labelRegRate
            // 
            this.labelRegRate.AutoSize = true;
            this.labelRegRate.Location = new System.Drawing.Point(667, 23);
            this.labelRegRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegRate.Name = "labelRegRate";
            this.labelRegRate.Size = new System.Drawing.Size(15, 15);
            this.labelRegRate.TabIndex = 67;
            this.labelRegRate.Text = "0";
            // 
            // labelSegTime
            // 
            this.labelSegTime.AutoSize = true;
            this.labelSegTime.Location = new System.Drawing.Point(393, 23);
            this.labelSegTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSegTime.Name = "labelSegTime";
            this.labelSegTime.Size = new System.Drawing.Size(15, 15);
            this.labelSegTime.TabIndex = 66;
            this.labelSegTime.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(819, 22);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 65;
            this.label8.Text = "chars/s";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(553, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 15);
            this.label7.TabIndex = 64;
            this.label7.Text = "s";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 63;
            this.label6.Text = "分词速度";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 62;
            this.label5.Text = "分词时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 61;
            this.label4.Text = "源字符串长度";
            // 
            // buttonSegment
            // 
            this.buttonSegment.Location = new System.Drawing.Point(11, 54);
            this.buttonSegment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSegment.Name = "buttonSegment";
            this.buttonSegment.Size = new System.Drawing.Size(100, 29);
            this.buttonSegment.TabIndex = 60;
            this.buttonSegment.Text = "分词";
            this.buttonSegment.UseVisualStyleBackColor = true;
            this.buttonSegment.Click += new System.EventHandler(this.buttonSegment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 338);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 59;
            this.label2.Text = "分词结果";
            // 
            // textBoxSegwords
            // 
            this.textBoxSegwords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSegwords.Location = new System.Drawing.Point(0, 355);
            this.textBoxSegwords.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSegwords.Multiline = true;
            this.textBoxSegwords.Name = "textBoxSegwords";
            this.textBoxSegwords.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSegwords.Size = new System.Drawing.Size(1264, 126);
            this.textBoxSegwords.TabIndex = 58;
            this.textBoxSegwords.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "源文";
            // 
            // checkBoxForceSingleWord
            // 
            this.checkBoxForceSingleWord.AutoSize = true;
            this.checkBoxForceSingleWord.Location = new System.Drawing.Point(657, 82);
            this.checkBoxForceSingleWord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxForceSingleWord.Name = "checkBoxForceSingleWord";
            this.checkBoxForceSingleWord.Size = new System.Drawing.Size(119, 19);
            this.checkBoxForceSingleWord.TabIndex = 89;
            this.checkBoxForceSingleWord.Text = "强制一元分词";
            this.checkBoxForceSingleWord.UseVisualStyleBackColor = true;
            // 
            // checkBoxTraditionalChs
            // 
            this.checkBoxTraditionalChs.AutoSize = true;
            this.checkBoxTraditionalChs.Checked = true;
            this.checkBoxTraditionalChs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTraditionalChs.Location = new System.Drawing.Point(797, 55);
            this.checkBoxTraditionalChs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxTraditionalChs.Name = "checkBoxTraditionalChs";
            this.checkBoxTraditionalChs.Size = new System.Drawing.Size(104, 19);
            this.checkBoxTraditionalChs.TabIndex = 90;
            this.checkBoxTraditionalChs.Text = "繁体字分词";
            this.checkBoxTraditionalChs.UseVisualStyleBackColor = true;
            // 
            // checkBoxST
            // 
            this.checkBoxST.AutoSize = true;
            this.checkBoxST.Checked = true;
            this.checkBoxST.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxST.Location = new System.Drawing.Point(934, 54);
            this.checkBoxST.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxST.Name = "checkBoxST";
            this.checkBoxST.Size = new System.Drawing.Size(164, 19);
            this.checkBoxST.TabIndex = 91;
            this.checkBoxST.Text = "同时输出简体和繁体";
            this.checkBoxST.UseVisualStyleBackColor = true;
            // 
            // checkBoxUnknownWord
            // 
            this.checkBoxUnknownWord.AutoSize = true;
            this.checkBoxUnknownWord.Location = new System.Drawing.Point(797, 81);
            this.checkBoxUnknownWord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxUnknownWord.Name = "checkBoxUnknownWord";
            this.checkBoxUnknownWord.Size = new System.Drawing.Size(119, 19);
            this.checkBoxUnknownWord.TabIndex = 92;
            this.checkBoxUnknownWord.Text = "未登录词识别";
            this.checkBoxUnknownWord.UseVisualStyleBackColor = true;
            // 
            // checkBoxFilterEnglish
            // 
            this.checkBoxFilterEnglish.AutoSize = true;
            this.checkBoxFilterEnglish.Location = new System.Drawing.Point(253, 114);
            this.checkBoxFilterEnglish.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxFilterEnglish.Name = "checkBoxFilterEnglish";
            this.checkBoxFilterEnglish.Size = new System.Drawing.Size(89, 19);
            this.checkBoxFilterEnglish.TabIndex = 93;
            this.checkBoxFilterEnglish.Text = "过滤英文";
            this.checkBoxFilterEnglish.UseVisualStyleBackColor = true;
            // 
            // numericUpDownFilterEnglishLength
            // 
            this.numericUpDownFilterEnglishLength.Location = new System.Drawing.Point(514, 110);
            this.numericUpDownFilterEnglishLength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownFilterEnglishLength.Name = "numericUpDownFilterEnglishLength";
            this.numericUpDownFilterEnglishLength.Size = new System.Drawing.Size(69, 25);
            this.numericUpDownFilterEnglishLength.TabIndex = 94;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(390, 115);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 15);
            this.label11.TabIndex = 95;
            this.label11.Text = "过滤英文长度";
            // 
            // labelFilterNumericLength
            // 
            this.labelFilterNumericLength.AutoSize = true;
            this.labelFilterNumericLength.Location = new System.Drawing.Point(797, 113);
            this.labelFilterNumericLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilterNumericLength.Name = "labelFilterNumericLength";
            this.labelFilterNumericLength.Size = new System.Drawing.Size(97, 15);
            this.labelFilterNumericLength.TabIndex = 98;
            this.labelFilterNumericLength.Text = "过滤数字长度";
            // 
            // numericUpDownFilterNumericLength
            // 
            this.numericUpDownFilterNumericLength.Location = new System.Drawing.Point(921, 108);
            this.numericUpDownFilterNumericLength.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDownFilterNumericLength.Name = "numericUpDownFilterNumericLength";
            this.numericUpDownFilterNumericLength.Size = new System.Drawing.Size(69, 25);
            this.numericUpDownFilterNumericLength.TabIndex = 97;
            // 
            // checkBoxFilterNumeric
            // 
            this.checkBoxFilterNumeric.AutoSize = true;
            this.checkBoxFilterNumeric.Location = new System.Drawing.Point(657, 112);
            this.checkBoxFilterNumeric.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxFilterNumeric.Name = "checkBoxFilterNumeric";
            this.checkBoxFilterNumeric.Size = new System.Drawing.Size(89, 19);
            this.checkBoxFilterNumeric.TabIndex = 96;
            this.checkBoxFilterNumeric.Text = "过滤数字";
            this.checkBoxFilterNumeric.UseVisualStyleBackColor = true;
            // 
            // checkBoxIgnoreCapital
            // 
            this.checkBoxIgnoreCapital.AutoSize = true;
            this.checkBoxIgnoreCapital.Location = new System.Drawing.Point(934, 80);
            this.checkBoxIgnoreCapital.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxIgnoreCapital.Name = "checkBoxIgnoreCapital";
            this.checkBoxIgnoreCapital.Size = new System.Drawing.Size(134, 19);
            this.checkBoxIgnoreCapital.TabIndex = 99;
            this.checkBoxIgnoreCapital.Text = "忽略英文大小写";
            this.checkBoxIgnoreCapital.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowTimeOnly
            // 
            this.checkBoxShowTimeOnly.AutoSize = true;
            this.checkBoxShowTimeOnly.Location = new System.Drawing.Point(11, 164);
            this.checkBoxShowTimeOnly.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxShowTimeOnly.Name = "checkBoxShowTimeOnly";
            this.checkBoxShowTimeOnly.Size = new System.Drawing.Size(134, 19);
            this.checkBoxShowTimeOnly.TabIndex = 100;
            this.checkBoxShowTimeOnly.Text = "仅显示分词时间";
            this.checkBoxShowTimeOnly.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnglishSegment
            // 
            this.checkBoxEnglishSegment.AutoSize = true;
            this.checkBoxEnglishSegment.Location = new System.Drawing.Point(394, 144);
            this.checkBoxEnglishSegment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxEnglishSegment.Name = "checkBoxEnglishSegment";
            this.checkBoxEnglishSegment.Size = new System.Drawing.Size(89, 19);
            this.checkBoxEnglishSegment.TabIndex = 101;
            this.checkBoxEnglishSegment.Text = "英文分词";
            this.checkBoxEnglishSegment.UseVisualStyleBackColor = true;
            // 
            // checkBoxSynonymOutput
            // 
            this.checkBoxSynonymOutput.AutoSize = true;
            this.checkBoxSynonymOutput.Location = new System.Drawing.Point(255, 771);
            this.checkBoxSynonymOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxSynonymOutput.Name = "checkBoxSynonymOutput";
            this.checkBoxSynonymOutput.Size = new System.Drawing.Size(104, 19);
            this.checkBoxSynonymOutput.TabIndex = 102;
            this.checkBoxSynonymOutput.Text = "输出同义词";
            this.checkBoxSynonymOutput.UseVisualStyleBackColor = true;
            // 
            // checkBoxWildcard
            // 
            this.checkBoxWildcard.AutoSize = true;
            this.checkBoxWildcard.Location = new System.Drawing.Point(377, 771);
            this.checkBoxWildcard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxWildcard.Name = "checkBoxWildcard";
            this.checkBoxWildcard.Size = new System.Drawing.Size(104, 19);
            this.checkBoxWildcard.TabIndex = 103;
            this.checkBoxWildcard.Text = "通配符匹配";
            this.checkBoxWildcard.UseVisualStyleBackColor = true;
            // 
            // checkBoxWildcardSegment
            // 
            this.checkBoxWildcardSegment.AutoSize = true;
            this.checkBoxWildcardSegment.Location = new System.Drawing.Point(517, 771);
            this.checkBoxWildcardSegment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxWildcardSegment.Name = "checkBoxWildcardSegment";
            this.checkBoxWildcardSegment.Size = new System.Drawing.Size(224, 19);
            this.checkBoxWildcardSegment.TabIndex = 104;
            this.checkBoxWildcardSegment.Text = "对通配符匹配出来的词再分词";
            this.checkBoxWildcardSegment.UseVisualStyleBackColor = true;
            // 
            // checkBoxCustomRule
            // 
            this.checkBoxCustomRule.AutoSize = true;
            this.checkBoxCustomRule.Location = new System.Drawing.Point(781, 770);
            this.checkBoxCustomRule.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxCustomRule.Name = "checkBoxCustomRule";
            this.checkBoxCustomRule.Size = new System.Drawing.Size(104, 19);
            this.checkBoxCustomRule.TabIndex = 105;
            this.checkBoxCustomRule.Text = "自定义规则";
            this.checkBoxCustomRule.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnglishMultiSelect
            // 
            this.checkBoxEnglishMultiSelect.AutoSize = true;
            this.checkBoxEnglishMultiSelect.Location = new System.Drawing.Point(253, 144);
            this.checkBoxEnglishMultiSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxEnglishMultiSelect.Name = "checkBoxEnglishMultiSelect";
            this.checkBoxEnglishMultiSelect.Size = new System.Drawing.Size(119, 19);
            this.checkBoxEnglishMultiSelect.TabIndex = 106;
            this.checkBoxEnglishMultiSelect.Text = "英文多元分词";
            this.checkBoxEnglishMultiSelect.UseVisualStyleBackColor = true;
            // 
            // btnShowResult
            // 
            this.btnShowResult.Location = new System.Drawing.Point(119, 89);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(100, 23);
            this.btnShowResult.TabIndex = 107;
            this.btnShowResult.Text = "显示结果";
            this.btnShowResult.UseVisualStyleBackColor = true;
            this.btnShowResult.Visible = false;
            this.btnShowResult.Click += new System.EventHandler(this.btnShowResult_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1272, 741);
            this.tabControl1.TabIndex = 108;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.textBoxSource);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxSegwords);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1264, 712);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "中文分词";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTextAnalysis);
            this.groupBox1.Controls.Add(this.buttonSegment);
            this.groupBox1.Controls.Add(this.numericUpDownRedundancy);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnShowResult);
            this.groupBox1.Controls.Add(this.checkBoxMultiSelect);
            this.groupBox1.Controls.Add(this.checkBoxEnglishMultiSelect);
            this.groupBox1.Controls.Add(this.checkBoxForceSingleWord);
            this.groupBox1.Controls.Add(this.buttonSaveConfig);
            this.groupBox1.Controls.Add(this.checkBoxTraditionalChs);
            this.groupBox1.Controls.Add(this.checkBoxDisplayPosition);
            this.groupBox1.Controls.Add(this.checkBoxFreqFirst);
            this.groupBox1.Controls.Add(this.checkBoxST);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBoxFilterStopWords);
            this.groupBox1.Controls.Add(this.checkBoxEnglishSegment);
            this.groupBox1.Controls.Add(this.checkBoxUnknownWord);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.checkBoxMatchName);
            this.groupBox1.Controls.Add(this.checkBoxShowTimeOnly);
            this.groupBox1.Controls.Add(this.checkBoxFilterEnglish);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBoxIgnoreCapital);
            this.groupBox1.Controls.Add(this.numericUpDownFilterEnglishLength);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelSrcLength);
            this.groupBox1.Controls.Add(this.labelFilterNumericLength);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labelRegRate);
            this.groupBox1.Controls.Add(this.numericUpDownFilterNumericLength);
            this.groupBox1.Controls.Add(this.checkBoxFilterNumeric);
            this.groupBox1.Controls.Add(this.labelSegTime);
            this.groupBox1.Location = new System.Drawing.Point(11, 508);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1245, 189);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分词设置";
            // 
            // btnTextAnalysis
            // 
            this.btnTextAnalysis.Location = new System.Drawing.Point(13, 89);
            this.btnTextAnalysis.Name = "btnTextAnalysis";
            this.btnTextAnalysis.Size = new System.Drawing.Size(100, 23);
            this.btnTextAnalysis.TabIndex = 108;
            this.btnTextAnalysis.Text = "文本分析";
            this.btnTextAnalysis.UseVisualStyleBackColor = true;
            this.btnTextAnalysis.Click += new System.EventHandler(this.btnTextAnalysis_Click);
            // 
            // textBoxSource
            // 
            this.textBoxSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSource.Location = new System.Drawing.Point(0, 21);
            this.textBoxSource.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxSource.MaxLength = 327670000;
            this.textBoxSource.Multiline = true;
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSource.Size = new System.Drawing.Size(1264, 314);
            this.textBoxSource.TabIndex = 108;
            this.textBoxSource.Text = "分萧索。两株大松树下围着一堆村民，男男女女和十几个小孩，正自聚精会神的听着一个瘦削的老者说话。";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1264, 712);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "处理结果";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1264, 712);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "量词分词结果";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1258, 706);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Location = new System.Drawing.Point(3, 3);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(1258, 706);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // FormDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 741);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.checkBoxCustomRule);
            this.Controls.Add(this.checkBoxWildcardSegment);
            this.Controls.Add(this.checkBoxWildcard);
            this.Controls.Add(this.checkBoxSynonymOutput);
            this.Controls.Add(this.numericUpDownUnknownWordsThreshold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormDemo";
            this.Text = "射雕英雄传Demo";
            this.Load += new System.EventHandler(this.FormDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRedundancy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnknownWordsThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterEnglishLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilterNumericLength)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDownRedundancy;
        private System.Windows.Forms.CheckBox checkBoxMultiSelect;
        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.NumericUpDown numericUpDownUnknownWordsThreshold;
        private System.Windows.Forms.CheckBox checkBoxFreqFirst;
        private System.Windows.Forms.CheckBox checkBoxDisplayPosition;
        private System.Windows.Forms.CheckBox checkBoxFilterStopWords;
        private System.Windows.Forms.CheckBox checkBoxMatchName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelSrcLength;
        private System.Windows.Forms.Label labelRegRate;
        private System.Windows.Forms.Label labelSegTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSegment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSegwords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxForceSingleWord;
        private System.Windows.Forms.CheckBox checkBoxTraditionalChs;
        private System.Windows.Forms.CheckBox checkBoxST;
        private System.Windows.Forms.CheckBox checkBoxUnknownWord;
        private System.Windows.Forms.CheckBox checkBoxFilterEnglish;
        private System.Windows.Forms.NumericUpDown numericUpDownFilterEnglishLength;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelFilterNumericLength;
        private System.Windows.Forms.NumericUpDown numericUpDownFilterNumericLength;
        private System.Windows.Forms.CheckBox checkBoxFilterNumeric;
        private System.Windows.Forms.CheckBox checkBoxIgnoreCapital;
        private System.Windows.Forms.CheckBox checkBoxShowTimeOnly;
        private System.Windows.Forms.CheckBox checkBoxEnglishSegment;
        private System.Windows.Forms.CheckBox checkBoxSynonymOutput;
        private System.Windows.Forms.CheckBox checkBoxWildcard;
        private System.Windows.Forms.CheckBox checkBoxWildcardSegment;
        private System.Windows.Forms.CheckBox checkBoxCustomRule;
        private System.Windows.Forms.CheckBox checkBoxEnglishMultiSelect;
        private System.Windows.Forms.Button btnShowResult;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.TabPage tabPage2;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnTextAnalysis;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

