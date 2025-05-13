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

namespace FlashCard_version3
{
    public partial class BackCardControl : UserControl
    {
        bool isFlipped = false;
        string textLabel = "";
        CARD card = new CARD();
        public BackCardControl()
        {
            InitializeComponent();

        }

        private void UserControl_Little_Load(object sender, EventArgs e)
        {
            card=this.Tag as CARD;
            var parent = this.guna2Panel_Little.Parent;
            this.guna2Panel_Little.Dock = DockStyle.None;
            this.guna2Panel_Little.Size = parent.Size;
            Class_BorderRadius.RoundCorners(this.guna2Panel_Little, 10);
            textLabel=card.Question;
        }
        private async  Task  flipCard(Panel panel, bool isFlipped,string textLabel)
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

            foreach (var item in panel.Controls)
            {
                if (item is Label label && isFlipped)
                {
                    label.Text = textLabel;
                }
                else if (item is Label label1 && !isFlipped) {
                    label1.Text = card.Question;
                }
            
            }
            

            while (panel.Width < originalWidth)
            {
                panel.Width = Math.Min(panel.Width + 20, originalWidth);
                panel.Left -= 10;
                await Task.Delay(10);
            }
        }



        
        private async void guna2Panel_Little_Click(object sender, EventArgs e)
        {
            await flipCard(this.guna2Panel_Little,isFlipped,textLabel);
            isFlipped = !isFlipped;
        }

        private void label_NoiDung_Click(object sender, EventArgs e)
        {
            guna2Panel_Little_Click(sender, e);
        }
    }
}
