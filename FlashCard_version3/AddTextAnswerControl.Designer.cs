namespace FlashCard_version3
{
    partial class AddTextAnswerControl
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
            this.guna2TextBox_TuLuan = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2TextBox_TuLuan
            // 
            this.guna2TextBox_TuLuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox_TuLuan.DefaultText = "";
            this.guna2TextBox_TuLuan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox_TuLuan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox_TuLuan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_TuLuan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_TuLuan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_TuLuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox_TuLuan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_TuLuan.Location = new System.Drawing.Point(77, 146);
            this.guna2TextBox_TuLuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox_TuLuan.Name = "guna2TextBox_TuLuan";
            this.guna2TextBox_TuLuan.PlaceholderText = "Nhập câu trả lời";
            this.guna2TextBox_TuLuan.SelectedText = "";
            this.guna2TextBox_TuLuan.Size = new System.Drawing.Size(229, 48);
            this.guna2TextBox_TuLuan.TabIndex = 0;
            this.guna2TextBox_TuLuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2TextBox_TuLuan);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(389, 353);
            this.guna2Panel1.TabIndex = 1;
            // 
            // UserControl_AddTuLuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UserControl_AddTuLuan";
            this.Size = new System.Drawing.Size(389, 353);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox_TuLuan;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}
