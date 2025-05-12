using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;


namespace FlashCard_version3
{
    public partial class QLDSSubTopic : UserControl
    {
        public event EventHandler SuKienTroVe;
        public int IdTopic;

        private bool checkIsbtnxoa = true;
        TOPIC t = new TOPIC();
        List<SUBTOPIC> subTopics = new List<SUBTOPIC>();
        public QLDSSubTopic()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            AddSubTopic formAddaDeck = new AddSubTopic(this.IdTopic);
            formAddaDeck.StartPosition = FormStartPosition.CenterParent;
         
            formAddaDeck.ShowDialog();

            if (formAddaDeck.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Đã thêm thành công");
                for (int i = flowLayoutPanel1.Controls.Count - 1; i >= 0; i--)
                {
                    Control control = flowLayoutPanel1.Controls[i];
                    if (control != guna2Panel1)
                    {
                        flowLayoutPanel1.Controls.RemoveAt(i);
                    }
                }
                LoadDanhSach();
            }

            
        }


        private void LoadDanhSach()
        {


            BUS.TopicBUS topicBUS = new BUS.TopicBUS();


            List<DTO.TOPIC> listTopic = new List<DTO.TOPIC>();

            listTopic = topicBUS.getListTopic();

           
            if (listTopic!=null)
            {
                foreach (DTO.TOPIC topic in listTopic)
                {
                    SubTopicControl ucCauHoi = new SubTopicControl();
                    ucCauHoi.Dock = DockStyle.Fill;
                    string path = Path.Combine(Application.StartupPath, "Images", topic.ImageName.ToString());

                    ucCauHoi.LoadImage(path);
                    ucCauHoi.Namelabel = topic.TopicName.ToString();
                    ucCauHoi.isbtnxoa = this.checkIsbtnxoa;
                    flowLayoutPanel1.Controls.Add(ucCauHoi);
                }
            }   
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (checkIsbtnxoa)
            {
                this.checkIsbtnxoa = false;
            }
            else
            {
                this.checkIsbtnxoa = true;
            }    
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is SubTopicControl uc)
                    {
                        uc.isbtnxoa = checkIsbtnxoa;
                    }
                }

        }

        public static void guna2Button3_Click(object sender, EventArgs e)
        {
            //SuKienTroVe?.Invoke(this, EventArgs.Empty);
            fTrangChu.guna2Button1_Click(sender, e);
        }

        private void QLDSSubTopic_Load(object sender, EventArgs e)
        {
            t = this.Tag as TOPIC;
            this.IdTopic = t.Id;
            subTopics = t.LsTopic;
            if (subTopics != null)
            {
                foreach (SUBTOPIC sub in subTopics)
                {
                    SubTopicControl subControl = new SubTopicControl();
                    subControl.Tag = sub;
                    subControl.isbtnxoa = this.checkIsbtnxoa;
                    flowLayoutPanel1.Controls.Add(subControl);
                }
            }      
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
