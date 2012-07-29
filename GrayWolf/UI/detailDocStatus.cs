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
    public partial class detailDocStatus : UserControl
    {
        public detailDocStatus()
        {
            InitializeComponent();
            loadtext();
        }
        void loadtext()
        {
            StreamReader inv = new StreamReader("inv.txt");
            StreamReader invs = new StreamReader("invs.txt");
            string tmp = inv.ReadLine();
            string tmp2 = "";
            while (tmp2 != tmp) { tmp2 = nextTitle(invs); }
            string i = nextI1(invs, "i5", "i6");
            this.richTextBox4.AppendText(i);
            inv.Close();
            invs.Close();

        }
        string nextI1(StreamReader s, string c1, string c2)
        {
            string res = "", tmp;
            bool flag = false;
            tmp = NextWord(s);
            while (true)
            {
                tmp = NextWord(s);
                if (tmp == c2 || tmp == "")
                    break;
                if (flag)
                    res = res + tmp + " ";
                if (tmp == c1)
                    flag = true;

            }
            return res;
        }
        string nextTitle(StreamReader s)
        {
            string res = "", tmp;
            bool flag = false;
            tmp = NextWord(s);
            while (true)
            {
                tmp = NextWord(s);
                if (tmp == "num" || tmp == "")
                    break;
                if (flag)
                    res = res + tmp + " ";
                if (tmp == "cinv")
                    flag = true;

            }
            return res;
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
