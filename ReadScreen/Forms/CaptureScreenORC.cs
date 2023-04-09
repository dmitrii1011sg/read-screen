using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadScreen
{
    public partial class CaptureScreenORC : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public CaptureScreenORC(Image screenshotImage)
        {
            InitializeComponent();
            screenshotBox.SizeMode = PictureBoxSizeMode.AutoSize;
            screenshotBox.Image = screenshotImage;
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
    }
}
