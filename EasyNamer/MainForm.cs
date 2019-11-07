using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace EasyNamer
{
    public partial class MainForm : Form
    {
        string filePath;
        DirectoryInfo directoryInfo;
        bool isFirstLoad = true;

        public MainForm()
        {
            InitializeComponent();
            VideoList.ListName = "동영상 리스트";
            SubtitleList.ListName = "자막 리스트";
            VideoList.fileType = new FileType(FileTypes.Video);
            SubtitleList.fileType = new FileType(FileTypes.Subtitle);
            string[] Version = Assembly.GetExecutingAssembly().GetName().Version.ToString().Split('.');
            this.Text = this.Text + " Ver." + Version[0]+"."+Version[1];
        }

        private void BtnFolderOpen_Click(object sender, EventArgs e)
        {
            if (isFirstLoad)
            {
                folderBrowserDialog1.SelectedPath = Properties.Settings.Default.defaultPath;
                isFirstLoad = false;
            }

            DialogResult dr = folderBrowserDialog1.ShowDialog();

            if (dr == DialogResult.Cancel) return;

            filePath = TbFilePath.Text = folderBrowserDialog1.SelectedPath;
            if (Properties.Settings.Default.isRecentPath)
            {
                Properties.Settings.Default.defaultPath = filePath;
                Properties.Settings.Default.Save();
            }
            FileNameLoad(filePath);
        }

        private void FileNameLoad(string filePath)
        {
            directoryInfo = new DirectoryInfo(filePath);
            List<FileInformation> videoDeleteList = new List<FileInformation>();
            List<FileInformation> subtitleDeletList = new List<FileInformation>();

            VideoList.FileNameLoad(directoryInfo);
            SubtitleList.FileNameLoad(directoryInfo);

            foreach (var videoname in VideoList.FileList)
            {
                foreach (var subtitlename in SubtitleList.FileList)
                {
                    if (videoname.FileName == subtitlename.FileName)
                    {
                        videoDeleteList.Add(videoname);
                        subtitleDeletList.Add(subtitlename);
                    }
                }
            }

            foreach (var item in videoDeleteList)
            {
                VideoList.FileList.Remove(item);
            }
            foreach (var item in subtitleDeletList)
            {
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

            if (videoListCount != subtitleListCount)
            {
                MessageBox.Show("동영상과 자막의 개수가 다릅니다.\n" +
                                "동영상 리스트와 자막 리스트를 확인하세요.");
                return;
            }
            else
            {
                for (int i = 0; i < videoListCount; i++)
                {
                    FileInformation video = VideoList.FileList[i];
                    FileInformation subtitle = SubtitleList.FileList[i];
                    string newfullname = filePath + "\\" + video.FileName + subtitle.Extension;
                    fileList.Add(new string[] { subtitle.Directory, newfullname });
                    subtitle.FileName = video.FileName;
                    subtitle.Directory = newfullname;
                }

                foreach (var item in fileList)
                {
                    FileInfo file = new FileInfo(item[0]);
                    file.MoveTo(item[1]);
                }

                SubtitleList.ListRefresh();

                MessageBox.Show("파일명 변경이 완료되었습니다.");
            }
        }

        private void BtnSetting_Click(object sender, EventArgs e)
        {
            SettingForm settingForm = new SettingForm();
            Point mainFormCenter = new Point(Location.X + Width / 2, Location.Y + Height / 2);
            settingForm.Location = new Point(mainFormCenter.X - settingForm.Width / 2, mainFormCenter.Y - settingForm.Height / 2);
            settingForm.ShowDialog();
        }
    }
}
