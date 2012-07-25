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
    public partial class expertTransition : UserControl
    {
        public expertTransition()
        {
            InitializeComponent();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl1 in panelControl1.Controls)
            {
                ctrl1.Dispose();
            }
            originalityStatus uc23 = new originalityStatus();
            uc23.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uc23);
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl1 in panelControl1.Controls)
            {
                ctrl1.Dispose();
            }
            representetiveStatus uc24 = new representetiveStatus();
            uc24.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uc24);
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl1 in panelControl1.Controls)
            {
                ctrl1.Dispose();
            }
            specificationStatus uc25 = new specificationStatus();
            uc25.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uc25);
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl1 in panelControl1.Controls)
            {
                ctrl1.Dispose();
            }
            detailDocStatus uc26 = new detailDocStatus();
            uc26.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uc26);
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl1 in panelControl1.Controls)
            {
                ctrl1.Dispose();
            }
            claimStatus uc27 = new claimStatus();
            uc27.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uc27);
        }

        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            foreach (Control ctrl1 in panelControl1.Controls)
            {
                ctrl1.Dispose();
            }
            saveChanges uc28 = new saveChanges();
            uc28.Dock = DockStyle.Fill;
            panelControl1.Controls.Add(uc28);
        }

       
    }
}
