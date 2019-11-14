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
    public enum Sorted
    {
        none,
        Ascending,
        Descending
    }

    public partial class FileListControl : UserControl
    {
        public BindingList<FileInformation> FileList = new BindingList<FileInformation>();

        public string ListName { set => label1.Text = value; }
        public FileType fileType;
        public Sorted sorted_;
        public Sorted sorted { get => sorted_; set =>   HeaderTextUpdate(value);  }

        public void HeaderTextUpdate(Sorted value)
        {
            sorted_ = value;
            switch (sorted)
            {
                case Sorted.none:
                    fileNameDataGridViewTextBoxColumn.HeaderText = "파일명";
                    break;
                case Sorted.Ascending:
                    fileNameDataGridViewTextBoxColumn.HeaderText = "파일명▲";
                    break;
                case Sorted.Descending:
                    fileNameDataGridViewTextBoxColumn.HeaderText = "파일명▼";
                    break;
            }
        }

        public FileListControl()
        {
            InitializeComponent();
            FileListView.DataSource = FileList;
            sorted = Sorted.none;
        }

        private void FileListView_DataSourceChanged(object sender, EventArgs e)
        {
            ListRefresh();
        }

        public void ListRefresh()
        {
            FileListView.Refresh();
            FileListView.AutoResizeColumns();
            foreach (DataGridViewRow row in FileListView.Rows)
            {
                row.HeaderCell.Value = String.Format("{0}", row.Index + 1);
            }
        }

        private void BtbIndexChange_Click(object sender, EventArgs e)
        {
            if (FileList.Count == 0) return;

            var obj = (Button)sender;
            switch (obj.Name)
            {
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

            sorted = Sorted.none;
            ListRefresh();
            
            bool SelectedRowsCount()
            {
                if (FileListView.SelectedRows.Count == 1) return true;
                return false;
            }
        }

        private void BtnUp_Click()
        {
            int SelectedRow = FileListView.CurrentCell.RowIndex;
            if (SelectedRow == 0) return;

            FileInformation tmp = FileList[SelectedRow];
            FileList.RemoveAt(SelectedRow);
            FileList.Insert(SelectedRow - 1, tmp);
            FileListView.CurrentCell = FileListView.Rows[SelectedRow - 1].Cells[0];
        }

        private void BtnDown_Click()
        {
            int SelectedRow = FileListView.CurrentCell.RowIndex;
            if (SelectedRow == FileList.Count - 1) return;

            FileInformation tmp = FileList[SelectedRow];
            FileList.RemoveAt(SelectedRow);
            FileList.Insert(SelectedRow + 1, tmp);
            FileListView.CurrentCell = FileListView.Rows[SelectedRow + 1].Cells[0];
        }

        private void BtnTop_Click()
        {
            int SelectedRow = FileListView.CurrentCell.RowIndex;

            FileInformation tmp = FileList[SelectedRow];
            FileList.RemoveAt(SelectedRow);
            FileList.Insert(0, tmp);
            FileListView.CurrentCell = FileListView.Rows[0].Cells[0];
        }

        private void BtnBottom_Click()
        {
            int SelectedRow = FileListView.CurrentCell.RowIndex;

            FileInformation tmp = FileList[SelectedRow];
            FileList.RemoveAt(SelectedRow);
            FileList.Insert(FileList.Count, tmp);
            FileListView.CurrentCell = FileListView.Rows[FileList.Count - 1].Cells[0];
        }

        private void BtnDelete_Click()
        {            
            foreach(DataGridViewRow item in FileListView.SelectedRows)
            {
                FileList.RemoveAt(item.Index);
            }
            FileListView.ClearSelection();
        }

        public void FileNameLoad(DirectoryInfo directoryInfo)
        {
            FileList.Clear();

            foreach (var item in directoryInfo.GetFiles())
            {
                string extension = item.Extension;
                string filename = Path.GetFileNameWithoutExtension(item.FullName);
                string fullname = item.FullName;

                foreach (var tmp in fileType.ExtensionList)
                {
                    if (extension.Equals(tmp, StringComparison.OrdinalIgnoreCase))
                    {
                        FileList.Add(new FileInformation(filename, extension.ToLower(), fullname));
                    }
                }
            }
            sorted = Sorted.none;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = fileType.filter;
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            foreach (var item in openFileDialog1.FileNames)
            {
                string extension = Path.GetExtension(item);
                string filename = Path.GetFileNameWithoutExtension(item);
                string fullname = item;

                FileInformation file = new FileInformation(filename, extension.ToLower(), fullname);

                int equalCount = 0;
                foreach (var tmp in FileList)
                {
                    if (tmp.Directory == file.Directory)
                        equalCount++;
                }
                if (equalCount == 0) FileList.Add(file);
            }

            FileListView.CurrentCell = FileListView.Rows[FileList.Count - 1].Cells[0];
            sorted = Sorted.none;
            ListRefresh();
        }

        private void FileListView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            switch (fileType.fileType)
            {
                case FileTypes.Video:
                    Process.Start("PotPlayer.exe", FileList[index].Directory);
                    break;
                case FileTypes.Subtitle:
                    Process.Start("notepad.exe", FileList[index].Directory);
                    break;
            }
        }

        private void FileListView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != 0) return;
            List<FileInformation> tmpList = new List<FileInformation>();

            foreach (var item in FileList)
            {
                tmpList.Add(item);
            }

            tmpList.Sort((FileInformation x, FileInformation y) => x.FileName.CompareTo(y.FileName));
            switch (sorted)
            {
                case Sorted.Ascending: tmpList.Reverse(); sorted = Sorted.Descending; break;
                case Sorted.Descending:
                case Sorted.none: sorted = Sorted.Ascending; break;
            }

            FileList.Clear();

            foreach (var item in tmpList)
            {
                FileList.Add(item);
            }

            ListRefresh();
        }
    }
}
