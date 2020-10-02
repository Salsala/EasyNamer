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
            TbDefaultPath.Text = Settings.Default.defaultPath;
            if (Settings.Default.isRecentPath) RdbRecent.Select();
            else RdbDefault.Select();
            cb_Language.Text = Settings.Default.Language;
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
