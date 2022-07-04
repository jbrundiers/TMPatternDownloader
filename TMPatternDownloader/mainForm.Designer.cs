namespace TMDownLoader
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.buttonListboxAdd = new System.Windows.Forms.Button();
            this.textBoxDownloadBasePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxURLBase = new System.Windows.Forms.TextBox();
            this.textBoxRelFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxRelFiles = new System.Windows.Forms.ListBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.progressBarDownload = new System.Windows.Forms.ProgressBar();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(607, 41);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 10;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // buttonListboxAdd
            // 
            this.buttonListboxAdd.Location = new System.Drawing.Point(607, 108);
            this.buttonListboxAdd.Name = "buttonListboxAdd";
            this.buttonListboxAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonListboxAdd.TabIndex = 11;
            this.buttonListboxAdd.Text = "Add";
            this.buttonListboxAdd.UseVisualStyleBackColor = true;
            this.buttonListboxAdd.Click += new System.EventHandler(this.buttonListboxAdd_Click);
            // 
            // textBoxDownloadBasePath
            // 
            this.textBoxDownloadBasePath.Location = new System.Drawing.Point(128, 42);
            this.textBoxDownloadBasePath.Name = "textBoxDownloadBasePath";
            this.textBoxDownloadBasePath.Size = new System.Drawing.Size(460, 20);
            this.textBoxDownloadBasePath.TabIndex = 12;
            this.textBoxDownloadBasePath.Text = "C:\\Temp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Download Base Path:";
            // 
            // textBoxURLBase
            // 
            this.textBoxURLBase.Location = new System.Drawing.Point(128, 68);
            this.textBoxURLBase.Name = "textBoxURLBase";
            this.textBoxURLBase.Size = new System.Drawing.Size(460, 20);
            this.textBoxURLBase.TabIndex = 14;
            this.textBoxURLBase.Text = "http://osce14-p.activeupdate.trendmicro.com/activeupdate/";
            // 
            // textBoxRelFilePath
            // 
            this.textBoxRelFilePath.Location = new System.Drawing.Point(128, 108);
            this.textBoxRelFilePath.Name = "textBoxRelFilePath";
            this.textBoxRelFilePath.Size = new System.Drawing.Size(460, 20);
            this.textBoxRelFilePath.TabIndex = 15;
            this.textBoxRelFilePath.Text = "server.ini";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "URL BAse:";
            // 
            // listBoxRelFiles
            // 
            this.listBoxRelFiles.FormattingEnabled = true;
            this.listBoxRelFiles.Location = new System.Drawing.Point(128, 137);
            this.listBoxRelFiles.Name = "listBoxRelFiles";
            this.listBoxRelFiles.Size = new System.Drawing.Size(554, 277);
            this.listBoxRelFiles.TabIndex = 17;
            this.listBoxRelFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxRelFiles_MouseDown);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(607, 436);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(75, 23);
            this.buttonDownload.TabIndex = 18;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // progressBarDownload
            // 
            this.progressBarDownload.Location = new System.Drawing.Point(128, 436);
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(460, 23);
            this.progressBarDownload.TabIndex = 19;
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "Options ...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 484);
            this.Controls.Add(this.progressBarDownload);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.listBoxRelFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRelFilePath);
            this.Controls.Add(this.textBoxURLBase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDownloadBasePath);
            this.Controls.Add(this.buttonListboxAdd);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TM Pattern downloader";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonListboxAdd;
        private System.Windows.Forms.TextBox textBoxDownloadBasePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxURLBase;
        private System.Windows.Forms.TextBox textBoxRelFilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxRelFiles;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolTip toolTips;
        private System.Windows.Forms.ProgressBar progressBarDownload;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    }
}

