namespace EasyNamer
{
    partial class FileListControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.FileListView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUp = new System.Windows.Forms.Button();
            this.BtnDown = new System.Windows.Forms.Button();
            this.BtnTop = new System.Windows.Forms.Button();
            this.BtnBottom = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileListView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FileListView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(715, 459);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // FileListView
            // 
            this.FileListView.AllowUserToAddRows = false;
            this.FileListView.AllowUserToResizeRows = false;
            this.FileListView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FileListView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FileListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fileNameDataGridViewTextBoxColumn,
            this.extensionDataGridViewTextBoxColumn,
            this.directoryDataGridViewTextBoxColumn});
            this.FileListView.DataSource = this.fileInformationBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FileListView.DefaultCellStyle = dataGridViewCellStyle2;
            this.FileListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileListView.Location = new System.Drawing.Point(3, 26);
            this.FileListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FileListView.Name = "FileListView";
            this.FileListView.ReadOnly = true;
            this.FileListView.RowHeadersWidth = 51;
            this.FileListView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.FileListView.RowTemplate.Height = 27;
            this.FileListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FileListView.Size = new System.Drawing.Size(709, 396);
            this.FileListView.TabIndex = 1;
            this.FileListView.TabStop = false;
            this.FileListView.VirtualMode = true;
            this.FileListView.DataSourceChanged += new System.EventHandler(this.FileListView_DataSourceChanged);
            this.FileListView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FileListView_CellDoubleClick);
            this.FileListView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FileListView_ColumnHeaderMouseClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Controls.Add(this.BtnAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnDelete, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnUp, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnDown, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnTop, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnBottom, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(505, 424);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(210, 35);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackgroundImage = global::EasyNamer.Properties.Resources.Add;
            this.BtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAdd.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnAdd.Location = new System.Drawing.Point(1, 1);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(1);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(33, 33);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackgroundImage = global::EasyNamer.Properties.Resources.Delete;
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDelete.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnDelete.Location = new System.Drawing.Point(36, 1);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(33, 33);
            this.BtnDelete.TabIndex = 1;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtbIndexChange_Click);
            // 
            // BtnUp
            // 
            this.BtnUp.BackgroundImage = global::EasyNamer.Properties.Resources.Up;
            this.BtnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUp.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnUp.Location = new System.Drawing.Point(106, 1);
            this.BtnUp.Margin = new System.Windows.Forms.Padding(1);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Padding = new System.Windows.Forms.Padding(5);
            this.BtnUp.Size = new System.Drawing.Size(33, 33);
            this.BtnUp.TabIndex = 2;
            this.BtnUp.UseVisualStyleBackColor = true;
            this.BtnUp.Click += new System.EventHandler(this.BtbIndexChange_Click);
            // 
            // BtnDown
            // 
            this.BtnDown.BackgroundImage = global::EasyNamer.Properties.Resources.Down;
            this.BtnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDown.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnDown.Location = new System.Drawing.Point(141, 1);
            this.BtnDown.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.Padding = new System.Windows.Forms.Padding(5);
            this.BtnDown.Size = new System.Drawing.Size(33, 33);
            this.BtnDown.TabIndex = 3;
            this.BtnDown.UseVisualStyleBackColor = true;
            this.BtnDown.Click += new System.EventHandler(this.BtbIndexChange_Click);
            // 
            // BtnTop
            // 
            this.BtnTop.BackgroundImage = global::EasyNamer.Properties.Resources.Top;
            this.BtnTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnTop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTop.Location = new System.Drawing.Point(71, 1);
            this.BtnTop.Margin = new System.Windows.Forms.Padding(1);
            this.BtnTop.Name = "BtnTop";
            this.BtnTop.Size = new System.Drawing.Size(33, 33);
            this.BtnTop.TabIndex = 4;
            this.BtnTop.UseVisualStyleBackColor = true;
            this.BtnTop.Click += new System.EventHandler(this.BtbIndexChange_Click);
            // 
            // BtnBottom
            // 
            this.BtnBottom.BackgroundImage = global::EasyNamer.Properties.Resources.Bottom;
            this.BtnBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBottom.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBottom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBottom.Location = new System.Drawing.Point(176, 1);
            this.BtnBottom.Margin = new System.Windows.Forms.Padding(1);
            this.BtnBottom.Name = "BtnBottom";
            this.BtnBottom.Padding = new System.Windows.Forms.Padding(5);
            this.BtnBottom.Size = new System.Drawing.Size(33, 33);
            this.BtnBottom.TabIndex = 5;
            this.BtnBottom.UseVisualStyleBackColor = true;
            this.BtnBottom.Click += new System.EventHandler(this.BtbIndexChange_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "파일명";
            this.fileNameDataGridViewTextBoxColumn.MinimumWidth = 300;
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // extensionDataGridViewTextBoxColumn
            // 
            this.extensionDataGridViewTextBoxColumn.DataPropertyName = "Extension";
            this.extensionDataGridViewTextBoxColumn.HeaderText = "확장자";
            this.extensionDataGridViewTextBoxColumn.MinimumWidth = 80;
            this.extensionDataGridViewTextBoxColumn.Name = "extensionDataGridViewTextBoxColumn";
            this.extensionDataGridViewTextBoxColumn.ReadOnly = true;
            this.extensionDataGridViewTextBoxColumn.Width = 80;
            // 
            // directoryDataGridViewTextBoxColumn
            // 
            this.directoryDataGridViewTextBoxColumn.DataPropertyName = "Directory";
            this.directoryDataGridViewTextBoxColumn.HeaderText = "경로";
            this.directoryDataGridViewTextBoxColumn.MinimumWidth = 300;
            this.directoryDataGridViewTextBoxColumn.Name = "directoryDataGridViewTextBoxColumn";
            this.directoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.directoryDataGridViewTextBoxColumn.Width = 300;
            // 
            // fileInformationBindingSource
            // 
            this.fileInformationBindingSource.DataSource = typeof(EasyNamer.FileInformation);
            // 
            // FileListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FileListControl";
            this.Size = new System.Drawing.Size(715, 459);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FileListView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileInformationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView FileListView;
        private System.Windows.Forms.BindingSource fileInformationBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUp;
        private System.Windows.Forms.Button BtnDown;
        private System.Windows.Forms.Button BtnTop;
        private System.Windows.Forms.Button BtnBottom;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directoryDataGridViewTextBoxColumn;
    }
}
