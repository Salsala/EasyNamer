namespace EasyNamer
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GbOption = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RdbRecent = new System.Windows.Forms.RadioButton();
            this.RdbDefault = new System.Windows.Forms.RadioButton();
            this.TbDefaultPath = new System.Windows.Forms.TextBox();
            this.BtnFind = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LbVersion = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.LbLanguage = new System.Windows.Forms.Label();
            this.cb_Language = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.GbOption.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbOption
            // 
            this.GbOption.Controls.Add(this.tableLayoutPanel1);
            this.GbOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GbOption.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.GbOption.Location = new System.Drawing.Point(13, 13);
            this.GbOption.Name = "GbOption";
            this.GbOption.Size = new System.Drawing.Size(468, 193);
            this.GbOption.TabIndex = 0;
            this.GbOption.TabStop = false;
            this.GbOption.Text = "설정";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.RdbRecent, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RdbDefault, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TbDefaultPath, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnFind, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.LbVersion, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 165);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // RdbRecent
            // 
            this.RdbRecent.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.RdbRecent, 3);
            this.RdbRecent.Dock = System.Windows.Forms.DockStyle.Left;
            this.RdbRecent.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.RdbRecent.Location = new System.Drawing.Point(3, 3);
            this.RdbRecent.Name = "RdbRecent";
            this.RdbRecent.Size = new System.Drawing.Size(83, 19);
            this.RdbRecent.TabIndex = 0;
            this.RdbRecent.TabStop = true;
            this.RdbRecent.Text = "최근 폴더";
            this.RdbRecent.UseVisualStyleBackColor = true;
            this.RdbRecent.CheckedChanged += new System.EventHandler(this.RdbRecent_CheckedChanged);
            // 
            // RdbDefault
            // 
            this.RdbDefault.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.RdbDefault, 3);
            this.RdbDefault.Dock = System.Windows.Forms.DockStyle.Left;
            this.RdbDefault.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.RdbDefault.Location = new System.Drawing.Point(3, 28);
            this.RdbDefault.Name = "RdbDefault";
            this.RdbDefault.Size = new System.Drawing.Size(96, 19);
            this.RdbDefault.TabIndex = 1;
            this.RdbDefault.TabStop = true;
            this.RdbDefault.Text = "지정된 폴더";
            this.RdbDefault.UseVisualStyleBackColor = true;
            this.RdbDefault.CheckedChanged += new System.EventHandler(this.RdbDefault_CheckedChanged);
            // 
            // TbDefaultPath
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TbDefaultPath, 2);
            this.TbDefaultPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbDefaultPath.Font = new System.Drawing.Font("맑은 고딕", 9.75F);
            this.TbDefaultPath.Location = new System.Drawing.Point(18, 53);
            this.TbDefaultPath.Name = "TbDefaultPath";
            this.TbDefaultPath.Size = new System.Drawing.Size(361, 25);
            this.TbDefaultPath.TabIndex = 2;
            // 
            // BtnFind
            // 
            this.BtnFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFind.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnFind.Location = new System.Drawing.Point(385, 53);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(74, 24);
            this.BtnFind.TabIndex = 3;
            this.BtnFind.Text = "찾아보기";
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnPath_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.BtnOK, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnCancel, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(287, 135);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(175, 30);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // BtnOK
            // 
            this.BtnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOK.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnOK.Location = new System.Drawing.Point(3, 3);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(81, 24);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.Text = "확인";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCancel.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.BtnCancel.Location = new System.Drawing.Point(90, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(82, 24);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "취소";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LbVersion
            // 
            this.LbVersion.AutoSize = true;
            this.LbVersion.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.LbVersion, 2);
            this.LbVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LbVersion.Font = new System.Drawing.Font("맑은 고딕", 8.25F);
            this.LbVersion.Location = new System.Drawing.Point(3, 152);
            this.LbVersion.Name = "LbVersion";
            this.LbVersion.Size = new System.Drawing.Size(209, 13);
            this.LbVersion.TabIndex = 5;
            this.LbVersion.Text = "label1";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel4, 4);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 255F));
            this.tableLayoutPanel4.Controls.Add(this.LbLanguage, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cb_Language, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 85);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(462, 30);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // LbLanguage
            // 
            this.LbLanguage.AutoSize = true;
            this.LbLanguage.Dock = System.Windows.Forms.DockStyle.Left;
            this.LbLanguage.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.LbLanguage.Location = new System.Drawing.Point(3, 0);
            this.LbLanguage.Name = "LbLanguage";
            this.LbLanguage.Size = new System.Drawing.Size(34, 30);
            this.LbLanguage.TabIndex = 0;
            this.LbLanguage.Text = "언어";
            this.LbLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_Language
            // 
            this.cb_Language.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Language.Font = new System.Drawing.Font("맑은 고딕", 9.75F);
            this.cb_Language.FormattingEnabled = true;
            this.cb_Language.Items.AddRange(new object[] {
            "Auto",
            "English",
            "日本語",
            "한국어"});
            this.cb_Language.Location = new System.Drawing.Point(43, 3);
            this.cb_Language.Name = "cb_Language";
            this.cb_Language.Size = new System.Drawing.Size(161, 25);
            this.cb_Language.Sorted = true;
            this.cb_Language.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Controls.Add(this.GbOption, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(494, 219);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(494, 219);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 230);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 225);
            this.Name = "SettingForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.GbOption.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbOption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton RdbRecent;
        private System.Windows.Forms.RadioButton RdbDefault;
        private System.Windows.Forms.TextBox TbDefaultPath;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label LbVersion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label LbLanguage;
        private System.Windows.Forms.ComboBox cb_Language;
    }
}