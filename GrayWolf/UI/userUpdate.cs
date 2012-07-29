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
    public partial class userUpdate : UserControl
    {
        public userUpdate()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader userAddress = new StreamReader("user.txt");
            string username = NextWord(userAddress);
            string id = NextWord(userAddress);
            userAddress.Close();
            StreamWriter user = new StreamWriter(username+".txt");
            user.WriteLine(textBox3.Text);
            user.WriteLine(textBox2.Text);
            user.Write(comboBox1.Text + " ");
            user.Write(comboBox2.Text + " ");
            user.WriteLine(comboBox3.Text);
            user update= new GrayWolf.user(textBox3.Text,textBox2.TabIndex,new DateTime(comboBox1.SelectedIndex,comboBox2.SelectedIndex,comboBox3.SelectedIndex));
            dbm.userUpdate(update);
            MessageBox.Show("اطلاعات کاربر بازنویسی شد");
            user.Close();

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
