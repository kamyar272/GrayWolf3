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
    public partial class addUser : UserControl
    {
        public addUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user,role,pass;
            StreamReader ur = new StreamReader("usernames.txt");
            while(true)
            {
               
                user = NextWord(ur);
                if (user == "")
                    break;
                pass = NextWord(ur);
                role = NextWord(ur);
                if(textBox1.Text==user)
                {
                    MessageBox.Show("کاربری با نام مشابه وجود دارد.");
                    return;
                }
            }
             ur.Close();
            
            
            StreamWriter tw = new StreamWriter("usernames.txt", true);
            tw.Write(textBox1.Text + " ");
            tw.WriteLine(textBox2.Text + " " + comboBox1.SelectedIndex.ToString());
            MessageBox.Show("کاربر مورد نظر ، به لیست کاربران اضافه شد");
            tw.Close();
            
        }
        
        string NextWord(StreamReader s)
        {    
            int c=s.Peek();  
            while(c!=-1 && Char.IsWhiteSpace(Convert.ToChar(c)))  
            {        
                s.Read();
                c=s.Peek();        
            }   
            if(c==-1) return ""; 
            StringBuilder b=new StringBuilder();
            while(c!=-1 && !Char.IsWhiteSpace(Convert.ToChar(c)))
            {        
                b.Append(Convert.ToChar(c));
                s.Read(); 
                c=s.Peek();
            }  
            return b.ToString();
        }
    }
}
