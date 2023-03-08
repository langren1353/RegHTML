using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class setHTML : Form {
        public setHTML() {
            InitializeComponent();
        }

        private void setHTML_FormClosing(object sender, FormClosingEventArgs e) {
            this.Owner.Enabled = true;
        }

        private void setHTML_Load(object sender, EventArgs e) {
            gUA.SelectedIndex = 0;
            sFatherLine.SelectedIndex = Form1.config.isFatherShow == true ? 0 : 1;
            sChildLine.SelectedIndex = Form1.config.isChildShow == true ? 0 : 1;
            sLineNum.SelectedIndex = Form1.config.isShowLineNum == true ? 0 : 1;
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
            Form1.config.isChildShow = sChildLine.SelectedIndex == 0;
            Form1.config.isFatherShow = sFatherLine.SelectedIndex == 0;
            Form1.config.isShowLineNum = sLineNum.SelectedIndex == 0;
            Form1.config.PostData = gPostData.Text;
            Form1.config.UA = gUA.Text;
            ((Form1)this.Owner).button2_Click(null, null);
            this.Close();
        }
    }
}
