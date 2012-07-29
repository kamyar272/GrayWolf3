using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrayWolf;

namespace Graywolf
{
    public partial class userFrame : Form
    {
        public userFrame()
        {
            InitializeComponent();

            DefaultInv di1 = new DefaultInv();
            di1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(di1);
        }
        
       private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            NewInv ni1 = new NewInv();
            ni1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(ni1);

        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            EditInv ei1 = new EditInv();
            ei1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(ei1);

        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            PricingInv pi1 = new PricingInv();
            pi1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(pi1);

        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            DocInv di1 = new DocInv();
            di1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(di1);
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            ReconsiderInv rci1 = new ReconsiderInv();
            rci1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(rci1);

        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            Morethan3 mrt1 = new Morethan3();
            mrt1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(mrt1);
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            companyReg cr1 = new companyReg();
            cr1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(cr1);

        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            Report r1 = new Report();
            r1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(r1);

        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            SearchInv si1 = new SearchInv();
            si1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(si1);

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            DefaultInv di1 = new DefaultInv();
            di1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(di1);

        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            newMessage nm1 = new newMessage();
            nm1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(nm1);
        }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            recivedMessage rm1 = new recivedMessage();
            rm1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(rm1);
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
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
