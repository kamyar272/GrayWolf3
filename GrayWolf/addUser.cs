using System;
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
            if (textBox1.Text == "kamyar")
                label3.Text="کاربر با نام مشابه وجود دارد";
            else
                label3.Text="کاربر جدید ، اضافه شد";
            
        }
    }
}
