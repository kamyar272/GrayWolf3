using System;
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
            string user = textBox1.Text;
            string pass = textBox2.Text;
            if (user == "kamyar")
                if (pass == "kamyar")
                {
                    var regionReq = new ManagerFrame();
                    regionReq.ShowDialog();
                    //MessageBox.Show("kamyar signed in");
                }
                else
                {
                    MessageBox.Show("کلمه عبور با شناسه مطابقت ندارد");
                }
            if(user=="momeni")
                if (pass == "rad")
                {
                    var regionReq = new expertFrame();
                    regionReq.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("کلمه عبور با شناسه مطابقت ندارد");
                }
            if (user == "test")
                if (pass == "test")
                {
                    var regionReq = new userFrame();

                    regionReq.ShowDialog();

                }
                else
                {
                    MessageBox.Show("کلمه عبور با شناسه مطابقت ندارد");
                }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        
    }
}
