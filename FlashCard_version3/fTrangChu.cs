using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace FlashCard_version3
{
    public partial class fTrangChu : Form
    {
        public static Stack<UserControl> List_UserControls = new Stack<UserControl>();
        public static void AddNewUserControl(UserControl newControl)
        {
            // Ẩn UserControl hiện tại (nếu có)
            if (List_UserControls.Count > 0)
            {
                List_UserControls.Peek().Visible = false;
            }
            gunaPan_container.Controls.Add(newControl);
            List_UserControls.Push(newControl);
            newControl.Dock = DockStyle.Fill;
            newControl.Visible = true;
            guna2Button_TroVe.Visible = List_UserControls.Count > 1;
            //guna2Button_TroVe.Visible = flase;
        }
        public fTrangChu()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            Bounds = Screen.PrimaryScreen.Bounds;
            //guna2Button_TroVe.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QLDSTopicControl qLDS = new QLDSTopicControl();
            qLDS.Size = gunaPan_container.Size;
            qLDS.SuKienTroVeFormCha += guna2Button1_Click;
            gunaPan_container.Controls.Add(qLDS);
            AddNewUserControl(qLDS);
        }

        public static void guna2Button1_Click(object sender, EventArgs e)
        {
            GoBack();
        }
        public static void GoBack()
        {
            if (List_UserControls.Count > 1)
            {
                // Loại bỏ UserControl hiện tại
                UserControl current = List_UserControls.Pop();
                current.Visible = false;
                gunaPan_container.Controls.Remove(current);

                // Hiển thị UserControl trước đó
                UserControl previous = List_UserControls.Peek();
                previous.Visible = true;
            }
            guna2Button_TroVe.Visible = List_UserControls.Count > 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            guna2Button1_Click(sender, e);
            MessageBox.Show("ok");
        }
        public static Panel GetTopMostParentPanel(Panel control)
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

        private void gunaPan_container_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
