namespace FlashCard_version3
{
    partial class QuestionCategoryControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button_tuLuan = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_tracNghiem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Button_tuLuan);
            this.guna2Panel1.Controls.Add(this.guna2Button_tracNghiem);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(389, 353);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Button_tuLuan
            // 
            this.guna2Button_tuLuan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_tuLuan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_tuLuan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button_tuLuan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button_tuLuan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Button_tuLuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button_tuLuan.ForeColor = System.Drawing.Color.Black;
            this.guna2Button_tuLuan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button_tuLuan.Location = new System.Drawing.Point(0, 107);
            this.guna2Button_tuLuan.Name = "guna2Button_tuLuan";
            this.guna2Button_tuLuan.Size = new System.Drawing.Size(389, 64);
            this.guna2Button_tuLuan.TabIndex = 1;
            this.guna2Button_tuLuan.Text = "Tự luận";
            this.guna2Button_tuLuan.Click += new System.EventHandler(this.guna2Button_tuLuan_Click);
            // 
            // guna2Button_tracNghiem
            // 
            this.guna2Button_tracNghiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_tracNghiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_tracNghiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button_tracNghiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button_tracNghiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button_tracNghiem.ForeColor = System.Drawing.Color.White;
            this.guna2Button_tracNghiem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button_tracNghiem.Location = new System.Drawing.Point(0, 37);
            this.guna2Button_tracNghiem.Name = "guna2Button_tracNghiem";
            this.guna2Button_tracNghiem.Size = new System.Drawing.Size(389, 64);
            this.guna2Button_tracNghiem.TabIndex = 0;
            this.guna2Button_tracNghiem.Text = "Trắc nghiệm";
            this.guna2Button_tracNghiem.Click += new System.EventHandler(this.guna2Button_tracNghiem_Click);
            // 
            // UserControl1_SelectQuestioncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UserControl1_SelectQuestioncs";
            this.Size = new System.Drawing.Size(389, 353);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button_tuLuan;
        private Guna.UI2.WinForms.Guna2Button guna2Button_tracNghiem;
    }
}
