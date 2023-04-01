using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ReadScreen
{
    public partial class CaptureScreen : Form
    {
        int selectX;
        int selectY;
        int selectWidth;
        int selectHeight;

        int startPointX;
        int startPointY;

        public Pen selectPen;
        bool start = false;

        public CaptureScreen()
        {
            InitializeComponent();

            screenPictureBox.MouseDown += new MouseEventHandler(screenPictureBox_MouseDown);
            screenPictureBox.MouseMove += new MouseEventHandler(screenPictureBox_MouseMove);
        }

        private void UpdateStartCordPosRect()
        {
            startPointX = selectX;
            startPointY = selectY;

            if (selectWidth < 0 & selectHeight < 0)
            {
                startPointX = selectX + selectWidth;
                startPointY = selectY + selectHeight;
            }
            else if (selectWidth < 0)
            {
                startPointX = selectX + selectWidth;
            }
            else if (selectHeight < 0)
            {
                startPointY = selectY + selectHeight;
            }
        }

        void CaptureWindowLoad(object sender, EventArgs e)
        {
            this.Hide();

            Bitmap printscreen = new Bitmap(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
            Graphics graphics = Graphics.FromImage(printscreen as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);

            using (MemoryStream s = new MemoryStream())
            {
                printscreen.Save(s, ImageFormat.Png);
                screenPictureBox.Size = new System.Drawing.Size(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height);
                screenPictureBox.Image = Image.FromStream(s);
            }

            this.Show();
            Cursor = Cursors.Cross;
        }

        private void SaveToClipboard()
        {
            string filename = System.IO.Path.GetFileNameWithoutExtension(System.IO.Path.GetRandomFileName()) + ".png";
            this.UpdateStartCordPosRect();
            
            Rectangle rect = new Rectangle(startPointX, startPointY, Math.Abs(selectWidth), Math.Abs(selectHeight));
            Bitmap OriginalImage = new Bitmap(screenPictureBox.Image, screenPictureBox.Width, screenPictureBox.Height);
            Bitmap _img = new Bitmap(Math.Abs(selectWidth), Math.Abs(selectHeight));
            Graphics g = Graphics.FromImage(_img);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.DrawImage(OriginalImage, 0, 0, rect, GraphicsUnit.Pixel);
            Clipboard.SetImage(_img);

            if (Clipboard.ContainsImage() == true)
            {
                Image image = (Image)Clipboard.GetDataObject().GetData(DataFormats.Bitmap);
                image.Save(Path.GetTempPath() + filename);
            }
            else
            {
                Console.WriteLine("Clipboard empty.");
            }

            Clipboard.SetImage(_img);
            Console.Write("Image copied");
        }

        private void screenPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (screenPictureBox.Image == null) return;
            if (start)
            {
                screenPictureBox.Refresh();
                selectWidth = e.X - selectX;
                selectHeight = e.Y - selectY;

                this.UpdateStartCordPosRect();
                screenPictureBox.CreateGraphics().DrawRectangle(selectPen, startPointX, startPointY, Math.Abs(selectWidth), Math.Abs(selectHeight));
            }

        }

        private void screenPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (!start)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Middle)
                {
                    Close();
                }
                else if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    selectX = e.X;
                    selectY = e.Y;
                    int width = screenPictureBox.Image.Size.Width;
                    int height = screenPictureBox.Image.Size.Height;

                    selectPen = new Pen(Color.Red, 1);
                    selectPen.DashStyle = DashStyle.Dash;
                }
                screenPictureBox.Refresh();
                start = true;
            }
            else
            {
                if (screenPictureBox.Image == null) return;

                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    screenPictureBox.Refresh();
                    selectWidth = e.X - selectX;
                    selectHeight = e.Y - selectY;
                    screenPictureBox.CreateGraphics().DrawRectangle(selectPen, selectX, selectY, selectWidth, selectHeight);
                }
                start = false;
                SaveToClipboard();
                Close();
            }
        }

        private void screenPictureBox_Click(object sender, EventArgs e) { }
    }
}
