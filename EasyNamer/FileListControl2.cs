using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace EasyNamer
{
    public partial class FileListControl2 : UserControl
    {
        public List<FileInformation> FileList = new List<FileInformation>();

        private readonly ListViewItem emptyItem_ = new ListViewItem(new string[] { "", "", "", "" });
        public string ListName { set => label1.Text = value; }
        public FileType fileType;
        public Sorted sorted_;
        public Sorted sorted { get => sorted_; set => HeaderTextUpdate(value); }

        public void HeaderTextUpdate(Sorted value)
        {
            sorted_ = value;
            switch (sorted) {
                case Sorted.none:
                    columnHeaderFileName.Text = "파일명";
                    break;
                case Sorted.Ascending:
                    columnHeaderFileName.Text = "파일명∧";
                    break;
                case Sorted.Descending:
                    columnHeaderFileName.Text = "파일명∨";
                    break;
            }

        }

        public FileListControl2()
        {
            InitializeComponent();
            sorted = Sorted.none;
        }
        
        public void ListRefresh()
        {
            fileNameListView.Items.Clear();

            foreach (var item in FileList) {
                fileNameListView.Items.Add(new ListViewItem(new string[] { item.FileName, item.Extension, item.Directory }));
            }
        }

        private void BtbIndexChange_Click(object sender, EventArgs e)
        {
            if (FileList.Count == 0) return;

            var obj = (Button)sender;
            switch (obj.Name) {
                case "BtnTop":
                    if (!SelectedRowsCount()) return;
                    BtnTop_Click();
                    break;
                case "BtnUp":
                    if (!SelectedRowsCount()) return;
                    BtnUp_Click();
                    break;
                case "BtnDown":
                    if (!SelectedRowsCount()) return;
                    BtnDown_Click();
                    break;
                case "BtnBottom":
                    if (!SelectedRowsCount()) return;
                    BtnBottom_Click();
                    break;
                case "BtnDelete": BtnDelete_Click(); break;
            }

            fileNameListView.Focus();
            sorted = Sorted.none;

            bool SelectedRowsCount()
            {
                if (fileNameListView.SelectedItems.Count == 1) return true;
                return false;
            }
        }

        private void BtnUp_Click()
        {
            int SelectedRow = fileNameListView.SelectedItems[0].Index;
            if (SelectedRow == 0) return;

            FileInformation tmp = FileList[SelectedRow];
            FileList.RemoveAt(SelectedRow);
            FileList.Insert(SelectedRow - 1, tmp);
            ListRefresh();
            fileNameListView.Items[SelectedRow - 1].Focused = true;
            fileNameListView.Items[SelectedRow - 1].Selected = true;
        }

        private void BtnDown_Click()
        {
            int SelectedRow = fileNameListView.SelectedItems[0].Index;
            if (SelectedRow == FileList.Count - 1) return;

            FileInformation tmp = FileList[SelectedRow];
            FileList.RemoveAt(SelectedRow);
            FileList.Insert(SelectedRow + 1, tmp);
            ListRefresh();
            fileNameListView.Items[SelectedRow + 1].Focused = true;
            fileNameListView.Items[SelectedRow + 1].Selected = true;
        }

        private void BtnTop_Click()
        {
            int SelectedRow = fileNameListView.SelectedItems[0].Index;

            FileInformation tmp = FileList[SelectedRow];
            FileList.RemoveAt(SelectedRow);
            FileList.Insert(0, tmp);
            ListRefresh();
            fileNameListView.Items[0].Focused = true;
            fileNameListView.Items[0].Selected = true;
        }

        private void BtnBottom_Click()
        {
            int SelectedRow = fileNameListView.SelectedItems[0].Index;

            FileInformation tmp = FileList[SelectedRow];
            FileList.RemoveAt(SelectedRow);
            FileList.Insert(FileList.Count, tmp);
            ListRefresh();
            fileNameListView.Items[FileList.Count - 1].Focused = true;
            fileNameListView.Items[FileList.Count - 1].Selected = true;
        }

        private void BtnDelete_Click()
        {

            List<int> indexes = new List<int>();
            foreach (ListViewItem item in fileNameListView.SelectedItems) {
                indexes.Add(item.Index);
                indexes.Reverse();
            }

            foreach (int index in indexes) {
                FileList.RemoveAt(index);
            }

            ListRefresh();
        }

        public void FileNameLoad(DirectoryInfo directoryInfo)
        {
            FileList.Clear();

            foreach (var item in directoryInfo.GetFiles()) {
                string extension = item.Extension;
                string filename = Path.GetFileNameWithoutExtension(item.FullName);
                string fullname = item.FullName;

                foreach (var tmp in fileType.ExtensionList) {
                    if (extension.Equals(tmp, StringComparison.OrdinalIgnoreCase)) {
                        FileList.Add(new FileInformation(filename, extension.ToLower(), fullname));
                    }
                }
            }

            sorted = Sorted.none;
            ListRefresh();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = fileType.filter;
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            foreach (var item in openFileDialog1.FileNames) {
                string extension = Path.GetExtension(item);
                string filename = Path.GetFileNameWithoutExtension(item);
                string fullname = item;

                FileInformation file = new FileInformation(filename, extension.ToLower(), fullname);

                int equalCount = 0;
                foreach (var tmp in FileList) {
                    if (tmp.Directory == file.Directory)
                        equalCount++;
                }
                if (equalCount == 0) FileList.Add(file);
            }

            sorted = Sorted.none;

            ListRefresh();
        }

        private void fileNameListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            List<FileInformation> tmpList = new List<FileInformation>();

            foreach (var item in FileList) {
                tmpList.Add(item);
            }

            tmpList.Sort((FileInformation x, FileInformation y) => x.FileName.CompareTo(y.FileName));
            switch (sorted) {
                case Sorted.Ascending: tmpList.Reverse(); sorted = Sorted.Descending; break;
                case Sorted.Descending:
                case Sorted.none: sorted = Sorted.Ascending; break;
            }

            FileList.Clear();
            fileNameListView.Items.Clear();

            foreach (var item in tmpList) FileList.Add(item);

            ListRefresh();
        }

        public void RemoveItem(FileInformation item)
        {
            FileList.Remove(item);
        }

        private void fileNameListView_DoubleClick(object sender, EventArgs e)
        {
            int index = fileNameListView.SelectedItems[0].Index;
            switch (fileType.fileType) {
                case FileTypes.Video:
                    Process.Start("PotPlayer.exe", FileList[index].Directory);
                    break;
                case FileTypes.Subtitle:
                    Process.Start("notepad.exe", FileList[index].Directory);
                    break;
            }
        }

        private void fileNameListView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void fileNameListView_DragDrop(object sender, DragEventArgs e)
        {
            string[] itmes = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string item in itmes) {
                string extension = Path.GetExtension(item);
                if (!fileType.ExtensionList.Contains(extension)) continue;

                string filename = Path.GetFileNameWithoutExtension(item);
                string fullname = item;
                FileInformation file = new FileInformation(filename, extension.ToLower(), fullname);
                int equalCount = 0;
                foreach (var tmp in FileList) {
                    if (tmp.Directory == file.Directory)
                        equalCount++;
                }
                if (equalCount == 0) FileList.Add(file);
            }
            
            sorted = Sorted.none;
            ListRefresh();

        }
    }
}
