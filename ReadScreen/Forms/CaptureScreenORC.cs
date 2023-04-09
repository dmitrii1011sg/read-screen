using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace ReadScreen
{
    public partial class CaptureScreenORC : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private Bitmap screenshotBitmap;
        private Pix screenshotPix;
        private Page page;
        private string pageText;

        private TesseractEngine engine;
        private static readonly BitmapToPixConverter bitmapConverter = new BitmapToPixConverter();

        public CaptureScreenORC(Image screenshotImage)
        {
            InitializeComponent();

            screenshotBitmap = (Bitmap)screenshotImage; 

            screenshotBox.SizeMode = PictureBoxSizeMode.AutoSize;
            screenshotBox.Image = screenshotImage;

            textBoxORC.Text = "Orc text is not implements";

            comboBoxSelectLang.DataSource = Constance.ComboxItemsLang;
            comboBoxSelectLang.ValueMember = "Id";
            comboBoxSelectLang.DisplayMember = "Lang";
            comboBoxSelectLang.SelectedIndex = comboBoxSelectLang.FindString(Properties.Settings.Default.sett_defaultlang);
        }

        private void CaptureScreenORC_Load(object sender, EventArgs e)
        {
            engine = new TesseractEngine(@"./tessdata", Properties.Settings.Default.sett_defaultlang, EngineMode.Default);
            screenshotPix = bitmapConverter.Convert(screenshotBitmap);
            UpdateTesseractText();
        }

        private void UpdateTesseractText()
        {
            textBoxORC.Clear();
            page = engine.Process(screenshotPix);
            pageText = page.GetText();
            foreach (string line in pageText.Split('\n'))
            {
                textBoxORC.AppendText("\r\n"+line);
            }
            // textBoxORC.Text = pageText.Length > 0 ? pageText : "Page Empty.";
            // textBoxORC.AppendText(pageText.Length > 0 ? pageText : "Page Empty.");
        }

        private void closeBtnControl_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void selectLangBtn_Click(object sender, EventArgs e)
        {
            engine = new TesseractEngine(@"./tessdata", comboBoxSelectLang.SelectedValue.ToString(), EngineMode.Default);
            UpdateTesseractText(); 
        }

        private void copyImageBtn_Click(object sender, EventArgs e)
        {
            ReadScreenUtils.CopyImageToClipcoard(screenshotBitmap);
        }

        private void saveImageBtn_Click(object sender, EventArgs e)
        {
            ReadScreenUtils.SaveImage(screenshotBitmap);
        }

        private void copyTextBtn_Click(object sender, EventArgs e)
        {
            ReadScreenUtils.CopyTextToClipboard(pageText);
        }
    }
}
