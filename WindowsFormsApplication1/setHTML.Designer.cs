namespace WindowsFormsApplication1 {
    partial class setHTML {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setHTML));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gPostData = new System.Windows.Forms.TextBox();
            this.gUA = new System.Windows.Forms.ComboBox();
            this.sFatherLine = new System.Windows.Forms.ComboBox();
            this.sChildLine = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sLineNum = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "显示父匹配";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "显示子匹配";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "UA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 48);
            this.label5.TabIndex = 4;
            this.label5.Text = "附属信息\r\n一般是Post\r\n的数据，不要\r\n有引号";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gPostData
            // 
            this.gPostData.Location = new System.Drawing.Point(91, 127);
            this.gPostData.Multiline = true;
            this.gPostData.Name = "gPostData";
            this.gPostData.Size = new System.Drawing.Size(265, 79);
            this.gPostData.TabIndex = 7;
            // 
            // gUA
            // 
            this.gUA.FormattingEnabled = true;
            this.gUA.Items.AddRange(new object[] {
            "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:39.0) Gecko/20100101 Firefox/39.0",
            "Mozilla/5.0 (Linux; U; Android 2.0; en-us; Droid Build/ESD20) AppleWebKit/530.17 " +
                "(KHTML, like Gecko) Version/4.0 Mobile Safari/530.17",
            "Mozilla/5.0 (Macintosh; U; PPC Mac OS X 10_5_8; ja-jp) AppleWebKit/533.16 (KHTML," +
                " like Gecko) Version/5.0 Safari/533.16"});
            this.gUA.Location = new System.Drawing.Point(91, 20);
            this.gUA.Name = "gUA";
            this.gUA.Size = new System.Drawing.Size(265, 20);
            this.gUA.TabIndex = 8;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gUA);
            this.groupBox1.Controls.Add(this.gPostData);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 216);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "获取选项";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.sLineNum);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.sChildLine);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.sFatherLine);
            this.groupBox2.Location = new System.Drawing.Point(12, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 70);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "显示选项";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "显示编号";
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
            // setHTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 370);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "setHTML";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.setHTML_FormClosing);
            this.Load += new System.EventHandler(this.setHTML_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox gPostData;
        private System.Windows.Forms.ComboBox gUA;
        private System.Windows.Forms.ComboBox sFatherLine;
        private System.Windows.Forms.ComboBox sChildLine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sLineNum;
    }
}