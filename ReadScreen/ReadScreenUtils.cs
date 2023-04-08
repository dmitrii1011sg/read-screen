using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadScreen
{
    class ReadScreenUtils
    {
        DateTime localDate = DateTime.Now;

        public void SaveImage(Image image)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.CheckPathExists = true;
            sfd.FileName = "Capture-" + localDate.ToString();
            sfd.Filter = "PNG Image(*.png)|*.png|JPG Image(*.jpg)|*.jpg|BMP Image(*.bmp)|*.bmp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                image.Save(sfd.FileName);
            }
        }

        public void CopyImageToClipcoard(Image image)
        {
            Clipboard.SetImage(image);
        }

        public void CopyTextToClipboard(string text)
        {
            Clipboard.SetText(text);
        }
    }
}
