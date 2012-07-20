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
    public partial class invSearch : UserControl
    {
        public invSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                StreamReader inv = new StreamReader("inventions.txt");
                richTextBox1.Clear();
                bool flag = false;
                bool exist=false;
                string res="";
                while (true)
                {
                    string tmp = NextWord(inv);
                    //MessageBox.Show(res);
                    if (tmp == "----" || tmp=="")
                    {
                        flag = true;
                        if(exist==true)
                          richTextBox1.AppendText(res + "\n\n");
                        res = "";
                    }
                    if (tmp == "")
                        break;

                    if (tmp == "++" && exist == true && flag==true)
                    {
                        listBox1.Items.Add(res);
                    }
                    
                    if (tmp == "++")
                    {
                        res = res + "\n";
                        flag = false;
                        continue;
                    }
                    if (tmp == "++" && exist == true) 
                    {
                        MessageBox.Show("");
                        res = res + "\n";
                        listBox1.Items.Add(res);
                        continue;
                    }
                    if (flag == true && textBox1.Text == tmp)
                        exist = true;
                    res = res + " "+tmp;
                    
                }
                inv.Close();
               
        
        
                
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
