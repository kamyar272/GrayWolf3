using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GrayWolf
{
    partial class expertFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainerControl4 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitContainerControl5 = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem8 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem9 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem10 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup5 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem11 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem12 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup6 = new DevExpress.XtraNavBar.NavBarGroup();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.navBarItem13 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem14 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem15 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem16 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem17 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem18 = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl4)).BeginInit();
            this.splitContainerControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl5)).BeginInit();
            this.splitContainerControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl4
            // 
            this.splitContainerControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl4.Horizontal = false;
            this.splitContainerControl4.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl4.Name = "splitContainerControl4";
            this.splitContainerControl4.Panel1.Text = "Panel1";
            this.splitContainerControl4.Panel2.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.splitContainerControl4.Panel2.Controls.Add(this.splitContainerControl5);
            this.splitContainerControl4.Panel2.Text = "Panel2";
            this.splitContainerControl4.Size = new System.Drawing.Size(659, 524);
            this.splitContainerControl4.SplitterPosition = 44;
            this.splitContainerControl4.TabIndex = 0;
            this.splitContainerControl4.Text = "splitContainerControl4";
            // 
            // splitContainerControl5
            // 
            this.splitContainerControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl5.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl5.Name = "splitContainerControl5";
            this.splitContainerControl5.Panel1.Controls.Add(this.navBarControl1);
            this.splitContainerControl5.Panel1.Text = "Panel1";
            this.splitContainerControl5.Panel2.Controls.Add(this.xtraScrollableControl1);
            this.splitContainerControl5.Panel2.Text = "Panel2";
            this.splitContainerControl5.Size = new System.Drawing.Size(659, 475);
            this.splitContainerControl5.SplitterPosition = 175;
            this.splitContainerControl5.TabIndex = 0;
            this.splitContainerControl5.Text = "splitContainerControl5";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup4,
            this.navBarGroup5,
            this.navBarGroup6});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem4,
            this.navBarItem5,
            this.navBarItem6,
            this.navBarItem8,
            this.navBarItem9,
            this.navBarItem10,
            this.navBarItem7,
            this.navBarItem11,
            this.navBarItem12,
            this.navBarItem13,
            this.navBarItem14,
            this.navBarItem15,
            this.navBarItem16,
            this.navBarItem17,
            this.navBarItem18});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 151;
            this.navBarControl1.Size = new System.Drawing.Size(175, 475);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "اختراع";
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "ثبت اختراع جدید";
            this.navBarItem1.Name = "navBarItem1";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "ویرایش مشخصات اختراع";
            this.navBarItem2.Name = "navBarItem2";
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "معرفی پرونده مرتبط با اختراع";
            this.navBarItem3.Name = "navBarItem3";
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "تعیین قیمت";
            this.navBarItem4.Name = "navBarItem4";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "درخواست‌ها";
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem8)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "بررسی مجدد پرونده";
            this.navBarItem5.Name = "navBarItem5";
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "صدور مجوز ثبت بیش از ۳ اختراع";
            this.navBarItem6.Name = "navBarItem6";
            // 
            // navBarItem8
            // 
            this.navBarItem8.Caption = "ثبت شرکت";
            this.navBarItem8.Name = "navBarItem8";
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "گزارش گیری";
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem9)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarItem9
            // 
            this.navBarItem9.Caption = "گزارش فعالیت کاربر";
            this.navBarItem9.Name = "navBarItem9";
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "جست‌وجو";
            this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem10)});
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // navBarItem10
            // 
            this.navBarItem10.Caption = "جست‌وجو اختراع";
            this.navBarItem10.Name = "navBarItem10";
            // 
            // navBarGroup5
            // 
            this.navBarGroup5.Caption = "صندوق پیغام‌ها";
            this.navBarGroup5.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem7),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem11),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem12)});
            this.navBarGroup5.Name = "navBarGroup5";
            // 
            // navBarItem7
            // 
            this.navBarItem7.Caption = "ایجاد پیغام جدید";
            this.navBarItem7.Name = "navBarItem7";
            // 
            // navBarItem11
            // 
            this.navBarItem11.Caption = "پیغام‌های دریافتی";
            this.navBarItem11.Name = "navBarItem11";
            // 
            // navBarItem12
            // 
            this.navBarItem12.Caption = "پیغام‌های ارسالی";
            this.navBarItem12.Name = "navBarItem12";
            // 
            // navBarGroup6
            // 
            this.navBarGroup6.Caption = "بررسی پرونده‌ها";
            this.navBarGroup6.Expanded = true;
            this.navBarGroup6.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem13),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem14),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem15),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem16),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem17),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem18)});
            this.navBarGroup6.Name = "navBarGroup6";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(479, 475);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // navBarItem13
            // 
            this.navBarItem13.Caption = "تایید اصالت";
            this.navBarItem13.Name = "navBarItem13";
            // 
            // navBarItem14
            // 
            this.navBarItem14.Caption = "تایید مفاد ادعا نامه";
            this.navBarItem14.Name = "navBarItem14";
            // 
            // navBarItem15
            // 
            this.navBarItem15.Caption = "تایید مشخصات کلی";
            this.navBarItem15.Name = "navBarItem15";
            // 
            // navBarItem16
            // 
            this.navBarItem16.Caption = "تایید جزئیات";
            this.navBarItem16.Name = "navBarItem16";
            // 
            // navBarItem17
            // 
            this.navBarItem17.Caption = "تایید صحت نمایندگان حقوقی";
            this.navBarItem17.Name = "navBarItem17";
            // 
            // navBarItem18
            // 
            this.navBarItem18.Caption = "خاتمه";
            this.navBarItem18.Name = "navBarItem18";
            // 
            // expertFrame
            // 
            this.ClientSize = new System.Drawing.Size(659, 524);
            this.Controls.Add(this.splitContainerControl4);
            this.Name = "expertFrame";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم کارشناس";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl4)).EndInit();
            this.splitContainerControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl5)).EndInit();
            this.splitContainerControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }
            
        string nextTitle(StreamReader s)
        {
            string res = "", tmp;
            bool flag=false;
            tmp = NextWord(s);
            while(true)
            {
                tmp = NextWord(s);
                if (tmp == "num" || tmp == "")
                    break;
                if (flag)
                    res = res + tmp + " ";
                if(tmp == "cinv")
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
        

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl4;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl5;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem8;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem9;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem10;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;
        private DevExpress.XtraNavBar.NavBarItem navBarItem11;
        private DevExpress.XtraNavBar.NavBarItem navBarItem12;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem13;
        private DevExpress.XtraNavBar.NavBarItem navBarItem14;
        private DevExpress.XtraNavBar.NavBarItem navBarItem15;
        private DevExpress.XtraNavBar.NavBarItem navBarItem16;
        private DevExpress.XtraNavBar.NavBarItem navBarItem17;
        private DevExpress.XtraNavBar.NavBarItem navBarItem18;
    }
}