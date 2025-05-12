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
    public partial class QLDSChuDeControl : UserControl
    {
        public event EventHandler<string> SuKienClickThayControl;
        public QLDSChuDeControl()
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
                    flowLayoutPanel1.Controls.Add(topic);
                }    
            }
        }

        private void Topic_SuKienClickpicturebox3(object sender, string e)
        {
            SuKienClickThayControl?.Invoke(sender, e);
        }
    }
}
