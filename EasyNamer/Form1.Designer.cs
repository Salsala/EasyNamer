namespace EasyNamer
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnFolderOpen = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.VideoList = new EasyNamer.FileListControl();
            this.SubtitleList = new EasyNamer.FileListControl();
            this.BtnRename = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.VideoList, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.SubtitleList, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(930, 699);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BtnFolderOpen
            // 
            this.BtnFolderOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnFolderOpen.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnFolderOpen.Location = new System.Drawing.Point(3, 3);
            this.BtnFolderOpen.Name = "BtnFolderOpen";
            this.BtnFolderOpen.Size = new System.Drawing.Size(94, 44);
            this.BtnFolderOpen.TabIndex = 2;
            this.BtnFolderOpen.TabStop = false;
            this.BtnFolderOpen.Text = "가져오기";
            this.BtnFolderOpen.UseVisualStyleBackColor = true;
            this.BtnFolderOpen.Click += new System.EventHandler(this.BtnFolderOpen_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "E:\\애니";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // VideoList
            // 
            this.VideoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoList.Location = new System.Drawing.Point(20, 70);
            this.VideoList.Margin = new System.Windows.Forms.Padding(0);
            this.VideoList.Name = "VideoList";
            this.VideoList.Size = new System.Drawing.Size(440, 609);
            this.VideoList.TabIndex = 3;
            this.VideoList.TabStop = false;
            // 
            // SubtitleList
            // 
            this.SubtitleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubtitleList.Location = new System.Drawing.Point(470, 70);
            this.SubtitleList.Margin = new System.Windows.Forms.Padding(0);
            this.SubtitleList.Name = "SubtitleList";
            this.SubtitleList.Size = new System.Drawing.Size(440, 609);
            this.SubtitleList.TabIndex = 4;
            this.SubtitleList.TabStop = false;
            // 
            // BtnRename
            // 
            this.BtnRename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRename.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnRename.Location = new System.Drawing.Point(103, 3);
            this.BtnRename.Name = "BtnRename";
            this.BtnRename.Size = new System.Drawing.Size(94, 44);
            this.BtnRename.TabIndex = 5;
            this.BtnRename.TabStop = false;
            this.BtnRename.Text = "변경";
            this.BtnRename.UseVisualStyleBackColor = true;
            this.BtnRename.Click += new System.EventHandler(this.BtnRename_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BtnFolderOpen, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnRename, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 20);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 50);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 699);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "EasyNamer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnFolderOpen;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private FileListControl VideoList;
        private FileListControl SubtitleList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnRename;
    }
}

