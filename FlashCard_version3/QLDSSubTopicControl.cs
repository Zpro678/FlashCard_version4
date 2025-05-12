using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace FlashCard_version3
{
    public partial class QLDSSubTopicControl : UserControl
    {
        DTO.SUBTOPIC subTopic =new SUBTOPIC();
        List<DTO.CARD> list_cards=new List<CARD>();
        public QLDSSubTopicControl()
        {
            InitializeComponent();
        }

        private void QLDSSubTopicControl_Load(object sender, EventArgs e)
        {
            subTopic = this.Tag as SUBTOPIC;
            if (subTopic == null) {
                MessageBox.Show("KO co subtopic");
                return;
            }
            list_cards = subTopic.LsCards;
            if (list_cards == null) {
                MessageBox.Show("Khong co card");
                return;
            }
            foreach (DTO.CARD card in list_cards)
            { 
                BackCardControl backCardControl = new BackCardControl();
                CARD cARD = card;
                backCardControl.Tag = cARD;
                flowLayoutPanel1.Controls.Add(backCardControl);
            }
        }
    }
}
