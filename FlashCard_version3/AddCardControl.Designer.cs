namespace FlashCard_version3
{
    partial class AddCardControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button_AddLittle = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2Button_AddLittle);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(195, 195);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(71, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2Button_AddLittle
            // 
            this.guna2Button_AddLittle.BorderRadius = 50;
            this.guna2Button_AddLittle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_AddLittle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_AddLittle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button_AddLittle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button_AddLittle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Button_AddLittle.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.guna2Button_AddLittle.ForeColor = System.Drawing.Color.White;
            this.guna2Button_AddLittle.Location = new System.Drawing.Point(0, 0);
            this.guna2Button_AddLittle.Margin = new System.Windows.Forms.Padding(7);
            this.guna2Button_AddLittle.Name = "guna2Button_AddLittle";
            this.guna2Button_AddLittle.Size = new System.Drawing.Size(195, 195);
            this.guna2Button_AddLittle.TabIndex = 0;
            this.guna2Button_AddLittle.Click += new System.EventHandler(this.guna2Button_AddLittle_Click);
            // 
            // UserControl1_AddLittlecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl1_AddLittlecs";
            this.Size = new System.Drawing.Size(195, 195);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button_AddLittle;
        private System.Windows.Forms.Label label1;
    }
}
