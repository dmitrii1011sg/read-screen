namespace ReadScreen
{
    partial class CaptureScreen
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
            this.screenPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.screenPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // screenPictureBox
            // 
            this.screenPictureBox.Location = new System.Drawing.Point(0, -1);
            this.screenPictureBox.Name = "screenPictureBox";
            this.screenPictureBox.Size = new System.Drawing.Size(328, 305);
            this.screenPictureBox.TabIndex = 0;
            this.screenPictureBox.TabStop = false;
            this.screenPictureBox.Click += new System.EventHandler(this.screenPictureBox_Click);
            // 
            // CaptureScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 306);
            this.ControlBox = false;
            this.Controls.Add(this.screenPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CaptureScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CaptureScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CaptureWindowLoad);
            ((System.ComponentModel.ISupportInitialize)(this.screenPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox screenPictureBox;
    }
}