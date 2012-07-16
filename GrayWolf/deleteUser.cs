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
    public partial class deleteUser : UserControl
    {
        public deleteUser()
        {
            InitializeComponent();
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, "محمد درخشانی");
            listBox1.Items.Insert(1, "محمد رضائیان");
            listBox1.Items.Insert(2, "محمد محرابیان");
        }
    }
}
