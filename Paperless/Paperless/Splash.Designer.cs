namespace Paperless
{
    partial class Splash
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
            this.title = new System.Windows.Forms.Label();
            this.tagline = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.Font = new System.Drawing.Font("Jura", 45F);
            this.title.Location = new System.Drawing.Point(168, 87);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(326, 63);
            this.title.TabIndex = 0;
            this.title.Text = "Paperless";
            this.title.UseCompatibleTextRendering = true;
            // 
            // tagline
            // 
            this.tagline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tagline.AutoSize = true;
            this.tagline.BackColor = System.Drawing.Color.Transparent;
            this.tagline.Font = new System.Drawing.Font("Jura", 13F);
            this.tagline.Location = new System.Drawing.Point(176, 145);
            this.tagline.Name = "tagline";
            this.tagline.Size = new System.Drawing.Size(305, 19);
            this.tagline.TabIndex = 1;
            this.tagline.Text = "Digital Document Storage System";
            this.tagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icon
            // 
            this.icon.Image = global::Paperless.Properties.Resources.new_page_64x64;
            this.icon.Location = new System.Drawing.Point(111, 97);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(64, 64);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.icon.TabIndex = 2;
            this.icon.TabStop = false;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(605, 250);
            this.ControlBox = false;
            this.Controls.Add(this.tagline);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.title);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Splash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Shown += new System.EventHandler(this.Splash_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label tagline;
        private System.Windows.Forms.PictureBox icon;
    }
}

