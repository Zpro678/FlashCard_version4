using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FlashCard_version3
{
    public partial class fAddCard : Form
    {
        public AddQuestionControl userControl_AddQuestion;
        public QuestionCategoryControl userControl1_AddAnswercs;
        public static Stack<UserControl> listUser = new Stack<UserControl>();
        public string question = "";

        public fAddCard()
        {
            InitializeComponent();
        }

        private void Form_AddLittleCard_Load(object sender, EventArgs e)
        {
            Console.WriteLine(guna2Button_TroVe.Height);
            Console.WriteLine(guna2Button_TroVe.Width);
            if (guna2Panel_.Controls.Count <= 0)
            {
                this.userControl_AddQuestion = new AddQuestionControl();
                AddNewUserControl(this.userControl_AddQuestion);
            }
            guna2Button_TroVe.Visible = false;
        }

        // Thêm UserControl vào panel và stack
        public static void AddNewUserControl(UserControl newControl)
        {
            // Ẩn UserControl hiện tại (nếu có)
            if (listUser.Count > 0)
            {
                listUser.Peek().Visible = false;
            }
            // Thêm UserControl mới vào Panel và Stack
            guna2Panel_.Controls.Add(newControl);
            listUser.Push(newControl);
            newControl.Dock = DockStyle.Fill;
            newControl.Visible = true;
            guna2Button_TroVe.Visible = listUser.Count > 1;
        }

        // Quay lại UserControl trước đó
        private void GoBack()
        {
            if (listUser.Count > 1)
            {
                // Loại bỏ UserControl hiện tại
                UserControl current = listUser.Pop();
                current.Visible = false;
                guna2Panel_.Controls.Remove(current);

                // Hiển thị UserControl trước đó
                UserControl previous = listUser.Peek();
                previous.Visible = true;
            }
            guna2Button_TroVe.Visible = listUser.Count > 1;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            foreach (var item in  guna2Panel_.Controls)
            {
                if (item is AddQuestionControl userQues &&userQues.Visible)
                {
                    foreach (var item2 in userQues.Controls)
                    {
                        if (item2 is TableLayoutPanel panel)
                        {
                            foreach (var item3 in panel.Controls)
                            {

                                if (item3 is Guna.UI2.WinForms.Guna2TextBox textBox && textBox.Text.Length > 0)
                                {
                                    this.question = textBox.Text;
                                    this.userControl1_AddAnswercs = new QuestionCategoryControl();
                                    AddNewUserControl(this.userControl1_AddAnswercs);
                                    return;
                                }
                            }
                        }
                    }
                }
                else if (item is AddMuiltipleChoiceControl userControlAddTracNghiem &&userControlAddTracNghiem.Visible)
                {
                    //MessageBox.Show("Đã thêm hoàn tất Trắc nghiệm");
                    LuuTracNghiem(userControlAddTracNghiem);
                    return;
                }
                else if (item is AddTextAnswerControl userControl_AddTuLuan&&userControl_AddTuLuan.Visible)
                {
                    //MessageBox.Show("Đã thêm tự luận");
                    LuuTuLuan(userControl_AddTuLuan);

                    return;
                }
            }
            MessageBox.Show("Mời nhập câu hỏi");
            return;
        }

        private void guna2Button_TroVe_Click(object sender, EventArgs e)
        {
            GoBack();
        }
        public void LuuTracNghiem(UserControl userControl) {
            List<string> ketQua = new List<string>();
            List<string>checkeds=new List<string>();
            foreach (var item in userControl.Controls) {
                if (item is Panel panel) {
                    foreach (var item2 in panel.Controls) {
                        if (item2 is FlowLayoutPanel flowLayoutPanel) { 
                            foreach(var item3 in flowLayoutPanel.Controls)
                            {
                                if(item3 is Guna.UI2.WinForms.Guna2CheckBox check)
                                {
                                    ketQua.Add(check.Text);
                                    if (check.Checked)
                                    {
                                        checkeds.Add(check.Text);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            string ketqua = "";
            foreach (string i in checkeds) {
                ketqua += i+"\n";
            }
            MessageBox.Show(ketqua);
        }
        public void LuuTuLuan(UserControl userControl) {
            var ketQua = "";
            foreach (var item in userControl.Controls)
            {
                if (item is Panel panel) {
                    foreach (var item2 in panel.Controls) {
                        if (item2 is Guna.UI2.WinForms.Guna2TextBox textBox) { 
                            ketQua+=textBox.Text;
                        }
                    }
                }
            }
            MessageBox.Show(ketQua);
        }   
    }
}
