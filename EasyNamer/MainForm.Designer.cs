using System.Drawing;

namespace EasyNamer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnFolderOpen = new System.Windows.Forms.Button();
            this.BtnRename = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbFilePath = new System.Windows.Forms.TextBox();
            this.BtnSetting = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.VideoList = new EasyNamer.FileListControl2();
            this.SubtitleList = new EasyNamer.FileListControl2();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Controls.Add(this.VideoList, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.SubtitleList, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 511);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Controls.Add(this.BtnFolderOpen, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnRename, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.TbFilePath, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnSetting, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 16);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(847, 40);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // BtnFolderOpen
            // 
            this.BtnFolderOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnFolderOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFolderOpen.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnFolderOpen.Location = new System.Drawing.Point(3, 2);
            this.BtnFolderOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnFolderOpen.Name = "BtnFolderOpen";
            this.tableLayoutPanel2.SetRowSpan(this.BtnFolderOpen, 2);
            this.BtnFolderOpen.Size = new System.Drawing.Size(74, 36);
            this.BtnFolderOpen.TabIndex = 2;
            this.BtnFolderOpen.TabStop = false;
            this.BtnFolderOpen.Text = "가져오기";
            this.BtnFolderOpen.UseVisualStyleBackColor = true;
            this.BtnFolderOpen.Click += new System.EventHandler(this.BtnFolderOpen_Click);
            // 
            // BtnRename
            // 
            this.BtnRename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRename.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRename.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnRename.Location = new System.Drawing.Point(83, 2);
            this.BtnRename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRename.Name = "BtnRename";
            this.tableLayoutPanel2.SetRowSpan(this.BtnRename, 2);
            this.BtnRename.Size = new System.Drawing.Size(74, 36);
            this.BtnRename.TabIndex = 5;
            this.BtnRename.TabStop = false;
            this.BtnRename.Text = "변경";
            this.BtnRename.UseVisualStyleBackColor = true;
            this.BtnRename.Click += new System.EventHandler(this.BtnRename_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(163, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "경로";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbFilePath
            // 
            this.TbFilePath.BackColor = System.Drawing.Color.White;
            this.TbFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbFilePath.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TbFilePath.Location = new System.Drawing.Point(213, 13);
            this.TbFilePath.Name = "TbFilePath";
            this.TbFilePath.Size = new System.Drawing.Size(591, 25);
            this.TbFilePath.TabIndex = 7;
            this.TbFilePath.TabStop = false;
            this.TbFilePath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbFilePath_KeyPress);
            // 
            // BtnSetting
            // 
            this.BtnSetting.BackgroundImage = global::EasyNamer.Properties.Resources.Setting;
            this.BtnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSetting.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSetting.Location = new System.Drawing.Point(808, 1);
            this.BtnSetting.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSetting.Name = "BtnSetting";
            this.tableLayoutPanel2.SetRowSpan(this.BtnSetting, 2);
            this.BtnSetting.Size = new System.Drawing.Size(38, 38);
            this.BtnSetting.TabIndex = 8;
            this.BtnSetting.TabStop = false;
            this.BtnSetting.UseVisualStyleBackColor = true;
            this.BtnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "D:\\비전팀\\상진\\새 폴더 (2)";
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // VideoList
            // 
            this.VideoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoList.Location = new System.Drawing.Point(18, 56);
            this.VideoList.Margin = new System.Windows.Forms.Padding(0);
            this.VideoList.Name = "VideoList";
            this.VideoList.Size = new System.Drawing.Size(419, 439);
            this.VideoList.sorted = EasyNamer.Sorted.none;
            this.VideoList.TabIndex = 3;
            this.VideoList.TabStop = false;
            // 
            // SubtitleList
            // 
            this.SubtitleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubtitleList.Location = new System.Drawing.Point(446, 56);
            this.SubtitleList.Margin = new System.Windows.Forms.Padding(0);
            this.SubtitleList.Name = "SubtitleList";
            this.SubtitleList.Size = new System.Drawing.Size(419, 439);
            this.SubtitleList.sorted = EasyNamer.Sorted.none;
            this.SubtitleList.TabIndex = 4;
            this.SubtitleList.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "EasyNamer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button BtnFolderOpen;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private FileListControl2 VideoList;
        private FileListControl2 SubtitleList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnRename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbFilePath;
        private System.Windows.Forms.Button BtnSetting;
    }
}

