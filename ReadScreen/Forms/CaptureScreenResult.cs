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

        private ReadScreenUtils Utils = new ReadScreenUtils();

        private TesseractEngine engine;
        private static readonly BitmapToPixConverter bitmapConverter = new BitmapToPixConverter();
        
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public CaptureScreenResult(Image screenshot)
        {
            InitializeComponent();

            screenshotBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            AutoSize = true;

            screenshotBitmap = (Bitmap)screenshot;
            screenshotBox.Image = screenshot;

            resultText.Text = "OCR text is not implements";

            comboBoxLang.DataSource = Constance.ComboxItemsLang;
            comboBoxLang.ValueMember = "Id";
            comboBoxLang.DisplayMember = "Lang";
            comboBoxLang.SelectedIndex = comboBoxLang.FindString("rus");
        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            Utils.SaveImage(screenshotBox.Image);
        }

        private void copyImage_Click(object sender, EventArgs e)
        {
            Utils.CopyImageToClipcoard(screenshotBox.Image);
        }

        private void copyText_Click(object sender, EventArgs e)
        {
            Utils.CopyTextToClipboard(resultText.Text);
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
            engine = new TesseractEngine(@"./tessdata", "rus", EngineMode.Default);
            screenshotPix = bitmapConverter.Convert(screenshotBitmap);
            UpdateTesseractText();
        }

        private void UpdateTesseractText()
        {
            page = engine.Process(screenshotPix);
            pageText = page.GetText();
            this.resultText.Text = pageText.Length > 0 ? pageText : "Page Empty.";
        }

        private void doneLang_Click(object sender, EventArgs e)
        {
            engine = new TesseractEngine(@"./tessdata", this.comboBoxLang.SelectedValue.ToString(), EngineMode.Default);
            this.UpdateTesseractText();
        }
    }
}
