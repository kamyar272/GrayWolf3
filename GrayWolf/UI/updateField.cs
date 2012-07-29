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
    public partial class updateField : UserControl
    {
        public updateField()
        {
            InitializeComponent();
        }

               
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl1 in panelControl1.Controls)
            {
                ctrl1.Dispose();
            }
            updateFieldDo uc7_2 = new updateFieldDo();
            uc7_2.Dock = DockStyle.Fill;
            panelControl1.Controls.Remove(textBox1);
            panelControl1.Controls.Remove(listBox1);
            panelControl1.Controls.Remove(button2);
            panelControl1.Controls.Remove(label3);

            panelControl1.Controls.Add(uc7_2);
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
