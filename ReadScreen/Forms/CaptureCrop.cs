using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ReadScreen
{
    public partial class CaptureCrop : Form
    {
        private Pen selectPen;
        private Point startPoint;
        private bool selectDrawing = false;

        public CaptureCrop()
        {
            InitializeComponent();

            Size = SystemInformation.VirtualScreen.Size;
            BackColor = Color.Black;
            Opacity = 0.3f;

            selectPen = new Pen(Color.Red);
            pictureArea.Visible = false;
        
            this.Activate();
        }

        private void CaptureCrop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }

        private void CaptureCrop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                selectDrawing = true;

                pictureArea.Visible = true;
                pictureArea.Location = startPoint;
            }
        }

        private void CaptureCrop_MouseMove(object sender, MouseEventArgs e)
        {
            if (!selectDrawing) return;

            pictureArea.Location = GetStartPointFromPoints(e.Location, startPoint);
            pictureArea.Size = GetSizeFromPoints(e.Location, startPoint);
        }

        private Size GetSizeFromPoints(Point pointStart, Point point)
        {
            int deltaW = point.X - pointStart.X;
            int deltaH = point.Y - pointStart.Y;
            return new Size(Math.Abs(deltaW), Math.Abs(deltaH));
        }

        private Point GetStartPointFromPoints(Point pointStart, Point point)
        {
            int deltaW = point.X - pointStart.X;
            int deltaH = point.Y - pointStart.Y;
            Point resultPoint = pointStart;

            if (deltaH < 0 & deltaW < 0) resultPoint = point;
            else if (deltaH < 0) resultPoint.Y = point.Y;
            else if (deltaW < 0) resultPoint.X = point.X;

            return resultPoint;
        }

        private void CaptureCrop_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                selectDrawing = false;
                Hide();
                
                Size resolution = GetSizeFromPoints(startPoint, e.Location);
                Bitmap bmpScreenshot = new Bitmap(resolution.Width, resolution.Height, PixelFormat.Format32bppArgb);
                Graphics gfxScreenshot = Graphics.FromImage(bmpScreenshot);
                gfxScreenshot.CopyFromScreen(startPoint.X, startPoint.Y, 0, 0, resolution, CopyPixelOperation.SourceCopy);

                // CaptureScreenResult captureResult = new CaptureScreenResult((Image)bmpScreenshot);
                //captureResult.Show();
                CaptureScreenORC captureOrc = new CaptureScreenORC((Image)bmpScreenshot);
                captureOrc.Show();
            }
            else if (e.Button == MouseButtons.Right) Close();
        }

        private void pictureArea_Paint(object sender, PaintEventArgs e)
        {
            Rectangle pictureAreaRect = new Rectangle(0, 0, pictureArea.Width - 1, pictureArea.Height - 1);
            e.Graphics.DrawRectangle(selectPen, pictureAreaRect);
        }
    }
}
