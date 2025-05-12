using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCard_version3
{
    public partial class FrontCardControl : UserControl
    {
        public FrontCardControl()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            QLDSSubTopicControl qLDSTheControl = new QLDSSubTopicControl();
            Panel item = GetTopMostParentPanel(this);
            qLDSTheControl.Size=item.Size;
            //TrangChu.AddNewUserControl(qLDSTheControl);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            guna2Panel1_Click((Control)sender, e);  
        }
        private Panel GetTopMostParentPanel(Control control)
        {
            Control current = control;
            Panel topPanel = null;

            while (current.Parent != null)
            {
                current = current.Parent;
                if (current is Guna.UI2.WinForms.Guna2Panel panel)
                {
                    topPanel = panel;
                }
            }

            return topPanel;
        }
    }
}
