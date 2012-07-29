using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrayWolf
{
    public partial class ManagerFrame : Form
    {
        public ManagerFrame()
        {
            InitializeComponent();

            DefaultManager di1 = new DefaultManager();
            di1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(di1);
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            UserInfoView uc1 = new UserInfoView();
            uc1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc1);
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            invSearch uc2 = new invSearch();
            uc2.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc2);
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            userSearch uc3 = new userSearch();
            uc3.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc3);
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            deleteUser uc4 = new deleteUser();
            uc4.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc4);
        }

        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            addUser uc5 = new addUser();
            uc5.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc5);
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            fieldSearch uc6 = new fieldSearch();
            uc6.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc6);
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            updateField uc7 = new updateField();
            uc7.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc7);
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            deleteField uc8 = new deleteField();
            uc8.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc8);
        }

        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            addField uc9 = new addField();
            uc9.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc9);
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            roleSearch uc10 = new roleSearch();
            uc10.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc10);
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            UserControl11 uc11 = new UserControl11();
            uc11.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc11);
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            deleteRole uc12 = new deleteRole();
            uc12.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc12);
        }
        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            addRole uc13 = new addRole();
            uc13.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc13);
        }

        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            expertReport uc14 = new expertReport();
            uc14.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc14);
        }

        private void navBarItem17_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            userReport uc15 = new userReport();
            uc15.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc15);
        }

        private void navBarItem19_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            invView uc16 = new invView();
            uc16.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc16);
        }

        private void navBarItem20_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            invAcceptance uc17 = new invAcceptance();
            uc17.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(uc17);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            DefaultManager di1 = new DefaultManager();
            di1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(di1);
        }

        private void navBarItem9_LinkClicked_1(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            newMessage nm1 = new newMessage();
            nm1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(nm1);
        }

        private void navBarItem21_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            recivedMessage rm1 = new recivedMessage();
            rm1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(rm1);
        }

        private void navBarItem22_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            sentMessage sm1 = new sentMessage();
            sm1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(sm1);
        }
    }
}
