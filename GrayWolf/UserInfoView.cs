using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrayWolf
{
    public partial class UserInfoView : UserControl
    {
        public UserInfoView()
        {
            InitializeComponent();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader user = new StreamReader(textBox1.Text + ".txt");
                richTextBox1.Clear();
                richTextBox1.AppendText("نام کاربر :");
                richTextBox1.AppendText(NextWord(user) + "\n");
                richTextBox1.AppendText("شماره کاربری :");
                richTextBox1.AppendText(NextWord(user) + "\n");
                richTextBox1.AppendText("تاریخ عضویت :");
                richTextBox1.AppendText(NextWord(user) + " " + NextWord(user) + " " + NextWord(user)+"\n");
                richTextBox1.AppendText("لیست اختراعات :");
                while (true)
                {
                    string tmp = NextWord(user);
                    if (tmp == "----")
                    {
                        richTextBox1.AppendText(tmp + "\n");
                        continue;
                    }
                    if (tmp == "++++" || tmp == "++")
                    {
                        richTextBox1.AppendText("\n");
                        continue;
                    }
                    if (tmp == "")
                        break;
                    else
                        richTextBox1.AppendText(tmp+" ");

                }
                user.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("نام کاربری صحیح نمی باشد");
            }
                  
        }
        string NextWord(StreamReader s)
        {
            int c = s.Peek();
            while (c != -1 && Char.IsWhiteSpace(Convert.ToChar(c)))
            {
                s.Read();
                c = s.Peek();
            }
            if (c == -1) return "";
            StringBuilder b = new StringBuilder();
            while (c != -1 && !Char.IsWhiteSpace(Convert.ToChar(c)))
            {
                b.Append(Convert.ToChar(c));
                s.Read();
                c = s.Peek();
            }
            return b.ToString();
        }
        
    }
}
