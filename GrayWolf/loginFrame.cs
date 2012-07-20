using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Graywolf;

namespace GrayWolf
{
    public partial class loginFrame : Form
    {
        public loginFrame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string remived;
            string user = textBox1.Text;
            string pass = textBox2.Text;
            StreamReader tr2 = new StreamReader("removeds.txt");
            while (true)
            {
                remived = NextWord(tr2);
                if (remived == "")
                {
                    break;
                }
                if (textBox1.Text == remived)
                {
                    MessageBox.Show("نام کاربری وارد شده فعلا مسدود میباشد");
                    tr2.Close();
                    return;
                }
            }
            tr2.Close();
            StreamReader tr = new StreamReader("usernames.txt");
            bool flag = false;
            while (true)
            {
                string TPuser = NextWord(tr);
                if (TPuser == "")
                    break;
                string TPpass = NextWord(tr);
                string TProle = NextWord(tr);
                if (TPuser == user)
                    if (TPpass == pass)
                    {
                        flag = true;
                        tr.Close();
                        
                        if (TProle == "2")
                        {
                            var regionReq = new ManagerFrame();
                            regionReq.ShowDialog();
                        }
                        if (TProle == "1")
                        {
                            var regionReq = new expertFrame();
                            regionReq.ShowDialog();
                        }
                        if (TProle == "0")
                        {
                            var regionReq = new userFrame();
                            regionReq.ShowDialog();
                        }
                        break;
                    }
                    else
                    {
                        MessageBox.Show("کلمه عبور با شناسه مطابقت ندارد");
                        break;
                    }
               
            }
            if(!flag)
                   MessageBox.Show("کاربری با این نام در سیستم ثبت نشده است.");
                       
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
