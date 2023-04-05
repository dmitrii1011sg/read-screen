using System;
using System.Windows.Forms;
using WK.Libraries.HotkeyListenerNS;



namespace ReadScreen
{
    public partial class MainForm : Form
    {
        internal static HotkeyListener hotkeyListener = new HotkeyListener();
        internal static Hotkey CntrPrtScKey = new Hotkey(Keys.Control, Keys.PrintScreen);

        public MainForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;

            copyClipboardCheckBox.Checked = Properties.Settings.Default.sett_copytoclipboard;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            notifyiconMain.Visible = true;

            hotkeyListener.Add(CntrPrtScKey);
            hotkeyListener.HotkeyPressed += Hkl_HotkeyPressed;
        }

        private void Hkl_HotkeyPressed(object sender, HotkeyEventArgs e)
        {
            if (e.Hotkey == CntrPrtScKey)
            {
                CaptureScreen capture = new CaptureScreen();
                capture.Show();
            }
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
            hotkeyListener.RemoveAll();
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
    }
}
