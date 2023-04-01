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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

            copyClipboardCheckBox.Checked = Properties.Settings.Default.sett_copytoclipboard;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }

        private void captureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaptureScreen capture = new CaptureScreen();
            capture.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            notifyiconMain.Visible = true;
        }
    }
}
