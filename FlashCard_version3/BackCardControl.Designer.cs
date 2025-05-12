namespace FlashCard_version3
{
    partial class BackCardControl
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
            this.guna2Panel_Little = new Guna.UI2.WinForms.Guna2Panel();
            this.label_NoiDung = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel_Little.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Panel_Little);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(192, 192);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel_Little
            // 
            this.guna2Panel_Little.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Panel_Little.Controls.Add(this.label_NoiDung);
            this.guna2Panel_Little.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel_Little.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel_Little.Name = "guna2Panel_Little";
            this.guna2Panel_Little.Size = new System.Drawing.Size(192, 192);
            this.guna2Panel_Little.TabIndex = 0;
            this.guna2Panel_Little.Click += new System.EventHandler(this.guna2Panel_Little_Click);
            // 
            // label_NoiDung
            // 
            this.label_NoiDung.AutoSize = true;
            this.label_NoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NoiDung.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_NoiDung.Location = new System.Drawing.Point(31, 77);
            this.label_NoiDung.Name = "label_NoiDung";
            this.label_NoiDung.Size = new System.Drawing.Size(128, 32);
            this.label_NoiDung.TabIndex = 0;
            this.label_NoiDung.Text = "Nội dung";
            this.label_NoiDung.Click += new System.EventHandler(this.label_NoiDung_Click);
            // 
            // UserControl_Little
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl_Little";
            this.Size = new System.Drawing.Size(192, 192);
            this.Load += new System.EventHandler(this.UserControl_Little_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel_Little.ResumeLayout(false);
            this.guna2Panel_Little.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel_Little;
        private System.Windows.Forms.Label label_NoiDung;
    }
}
