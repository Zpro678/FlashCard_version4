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
            this.guna2Button_tuLuan = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_tracNghiem = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Button_tuLuan
            // 
            this.guna2Button_tuLuan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_tuLuan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_tuLuan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button_tuLuan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button_tuLuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Button_tuLuan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(66)))), ((int)(((byte)(114)))));
            this.guna2Button_tuLuan.Font = new System.Drawing.Font("Noto Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button_tuLuan.ForeColor = System.Drawing.Color.White;
            this.guna2Button_tuLuan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button_tuLuan.Location = new System.Drawing.Point(3, 186);
            this.guna2Button_tuLuan.Name = "guna2Button_tuLuan";
            this.guna2Button_tuLuan.Size = new System.Drawing.Size(383, 46);
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
            this.guna2Button_tracNghiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Button_tracNghiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(66)))), ((int)(((byte)(114)))));
            this.guna2Button_tracNghiem.Font = new System.Drawing.Font("Noto Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button_tracNghiem.ForeColor = System.Drawing.Color.White;
            this.guna2Button_tracNghiem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button_tracNghiem.Location = new System.Drawing.Point(3, 117);
            this.guna2Button_tracNghiem.Name = "guna2Button_tracNghiem";
            this.guna2Button_tracNghiem.Size = new System.Drawing.Size(383, 46);
            this.guna2Button_tracNghiem.TabIndex = 0;
            this.guna2Button_tracNghiem.Text = "Trắc nghiệm";
            this.guna2Button_tracNghiem.Click += new System.EventHandler(this.guna2Button_tracNghiem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Button_tuLuan, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.guna2Button_tracNghiem, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(389, 353);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // QuestionCategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "QuestionCategoryControl";
            this.Size = new System.Drawing.Size(389, 353);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button guna2Button_tuLuan;
        private Guna.UI2.WinForms.Guna2Button guna2Button_tracNghiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
