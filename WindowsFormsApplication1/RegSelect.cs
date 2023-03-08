using System;
using System.Drawing;
using System.Windows.Forms;

namespace RegHTML {
    public partial class RegSelect : Form {
        public RegSelect(WindowsFormsApplication1.Form1 form1) {
            InitializeComponent();
            this.Owner = form1;
            this.Location = new Point(this.Owner.Bounds.Right - 100, this.Owner.Bounds.Top + 70);
        }

        private void Form1_Load(object sender, EventArgs e) {
           
            listView1.Columns.Add("描述", 120);
            listView1.Columns.Add("正则表达式", 120);

            listView1.Items.Add(new ListViewItem(new String[] { "普通中文", "[\\u4e00-\\u9fa5]" }));
            listView1.Items.Add(new ListViewItem(new String[] { "全角字符", "[\\uFF00-\\uFFFF]" }));
            listView1.Items.Add(new ListViewItem(new String[] { "普通中文+中文标点", "[\\u4E00-\\u9FA5]|[\\uFE30-\\uFFA0]" }));
            
            listView1.Items.Add(new ListViewItem(new String[] { "电子邮件Email", "w+([-+.]w+)*@w+([-.]w+)*.w+([-.]w+)*" }));
            listView1.Items.Add(new ListViewItem(new String[] { "正浮点数", "[1-9]\\d*.\\d*|0.\\d*[1-9]\\d*" }));
            listView1.Items.Add(new ListViewItem(new String[] { "身份证", "(\\d{14}|\\d{17})(\\d|[xX])" }));

        }

        private void listView1_DoubleClick(object sender, EventArgs e) {
            int num = listView1.SelectedIndices[0];
            String text = listView1.Items[num].SubItems[1].Text;
            TextBox father_input = (TextBox)((WindowsFormsApplication1.Form1)this.Owner).Controls["tabControl1"].Controls[0].Controls["inputReg"];
            String oldtext = father_input.Text;
            father_input.Text = oldtext + text;
        }

        private void button1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
