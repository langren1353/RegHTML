namespace WindowsFormsApplication1
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
            this.openConn = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.inputReg = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.searchKeyWd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gNoTabflag = new System.Windows.Forms.CheckBox();
            this.gNoLineflag = new System.Windows.Forms.CheckBox();
            this.gCharset = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gNoEmptyLine = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sCharset = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button6 = new System.Windows.Forms.Button();
            this.inputReplace = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.text_result = new RichTextBoxEx();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sLineNum = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.sChildLine = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.sFatherLine = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gHeaderData = new RichTextBoxEx();
            this.gPostData = new RichTextBoxEx();
            this.textBox1 = new RichTextBoxEx();
            this.cIsMethodPost = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gContextFormat = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cReplace_to = new System.Windows.Forms.TextBox();
            this.btn_Replace = new System.Windows.Forms.Button();
            this.cReplace_from = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openConn
            // 
            this.openConn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openConn.Location = new System.Drawing.Point(518, 2);
            this.openConn.Name = "openConn";
            this.openConn.Size = new System.Drawing.Size(67, 33);
            this.openConn.TabIndex = 0;
            this.openConn.Text = "打开链接";
            this.openConn.UseVisualStyleBackColor = true;
            this.openConn.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchText
            // 
            this.searchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchText.Font = new System.Drawing.Font("宋体", 10F);
            this.searchText.Location = new System.Drawing.Point(59, 8);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(417, 23);
            this.searchText.TabIndex = 0;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            this.searchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchText_KeyDown);
            this.searchText.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.searchText_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(4, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "网址：";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(623, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "P";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "正则表达式：";
            // 
            // inputReg
            // 
            this.inputReg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputReg.Font = new System.Drawing.Font("宋体", 10F);
            this.inputReg.Location = new System.Drawing.Point(107, 3);
            this.inputReg.Name = "inputReg";
            this.inputReg.Size = new System.Drawing.Size(322, 23);
            this.inputReg.TabIndex = 6;
            this.inputReg.TextChanged += new System.EventHandler(this.inputReg_TextChanged);
            this.inputReg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputReg_KeyDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 33);
            this.button2.TabIndex = 7;
            this.button2.Text = "全文匹配";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(122, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "复制Reg";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(448, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 72);
            this.button4.TabIndex = 9;
            this.button4.Text = "设置";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(233, 35);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 33);
            this.button5.TabIndex = 10;
            this.button5.Text = "选择正则";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.searchKeyWd);
            this.groupBox1.Location = new System.Drawing.Point(488, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 70);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "全文搜索";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(30, 45);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(110, 25);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "搜索/下一个";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // searchKeyWd
            // 
            this.searchKeyWd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchKeyWd.Location = new System.Drawing.Point(17, 20);
            this.searchKeyWd.Name = "searchKeyWd";
            this.searchKeyWd.Size = new System.Drawing.Size(136, 21);
            this.searchKeyWd.TabIndex = 0;
            this.searchKeyWd.TextChanged += new System.EventHandler(this.searchKeyWd_TextChanged);
            this.searchKeyWd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchKeyWd_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(382, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "0/0";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // gNoTabflag
            // 
            this.gNoTabflag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gNoTabflag.AutoSize = true;
            this.gNoTabflag.Location = new System.Drawing.Point(488, 68);
            this.gNoTabflag.Name = "gNoTabflag";
            this.gNoTabflag.Size = new System.Drawing.Size(90, 16);
            this.gNoTabflag.TabIndex = 15;
            this.gNoTabflag.Text = "去掉Tab标记";
            this.gNoTabflag.UseVisualStyleBackColor = true;
            this.gNoTabflag.CheckedChanged += new System.EventHandler(this.HTMLTextCheckedchange);
            // 
            // gNoLineflag
            // 
            this.gNoLineflag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gNoLineflag.AutoSize = true;
            this.gNoLineflag.Location = new System.Drawing.Point(566, 49);
            this.gNoLineflag.Name = "gNoLineflag";
            this.gNoLineflag.Size = new System.Drawing.Size(84, 16);
            this.gNoLineflag.TabIndex = 14;
            this.gNoLineflag.Text = "去掉行标记";
            this.gNoLineflag.UseVisualStyleBackColor = true;
            this.gNoLineflag.CheckedChanged += new System.EventHandler(this.HTMLTextCheckedchange);
            // 
            // gCharset
            // 
            this.gCharset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gCharset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gCharset.FormattingEnabled = true;
            this.gCharset.Items.AddRange(new object[] {
            "GB2312",
            "GBK",
            "GB18030",
            "UTF-8"});
            this.gCharset.Location = new System.Drawing.Point(580, 87);
            this.gCharset.Name = "gCharset";
            this.gCharset.Size = new System.Drawing.Size(68, 20);
            this.gCharset.TabIndex = 17;
            this.gCharset.SelectedIndexChanged += new System.EventHandler(this.gCharset_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(491, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "请求网页的编码";
            // 
            // gNoEmptyLine
            // 
            this.gNoEmptyLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gNoEmptyLine.AutoSize = true;
            this.gNoEmptyLine.Location = new System.Drawing.Point(488, 49);
            this.gNoEmptyLine.Name = "gNoEmptyLine";
            this.gNoEmptyLine.Size = new System.Drawing.Size(72, 16);
            this.gNoEmptyLine.TabIndex = 18;
            this.gNoEmptyLine.Text = "去掉空行";
            this.gNoEmptyLine.UseVisualStyleBackColor = true;
            this.gNoEmptyLine.CheckedChanged += new System.EventHandler(this.HTMLTextCheckedchange);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "输出网页的编码";
            // 
            // sCharset
            // 
            this.sCharset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sCharset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sCharset.FormattingEnabled = true;
            this.sCharset.Items.AddRange(new object[] {
            "GB2312",
            "GBK",
            "GB18030",
            "UTF-8"});
            this.sCharset.Location = new System.Drawing.Point(580, 109);
            this.sCharset.Name = "sCharset";
            this.sCharset.Size = new System.Drawing.Size(68, 20);
            this.sCharset.TabIndex = 19;
            this.sCharset.SelectedIndexChanged += new System.EventHandler(this.sCharset_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.Location = new System.Drawing.Point(373, 286);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 28);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "备忘记事本";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.inputReplace);
            this.groupBox2.Location = new System.Drawing.Point(522, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 67);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "正则结果替换";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "行号";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(57, 38);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 29);
            this.button6.TabIndex = 1;
            this.button6.Text = "执行替换";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // inputReplace
            // 
            this.inputReplace.Location = new System.Drawing.Point(6, 15);
            this.inputReplace.Name = "inputReplace";
            this.inputReplace.Size = new System.Drawing.Size(110, 21);
            this.inputReplace.TabIndex = 0;
            this.inputReplace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputReplace_KeyDown);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(346, 35);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 33);
            this.button7.TabIndex = 26;
            this.button7.Text = "格式化Reg";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(41, 38);
            this.label5.MaximumSize = new System.Drawing.Size(500, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 14);
            this.label5.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 28;
            this.label7.Text = "标题:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 20);
            this.tabControl1.Location = new System.Drawing.Point(5, 291);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(652, 320);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 29;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.inputReg);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.text_result);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(644, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "正则匹配";
            // 
            // text_result
            // 
            this.text_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_result.DetectUrls = false;
            this.text_result.Font = new System.Drawing.Font("宋体", 10F);
            this.text_result.HideSelection = false;
            this.text_result.Location = new System.Drawing.Point(6, 76);
            this.text_result.Name = "text_result";
            this.text_result.Size = new System.Drawing.Size(632, 211);
            this.text_result.TabIndex = 25;
            this.text_result.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.gHeaderData);
            this.tabPage2.Controls.Add(this.gPostData);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(644, 292);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "设置选项";
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(532, 224);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(106, 64);
            this.button8.TabIndex = 17;
            this.button8.Text = "确定";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.sLineNum);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.sChildLine);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.sFatherLine);
            this.groupBox3.Location = new System.Drawing.Point(7, 217);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 71);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "正则显示选项";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "显示编号";
            // 
            // sLineNum
            // 
            this.sLineNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sLineNum.FormattingEnabled = true;
            this.sLineNum.Items.AddRange(new object[] {
            "True",
            "False"});
            this.sLineNum.Location = new System.Drawing.Point(91, 40);
            this.sLineNum.Name = "sLineNum";
            this.sLineNum.Size = new System.Drawing.Size(80, 20);
            this.sLineNum.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "显示父匹配";
            // 
            // sChildLine
            // 
            this.sChildLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sChildLine.FormattingEnabled = true;
            this.sChildLine.Items.AddRange(new object[] {
            "True",
            "False"});
            this.sChildLine.Location = new System.Drawing.Point(276, 11);
            this.sChildLine.Name = "sChildLine";
            this.sChildLine.Size = new System.Drawing.Size(80, 20);
            this.sChildLine.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(196, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "显示子匹配";
            // 
            // sFatherLine
            // 
            this.sFatherLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sFatherLine.FormattingEnabled = true;
            this.sFatherLine.Items.AddRange(new object[] {
            "True",
            "False"});
            this.sFatherLine.Location = new System.Drawing.Point(91, 11);
            this.sFatherLine.Name = "sFatherLine";
            this.sFatherLine.Size = new System.Drawing.Size(80, 20);
            this.sFatherLine.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "Header数据:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 36);
            this.label8.TabIndex = 0;
            this.label8.Text = "POST数据:\r\n\r\n无数据则GET";
            // 
            // gHeaderData
            // 
            this.gHeaderData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gHeaderData.DetectUrls = false;
            this.gHeaderData.Font = new System.Drawing.Font("宋体", 10F);
            this.gHeaderData.Location = new System.Drawing.Point(75, 87);
            this.gHeaderData.Name = "gHeaderData";
            this.gHeaderData.Size = new System.Drawing.Size(563, 124);
            this.gHeaderData.TabIndex = 10;
            this.gHeaderData.Text = "";
            // 
            // gPostData
            // 
            this.gPostData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gPostData.DetectUrls = false;
            this.gPostData.Font = new System.Drawing.Font("宋体", 10F);
            this.gPostData.Location = new System.Drawing.Point(75, 8);
            this.gPostData.Name = "gPostData";
            this.gPostData.Size = new System.Drawing.Size(563, 73);
            this.gPostData.TabIndex = 8;
            this.gPostData.Text = "";
            this.gPostData.TextChanged += new System.EventHandler(this.gPostData_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.DetectUrls = false;
            this.textBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(8, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(468, 230);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "";
            // 
            // cIsMethodPost
            // 
            this.cIsMethodPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cIsMethodPost.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cIsMethodPost.ForeColor = System.Drawing.Color.Black;
            this.cIsMethodPost.Location = new System.Drawing.Point(477, 8);
            this.cIsMethodPost.Name = "cIsMethodPost";
            this.cIsMethodPost.Size = new System.Drawing.Size(42, 23);
            this.cIsMethodPost.TabIndex = 30;
            this.cIsMethodPost.Text = "GET";
            this.cIsMethodPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(491, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 12);
            this.label13.TabIndex = 32;
            this.label13.Text = "Unicode格式化";
            // 
            // gContextFormat
            // 
            this.gContextFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gContextFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gContextFormat.FormattingEnabled = true;
            this.gContextFormat.Items.AddRange(new object[] {
            "Normal",
            "NoASCII",
            "NOASCII&ESC"});
            this.gContextFormat.Location = new System.Drawing.Point(580, 132);
            this.gContextFormat.Name = "gContextFormat";
            this.gContextFormat.Size = new System.Drawing.Size(68, 20);
            this.gContextFormat.TabIndex = 31;
            this.gContextFormat.SelectedIndexChanged += new System.EventHandler(this.gContextFormat_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.cReplace_to);
            this.groupBox4.Controls.Add(this.btn_Replace);
            this.groupBox4.Controls.Add(this.cReplace_from);
            this.groupBox4.Location = new System.Drawing.Point(488, 158);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 65);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "内容替换";
            // 
            // cReplace_to
            // 
            this.cReplace_to.Location = new System.Drawing.Point(6, 38);
            this.cReplace_to.Name = "cReplace_to";
            this.cReplace_to.Size = new System.Drawing.Size(84, 21);
            this.cReplace_to.TabIndex = 1;
            this.cReplace_to.TextChanged += new System.EventHandler(this.cReplace_from_TextChanged);
            this.cReplace_to.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cReplace_to_KeyDown);
            // 
            // btn_Replace
            // 
            this.btn_Replace.Location = new System.Drawing.Point(93, 19);
            this.btn_Replace.Name = "btn_Replace";
            this.btn_Replace.Size = new System.Drawing.Size(67, 33);
            this.btn_Replace.TabIndex = 2;
            this.btn_Replace.Text = "替换";
            this.btn_Replace.UseVisualStyleBackColor = true;
            this.btn_Replace.Click += new System.EventHandler(this.btn_Replace_Click);
            // 
            // cReplace_from
            // 
            this.cReplace_from.Location = new System.Drawing.Point(6, 14);
            this.cReplace_from.Name = "cReplace_from";
            this.cReplace_from.Size = new System.Drawing.Size(84, 21);
            this.cReplace_from.TabIndex = 0;
            this.cReplace_from.TextChanged += new System.EventHandler(this.cReplace_from_TextChanged);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Location = new System.Drawing.Point(588, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(30, 33);
            this.button9.TabIndex = 33;
            this.button9.Text = "D";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(659, 616);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gContextFormat);
            this.Controls.Add(this.cIsMethodPost);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sCharset);
            this.Controls.Add(this.gNoEmptyLine);
            this.Controls.Add(this.gCharset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gNoTabflag);
            this.Controls.Add(this.gNoLineflag);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.openConn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AC网页——正则";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openConn;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputReg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox searchKeyWd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox gNoTabflag;
        private System.Windows.Forms.CheckBox gNoLineflag;
        private System.Windows.Forms.ComboBox gCharset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox gNoEmptyLine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sCharset;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox inputReplace;
        private System.Windows.Forms.CheckBox checkBox1;
        private RichTextBoxEx textBox1;
        private RichTextBoxEx text_result;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private RichTextBoxEx gPostData;
        private RichTextBoxEx gHeaderData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox sLineNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox sChildLine;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox sFatherLine;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label cIsMethodPost;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox gContextFormat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_Replace;
        private System.Windows.Forms.TextBox cReplace_from;
        private System.Windows.Forms.TextBox cReplace_to;
        private System.Windows.Forms.Button button9;
    }
}

