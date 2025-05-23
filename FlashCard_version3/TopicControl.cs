﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace FlashCard_version3
{
    public partial class TopicControl : UserControl
    {
        public event EventHandler<int> SuKienClickpicturebox3;
        public event EventHandler SuKienTroVeCuaSubTopic;

        TOPIC t = new TOPIC();
        string fixPath = Path.Combine(Application.StartupPath, "Images");
        public TopicControl()
        {
            InitializeComponent();
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
        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            Control parent = GetTopMostParentPanel(this);
            //parent.Controls.Clear();
            QLDSSubTopic fsubtopic = new QLDSSubTopic();
            fsubtopic.Tag = t;
            fsubtopic.SuKienTroVe += GuiVeQLSUBTOPIC;
            fsubtopic.Size = parent.Size;
            //parent.Controls.Add(fsubtopic);
            fTrangChu.AddNewUserControl(fsubtopic);
        }
        private void GuiVeQLSUBTOPIC(object sender, EventArgs e)
        {
            SuKienTroVeCuaSubTopic?.Invoke(this, EventArgs.Empty);
        }
        private void TopicControl_Load(object sender, EventArgs e)
        {
            t = (TOPIC)this.Tag;
            if (t.ImageName != "")
            {
                pB_topicImage.Image = Image.FromFile(fixPath + "//" + t.ImageName);
            }
            else
                pB_topicImage.Image = null;
            label1.Text = t.TopicName;
            lbl_topics.Text = t.LsTopic.Count().ToString();
            lbl_notes.Text = "0";
        }

        private void pB_topicImage_Click(object sender, EventArgs e)
        {
            //SuKienClickpicturebox3?.Invoke(this, t.Id);
            //Console.WriteLine(Application.StartupPath);
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                string imageName = Path.GetFileName(openfile.FileName);
                t.ImageName = imageName;
                pB_topicImage.Image = Image.FromFile(openfile.FileName);

                if (!Directory.Exists(fixPath))
                {
                    Directory.CreateDirectory(fixPath);
                }
                if(!File.Exists(fixPath + "\\" + imageName))
                    File.Copy(openfile.FileName, fixPath + "\\" + imageName, true);
                TopicBUS.Instance.addImage(t);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1_Click(sender, e);
        }
    }
}
