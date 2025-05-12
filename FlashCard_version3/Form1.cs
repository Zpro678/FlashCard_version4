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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QLDSChuDeControl qLDS = new QLDSChuDeControl();
            qLDS.Size = gunaPan_container.Size;
            gunaPan_container.Controls.Add(qLDS);
            Console.WriteLine(pictureBox2.Width + " " + pictureBox2.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
