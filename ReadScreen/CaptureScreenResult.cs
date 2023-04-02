using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReadScreen
{
    public partial class CaptureScreenResult : Form
    {
        DateTime localDate = DateTime.Now;

        public CaptureScreenResult(Image screenshot)
        {
            InitializeComponent();

            this.screenshotBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AutoSize = true;

            this.screenshotBox.Image = screenshot;

            this.resultText.Text = "OCR text is not implements"; 
        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.CheckPathExists = true;
            sfd.FileName = "Capture-"+localDate.ToString();
            sfd.Filter = "PNG Image(*.png)|*.png|JPG Image(*.jpg)|*.jpg|BMP Image(*.bmp)|*.bmp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                screenshotBox.Image.Save(sfd.FileName);
            }
        }

        private void copyImage_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(screenshotBox.Image);
        }

        private void copyText_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(resultText.Text);
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
