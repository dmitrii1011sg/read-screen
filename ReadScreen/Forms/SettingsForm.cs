using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


namespace ReadScreen
{
    public partial class SettingForm : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private MainForm MainForm;

        public SettingForm(MainForm mainForm)
        {
            InitializeComponent();

            MainForm = mainForm;

            settingsControl.SaveSettingsButtonClick += new EventHandler(saveSetting_Click);
        }

        private void emailLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Constance.developerEmail);
        }

        private void closeBtnControl_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabSetting_Click(object sender, EventArgs e)
        {
            settingsControl.BringToFront();
            tabSetting.FlatAppearance.BorderColor = Color.FromArgb(195, 147, 86);
            tabAbout.FlatAppearance.BorderColor = Color.FromArgb(35, 35, 37);
        }

        private void tabAbout_Click(object sender, EventArgs e)
        {
            aboutControl.BringToFront();
            tabAbout.FlatAppearance.BorderColor = Color.FromArgb(195, 147, 86);
            tabSetting.FlatAppearance.BorderColor = Color.FromArgb(35, 35, 37);
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - startPoint.X, point.Y - startPoint.Y);
            }
        }

        private void saveSetting_Click(object sender, EventArgs e)
        {
            MainForm.ViewNotification("Save", "Settings saved");
        }
    }
}
