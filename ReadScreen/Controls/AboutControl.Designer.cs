namespace ReadScreen
{
    partial class AboutControl
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
            this.title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.developerLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(13, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(146, 20);
            this.title.TabIndex = 0;
            this.title.Text = "About ReadScreen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "The ReadScreen application is a tool that\r\nallows users to capture screenshots of" +
    " their\r\ncomputer screen. The application also helps\r\nto translate text from a sc" +
    "reenshot into \r\nmachine text.";
            // 
            // developerLabel
            // 
            this.developerLabel.AutoSize = true;
            this.developerLabel.ForeColor = System.Drawing.Color.White;
            this.developerLabel.Location = new System.Drawing.Point(17, 176);
            this.developerLabel.Name = "developerLabel";
            this.developerLabel.Size = new System.Drawing.Size(139, 13);
            this.developerLabel.TabIndex = 2;
            this.developerLabel.Text = "Developer: Dmitrii Gorshkov";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.ForeColor = System.Drawing.Color.White;
            this.versionLabel.Location = new System.Drawing.Point(213, 176);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(19, 13);
            this.versionLabel.TabIndex = 3;
            this.versionLabel.Text = "v0";
            // 
            // AboutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.developerLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Name = "AboutControl";
            this.Size = new System.Drawing.Size(258, 228);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label developerLabel;
        private System.Windows.Forms.Label versionLabel;
    }
}
