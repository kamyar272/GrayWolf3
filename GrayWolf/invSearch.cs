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
    public partial class invSearch : UserControl
    {
        public invSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(0, "زیردریایی تندر 91");
            listBox1.Items.Insert(1, "نشت گیر زیردریایی");
            richTextBox1.Clear();
            richTextBox1.AppendText("اطلاعات اختراع زیردریایی \n");
            richTextBox1.AppendText("نام کامل اختراع : زیر دریای تند رو تندر91\n");
            richTextBox1.AppendText("شماره ثبت اختراع : 87ت110/951\n");
            richTextBox1.AppendText("مخترع : حسن اسلامی ، مجید صالحی ، کامیار مومنی راد\n");
            richTextBox1.AppendText("تاریخ ثبت نهایی : 91/1/19\n");
            richTextBox1.AppendText("قیمت : 144 ملیون ریال\n");         
        }
    }
}
