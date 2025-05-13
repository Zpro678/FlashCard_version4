namespace FlashCard_version3
{
    partial class AddChuDe
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picture_TMCD = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtThemMoiChuDe = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddChuDe = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture_TMCD)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_TMCD
            // 
            this.picture_TMCD.BackColor = System.Drawing.Color.Transparent;
            this.picture_TMCD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_TMCD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture_TMCD.FillColor = System.Drawing.Color.Transparent;
            this.picture_TMCD.Image = global::FlashCard_version3.Properties.Resources._8O4OT_6;
            this.picture_TMCD.ImageRotate = 0F;
            this.picture_TMCD.Location = new System.Drawing.Point(12, 31);
            this.picture_TMCD.Name = "picture_TMCD";
            this.picture_TMCD.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picture_TMCD.Size = new System.Drawing.Size(176, 171);
            this.picture_TMCD.TabIndex = 0;
            this.picture_TMCD.TabStop = false;
            this.picture_TMCD.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // txtThemMoiChuDe
            // 
            this.txtThemMoiChuDe.BackColor = System.Drawing.Color.Transparent;
            this.txtThemMoiChuDe.BorderColor = System.Drawing.Color.Transparent;
            this.txtThemMoiChuDe.BorderRadius = 20;
            this.txtThemMoiChuDe.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtThemMoiChuDe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThemMoiChuDe.DefaultText = "";
            this.txtThemMoiChuDe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThemMoiChuDe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThemMoiChuDe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThemMoiChuDe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThemMoiChuDe.FillColor = System.Drawing.SystemColors.HotTrack;
            this.txtThemMoiChuDe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThemMoiChuDe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtThemMoiChuDe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThemMoiChuDe.Location = new System.Drawing.Point(214, 94);
            this.txtThemMoiChuDe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThemMoiChuDe.Name = "txtThemMoiChuDe";
            this.txtThemMoiChuDe.PlaceholderText = "Tên chủ đề";
            this.txtThemMoiChuDe.SelectedText = "";
            this.txtThemMoiChuDe.Size = new System.Drawing.Size(176, 46);
            this.txtThemMoiChuDe.TabIndex = 1;
            // 
            // btnAddChuDe
            // 
            this.btnAddChuDe.BackColor = System.Drawing.Color.Transparent;
            this.btnAddChuDe.BorderRadius = 20;
            this.btnAddChuDe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddChuDe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddChuDe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddChuDe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddChuDe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddChuDe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddChuDe.ForeColor = System.Drawing.Color.White;
            this.btnAddChuDe.Location = new System.Drawing.Point(408, 94);
            this.btnAddChuDe.Name = "btnAddChuDe";
            this.btnAddChuDe.Size = new System.Drawing.Size(113, 46);
            this.btnAddChuDe.TabIndex = 2;
            this.btnAddChuDe.Text = "Thêm";
            this.btnAddChuDe.Click += new System.EventHandler(this.btnAddChuDe_Click);
            // 
            // AddChuDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FlashCard_version3.Properties.Resources.Greeting_card__say_something__note__catatan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 242);
            this.Controls.Add(this.btnAddChuDe);
            this.Controls.Add(this.txtThemMoiChuDe);
            this.Controls.Add(this.picture_TMCD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddChuDe";
            this.Text = "Thêm mới chủ đề";
            this.Load += new System.EventHandler(this.AddChuDe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_TMCD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox picture_TMCD;
        private Guna.UI2.WinForms.Guna2TextBox txtThemMoiChuDe;
        private Guna.UI2.WinForms.Guna2Button btnAddChuDe;
    }
}