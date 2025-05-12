namespace FlashCard_version3
{
    partial class AddMuiltipleChoiceControl
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
            this.guna2Panel_flow = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanel_ = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox_CauTraLoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel_flow.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel_flow
            // 
            this.guna2Panel_flow.AutoScroll = true;
            this.guna2Panel_flow.Controls.Add(this.flowLayoutPanel_);
            this.guna2Panel_flow.Location = new System.Drawing.Point(3, 0);
            this.guna2Panel_flow.Name = "guna2Panel_flow";
            this.guna2Panel_flow.Size = new System.Drawing.Size(383, 293);
            this.guna2Panel_flow.TabIndex = 0;
            // 
            // flowLayoutPanel_
            // 
            this.flowLayoutPanel_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_.Name = "flowLayoutPanel_";
            this.flowLayoutPanel_.Size = new System.Drawing.Size(383, 293);
            this.flowLayoutPanel_.TabIndex = 0;
            this.flowLayoutPanel_.WrapContents = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(270, 299);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(116, 45);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Thêm";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2TextBox_CauTraLoi
            // 
            this.guna2TextBox_CauTraLoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox_CauTraLoi.DefaultText = "";
            this.guna2TextBox_CauTraLoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox_CauTraLoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox_CauTraLoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_CauTraLoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_CauTraLoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_CauTraLoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox_CauTraLoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_CauTraLoi.Location = new System.Drawing.Point(3, 300);
            this.guna2TextBox_CauTraLoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox_CauTraLoi.Name = "guna2TextBox_CauTraLoi";
            this.guna2TextBox_CauTraLoi.PlaceholderText = "Mời nhập câu trả lời";
            this.guna2TextBox_CauTraLoi.SelectedText = "";
            this.guna2TextBox_CauTraLoi.Size = new System.Drawing.Size(261, 44);
            this.guna2TextBox_CauTraLoi.TabIndex = 2;
            // 
            // UserControlAddTracNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2TextBox_CauTraLoi);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Panel_flow);
            this.Name = "UserControlAddTracNghiem";
            this.Size = new System.Drawing.Size(389, 353);
            this.Load += new System.EventHandler(this.UserControlAddTracNghiem_Load);
            this.guna2Panel_flow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel_flow;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox_CauTraLoi;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_;
    }
}
