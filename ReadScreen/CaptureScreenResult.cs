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

        private TesseractEngine engine;
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

            this.comboBoxLang.DataSource = new ComboItemLang[] {
                new ComboItemLang{ Id = "rus", Lang = "Russian" },
                new ComboItemLang{ Id = "en", Lang = "English" }
            };

            this.comboBoxLang.ValueMember = "Id";
            this.comboBoxLang.DisplayMember = "Lang";

            this.comboBoxLang.SelectedIndex = this.comboBoxLang.FindString("rus");
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
            engine = new TesseractEngine(@"./tessdata", "rus", EngineMode.Default);
            screenshotPix = bitmapConverter.Convert((Bitmap)screenshotBox.Image);
            this.UpdateTesseractText();
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

    class ComboItemLang
    {
        public string Id { get; set; }
        public string Lang { get; set; }
    }
}
