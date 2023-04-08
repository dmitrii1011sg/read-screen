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
        }

        private void Hkl_HotkeyPressed(object sender, HotkeyEventArgs e)
        {
            if (e.Hotkey == CntrPrtScKey)
            {
                CaptureCrop capture = new CaptureCrop();
                capture.Show();
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingForm form = new SettingForm();
            form.Show();
        }

        private void captureScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaptureCrop capture = new CaptureCrop();
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
    }
}
