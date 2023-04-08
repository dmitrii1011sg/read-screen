using System;
using System.Diagnostics;
using System.Windows.Forms;
using WK.Libraries.HotkeyListenerNS;



namespace ReadScreen
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void emailLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Constance.developerEmail);
        }

        private void changeSettingBtn_Click(object sender, EventArgs e)
        {
            settingsControl.BringToFront();
        }

        private void changeAboutBtn_Click(object sender, EventArgs e)
        {
            aboutControl.BringToFront();
        }
    }
}
