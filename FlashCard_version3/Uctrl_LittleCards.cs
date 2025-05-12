using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCard_version3
{
    public partial class Uctrl_LittleCards : UserControl
    {
        public Class_BorderRadius Class_BorderRadius=new Class_BorderRadius();
        private bool isFlipped = false;
        private bool answer = false;
        private string textLabel = "";
        public Uctrl_LittleCards()
        {
            InitializeComponent();
            //Class_BorderRadius.RoundCorners(guna2Panel_DapAn, 3);
        }

        private void Uctrl_LittleCards_Load(object sender, EventArgs e)
        {
            this.textLabel=this.label_NoiDung.Text;
            if (1 > 0)
            {
                this.guna2Panel_CauTraLoi.Controls.Clear();
                QuizzControl userControl_TracNghiem=new QuizzControl();
                this.guna2Panel_CauTraLoi.Controls.Add(userControl_TracNghiem);
            }
            
        }
        private async Task flipCard(Panel panel, bool answer, bool isFlipped)
        {
            int originalWidth = panel.Width;
            int originalHeight = panel.Height;
            var parent = panel.Parent;
            panel.Dock = DockStyle.None;
            panel.Size = parent.Size;
            while (panel.Width > 0)
            {
                panel.Width = Math.Max(panel.Width - 20, 0);
                panel.Left += 10;
                await Task.Delay(10);
            }

            if (!isFlipped)
            {
                if (answer)
                {
                    var userControl_PictureBox = new UserControl_PictureBox
                    {
                        Location = new Point(0, 0),
                    };
                    panel.Controls.Add(userControl_PictureBox);
                }
                else
                {
                    var userControl_PictureBoxSai = new UserControl_PictureBoxSai
                    {
                        Location = new Point(0, 0),
                    };
                    panel.Controls.Add(userControl_PictureBoxSai);
                }
                foreach (var item in panel.Controls)
                {
                    if (item is Label label)
                    {
                        label.Text = "Da lat the";
                    }
                }
            }
            else
            {
                foreach (var item in panel.Controls)
                {
                    if (item is Label label)
                    {
                        label.Text = this.textLabel ;
                    }
                }
                foreach (var item in panel.Controls)
                {
                    if (item is UserControl_PictureBoxSai sai)
                    {
                        panel.Controls.Remove(sai);
                    }
                    else if (item is UserControl_PictureBox dung)
                    {
                        panel.Controls.Remove(dung);
                    }
                }
            }

            while (panel.Width < originalWidth)
            {
                panel.Width = Math.Min(panel.Width + 20, originalWidth);
                panel.Left -= 10;
                panel.Refresh();
                Application.DoEvents();
                await Task.Delay(10);
            }
        }
            
       
        private async void guna2Button3_Click(object sender, EventArgs e)
        {
            await flipCard(this.guna2Panel_NoiDung,this.answer, this.isFlipped);
            isFlipped=!isFlipped;
        }
    }
}
