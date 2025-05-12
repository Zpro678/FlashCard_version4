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
    public partial class AddMuiltipleChoiceControl : UserControl
    {
        public AddMuiltipleChoiceControl()
        {
            InitializeComponent();
        }

        private void UserControlAddTracNghiem_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Tạo một Guna2CheckBox mới
            if (this.guna2TextBox_CauTraLoi.Text.Length == 0) {
                MessageBox.Show("Nhap cau tra loi");
                return;

            }
            Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox = new Guna.UI2.WinForms.Guna2CheckBox
            {
                Font = new Font("Arial", 12),
                Text = this.guna2TextBox_CauTraLoi.Text,
                AutoSize = true,  // Điều chỉnh kích thước tự động
                Margin = new Padding(5),  // Khoảng cách giữa các checkbox
                Checked = false  // Mặc định là chưa chọn
            };

            //// Đăng ký sự kiện CheckedChanged
            //guna2CheckBox.CheckedChanged += (s, args) =>
            //{
            //    MessageBox.Show($"Bạn đã {(guna2CheckBox.Checked ? "chọn" : "bỏ chọn")}: {guna2CheckBox.Text}");
            //};

            // Thêm checkbox vào panel có layout dạng flow
            this.flowLayoutPanel_.Controls.Add(guna2CheckBox);
            this.guna2TextBox_CauTraLoi.Text = "";
        }
    }
}
