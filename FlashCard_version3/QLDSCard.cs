using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace FlashCard_version3
{
    public partial class QLDSCard : UserControl
    {
        DTO.SUBTOPIC subTopic =new SUBTOPIC();
        List<DTO.CARD> list_cards=new List<CARD>();
        string fixPath = Path.Combine(Application.StartupPath, "Images");
        public QLDSCard()
        {
            InitializeComponent();
        }

        private void QLDSSubTopicControl_Load(object sender, EventArgs e)
        {
            subTopic = this.Tag as SUBTOPIC;
            label2.Text = subTopic.TopicName;
            label3.Text = subTopic.SubtopicName;
            if(subTopic.ImageName != "")
                guna2PictureBox1.Image = Image.FromFile(fixPath + "\\" + subTopic.ImageName);
            list_cards = subTopic.LsCards;
            guna2Button1.Text = list_cards.Count.ToString();
            foreach (DTO.CARD card in list_cards)
            {
                BackCardControl backCard = new BackCardControl();
                backCard.Tag = card;
                flowLayoutPanel1.Controls.Add(backCard);
            }

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                string imageName = Path.GetFileName(openfile.FileName);
                subTopic.ImageName = imageName;
                guna2PictureBox1.Image = Image.FromFile(openfile.FileName);

                if (!Directory.Exists(fixPath))
                {
                    Directory.CreateDirectory(fixPath);
                }
                if (!File.Exists(fixPath + "\\" + imageName))
                    File.Copy(openfile.FileName, fixPath + "\\" + imageName, true);
                SubTopicBUS.Instance.addImage(subTopic);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            fTrangChu.GoBack();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            fAddCard form_AddLittleCard = new fAddCard();
            form_AddLittleCard.ShowDialog();
        }
    }
}
