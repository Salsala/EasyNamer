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

namespace EasyNamer
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            LbVersion.Text = "Build Ver." + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            TbDefaultPath.Text = Properties.Settings.Default.defaultPath;
            if (Properties.Settings.Default.isRecentPath) RdbRecent.Select();
            else RdbDefault.Select();
        }

        private void BtnPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = Properties.Settings.Default.defaultPath;
            DialogResult dr = folderBrowserDialog1.ShowDialog();

            if (dr == DialogResult.Cancel) return;

            TbDefaultPath.Text = folderBrowserDialog1.SelectedPath;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (RdbDefault.Checked)
            {
                Properties.Settings.Default.isRecentPath = false;
                Properties.Settings.Default.defaultPath = TbDefaultPath.Text;
            }
            else if (RdbRecent.Checked) Properties.Settings.Default.isRecentPath = true;

            Properties.Settings.Default.Save();
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
