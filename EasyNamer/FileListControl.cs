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
using EasyNamer.Properties;

namespace EasyNamer
{
    public partial class FileListControl : UserControl
    {
        private readonly ListViewItem emptyItem_ = new ListViewItem(new string[] { "", "", "", "" });
        public string ListName { get => label1.Text; set => label1.Text = value; }
        public FileType fileType;
        public SortOrder sorted { get => fileNameListView.Sorting; set => HeaderTextUpdate(value); }
        private string chFN;

        public void ApplyLanguage()
        {
            chFN = Language.TXT_FileName;
            columnHeaderExtension.Text = Language.TXT_Extension;
            columnHeaderDirectory.Text = Language.TXT_Path;
            HeaderTextUpdate(sorted);

        }

        public void HeaderTextUpdate(SortOrder value)
        {
            fileNameListView.Sorting = value;
            switch (sorted) {
                case SortOrder.None:
                    columnHeaderFileName.Text = chFN;
                    break;
                case SortOrder.Ascending:
                    columnHeaderFileName.Text = $"{chFN}∧";
                    break;
                case SortOrder.Descending:
                    columnHeaderFileName.Text = $"{chFN}∨";
                    break;
            }

        }

        public FileListControl()
        {
            InitializeComponent();
            chFN = "파일명";
            sorted = SortOrder.None;
        }
        
        private void BtbIndexChange_Click(object sender, EventArgs e)
        {
            if (fileNameListView.Items.Count == 0) return;

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
            sorted = SortOrder.None;

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

            ListViewItem tmp = fileNameListView.Items[SelectedRow];
            fileNameListView.Items.RemoveAt(SelectedRow);
            fileNameListView.Items.Insert(SelectedRow - 1, tmp);
            fileNameListView.Items[SelectedRow - 1].Focused = true;
            fileNameListView.Items[SelectedRow - 1].Selected = true;
        }

        private void BtnDown_Click()
        {
            int SelectedRow = fileNameListView.SelectedItems[0].Index;
            if (SelectedRow == fileNameListView.Items.Count - 1) return;

            ListViewItem tmp = fileNameListView.Items[SelectedRow];
            fileNameListView.Items.RemoveAt(SelectedRow);
            fileNameListView.Items.Insert(SelectedRow + 1, tmp);
            fileNameListView.Items[SelectedRow + 1].Focused = true;
            fileNameListView.Items[SelectedRow + 1].Selected = true;
        }

        private void BtnTop_Click()
        {
            int SelectedRow = fileNameListView.SelectedItems[0].Index;

            ListViewItem tmp = fileNameListView.Items[SelectedRow];
            fileNameListView.Items.RemoveAt(SelectedRow);
            fileNameListView.Items.Insert(0, tmp);
            fileNameListView.Items[0].Focused = true;
            fileNameListView.Items[0].Selected = true;
        }

        private void BtnBottom_Click()
        {
            int SelectedRow = fileNameListView.SelectedItems[0].Index;

            ListViewItem tmp = fileNameListView.Items[SelectedRow];
            fileNameListView.Items.RemoveAt(SelectedRow);
            fileNameListView.Items.Insert(fileNameListView.Items.Count, tmp);
            fileNameListView.Items[fileNameListView.Items.Count - 1].Focused = true;
            fileNameListView.Items[fileNameListView.Items.Count - 1].Selected = true;
        }

        private void BtnDelete_Click()
        {
            foreach (ListViewItem item in fileNameListView.SelectedItems)
                fileNameListView.Items.Remove(item);
        }

        public void FileNameLoad(DirectoryInfo directoryInfo)
        {
            fileNameListView.Items.Clear();

            foreach (var item in directoryInfo.GetFiles()) {
                openFile(item.FullName);
            }
            sorted = SortOrder.None;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = fileType.filter;
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            foreach (var item in openFileDialog1.FileNames) {
                openFile(item);
            }

            sorted = SortOrder.None;
        }

        private void openFile(string file)
        {
            string extension = Path.GetExtension(file).ToLower();
            string filename = Path.GetFileNameWithoutExtension(file);
            string fullname = file;

            ListViewItem newItem = new ListViewItem(new string[] { filename, extension, fullname });

            int equalCount = 0;
            foreach (ListViewItem tmp in fileNameListView.Items) {
                if (tmp.SubItems[2].Text == newItem.SubItems[2].Text)
                    equalCount++;
            }
            if (equalCount == 0)
                foreach (var tmp in fileType.ExtensionList) {
                    if (extension.Equals(tmp, StringComparison.OrdinalIgnoreCase)) {
                        fileNameListView.Items.Add(newItem);
                    }
                }
        }

        private void fileNameListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (sorted) {
                case SortOrder.Ascending: sorted = SortOrder.Descending; break;
                case SortOrder.Descending:
                case SortOrder.None: sorted = SortOrder.Ascending; break;
            }
        }

        private void fileNameListView_DoubleClick(object sender, EventArgs e)
        {
            var item = fileNameListView.SelectedItems[0];
            Process.Start(item.SubItems[2].Text);
        }

        private void fileNameListView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void fileNameListView_DragDrop(object sender, DragEventArgs e)
        {
            string[] itmes = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string item in itmes) {
                openFile(item);
            }

            sorted = SortOrder.None;
        }
    }
}
