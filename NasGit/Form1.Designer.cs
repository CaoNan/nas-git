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
            this.tcRepositories = new System.Windows.Forms.TabControl();
            this.tpRepository = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddRepository = new System.Windows.Forms.ToolStripButton();
            this.tsbCloneRepository = new System.Windows.Forms.ToolStripButton();
            this.tsbSettings = new System.Windows.Forms.ToolStripButton();
            this.fswCheckFilechanges = new System.IO.FileSystemWatcher();
            this.fbdAddRepository = new System.Windows.Forms.FolderBrowserDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblChangeset = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.tcRepositories.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fswCheckFilechanges)).BeginInit();
            this.SuspendLayout();
            // 
            // tcRepositories
            // 
            this.tcRepositories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcRepositories.Controls.Add(this.tpRepository);
            this.tcRepositories.Controls.Add(this.tabPage1);
            this.tcRepositories.Enabled = false;
            this.tcRepositories.Location = new System.Drawing.Point(12, 54);
            this.tcRepositories.Name = "tcRepositories";
            this.tcRepositories.SelectedIndex = 0;
            this.tcRepositories.Size = new System.Drawing.Size(769, 27);
            this.tcRepositories.TabIndex = 0;
            // 
            // tpRepository
            // 
            this.tpRepository.Location = new System.Drawing.Point(4, 22);
            this.tpRepository.Name = "tpRepository";
            this.tpRepository.Padding = new System.Windows.Forms.Padding(3);
            this.tpRepository.Size = new System.Drawing.Size(761, 1);
            this.tpRepository.TabIndex = 1;
            this.tpRepository.Text = "Repository";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(761, 1);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddRepository,
            this.tsbCloneRepository,
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
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 154);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(300, 333);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Changeset:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Branch:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "User:";
            // 
            // lblChangeset
            // 
            this.lblChangeset.AutoSize = true;
            this.lblChangeset.Location = new System.Drawing.Point(79, 88);
            this.lblChangeset.Name = "lblChangeset";
            this.lblChangeset.Size = new System.Drawing.Size(320, 13);
            this.lblChangeset.TabIndex = 8;
            this.lblChangeset.Text = "13 (08fac2542450) + Updated group registrations (not working yet)";
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(81, 105);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(39, 13);
            this.lblBranch.TabIndex = 9;
            this.lblBranch.Text = "Master";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(81, 122);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(42, 13);
            this.lblUser.TabIndex = 10;
            this.lblUser.Text = "SaWey";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 499);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.lblChangeset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tcRepositories);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "NAS GIT";
            this.tcRepositories.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fswCheckFilechanges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcRepositories;
        private System.Windows.Forms.TabPage tpRepository;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbCloneRepository;
        private System.Windows.Forms.ToolStripButton tsbSettings;
        private System.Windows.Forms.ToolStripButton tsbAddRepository;
        private System.IO.FileSystemWatcher fswCheckFilechanges;
        private System.Windows.Forms.FolderBrowserDialog fbdAddRepository;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblChangeset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblBranch;
    }
}

