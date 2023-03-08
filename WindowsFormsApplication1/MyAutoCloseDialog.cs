using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RegHTML {
    public partial class MyAutoCloseDialog : Form {
        public MyAutoCloseDialog() {
            InitializeComponent();
        }

        private void MyAutoCloseDialog_Deactivate(object sender, EventArgs e) {
            this.Close();
        }

        private void skinButton1_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
