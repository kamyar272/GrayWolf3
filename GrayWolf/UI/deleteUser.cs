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
    public partial class deleteUser : UserControl
    {
        public deleteUser()
        {
            InitializeComponent();
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            StreamWriter tr = new StreamWriter("removeds.txt",true);
            tr.WriteLine(textBox1.Text);
            MessageBox.Show(" نام کاربری مورد نظر غیر فعال شد");
            tr.Close();
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
