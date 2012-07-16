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
    public partial class addRole : UserControl
    {
        public addRole()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               label3.Text = "نقش جدید ، تخصیص داده شد";
            
        }
    }
}
