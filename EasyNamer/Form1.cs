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

namespace EasyNamer
{
    public partial class Form1 : Form
    {
        string filePath;
        DirectoryInfo directoryInfo;
        public List<FileInformation> videoList = new List<FileInformation>();
        public List<FileInformation> subtitleList = new List<FileInformation>();
        public Form1()
        {
            InitializeComponent();
            VideoList.ListName = "동영상 리스트";
            SubtitleList.ListName = "자막 리스트";
        }

        private void BtnFolderOpen_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            filePath = folderBrowserDialog1.SelectedPath;

            FileNameLoad(filePath);
        }

        private void FileNameLoad(string filePath)
        {
            directoryInfo = new DirectoryInfo(filePath);
            List<FileInformation> videoDeleteList = new List<FileInformation>();
            List<FileInformation> subtitleDeletList = new List<FileInformation>();

            foreach (var item in directoryInfo.GetFiles())
            {
                string extension = item.Extension;
                string filename = Path.GetFileNameWithoutExtension(item.FullName);
                string fullname = item.FullName;

                if (extension == ".mkv" || extension == ".mp4" || extension == ".MKV" || extension == ".MP4")
                {
                    videoList.Add(new FileInformation(filename, extension.ToLower(), fullname));
                }
                else if (extension == ".smi" || extension == ".SMI")
                {
                    subtitleList.Add(new FileInformation(filename, extension.ToLower(), fullname));
                }
            }


            foreach (var videoname in videoList)
            {
                foreach (var subtitlename in subtitleList)
                {
                    if (videoname.파일명 == subtitlename.파일명)
                    {
                        videoDeleteList.Add(videoname);
                        subtitleDeletList.Add(subtitlename);
                    }
                }
            }

            foreach (var item in videoDeleteList)
            {
                videoList.Remove(item);
            }
            foreach (var item in subtitleDeletList)
            {
                subtitleList.Remove(item);
            }

            VideoList.FileListView.DataSource = videoList;
            SubtitleList.FileListView.DataSource = subtitleList;
            VideoList.FileListView.AutoResizeColumns();
            SubtitleList.FileListView.AutoResizeColumns();

            foreach(DataGridViewRow row in VideoList.FileListView.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
            foreach (DataGridViewRow row in SubtitleList.FileListView.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void BtnRename_Click(object sender, EventArgs e)
        {
            int videoListCount = videoList.Count;
            int subtitleListCount = subtitleList.Count;
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
                    FileInformation video = videoList[i];
                    FileInformation subtitle = subtitleList[i];
                    string newfullname = filePath + "//" + video.파일명 + subtitle.확장자;
                    fileList.Add(new string[] { subtitle.경로, newfullname });
                    subtitle.파일명 = video.파일명;
                    subtitle.경로 = newfullname;
                }

                foreach (var item in fileList)
                {
                    FileInfo file = new FileInfo(item[0]);
                    file.MoveTo(item[1]);
                }

                SubtitleList.FileListView.Refresh();
                SubtitleList.FileListView.AutoResizeColumns();

                MessageBox.Show("파일명 변경이 완료되었습니다.");
            }
        }
    }
}
