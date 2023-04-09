using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            this.ShowInTaskbar = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            iconMain.Visible = true;
            hotkeyListener.Add(CntrPrtScKey);
            hotkeyListener.HotkeyPressed += Hkl_HotkeyPressed;

            Timer MyTimer = new Timer();
            MyTimer.Interval = 1000;
            MyTimer.Tick += new EventHandler(timer_Tick);
            MyTimer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Hide();
        }

        private void Hkl_HotkeyPressed(object sender, HotkeyEventArgs e)
        {
            if (e.Hotkey == CntrPrtScKey)
            {
                CaptureCrop capture = new CaptureCrop(this);
                capture.Show();
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm form = new SettingForm(this);
            form.Show();
        }

        private void captureScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaptureCrop capture = new CaptureCrop(this);
            capture.Show();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iconMain.Dispose();
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

        public void ViewNotification(string title, string content, int timer = 10)
        {
            iconMain.BalloonTipTitle = title;
            iconMain.BalloonTipText = content;
            iconMain.ShowBalloonTip(timer);
        }
    }
}
