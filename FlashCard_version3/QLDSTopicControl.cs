using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace FlashCard_version3
{
    public partial class QLDSTopicControl : UserControl
    {
        public event EventHandler<int> SuKienClickThayControl;
        public event EventHandler SuKienTroVeFormCha;
        public QLDSTopicControl()
        {
            InitializeComponent();
        }

        List<TOPIC> lsTopic = new List<TOPIC>();
        private void QLDSChuDeControl_Load(object sender, EventArgs e)
        {
            lsTopic = TopicBUS.Instance.getListTopic();
            if(lsTopic != null)
            {
                foreach(TOPIC t in lsTopic)
                {
                    TopicControl topic = new TopicControl();
                    topic.Tag = t;
                    topic.SuKienClickpicturebox3 += Topic_SuKienClickpicturebox3;
                    topic.SuKienTroVeCuaSubTopic += Topic_SukienTroveSubtopic;
                    flowLayoutPanel1.Controls.Add(topic);
                }    
            }
        }

        private void Topic_SukienTroveSubtopic(object sender, EventArgs e)
        {
            SuKienTroVeFormCha?.Invoke(this, new EventArgs());
        }

        private void Topic_SuKienClickpicturebox3(object sender, int e)
        {
            SuKienClickThayControl?.Invoke(sender, e);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddChuDe addChuDe = new AddChuDe();
            addChuDe.StartPosition = FormStartPosition.CenterParent;
            addChuDe.ShowDialog();
            if (addChuDe.DialogResult == DialogResult.OK)
            {
                LoadDanhSachTopic();
            }    
        }

        private void LoadDanhSachTopic()
        {
            flowLayoutPanel1.Controls.Clear();
            TopicBUS topicBUS = new TopicBUS();
            List<TOPIC> topicList = new List<TOPIC>();

            topicList = topicBUS.getListTopic();

            foreach (TOPIC topic in topicList)
            {
                TopicControl topiccontrol = new TopicControl();
                topiccontrol.Tag = topic;
                topiccontrol.SuKienClickpicturebox3 += Topic_SuKienClickpicturebox3;
                topiccontrol.SuKienTroVeCuaSubTopic += Topic_SukienTroveSubtopic;
                flowLayoutPanel1.Controls.Add(topiccontrol);
            }

        }
    }
}
