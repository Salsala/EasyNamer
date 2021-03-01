using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using EasyNamer.Properties;
using System.Globalization;

namespace EasyNamer
{
    public partial class MainForm : Form
    {
        string filePath;
        bool isFirstLoad = true;

        EventHandler languageChanged;

        public MainForm()
        {
            InitializeComponent();

            languageChanged += LanguageChanged;

            SettingChanged(null, EventArgs.Empty);

            VideoList.fileType = new FileType(FileTypes.Video);
            SubtitleList.fileType = new FileType(FileTypes.Subtitle);
            filePath = TbFilePath.Text = Directory.Exists(Settings.Default.defaultPath)?Settings.Default.defaultPath:@"C:\";

            string[] Version = Assembly.GetExecutingAssembly().GetName().Version.ToString().Split('.');
            this.Text = this.Text + " Ver." + Version[0] + "." + Version[1] + "." + Version[2];
            FileNameLoad(filePath);
        }

        private void LanguageChanged(object sender, EventArgs e)
        {
            ApplyControlCulture((Control)sender, Language.Culture);
            Program.Messages.Clear();
            for (int i = 0; i < 5; i++) {
                Program.Messages.Add(Language.ResourceManager.GetString($"TXT_Message{i + 1}", Language.Culture));
            }
        }

        private void ApplyControlCulture(Control ctrls, CultureInfo culture)
        {
            foreach (Control ctrl in ctrls.Controls) {
                if (ctrl is Button btn) btn.Text = Language.ResourceManager.GetString(btn.Name.Replace("Btn", "TXT_"), culture);
                else if (ctrl is Label label) label.Text = Language.ResourceManager.GetString(label.Name.Replace("Lb", "TXT_"), culture);
                else if (ctrl is FileListControl filelist) {
                    filelist.ListName = Language.ResourceManager.GetString($"TXT_{filelist.Name}", culture);
                    filelist.ApplyLanguage();
                } else if (ctrl is GroupBox gb) {
                    gb.Text = Language.ResourceManager.GetString(gb.Name.Replace("Gb", "TXT_"), culture);
                    ApplyControlCulture(gb, culture);
                } else if (ctrl is RadioButton rdb) rdb.Text = Language.ResourceManager.GetString(rdb.Name.Replace("Rdb", "TXT_"), culture);
                else ApplyControlCulture(ctrl, culture);
            }
        }

        private void BtnFolderOpen_Click(object sender, EventArgs e)
        {
            if (isFirstLoad) {
                folderBrowserDialog1.SelectedPath = Settings.Default.defaultPath;
                isFirstLoad = false;
            }

            DialogResult dr = folderBrowserDialog1.ShowDialog();

            if (dr == DialogResult.Cancel) return;

            filePath = TbFilePath.Text = folderBrowserDialog1.SelectedPath;
            if (Settings.Default.isRecentPath) {
                Settings.Default.defaultPath = filePath;
                Settings.Default.Save();
            }
            FileNameLoad(filePath);
        }

        private void FileNameLoad(string filePath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(filePath);

            List<ListViewItem> videoDeleteList = new List<ListViewItem>();
            List<ListViewItem> subtitleDeletList = new List<ListViewItem>();

            VideoList.FileNameLoad(directoryInfo);
            SubtitleList.FileNameLoad(directoryInfo);

            foreach (ListViewItem videoname in VideoList.fileNameListView.Items) {
                foreach (ListViewItem subtitlename in SubtitleList.fileNameListView.Items) {
                    if (videoname.ToString() == subtitlename.ToString()) {
                        videoDeleteList.Add(videoname);
                        subtitleDeletList.Add(subtitlename);
                    }
                }
            }

            foreach (var item in videoDeleteList) {
                VideoList.fileNameListView.Items.Remove(item);
            }
            foreach (var item in subtitleDeletList) {
                SubtitleList.fileNameListView.Items.Remove(item);
            }
        }

        private void BtnRename_Click(object sender, EventArgs e)
        {
            int videoListCount = VideoList.fileNameListView.Items.Count;
            int subtitleListCount = SubtitleList.fileNameListView.Items.Count;
            List<string[]> fileList = new List<string[]>();

            if (videoListCount != subtitleListCount) {
                MessageBox.Show(Program.Messages[2]);
                return;
            } else if (videoListCount == 0 && subtitleListCount == 0) {
                MessageBox.Show(Program.Messages[3]);
                return;
            } else {
                for (int i = 0; i < videoListCount; i++) {
                    ListViewItem video = VideoList.fileNameListView.Items[i];
                    ListViewItem subtitle = SubtitleList.fileNameListView.Items[i];
                    filePath = new FileInfo(video.SubItems[2].Text).DirectoryName;
                    TbFilePath.Text = TbFilePath.Text != filePath ? filePath : TbFilePath.Text;
                    string newfullname = $@"{filePath ?? new FileInfo(subtitle.SubItems[2].Text).DirectoryName}\{video.Text}{subtitle.SubItems[1].Text}";
                    fileList.Add(new string[] { subtitle.SubItems[2].Text, newfullname });
                    subtitle.Text = video.Text;
                    subtitle.SubItems[2].Text = newfullname;
                }

                foreach (var item in fileList) {
                    FileInfo file = new FileInfo(item[0]);
                    file.MoveTo(item[1]);
                }

                MessageBox.Show(Program.Messages[0]);
            }
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();

            settingForm.settingChanged += SettingChanged;

            ApplyControlCulture(settingForm, Language.Culture);

            Point mainFormCenter = new Point(Location.X + Width / 2, Location.Y + Height / 2);
            settingForm.Location = new Point(mainFormCenter.X - settingForm.Width / 2, mainFormCenter.Y - settingForm.Height / 2);
            settingForm.ShowDialog();
        }

        private void SettingChanged(object sender, EventArgs e)
        {
            Language.Culture = UpdateCulture();
            languageChanged.Invoke(this, EventArgs.Empty);
        }

        private CultureInfo UpdateCulture()
        {
            CultureInfo lang = CultureInfo.CurrentUICulture;
            string LanguageCode = Settings.Default.Language;
            if (LanguageCode == "Auto") lang = CultureInfo.CurrentUICulture;
            else lang = new CultureInfo(LanguageCode);
            return lang;
        }

        private void TbFilePath_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (e.KeyChar == (char)Keys.Enter) {
                string tmp = filePath;
                try {
                    if (tb.Text.Substring(1, 2) == @":\")
                        tb.Text = tb.Text.Replace(tb.Text.Substring(0, 2), tb.Text.Substring(0, 2).ToUpper());
                    filePath = tb.Text;

                    FileNameLoad(filePath);
                    ActiveControl=null;
                    e.Handled = true;
                } catch {
                    MessageBox.Show(Program.Messages[1]);
                    filePath = tmp;
                    tb.SelectAll();
                }

                if (Settings.Default.isRecentPath) {
                    Settings.Default.defaultPath = filePath;
                    Settings.Default.Save();
                }

            }
        }

        private void TbFilePath_MouseUp(object sender, MouseEventArgs e)
        {
            Program.TripleClick(TbFilePath);
        }
    }
}
