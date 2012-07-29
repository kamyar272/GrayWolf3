using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Graywolf;

namespace GrayWolf
{
    public partial class expertFrame2 : Form
    {
        public expertFrame2()
        {
            InitializeComponent();
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

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            ReconsiderInv ri1 = new ReconsiderInv();
            ri1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(ri1);
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            Morethan3 mt1 = new Morethan3();
            mt1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(mt1);
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
            userReport ur1 = new userReport();
            ur1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(ur1);
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

        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            originalityStatus os1 = new originalityStatus();
            os1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(os1);
        }

        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            claimStatus cs1 = new claimStatus();
            cs1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(cs1);
        }

        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            specificationStatus ss1 = new specificationStatus();
            ss1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(ss1);
        }

        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            detailDocStatus dds1 = new detailDocStatus();
            dds1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(dds1);
        }

        private void navBarItem17_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            representetiveStatus rs1 = new representetiveStatus();
            rs1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(rs1);
        }

        private void navBarItem18_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl in xtraScrollableControl1.Controls)
            {
                ctrl.Dispose();
            }
            saveChanges sc1 = new saveChanges();
            sc1.Dock = DockStyle.Fill;
            xtraScrollableControl1.Controls.Add(sc1);
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
