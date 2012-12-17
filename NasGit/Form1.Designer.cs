using System.Diagnostics;
namespace NasGit {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (DropWindowThread != null) {
                try
                {
                    DropWindowThread.Abort();
                }
                catch (System.Threading.ThreadAbortException ex)
                {
                   Debug.WriteLine( ex.Message);
                   throw;
                }
                    
            }
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddRepository = new System.Windows.Forms.ToolStripButton();
            this.tsbCloneRepository = new System.Windows.Forms.ToolStripButton();
            this.tsbSettings = new System.Windows.Forms.ToolStripButton();
            this.fswCheckFilechanges = new System.IO.FileSystemWatcher();
            this.fbdAddRepository = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlRepositories = new System.Windows.Forms.Panel();
            this.rtbDiff = new System.Windows.Forms.RichTextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblChangeset = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvModifiedFiles = new System.Windows.Forms.ListView();
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hash = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCommits = new System.Windows.Forms.ListView();
            this.Revision = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Message = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tcRepositories = new System.Windows.Forms.TabControl();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlAddRepo = new System.Windows.Forms.Panel();
            this.txtLocalPath = new System.Windows.Forms.TextBox();
            this.lblLocalPath = new System.Windows.Forms.Label();
            this.btnCancelAddRepo = new System.Windows.Forms.Button();
            this.btnAddRepository = new System.Windows.Forms.Button();
            this.txtRepoPath = new System.Windows.Forms.TextBox();
            this.lblRepoPath = new System.Windows.Forms.Label();
            this.txtRepoName = new System.Windows.Forms.TextBox();
            this.tsbBranching = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fswCheckFilechanges)).BeginInit();
            this.pnlRepositories.SuspendLayout();
            this.pnlAddRepo.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddRepository,
            this.tsbCloneRepository,
            this.tsbBranching,
            this.tsbSettings});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(16, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(769, 51);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddRepository
            // 
            this.tsbAddRepository.AutoSize = false;
            this.tsbAddRepository.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddRepository.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddRepository.Image")));
            this.tsbAddRepository.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAddRepository.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddRepository.Name = "tsbAddRepository";
            this.tsbAddRepository.Size = new System.Drawing.Size(38, 38);
            this.tsbAddRepository.ToolTipText = "Create repository";
            this.tsbAddRepository.Click += new System.EventHandler(this.tsbAddRepository_Click);
            // 
            // tsbCloneRepository
            // 
            this.tsbCloneRepository.AutoSize = false;
            this.tsbCloneRepository.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCloneRepository.Image = ((System.Drawing.Image)(resources.GetObject("tsbCloneRepository.Image")));
            this.tsbCloneRepository.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCloneRepository.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCloneRepository.Name = "tsbCloneRepository";
            this.tsbCloneRepository.Size = new System.Drawing.Size(38, 38);
            this.tsbCloneRepository.ToolTipText = "Clone repository";
            this.tsbCloneRepository.Click += new System.EventHandler(this.tsbCloneRepository_Click);
            // 
            // tsbSettings
            // 
            this.tsbSettings.AutoSize = false;
            this.tsbSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSettings.Image = ((System.Drawing.Image)(resources.GetObject("tsbSettings.Image")));
            this.tsbSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSettings.Name = "tsbSettings";
            this.tsbSettings.Size = new System.Drawing.Size(38, 38);
            this.tsbSettings.Text = "toolStripButton1";
            this.tsbSettings.ToolTipText = "Settings";
            // 
            // fswCheckFilechanges
            // 
            this.fswCheckFilechanges.EnableRaisingEvents = true;
            this.fswCheckFilechanges.SynchronizingObject = this;
            // 
            // fbdAddRepository
            // 
            this.fbdAddRepository.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // pnlRepositories
            // 
            this.pnlRepositories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRepositories.Controls.Add(this.rtbDiff);
            this.pnlRepositories.Controls.Add(this.lblUser);
            this.pnlRepositories.Controls.Add(this.lblBranch);
            this.pnlRepositories.Controls.Add(this.lblChangeset);
            this.pnlRepositories.Controls.Add(this.label3);
            this.pnlRepositories.Controls.Add(this.label2);
            this.pnlRepositories.Controls.Add(this.label1);
            this.pnlRepositories.Controls.Add(this.lvModifiedFiles);
            this.pnlRepositories.Controls.Add(this.lvCommits);
            this.pnlRepositories.Controls.Add(this.tcRepositories);
            this.pnlRepositories.Location = new System.Drawing.Point(12, 55);
            this.pnlRepositories.Name = "pnlRepositories";
            this.pnlRepositories.Size = new System.Drawing.Size(773, 550);
            this.pnlRepositories.TabIndex = 13;
            // 
            // rtbDiff
            // 
            this.rtbDiff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDiff.Location = new System.Drawing.Point(325, 229);
            this.rtbDiff.Name = "rtbDiff";
            this.rtbDiff.Size = new System.Drawing.Size(443, 314);
            this.rtbDiff.TabIndex = 20;
            this.rtbDiff.Text = "";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(391, 213);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(10, 13);
            this.lblUser.TabIndex = 19;
            this.lblUser.Text = ".";
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(391, 196);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(10, 13);
            this.lblBranch.TabIndex = 18;
            this.lblBranch.Text = ".";
            // 
            // lblChangeset
            // 
            this.lblChangeset.AutoSize = true;
            this.lblChangeset.Location = new System.Drawing.Point(389, 179);
            this.lblChangeset.Name = "lblChangeset";
            this.lblChangeset.Size = new System.Drawing.Size(10, 13);
            this.lblChangeset.TabIndex = 17;
            this.lblChangeset.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Branch:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Changeset:";
            // 
            // lvModifiedFiles
            // 
            this.lvModifiedFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName,
            this.hash});
            this.lvModifiedFiles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvModifiedFiles.Location = new System.Drawing.Point(3, 179);
            this.lvModifiedFiles.Name = "lvModifiedFiles";
            this.lvModifiedFiles.Size = new System.Drawing.Size(300, 364);
            this.lvModifiedFiles.TabIndex = 13;
            this.lvModifiedFiles.UseCompatibleStateImageBehavior = false;
            this.lvModifiedFiles.View = System.Windows.Forms.View.Details;
            // 
            // fileName
            // 
            this.fileName.Text = "name";
            this.fileName.Width = 291;
            // 
            // hash
            // 
            this.hash.Text = "hash";
            this.hash.Width = 1;
            // 
            // lvCommits
            // 
            this.lvCommits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCommits.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Revision,
            this.Message,
            this.Author,
            this.Age});
            this.lvCommits.FullRowSelect = true;
            this.lvCommits.GridLines = true;
            this.lvCommits.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCommits.Location = new System.Drawing.Point(3, 35);
            this.lvCommits.MultiSelect = false;
            this.lvCommits.Name = "lvCommits";
            this.lvCommits.Size = new System.Drawing.Size(765, 138);
            this.lvCommits.TabIndex = 12;
            this.lvCommits.UseCompatibleStateImageBehavior = false;
            this.lvCommits.View = System.Windows.Forms.View.Details;
            // 
            // Revision
            // 
            this.Revision.Text = "Revision";
            this.Revision.Width = 80;
            // 
            // Message
            // 
            this.Message.Text = "Message";
            this.Message.Width = 440;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 100;
            // 
            // Age
            // 
            this.Age.Text = "Age";
            this.Age.Width = 80;
            // 
            // tcRepositories
            // 
            this.tcRepositories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcRepositories.Location = new System.Drawing.Point(3, 7);
            this.tcRepositories.Name = "tcRepositories";
            this.tcRepositories.SelectedIndex = 0;
            this.tcRepositories.Size = new System.Drawing.Size(766, 22);
            this.tcRepositories.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Name:";
            // 
            // pnlAddRepo
            // 
            this.pnlAddRepo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddRepo.Controls.Add(this.txtLocalPath);
            this.pnlAddRepo.Controls.Add(this.lblLocalPath);
            this.pnlAddRepo.Controls.Add(this.btnCancelAddRepo);
            this.pnlAddRepo.Controls.Add(this.btnAddRepository);
            this.pnlAddRepo.Controls.Add(this.txtRepoPath);
            this.pnlAddRepo.Controls.Add(this.lblRepoPath);
            this.pnlAddRepo.Controls.Add(this.txtRepoName);
            this.pnlAddRepo.Controls.Add(this.label4);
            this.pnlAddRepo.Location = new System.Drawing.Point(12, 51);
            this.pnlAddRepo.Name = "pnlAddRepo";
            this.pnlAddRepo.Size = new System.Drawing.Size(773, 64);
            this.pnlAddRepo.TabIndex = 15;
            this.pnlAddRepo.Visible = false;
            // 
            // txtLocalPath
            // 
            this.txtLocalPath.Enabled = false;
            this.txtLocalPath.Location = new System.Drawing.Point(411, 4);
            this.txtLocalPath.Name = "txtLocalPath";
            this.txtLocalPath.Size = new System.Drawing.Size(287, 20);
            this.txtLocalPath.TabIndex = 21;
            this.txtLocalPath.Visible = false;
            // 
            // lblLocalPath
            // 
            this.lblLocalPath.AutoSize = true;
            this.lblLocalPath.Location = new System.Drawing.Point(345, 7);
            this.lblLocalPath.Name = "lblLocalPath";
            this.lblLocalPath.Size = new System.Drawing.Size(60, 13);
            this.lblLocalPath.TabIndex = 20;
            this.lblLocalPath.Text = "Local path:";
            this.lblLocalPath.Visible = false;
            // 
            // btnCancelAddRepo
            // 
            this.btnCancelAddRepo.Location = new System.Drawing.Point(249, 31);
            this.btnCancelAddRepo.Name = "btnCancelAddRepo";
            this.btnCancelAddRepo.Size = new System.Drawing.Size(86, 20);
            this.btnCancelAddRepo.TabIndex = 19;
            this.btnCancelAddRepo.Text = "Cancel";
            this.btnCancelAddRepo.UseVisualStyleBackColor = true;
            this.btnCancelAddRepo.Click += new System.EventHandler(this.btnCancelAddRepo_Click);
            // 
            // btnAddRepository
            // 
            this.btnAddRepository.Location = new System.Drawing.Point(157, 31);
            this.btnAddRepository.Name = "btnAddRepository";
            this.btnAddRepository.Size = new System.Drawing.Size(86, 20);
            this.btnAddRepository.TabIndex = 18;
            this.btnAddRepository.Text = "Add repository";
            this.btnAddRepository.UseVisualStyleBackColor = true;
            this.btnAddRepository.Click += new System.EventHandler(this.btnAddRepository_Click);
            // 
            // txtRepoPath
            // 
            this.txtRepoPath.Enabled = false;
            this.txtRepoPath.Location = new System.Drawing.Point(48, 4);
            this.txtRepoPath.Name = "txtRepoPath";
            this.txtRepoPath.Size = new System.Drawing.Size(287, 20);
            this.txtRepoPath.TabIndex = 17;
            // 
            // lblRepoPath
            // 
            this.lblRepoPath.AutoSize = true;
            this.lblRepoPath.Location = new System.Drawing.Point(4, 7);
            this.lblRepoPath.Name = "lblRepoPath";
            this.lblRepoPath.Size = new System.Drawing.Size(32, 13);
            this.lblRepoPath.TabIndex = 16;
            this.lblRepoPath.Text = "Path:";
            // 
            // txtRepoName
            // 
            this.txtRepoName.Location = new System.Drawing.Point(48, 32);
            this.txtRepoName.Name = "txtRepoName";
            this.txtRepoName.Size = new System.Drawing.Size(103, 20);
            this.txtRepoName.TabIndex = 15;
            // 
            // tsbBranching
            // 
            this.tsbBranching.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBranching.Image = ((System.Drawing.Image)(resources.GetObject("tsbBranching.Image")));
            this.tsbBranching.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBranching.Name = "tsbBranching";
            this.tsbBranching.Size = new System.Drawing.Size(23, 48);
            this.tsbBranching.Text = "toolStripButton1";
            this.tsbBranching.ToolTipText = "Manage branches";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 612);
            this.Controls.Add(this.pnlAddRepo);
            this.Controls.Add(this.pnlRepositories);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(809, 650);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "NAS GIT";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fswCheckFilechanges)).EndInit();
            this.pnlRepositories.ResumeLayout(false);
            this.pnlRepositories.PerformLayout();
            this.pnlAddRepo.ResumeLayout(false);
            this.pnlAddRepo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCloneRepository;
        private System.Windows.Forms.ToolStripButton tsbSettings;
        private System.Windows.Forms.ToolStripButton tsbAddRepository;
        private System.IO.FileSystemWatcher fswCheckFilechanges;
        private System.Windows.Forms.FolderBrowserDialog fbdAddRepository;
        private System.Windows.Forms.Panel pnlRepositories;
        private System.Windows.Forms.RichTextBox rtbDiff;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblChangeset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvModifiedFiles;
        private System.Windows.Forms.ColumnHeader fileName;
        private System.Windows.Forms.ColumnHeader hash;
        private System.Windows.Forms.ListView lvCommits;
        private System.Windows.Forms.ColumnHeader Revision;
        private System.Windows.Forms.ColumnHeader Message;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.TabControl tcRepositories;
        private System.Windows.Forms.Panel pnlAddRepo;
        private System.Windows.Forms.TextBox txtRepoPath;
        private System.Windows.Forms.Label lblRepoPath;
        private System.Windows.Forms.TextBox txtRepoName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddRepository;
        private System.Windows.Forms.Button btnCancelAddRepo;
        private System.Windows.Forms.TextBox txtLocalPath;
        private System.Windows.Forms.Label lblLocalPath;
        private System.Windows.Forms.ToolStripButton tsbBranching;
    }
}

