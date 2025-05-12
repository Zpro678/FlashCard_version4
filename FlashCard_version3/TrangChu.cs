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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowFormQLDChuDeControl();
        }

        private void QLDS_SuKienClickThayControl(object sender, string e)
        {
            QLDSSubTopic noiDung = new QLDSSubTopic();
            noiDung.Dock = DockStyle.Fill;
            noiDung.BringToFront();
            noiDung.SuKienTroVe += NoiDung_SuKienTroVe;
            gunaPan_container.Controls.Clear();
            gunaPan_container.Controls.Add(noiDung);

        }

        private void ShowFormQLDChuDeControl()
        {
            QLDSChuDeControl qLDS = new QLDSChuDeControl();
            qLDS.Size = gunaPan_container.Size;
            qLDS.SuKienClickThayControl += QLDS_SuKienClickThayControl;
            gunaPan_container.Controls.Clear();
            gunaPan_container.Controls.Add(qLDS);
            Console.WriteLine(pictureBox2.Width + " " + pictureBox2.Height);
        }

        private void NoiDung_SuKienTroVe(object sender, EventArgs e)
        {
            ShowFormQLDChuDeControl();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPan_container_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
