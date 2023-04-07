namespace ReadScreen
{
    partial class CaptureCrop
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
            this.pictureArea = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureArea)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureArea
            // 
            this.pictureArea.BackColor = System.Drawing.Color.White;
            this.pictureArea.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureArea.Location = new System.Drawing.Point(180, 180);
            this.pictureArea.Name = "pictureArea";
            this.pictureArea.Size = new System.Drawing.Size(100, 100);
            this.pictureArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureArea.TabIndex = 0;
            this.pictureArea.TabStop = false;
            this.pictureArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureArea_Paint);
            // 
            // CaptureCrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(460, 460);
            this.Controls.Add(this.pictureArea);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaptureCrop";
            this.Text = "CaptureCrop";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CaptureCrop_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CaptureCrop_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CaptureCrop_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CaptureCrop_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureArea;
    }
}