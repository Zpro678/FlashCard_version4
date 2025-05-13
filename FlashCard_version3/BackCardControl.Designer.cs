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
            this.guna2Panel_Little = new Guna.UI2.WinForms.Guna2Panel();
            this.label_NoiDung = new System.Windows.Forms.Label();
            this.guna2Panel_Little.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel_Little
            // 
            this.guna2Panel_Little.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(82)))), ((int)(((byte)(149)))));
            this.guna2Panel_Little.BorderRadius = 20;
            this.guna2Panel_Little.Controls.Add(this.label_NoiDung);
            this.guna2Panel_Little.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel_Little.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel_Little.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel_Little.Name = "guna2Panel_Little";
            this.guna2Panel_Little.Size = new System.Drawing.Size(250, 320);
            this.guna2Panel_Little.TabIndex = 0;
            this.guna2Panel_Little.Click += new System.EventHandler(this.guna2Panel_Little_Click);
            // 
            // label_NoiDung
            // 
            this.label_NoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_NoiDung.Font = new System.Drawing.Font("Noto Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NoiDung.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_NoiDung.Location = new System.Drawing.Point(0, 0);
            this.label_NoiDung.Margin = new System.Windows.Forms.Padding(10);
            this.label_NoiDung.Name = "label_NoiDung";
            this.label_NoiDung.Size = new System.Drawing.Size(250, 320);
            this.label_NoiDung.TabIndex = 0;
            this.label_NoiDung.Text = "Nội dung";
            this.label_NoiDung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_NoiDung.Click += new System.EventHandler(this.label_NoiDung_Click);
            // 
            // BackCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel_Little);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "BackCardControl";
            this.Size = new System.Drawing.Size(250, 320);
            this.Load += new System.EventHandler(this.UserControl_Little_Load);
            this.guna2Panel_Little.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel_Little;
        private System.Windows.Forms.Label label_NoiDung;
    }
}
