using Guna.UI2.WinForms;

namespace FlashCard_version3
{
    partial class fAddCard
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
            guna2Panel_ = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button_TroVe = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Panel_
            // 
            guna2Panel_.Location = new System.Drawing.Point(219, 55);
            guna2Panel_.Name = "guna2Panel_";
            guna2Panel_.Size = new System.Drawing.Size(389, 353);
            guna2Panel_.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(490, 4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(118, 45);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Lưu";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button_TroVe
            // 
            guna2Button_TroVe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            guna2Button_TroVe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            guna2Button_TroVe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            guna2Button_TroVe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            guna2Button_TroVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            guna2Button_TroVe.ForeColor = System.Drawing.Color.White;
            guna2Button_TroVe.Location = new System.Drawing.Point(219, 4);
            guna2Button_TroVe.Name = "guna2Button_TroVe";
            guna2Button_TroVe.Size = new System.Drawing.Size(79, 45);
            guna2Button_TroVe.TabIndex = 2;
            guna2Button_TroVe.Text = "<";
            guna2Button_TroVe.Click += new System.EventHandler(this.guna2Button_TroVe_Click);
            // 
            // Form_AddLittleCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(guna2Button_TroVe);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(guna2Panel_);
            this.Name = "Form_AddLittleCard";
            this.Text = "Form_AddLittleCard";
            this.Load += new System.EventHandler(this.Form_AddLittleCard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public static Guna.UI2.WinForms.Guna2Panel guna2Panel_;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        public static Guna.UI2.WinForms.Guna2Button guna2Button_TroVe;
    }
}