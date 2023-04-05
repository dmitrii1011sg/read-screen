using System;
using System.Drawing;
using System.Windows.Forms;
using Tesseract;

namespace ReadScreen
{
    public partial class CaptureScreenResult : Form
    {
        /// <summary>
        ///  Tesseract param
        /// </summary>
        private Bitmap screenshotBitmap;
        private Pix screenshotPix;
        private Page page;
        private string pageText;

        internal static TesseractEngine engine = new TesseractEngine(@"./tessdata", "rus", EngineMode.Default);
        private static readonly BitmapToPixConverter bitmapConverter = new BitmapToPixConverter();


        DateTime localDate = DateTime.Now;
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public CaptureScreenResult(Image screenshot)
        {
            InitializeComponent();

            this.screenshotBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AutoSize = true;

            this.screenshotBitmap = (Bitmap)screenshot;
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

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void flowLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void CaptureScreenResult_Load(object sender, EventArgs e)
        {
            screenshotPix = bitmapConverter.Convert((Bitmap)screenshotBox.Image);
            page = engine.Process(screenshotPix);
            pageText = page.GetText();
            this.resultText.Text = pageText.Length > 0 ? pageText : "Page Empty.";
        }
    }
}
