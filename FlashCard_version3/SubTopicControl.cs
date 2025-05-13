using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.IO;

namespace FlashCard_version3
{
    public partial class SubTopicControl : UserControl
    {
        private 
        SUBTOPIC sub = new SUBTOPIC();
        List<CARD> card;
        string fixPath = Path.Combine(Application.StartupPath, "Images");
        public SubTopicControl()
        {
            InitializeComponent();
        
        }

        public void LoadImage(string path)
        {
            guna2CirclePictureBox1.Image = Image.FromFile(path);
            guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public string Namelabel
        {
            get => this.label1.Text;
            set => this.label1.Text = value; 
        }

        public bool isbtnxoa
        {
            get => this.guna2Button1.Visible;
            set
            {
                this.guna2Button1.Visible = value;
                this.guna2Button2.Visible = !value;
            }
        }

        private void SubTopicControl_Load(object sender, EventArgs e)
        {
            sub = this.Tag as SUBTOPIC;
            this.card = sub.LsCards;
            if (sub.ImageName != "")
                guna2CirclePictureBox1.Image = Image.FromFile(fixPath + "\\" +sub.ImageName);
            else
                guna2CirclePictureBox1.Image = null;

            label1.Text = sub.SubtopicName;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            QLDSCard qLDSSubTopicControl = new QLDSCard();
            qLDSSubTopicControl.Tag = this.sub;
            Panel parent =GetTopMostParentPanel(this);
            qLDSSubTopicControl.Size=parent.Size;
            fTrangChu.AddNewUserControl(qLDSSubTopicControl);
            //qLDSSubTopicControl;
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
                    topPanel = panel; // ghi nhận panel cuối cùng
                }
            }

            return topPanel;
        }
    }
}
