using BUS;
using DTO;
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

namespace FlashCard_version3
{
    public partial class AddChuDe : Form
    {
        public AddChuDe()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            loadImage();
        }

        private void AddChuDe_Load(object sender, EventArgs e)
        {

        }

        private string NameImage = "";
        private string PathImage = "";

        private void loadImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png",
                Title = "Select an Image",
                InitialDirectory = Application.StartupPath + "Images"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                this.PathImage = filePath;
                NameImage = Path.GetFileName(openFileDialog.FileName);
                picture_TMCD.Image = Image.FromFile(filePath);
                picture_TMCD.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void SaveImage(string path)
        {
            if (string.IsNullOrEmpty(path) || !File.Exists(path))
            {
                MessageBox.Show("File ảnh không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string folderPath = "Images";

            try
            {

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                string name = Path.GetFileNameWithoutExtension(this.NameImage);


                string destinationPath = Path.Combine(folderPath, $"{name}.jpg");

                int count = 1;
                string newDestinationPath = destinationPath;


               if (!(File.Exists(newDestinationPath)))
                {

                    File.Copy(path, newDestinationPath);
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddChuDe_Click(object sender, EventArgs e)
        {
            TOPIC tOPIC = new TOPIC();
            tOPIC.TopicName = txtThemMoiChuDe.Text;
            tOPIC.ImageName = this.NameImage;

            SaveImage(this.PathImage);

            TopicBUS topicBUS = new TopicBUS();

            if (topicBUS.AddTopic(tOPIC)!=0)
            {
                MessageBox.Show("Thêm chủ đề thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm chủ đề thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
