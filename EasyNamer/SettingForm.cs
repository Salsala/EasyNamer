using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using EasyNamer.Properties;

namespace EasyNamer
{
    public partial class SettingForm : Form
    {
        public EventHandler settingChanged;

        public SettingForm()
        {
            InitializeComponent();
            LanguageChange();
            LbVersion.Text = "Build Ver." + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            SettingLoad();
        }

        private void SettingLoad()
        {
            TbDefaultPath.Text = Settings.Default.defaultPath;
            if (Settings.Default.isRecentPath) RdbRecent.Select();
            else RdbDefault.Select();
            switch (Settings.Default.Language) {
                case "한국어": cb_Language.SelectedIndex=3; break;
                case "日本語": cb_Language.SelectedIndex=2; break;
                case "English": cb_Language.SelectedIndex=1; break;
                case "Auto":
                default: cb_Language.SelectedIndex = 0; break;
            }
        }

        private void LanguageChange()
        {
            groupBox1.Text = Language.TXT_Option;
            RdbDefault.Text = Language.TXT_Default;
            RdbRecent.Text = Language.TXT_Recent;
            BtnPath.Text = Language.TXT_Find;
            BtnOk.Text = Language.TXT_OK;
            BtnCancel.Text = Language.TXT_Cancel;
            label1.Text = Language.TXT_Language;
            cb_Language.Items[0] = Language.TXT_Auto;

        }

        private void BtnPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = Settings.Default.defaultPath;
            DialogResult dr = folderBrowserDialog1.ShowDialog();

            if (dr == DialogResult.Cancel) return;

            TbDefaultPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (RdbDefault.Checked)
            {
                Settings.Default.isRecentPath = false;
                Settings.Default.defaultPath = TbDefaultPath.Text;
            }
            else if (RdbRecent.Checked) Settings.Default.isRecentPath = true;
            switch (cb_Language.SelectedIndex) {
                case 3: Settings.Default.Language = "한국어"; break;
                case 2: Settings.Default.Language = "日本語"; break;
                case 1: Settings.Default.Language = "English"; break;
                case 0:
                default: Settings.Default.Language = "Auto"; break;
            }


            Settings.Default.Language = cb_Language.Text;

            Settings.Default.Save();

            settingChanged.Invoke(null, EventArgs.Empty);

            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RdbRecent_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbRecent.Checked)
            {
                TbDefaultPath.Enabled = false;
                BtnPath.Enabled = false;
            }
        }

        private void RdbDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbDefault.Checked)
            {
                TbDefaultPath.Enabled = true;
                BtnPath.Enabled = true;
            }
        }
    }
}
