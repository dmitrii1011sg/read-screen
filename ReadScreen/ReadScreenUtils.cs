using Microsoft.Win32;
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
        public static void SaveImage(Image image)
        {
            string localDate = DateTime.Now.ToString().Replace(".", "").Replace(":", "").Replace(" ", "");
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.CheckPathExists = true;
            sfd.FileName = "Capture-" + localDate.ToString();
            sfd.Filter = "PNG Image(*.png)|*.png|JPG Image(*.jpg)|*.jpg|BMP Image(*.bmp)|*.bmp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                image.Save(sfd.FileName);
            }
        }

        public static void CopyImageToClipcoard(Image image)
        {
            Clipboard.SetImage(image);
        }

        public static void CopyTextToClipboard(string text)
        {
            Clipboard.SetText(text);
        }

        public static void AddApplicationToStartup()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                key.SetValue("ReadScreen", "\"" + Application.ExecutablePath + "\"");
            }
        }

        public static void RemoveApplicationFromStartup()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
            {
                key.DeleteValue("ReadScreen", false);
            }
        }
    }
}
