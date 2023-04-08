using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadScreen
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();

            autoCopyImage.Checked = Properties.Settings.Default.sett_copyimagetoclipboard;
            autoCopyText.Checked = Properties.Settings.Default.sett_copytexttoclipboard;
            nothingCopyBtn.Checked = Properties.Settings.Default.sett_copynothingtoclipboard;

            comboBoxDefaultLang.DataSource = Constance.ComboxItemsLang;
            comboBoxDefaultLang.ValueMember = "Id";
            comboBoxDefaultLang.DisplayMember = "Lang";
            comboBoxDefaultLang.SelectedIndex = this.comboBoxDefaultLang.FindString(Properties.Settings.Default.sett_defaultlang);
        }

        private void UpdateAutoCopySettings()
        {
            Properties.Settings.Default.sett_copyimagetoclipboard = autoCopyImage.Checked;
            Properties.Settings.Default.sett_copytexttoclipboard = autoCopyText.Checked;
            Properties.Settings.Default.sett_copynothingtoclipboard = nothingCopyBtn.Checked;
        }

        private void UpdateDefaultLangSettings()
        {
            Properties.Settings.Default.sett_defaultlang = comboBoxDefaultLang.SelectedValue.ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            UpdateAutoCopySettings();
            UpdateDefaultLangSettings();
        }
    }
}
