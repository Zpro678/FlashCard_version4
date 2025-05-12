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
    public partial class AddSubTopic : Form
    {

        public event EventHandler<DialogResult> Accepted;

        private int IDtopic;
        public AddSubTopic(int id)
        {
            InitializeComponent();
            this.IDtopic = id;
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
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
                NameImage =Path.GetFileName( openFileDialog.FileName);
                guna2CirclePictureBox1.Image = Image.FromFile(filePath);
                guna2CirclePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
            
        
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            loadImage();
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

                
                while (File.Exists(newDestinationPath))
                {
                    newDestinationPath = Path.Combine(folderPath, $"{name}_{count}.jpg");
                    count++;
                }

                
                File.Copy(path, newDestinationPath);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
            List<object> list = new List<object>();
            list.Add(NameImage);
            list.Add(guna2TextBox1.Text);
            list.Add(this.IDtopic);

           

            SaveImage(this.PathImage);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
