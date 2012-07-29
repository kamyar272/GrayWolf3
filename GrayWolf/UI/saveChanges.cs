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
    public partial class saveChanges : UserControl
    {
        public saveChanges()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dbm.saveBuffer();
            MessageBox.Show("ازریابی های شما کارشناس محترم ، ذخیره شد");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            dbm.discardBuffer();
            MessageBox.Show("اطلاعات ازریابیهای این پرونده دور ریخته شد");
            //return;
        }
    }
}
