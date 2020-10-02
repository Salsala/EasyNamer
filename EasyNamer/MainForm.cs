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
        DirectoryInfo directoryInfo;
        bool isFirstLoad = true;
        List<string> Messages=new List<string>();

        EventHandler languageChanged;

        public MainForm()
        {
            InitializeComponent();

            languageChanged += LanguageChanged;
            languageChanged += VideoList.LanguageChanged;
            languageChanged += SubtitleList.LanguageChanged;

            SettingChanged(null, EventArgs.Empty);

            VideoList.fileType = new FileType(FileTypes.Video);
            SubtitleList.fileType = new FileType(FileTypes.Subtitle);
            filePath = TbFilePath.Text = Settings.Default.defaultPath;
            string[] Version = Assembly.GetExecutingAssembly().GetName().Version.ToString().Split('.');
            this.Text = this.Text + " Ver." + Version[0] + "." + Version[1] + "." + Version[2];
            FileNameLoad(filePath);
        }

        private void LanguageChanged(object sender, EventArgs e)
        {
            Messages.Clear();
            BtnFolderOpen.Text = Language.TXT_FileLoad;
            BtnRename.Text = Language.TXT_Rename;
            label1.Text = Language.TXT_Path;
            VideoList.ListName = Language.TXT_VideoList;
            SubtitleList.ListName = Language.TXT_SubtitleList;
            Messages.Add(Language.TXT_Message1);
            Messages.Add(Language.TXT_Message2);
            Messages.Add(Language.TXT_Message3);
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
            directoryInfo = new DirectoryInfo(filePath);

            List<FileInformation> videoDeleteList = new List<FileInformation>();
            List<FileInformation> subtitleDeletList = new List<FileInformation>();
            try {
                VideoList.FileNameLoad(directoryInfo);
                SubtitleList.FileNameLoad(directoryInfo);
            } catch {
                MessageBox.Show(Messages[1]);
                return;
            }
            foreach (var videoname in VideoList.FileList) {
                foreach (var subtitlename in SubtitleList.FileList) {
                    if (videoname.FileName == subtitlename.FileName) {
                        videoDeleteList.Add(videoname);
                        subtitleDeletList.Add(subtitlename);
                    }
                }
            }

            foreach (var item in videoDeleteList) {
                VideoList.FileList.Remove(item);
            }
            foreach (var item in subtitleDeletList) {
                SubtitleList.FileList.Remove(item);
            }

            VideoList.ListRefresh();
            SubtitleList.ListRefresh();
        }

        private void BtnRename_Click(object sender, EventArgs e)
        {
            int videoListCount = VideoList.FileList.Count;
            int subtitleListCount = SubtitleList.FileList.Count;
            List<string[]> fileList = new List<string[]>();

            if (videoListCount != subtitleListCount) {
                MessageBox.Show(Messages[2]);
                return;
            } else {
                for (int i = 0; i < videoListCount; i++) {
                    FileInformation video = VideoList.FileList[i];
                    FileInformation subtitle = SubtitleList.FileList[i];
                    filePath = new FileInfo(video.Directory).DirectoryName;
                    TbFilePath.Text = TbFilePath.Text != filePath ? filePath : TbFilePath.Text;
                    string newfullname = $@"{filePath ?? new FileInfo(subtitle.Directory).DirectoryName}\{video.FileName}{subtitle.Extension}";
                    fileList.Add(new string[] { subtitle.Directory, newfullname });
                    subtitle.FileName = video.FileName;
                    subtitle.Directory = newfullname;
                }

                foreach (var item in fileList) {
                    FileInfo file = new FileInfo(item[0]);
                    file.MoveTo(item[1]);
                }

                SubtitleList.ListRefresh();

                MessageBox.Show(Messages[0]);
            }
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();

            settingForm.settingChanged += SettingChanged;

            Point mainFormCenter = new Point(Location.X + Width / 2, Location.Y + Height / 2);
            settingForm.Location = new Point(mainFormCenter.X - settingForm.Width / 2, mainFormCenter.Y - settingForm.Height / 2);
            settingForm.ShowDialog();
        }

        private void SettingChanged(object sender, EventArgs e)
        {
            Language.Culture = UpdateCulture();
            languageChanged.Invoke(null, EventArgs.Empty);
        }

        private CultureInfo UpdateCulture()
        {
            CultureInfo lang = CultureInfo.CurrentUICulture;
            switch (Settings.Default.Language) {
                case "한국어": lang = new CultureInfo("ko-KR"); break;
                case "日本語": lang = new CultureInfo("ja-JP"); break;
                case "English": lang = new CultureInfo("en-US"); break;
                case "Auto":
                default: lang = CultureInfo.CurrentUICulture; break;
            }
            return lang;
        }


        private void TbFilePath_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (e.KeyChar == (char)Keys.Enter) {
                filePath = tb.Text;
                if (Settings.Default.isRecentPath) {
                    Settings.Default.defaultPath = filePath;
                    Settings.Default.Save();
                }
                FileNameLoad(filePath);
            }
        }
    }
}
