using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Text;
using System.Diagnostics;
using RegHTML;
using System.Reflection;
using System.Collections.Specialized;
using System.Collections;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public static int searchPos = 0, curCount = 0, maxCount = 0;
        public static Boolean needFind = true, isInit = false;
        private String[] HTMLTextset = new String[8];
        private Boolean isMethodPost = false;
        MyAutoCloseDialog dialog = new MyAutoCloseDialog();
        public class config {
            public static String charSet = "GBK";
            public static String outCharset = "UTF-8";
            public static int num1, num2, num3, showNum;
            public static String PostData = "";
            public static String HeaderData = "";
            public static String UA = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:42.0) Gecko/20100101 Firefox/42.0";

            public static Boolean isFatherShow = true;
            public static Boolean isChildShow = true;
            public static Boolean isShowLineNum = true;
            
            public static Boolean isNoTab = false;
        }
        private class oldText {
            public static Stack<String> oldSearchText_Zdo = new Stack<String>();
            public static Stack<String> oldSearchText_Ydo = new Stack<String>();
            public static Boolean oldSearchText_isFunc = false;

            public static Stack<String> oldHTMLText_Zdo = new Stack<String>();
            public static Stack<String> oldHTMLText_Ydo = new Stack<String>();
            public static Boolean oldHTMLText_isFunc = false;

            public static Stack<String> oldRegText_Zdo = new Stack<String>();
            public static Stack<String> oldRegText_Ydo = new Stack<String>();
            public static Boolean oldRegText_isFunc = false;

            public static Stack<String> oldResultText_Zdo = new Stack<String>();
            public static Stack<String> oldResultText_Ydo = new Stack<String>();
            public static Boolean oldResultText_isFunc = false;

            public static void DealSearchText_Zdo(TextBox tbk) {
                try {
                    //Console.Write("撤销"+ oldSearchText_Zdo.Count);
                    String top = oldText.oldSearchText_Zdo.Pop();
                    //Console.Write(top);
                    oldText.oldSearchText_Ydo.Push(top);
                    top = oldText.oldSearchText_Zdo.Peek();
                    //Console.Write(top);
                    tbk.Text = top;
                } catch (Exception e) {
                    Console.Write(e.Message);
                    tbk.Text = "";
                }
            }
            public static void DealHTMLText_Zdo(RichTextBox tbk) {
                try {
                    String top = oldText.oldHTMLText_Zdo.Pop();
                    Console.Write(top);
                    oldText.oldHTMLText_Ydo.Push(top);
                    top = oldText.oldHTMLText_Zdo.Peek();
                    tbk.Text = top;
                } catch (Exception e) {
                    Console.Write(e.Message);
                    tbk.Text = "";
                }
            }
            public static void DealRegText_Zdo(TextBox tbk) {
                try {
                    String top = oldText.oldRegText_Zdo.Pop();
                    oldText.oldRegText_Ydo.Push(top);
                    top = oldText.oldRegText_Zdo.Peek();
                    tbk.Text = top;
                } catch (Exception e) {
                    Console.Write(e.Message);
                    tbk.Text = "";
                }
            }
            public static void DealResultText_Zdo(RichTextBox tbk) {
                try {
                    String top = oldText.oldResultText_Zdo.Pop();
                    oldText.oldResultText_Ydo.Push(top);
                    top = oldText.oldResultText_Zdo.Peek();
                    tbk.Text = top;
                } catch (Exception e) {
                    Console.Write(e.Message);
                    tbk.Text = "";
                }
            }
            public static void DealSearchText_Ydo(TextBox tbk) {
                try {
                    String top = oldText.oldSearchText_Ydo.Pop();
                    oldText.oldSearchText_Zdo.Push(top);
                    top = oldText.oldSearchText_Zdo.Peek();
                    tbk.Text = top;
                } catch (Exception e) {
                    Console.Write(e.Message);
                    tbk.Text = "";
                }
            }
            public static void DealHTMLText_Ydo(RichTextBox tbk) {
                try {
                    String top = oldText.oldHTMLText_Ydo.Pop();
                    oldText.oldHTMLText_Zdo.Push(top);
                    top = oldText.oldHTMLText_Zdo.Peek();
                    tbk.Text = top;
                } catch (Exception e) {
                    Console.Write(e.Message);
                    tbk.Text = "";
                }
            }
            public static void DealRegText_Ydo(TextBox tbk) {
                try {
                    String top = oldText.oldRegText_Ydo.Pop();
                    oldText.oldRegText_Zdo.Push(top);
                    top = oldText.oldRegText_Zdo.Peek();
                    tbk.Text = top;
                } catch (Exception e) {
                    Console.Write(e.Message);
                    tbk.Text = "";
                }
            }
            public static void DealResultText_Ydo(RichTextBox tbk) {
                try {
                    String top = oldText.oldResultText_Zdo.Pop();
                    oldText.oldResultText_Ydo.Push(top);
                    top = oldText.oldResultText_Zdo.Peek();
                    tbk.Text = top;
                } catch (Exception e) {
                    Console.Write(e.Message);
                    tbk.Text = "";
                }
            }
        }
        public String getSaveDocument() {
            string temp = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\ACReg";
            if (!Directory.Exists(temp)) {
                Directory.CreateDirectory(temp);
                return temp;
            }
            return temp;
        }
        public Form1() {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }
       
        /*****************************以下为N个Ctrl Z 和 Ctrl Y事件***************************/
        private void searchText_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) button1_Click(null, null);
            if (e.Control && e.KeyCode == Keys.Z) {
                oldText.DealSearchText_Zdo(searchText);
                e.Handled = true;
            } else if (e.Control && e.KeyCode == Keys.Y) {
                oldText.DealSearchText_Ydo(searchText);
                e.Handled = true;
            } else if (!e.Control) {
                return;
            }
            oldText.oldSearchText_isFunc = true;
        }

        private void searchText_TextChanged(object sender, EventArgs e) {
            // 若是函数调用则重置flag，不加入回退表-正常返回
            // 按键输入方式或者其他方式，加入回退表
            if (oldText.oldSearchText_isFunc == true) {
                oldText.oldSearchText_isFunc = false;
                return;
            }
            Console.WriteLine(searchText.Text);
            oldText.oldSearchText_Zdo.Push(searchText.Text);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.Z) {
                oldText.DealHTMLText_Zdo(textBox1);
                e.Handled = true;
            } else if (e.Control && e.KeyCode == Keys.Y) {
                oldText.DealHTMLText_Ydo(textBox1);
                e.Handled = true;
            } else if (!e.Control) {
                HTMLchanged();
                return;
            }
            oldText.oldHTMLText_isFunc = true;
        }

        private void inputReg_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) button2_Click(null, null);
            if (e.Control && e.KeyCode == Keys.Z) {
                oldText.DealRegText_Zdo(inputReg);
                e.Handled = true;
            } else if (e.Control && e.KeyCode == Keys.Y) {
                oldText.DealRegText_Ydo(inputReg);
                e.Handled = true;
            } else if (!e.Control) {
                return;
            }
            oldText.oldRegText_isFunc = true;
        }

        private void inputReg_TextChanged(object sender, EventArgs e) {
            // 若是函数调用则重置flag，不加入回退表-正常返回
            // 按键输入方式或者其他方式，加入回退表
            if (oldText.oldRegText_isFunc == true) {
                oldText.oldRegText_isFunc = false;
                return;
            }
            Console.WriteLine(inputReg.Text);
            oldText.oldRegText_Zdo.Push(inputReg.Text);
        }

        private void text_result_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.Z) {
                oldText.DealResultText_Zdo(text_result);
                e.Handled = true;
            } else if (e.Control && e.KeyCode == Keys.Y) {
                oldText.DealResultText_Ydo(text_result);
                e.Handled = true;
            } else if (e.Control && e.KeyCode == Keys.A) {
                text_result.SelectAll();
                e.Handled = true;
            } else if (!e.Control) {
                e.Handled = true;
                return;
            }
            oldText.oldResultText_isFunc = true;
        }

        private void text_result_TextChanged(object sender, EventArgs e) {
            // 若是函数调用则重置flag，不加入回退表-正常返回
            // 按键输入方式或者其他方式，加入回退表
            if (oldText.oldResultText_isFunc == true) {
                oldText.oldResultText_isFunc = false;
                return;
            }
            Console.WriteLine(text_result.Text);
            oldText.oldResultText_Zdo.Push(text_result.Text);
        }
        /****************************N个Ctrl Z 和 Ctrl Y事件结束****************************/
        
        public static void SetHeaderValue(WebHeaderCollection header, string name, string value)
        {
            var property = typeof(WebHeaderCollection).GetProperty("InnerCollection",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            if (property != null)
            {
                var collection = property.GetValue(header, null) as NameValueCollection;
                collection[name] = value;
            }
        }

        public String myHttpStringGet(String url, String charset)
        {
            String outStr = "";
            try
            {
                HttpWebRequest httpWebReq = (HttpWebRequest)WebRequest.Create(url);
                httpWebReq.UserAgent = config.UA;
                String[] tHeaders = config.HeaderData.Replace("\r", "").Split(new String[]{ "\n"}, StringSplitOptions.RemoveEmptyEntries);
                foreach (String one in tHeaders) {
                    int pos = one.LastIndexOf(":");
                    String[] pers = new string[2];
                    pers[0] = one.Substring(0, pos);
                    pers[1] = one.Substring(pos + 1).Trim();
                    SetHeaderValue(httpWebReq.Headers, pers[0], pers[1]);
                }
                httpWebReq.Credentials = CredentialCache.DefaultCredentials;
                if (isMethodPost == true)
                {
                    httpWebReq.Method = "POST";
                    isMethodPost = false; //POST之后默认设置为GET方法
                    setMethod_POST_And_GET(isMethodPost);
                    byte[] bs = Encoding.UTF8.GetBytes(config.PostData);
                    using (Stream reqStream = httpWebReq.GetRequestStream())
                    {
                        reqStream.Write(bs, 0, bs.Length);
                        reqStream.Close();
                    }
                }
                HttpWebResponse response = (HttpWebResponse)httpWebReq.GetResponse();
                Stream stream = response.GetResponseStream();
                StreamReader streamReader = new StreamReader(stream, Encoding.GetEncoding(charset));
                outStr = streamReader.ReadToEnd();
                streamReader.Close();
                stream.Close();
                response.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return outStr;
        }

        public String myHttpStringDeal(String url, String charset)
        {
            String outStr = "";
            try
            {
                String[] tHeaders = config.HeaderData.Replace("\r", "").Split(new String[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                ArrayList list = new ArrayList();
                foreach (String one in tHeaders)
                {
                    list.Add(one);
                }
                if (isMethodPost == true) {
                    isMethodPost = false; //POST之后默认设置为GET方法
                    setMethod_POST_And_GET(isMethodPost);
                    return MyHttp.myHttpStringPost(url, charset, config.PostData);
                }
                else {
                    return MyHttp.myHttpStringGet(url, charset, config.PostData);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return outStr;
        }

        public void button1_Click(object sender, EventArgs e) {
            if (tabControl1.SelectedIndex == 1) {
                tabControl1.SelectedIndex = 0;
                button8_Click(null, null);
            }
            gContextFormat.SelectedIndex = 0;
            searchPos = 0;
            needFind = true;
            textBox1.Clear();
            label5.Text = "";
            label7.Text = "";
            Thread t1 = new Thread(new ThreadStart(ThreadHTMLGet));
            t1.Start();
        }

        public void ThreadHTMLGet() {
            String urlStr = searchText.Text;
            if (urlStr.IndexOf("http://") != 0 && urlStr.IndexOf("https://") != 0)
                urlStr = "http://" + urlStr;
            String outStr = myHttpStringDeal(urlStr, config.charSet);
            textBox1.Text = outStr;
            String title = MyReg.Reg_GetFirstString(outStr, "<title>([^<]+)</title>");
            if(title != null)
                label5.Text = MyTools.GetSubstringByLength(title.Trim(), 46);
            label7.Text = "标题:";
            HTMLTextCheckedchange(null, null);
        }
        public void button3_Click(object sender, EventArgs e) {
            String reg = inputReg.Text.Trim();
            String regText = reg.Replace("\\", "\\\\").Replace("\"", "\\\"");
            Clipboard.Clear();
            Clipboard.SetData(DataFormats.StringFormat, regText);
            dialog.Show();
            dialog = new MyAutoCloseDialog();
            //MessageBox.Show(this, "已经成功复制到剪切板了哦", "复制成功");
        }

        public void button2_Click(object sender, EventArgs e) { // 正则处理
            String outRegResult = "";
            try {
                String regStr = inputReg.Text;
                if (regStr == "") return;
                Regex reg = new Regex(regStr);
                String text = textBox1.Text;
                MatchCollection matchs = null;
                if (text != "")
                    matchs = reg.Matches(text);
                else
                    return;
                int count = matchs.Count;
                for (int i = 1; i <= count; i++) {
                    if(config.isShowLineNum == true)
                        outRegResult += i + ".";
                    if (config.isFatherShow == true)
                        outRegResult += matchs[i - 1].Groups[0].Value;
                    outRegResult += "\r\n";
                    int gCount = matchs[i - 1].Groups.Count;
                    if (config.isChildShow == true) {
                        for (int j = 1; j < gCount; j++) {
                            outRegResult += "  " + j + ".)" + matchs[i - 1].Groups[j].Value + "\r\n";
                        }
                        outRegResult += "\r\n";
                    }
                }
            } catch (Exception ee) {
                MessageBox.Show(this, ee.Message);
                outRegResult = "无法匹配成功";
            }
            if (outRegResult.Equals(""))
                outRegResult = "无法匹配成功";
            text_result.Text = outRegResult;
        }
        private void btn_Search_Click(object sender, EventArgs e) {
            //String[] re = text.Split(new String[] { " "}, StringSplitOptions.RemoveEmptyEntries);
            //List<string> list = new List<string>();
            //foreach (String i in re) {
            //    list.Add(i);
            //}
            String text = searchKeyWd.Text;
            if (needFind == true) {
                int startPos = myFindandHightlight(text, "#FFF300");
                if (startPos == -1) return;
                searchPos = startPos;
                needFind = false;
                curCount++;
                textBox1.SelectionStart = startPos;
                textBox1.SelectionLength = text.Length;
                textBox1.SelectionBackColor = ColorTranslator.FromHtml("#FFF300");
            } else {
                //普通的改变序号
                int prePos = (searchPos > textBox1.Text.Length) ? 0 : searchPos; // 如果位置越界，那么重设为0
                searchPos = textBox1.Find(text, prePos + text.Length, RichTextBoxFinds.None);
                curCount++;
                if (searchPos == -1) {
                    MessageBox.Show(this, "查找完毕，重置搜索index为0");
                    searchPos = 0;
                    curCount = 0;
                    return;
                }
                textBox1.SelectionStart = searchPos;
                textBox1.SelectionLength = text.Length;
                textBox1.SelectionBackColor = ColorTranslator.FromHtml("#FFF300");
            }
            label3.Text = curCount + "/" + maxCount;
        }
        public int myFindandHightlight(String text, String ColorStrring) {
            int index = textBox1.Find(text, RichTextBoxFinds.None);//调用find方法
            Boolean isfinded = false;
            int startPos = index;
            int nextIndex = -1;
            curCount = 0;
            maxCount = 0;
            while (nextIndex != startPos) {//循环查找字符串，并用蓝色加粗12号Times New Roman标记之  
                maxCount++;
                textBox1.SelectionStart = index;
                textBox1.SelectionLength = text.Length;
                textBox1.SelectionBackColor = ColorTranslator.FromHtml(ColorStrring);
                textBox1.Focus();
                nextIndex = textBox1.Find(text, index + text.Length, RichTextBoxFinds.None);
                if (nextIndex == -1)//若查到文件末尾，则重置nextIndex为初始位置的值，使其达到初始位置，顺利结束循环，否则会有异常。  
                    nextIndex = startPos;
                if (isfinded == false) {
                    if (searchPos < nextIndex) {
                        searchPos = nextIndex;
                        isfinded = true;
                    }
                }
                index = nextIndex;
            }
            return startPos;
        }
        
        private void HTMLchanged() {
            searchPos = 0;
            needFind = true;
            Console.WriteLine("modified");
        }

        private void button4_Click(object sender, EventArgs e) {
            tabControl1.SelectedIndex = 1;
            //setHTML sethtml = new setHTML();
            //this.AddOwnedForm(sethtml);
            //this.Enabled = false;
            //sethtml.Show();
        }

        private void button1_Click_1(object sender, EventArgs e) {
            String HTMLText = textBox1.Text.Trim();
            String temp = getSaveDocument() + "/regHTMLtext.html";
            FileStream fileStream = new FileStream(temp, FileMode.Create);
            StreamWriter sWriter = new StreamWriter(fileStream, Encoding.GetEncoding(config.outCharset));
            sWriter.Write(HTMLText);
            sWriter.Close();
            fileStream.Close();
            System.Diagnostics.Process.Start(temp);
        }

        private void HTMLTextCheckedchange(object sender, EventArgs e) {
            if(e == null)
                HTMLTextset[0] = null;
            if (isInit == true) return;
            config.num1 = gNoEmptyLine.Checked == true ? 1 : 0;
            config.num2 = gNoLineflag.Checked == true ? 1 : 0;
            config.num3 = gNoTabflag.Checked == true ? 1 : 0;

            int num = config.num1 + config.num2 * 2 + config.num3 * 4;// noLine = 1, noTab  = 2, noAll = 3
            String outStr = HTMLTextset[0];
            if (outStr == null) outStr = textBox1.Text;
            HTMLTextset[0] = outStr; // 000
            HTMLTextset[1] = myReplace(outStr, "(?=\n)\n\\s*(?=\n)", "");// outStr.Replace("\n\r", ""); // 001
            HTMLTextset[2] = myReplace(outStr, "\n", ""); //outStr.Replace("\r\n", ""); // 010
            HTMLTextset[4] = myReplace(outStr, "\t", ""); //outStr.Replace("\t", ""); // 100

            HTMLTextset[3] = HTMLTextset[2];             // 011----A+a = A
            HTMLTextset[5] = myReplace(HTMLTextset[1], "\t", "");  //HTMLTextset[1].Replace("\t", ""); // 101
            HTMLTextset[6] = myReplace(HTMLTextset[2], "\t", ""); //HTMLTextset[2].Replace("\t", ""); // 110
            HTMLTextset[7] = HTMLTextset[6]; // 111
            textBox1.Text = HTMLTextset[num];
            HTMLchanged();
        }

        public String myReplace(String source, String oldStr ,String newStr) {
            Regex reg = new Regex(oldStr);
            return reg.Replace(source, newStr);
        }
        private void Form1_Load(object sender, EventArgs e) {
            //任务列表：
            isInit = true;
            initData();
            gCharset.SelectedItem = config.charSet;
            sCharset.SelectedItem = config.outCharset;
            gContextFormat.SelectedIndex = 0;
            if (config.num1 == 1) gNoEmptyLine.Checked = true;
            if (config.num2 == 1) gNoLineflag.Checked = true;
            if (config.num3 == 1) gNoTabflag.Checked = true;
            if (config.showNum == 1) checkBox1.Checked = true;
            isInit = false;
        }
        public void initData() {
            // 从文件中读取数据
            try {
                String temp = getSaveDocument() + "/regHTMLini.ini";
                FileStream fileStream = new FileStream(temp, FileMode.OpenOrCreate);
                TextReader streamReader = new StreamReader(fileStream);
                searchText.Text = streamReader.ReadLine();
                inputReg.Text = streamReader.ReadLine();
                try {
                    string text = streamReader.ReadLine();
                    string[] configCharset  = null;
                    string[] configNum      = null;
                    if (text != null) {
                        configCharset = text.Split(new string[] { "|" }, StringSplitOptions.None);
                        text = streamReader.ReadLine();
                        if (text != null) {
                            configNum = text.Split(new String[] { "|" }, StringSplitOptions.None);
                            config.charSet = configCharset[0]; config.outCharset = configCharset[1];
                            config.num1 = Int16.Parse(configNum[0]); config.num2 = Int16.Parse(configNum[1]); config.num3 = Int16.Parse(configNum[2]); config.showNum = Int16.Parse(configNum[3]);
                            String[] replaceTxet = streamReader.ReadLine().Split('|');
                            cReplace_from.Text = replaceTxet[0];
                            cReplace_to.Text = replaceTxet[1];
                            searchKeyWd.Text = streamReader.ReadLine();
                            inputReplace.Text = streamReader.ReadLine();
                            text = streamReader.ReadToEnd();
                            textBox1.Text = text + "";
                            label5.Text = MyReg.Reg_GetFirstString(text, "<title>([^<]+)</title>");
                        } 
                    }
                    label7.Text = "标题:";
                } catch (Exception e) {
                    Console.Write(e);
                }
                streamReader.Close();
                fileStream.Close();
            } catch (Exception e) {
                Console.Write(e);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            String temp = getSaveDocument() + "/regHTMLini.ini";
            if (File.Exists(temp))
                File.Delete(temp);
            FileStream fileStream = new FileStream(temp, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            /*************/
            streamWriter.WriteLine(searchText.Text);
            streamWriter.WriteLine(inputReg.Text);
            streamWriter.WriteLine(config.charSet + "|" + config.outCharset);
            streamWriter.WriteLine(config.num1+"|"+config.num2+"|"+ config.num3 + "|"+ config.showNum);
            streamWriter.WriteLine(cReplace_from.Text+"|"+cReplace_to.Text);
            streamWriter.WriteLine(searchKeyWd.Text);
            streamWriter.WriteLine(inputReplace.Text);
            // 最后放入之前的HTML
            streamWriter.Write(textBox1.Text); // 不是writeLine，否则会导致回车越来越多
            streamWriter.Close();
            /*************/
            fileStream.Close();
        }

        private void gCharset_SelectedIndexChanged(object sender, EventArgs e) {
            config.charSet = gCharset.SelectedItem.ToString();
            sCharset.SelectedItem = config.charSet;
        }

        private void searchKeyWd_TextChanged(object sender, EventArgs e) {
            HTMLchanged();
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void button5_Click(object sender, EventArgs e) {
            RegHTML.RegSelect regSelect = new RegHTML.RegSelect(this);
            regSelect.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //MessageBox.Show(this, "杂项说明，包括版权，使用方法，缺点(\\r\\n-->\\n)");
            // 调用系统notepad 打开记录的
            String temp = getSaveDocument() + "/myNote.txt";
            Process.Start("NOTEPAD", temp);
        }

        private void button6_Click(object sender, EventArgs e) {
            String regStr = inputReg.Text;
            String repStr = inputReplace.Text;
            config.showNum = checkBox1.Checked == true?1:0;
            if (regStr == "") return;
            Regex reg = new Regex(regStr);
            String text = textBox1.Text;
            MatchCollection matchs = null;
            String outRegResult = "";
            if (text != "")
                matchs = reg.Matches(text);
            int count = matchs.Count;
            for (int i = 1; i <= count; i++) {
                if(config.showNum == 1)
                    outRegResult += i + ".";
                if (config.isFatherShow == true)
                    outRegResult += reg.Replace(matchs[i-1].Groups[0].Value, repStr);
                outRegResult += "\r\n";
            }
            if (outRegResult.Equals(""))
                outRegResult = "无法匹配成功";
            text_result.Text = outRegResult;
        }

        private void inputReplace_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                button6_Click(null, null);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if (isInit == true) return;
            button6_Click(null,null);
        }

        private void searchText_MouseDoubleClick(object sender, MouseEventArgs e) {
            searchText.SelectAll();
        }

        private void button7_Click(object sender, EventArgs e) {
            String tex = inputReg.Text;
            tex = tex.Replace("\\\\", "\\");
            tex = tex.Replace("\\\"", "\"");
            inputReg.Text = tex;
        }

        private void button8_Click(object sender, EventArgs e) {
            Form1.config.isChildShow = sChildLine.SelectedIndex == 0;
            Form1.config.isFatherShow = sFatherLine.SelectedIndex == 0;
            Form1.config.isShowLineNum = sLineNum.SelectedIndex == 0;
            Form1.config.PostData = gPostData.Text;
            Form1.config.HeaderData = gHeaderData.Text;
            button2_Click(null, null);//重新正则匹配
            tabControl1.SelectedIndex = 0;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            Console.WriteLine(tabControl1.SelectedIndex+"");
            if (tabControl1.SelectedIndex == 1) {
                reNewMethod_POST_And_GET();
                sFatherLine.SelectedIndex = Form1.config.isFatherShow == true ? 0 : 1;
                sChildLine.SelectedIndex = Form1.config.isChildShow == true ? 0 : 1;
                sLineNum.SelectedIndex = Form1.config.isShowLineNum == true ? 0 : 1;
            } else {
                button8_Click(null, null);
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e) {
            //MessageBox.Show(this, "杂项说明，包括版权，使用方法，缺点(\\r\\n-->\\n)");
            // 调用系统notepad 打开记录的
            String temp = getSaveDocument() + "/myNote.txt";
            Process.Start("NOTEPAD", temp);
        }

        private void gPostData_TextChanged(object sender, EventArgs e) {
            reNewMethod_POST_And_GET();
        }
        /// <summary>
        /// 如果内容不为空，则设置为POST模式，否则为GET模式
        /// </summary>
        private void reNewMethod_POST_And_GET() {
            if ("".Equals(gPostData.Text)) {
                isMethodPost = false;
                setMethod_POST_And_GET(isMethodPost);
            } else {
                isMethodPost = true;
                setMethod_POST_And_GET(isMethodPost);
            }
        }
        private void setMethod_POST_And_GET(Boolean method) {
            if (method == false) {
                cIsMethodPost.Text = "GET";
                cIsMethodPost.ForeColor = Color.Black;
            } else {
                cIsMethodPost.Text = "POST";
                cIsMethodPost.ForeColor = Color.Blue;
            } 
        }

        private void gContextFormat_SelectedIndexChanged(object sender, EventArgs e) {
            if (isInit == true) return;
            String outStr = HTMLTextset[0];
            if (outStr == null) outStr = textBox1.Text;
            HTMLTextset[0] = outStr; // 000
            switch (gContextFormat.SelectedIndex) {
                case 0:
                    textBox1.Text = HTMLTextset[0];
                    HTMLchanged();
                    break;
                case 1:
                    textBox1.Text = MyTools.getNormalText(HTMLTextset[0]);
                    break;
                case 2:
                    textBox1.Text = MyTools.getNormalText(HTMLTextset[0]).Replace("\\/", "/");
                    break;
                default:
                    MessageBox.Show("this has not been set yet");
                    break;
            }
        }

        private void btn_Replace_Click(object sender, EventArgs e){
            var regex = new Regex(cReplace_from.Text);
            var matches = regex.Matches(textBox1.Text);

            HTMLTextset[0] = textBox1.Text = Regex.Replace(textBox1.Text, cReplace_from.Text, cReplace_to.Text);//textBox1.Text.Replace(cReplace_from.Text, cReplace_to.Text);
            label3.Text = "已替换："+matches.Count+"次";
        }

        private void cReplace_to_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btn_Replace_Click(null, null);
        }

        private void cReplace_from_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "0/0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            byte[] bt = myHttpDownload(searchText.Text);
            writeToFile(bt, "D:/a.mp4");
        }
        private void writeToFile(byte[] result, String saveUrl)
        {
            FileStream fs = new FileStream(saveUrl, FileMode.Append);
            fs.Write(result, 0, result.Length);
            fs.Close();
        }
        public static byte[] myHttpDownload(String url)
        {
            WebClient client = new WebClient();
            String[] tHeaders = config.HeaderData.Replace("\r", "").Split(new String[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (String one in tHeaders)
            {
                int pos = one.LastIndexOf(":");
                String[] pers = new string[2];
                pers[0] = one.Substring(0, pos);
                pers[1] = one.Substring(pos + 1).Trim();
                SetHeaderValue(client.Headers, pers[0], pers[1]);
            }
            Stream str = client.OpenRead(url);
            MemoryStream stmMemory = new MemoryStream();
            byte[] buffer = new byte[64 * 1024];
            int i;
            while ((i = str.Read(buffer, 0, buffer.Length)) > 0)
            {
                stmMemory.Write(buffer, 0, i);
            }
            byte[] arraryByte = stmMemory.ToArray();
            stmMemory.Close();
            str.Close();
            return arraryByte;
        }

        private void sCharset_SelectedIndexChanged(object sender, EventArgs e) {
            config.outCharset = sCharset.SelectedItem.ToString();
        }

        private void searchKeyWd_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter)
                btn_Search_Click(null, null);
            e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            // 若是函数调用则重置flag，不加入回退表-正常返回
            // 按键输入方式或者其他方式，加入回退表
            if (oldText.oldHTMLText_isFunc == true) {
                oldText.oldHTMLText_isFunc = false;
                return;
            }
            Console.WriteLine(textBox1.Text);
            oldText.oldHTMLText_Zdo.Push(textBox1.Text);
        }
    }
}
