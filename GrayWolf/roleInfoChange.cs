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
    public partial class UserControl11 : UserControl
    {
        public UserControl11()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl1 in xtraScrollableControl1.Controls)
            {
                ctrl1.Dispose();
            }
            roleInfoChangeDo uc11_2 = new roleInfoChangeDo();
            uc11_2.Dock = DockStyle.Fill;

            xtraScrollableControl1.Controls.Remove(textBox3);

            xtraScrollableControl1.Controls.Remove(listBox1);
            xtraScrollableControl1.Controls.Remove(button2);

            xtraScrollableControl1.Controls.Add(uc11_2);
        }
    }
}
