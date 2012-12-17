namespace NasGit
{
    partial class DropWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DropWindow));
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("master");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("...");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("repo1", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("master");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("repo2", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.pbcApp = new System.Windows.Forms.PictureBox();
            this.pbCommit = new System.Windows.Forms.PictureBox();
            this.pbBranch = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRepoName = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.trvRepos = new System.Windows.Forms.TreeView();
            this.pnlDropBox = new System.Windows.Forms.Panel();
            this.pnlDragMeHelp = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbcApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCommit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBranch)).BeginInit();
            this.pnlDropBox.SuspendLayout();
            this.pnlDragMeHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbcApp
            // 
            this.pbcApp.Image = ((System.Drawing.Image)(resources.GetObject("pbcApp.Image")));
            this.pbcApp.Location = new System.Drawing.Point(0, 0);
            this.pbcApp.Name = "pbcApp";
            this.pbcApp.Size = new System.Drawing.Size(19, 19);
            this.pbcApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcApp.TabIndex = 10;
            this.pbcApp.TabStop = false;
            // 
            // pbCommit
            // 
            this.pbCommit.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbCommit.Image = ((System.Drawing.Image)(resources.GetObject("pbCommit.Image")));
            this.pbCommit.Location = new System.Drawing.Point(3, 5);
            this.pbCommit.Name = "pbCommit";
            this.pbCommit.Size = new System.Drawing.Size(44, 42);
            this.pbCommit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCommit.TabIndex = 12;
            this.pbCommit.TabStop = false;
            // 
            // pbBranch
            // 
            this.pbBranch.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbBranch.Image = ((System.Drawing.Image)(resources.GetObject("pbBranch.Image")));
            this.pbBranch.Location = new System.Drawing.Point(3, 53);
            this.pbBranch.Name = "pbBranch";
            this.pbBranch.Size = new System.Drawing.Size(44, 42);
            this.pbBranch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBranch.TabIndex = 13;
            this.pbBranch.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(0, 108);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(89, 13);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Working on repo:";
            // 
            // lblRepoName
            // 
            this.lblRepoName.AllowDrop = true;
            this.lblRepoName.AutoSize = true;
            this.lblRepoName.Location = new System.Drawing.Point(95, 108);
            this.lblRepoName.Name = "lblRepoName";
            this.lblRepoName.Size = new System.Drawing.Size(61, 13);
            this.lblRepoName.TabIndex = 15;
            this.lblRepoName.Text = "RepoName";
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(9, 130);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(80, 13);
            this.lblBranch.TabIndex = 16;
            this.lblBranch.Text = "Current branch:";
            // 
            // lblBranchName
            // 
            this.lblBranchName.AllowDrop = true;
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.Location = new System.Drawing.Point(95, 130);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(69, 13);
            this.lblBranchName.TabIndex = 17;
            this.lblBranchName.Text = "BranchName";
            // 
            // trvRepos
            // 
            this.trvRepos.AllowDrop = true;
            this.trvRepos.Enabled = false;
            this.trvRepos.HotTracking = true;
            this.trvRepos.Location = new System.Drawing.Point(53, 5);
            this.trvRepos.Name = "trvRepos";
            treeNode6.Name = "Node5";
            treeNode6.Text = "master";
            treeNode7.Name = "Node6";
            treeNode7.Text = "...";
            treeNode8.Name = "Node0";
            treeNode8.Text = "repo1";
            treeNode9.Name = "Node7";
            treeNode9.Text = "master";
            treeNode10.Name = "Node1";
            treeNode10.Text = "repo2";
            this.trvRepos.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode10});
            this.trvRepos.Size = new System.Drawing.Size(152, 90);
            this.trvRepos.TabIndex = 18;
            this.trvRepos.Visible = false;
            // 
            // pnlDropBox
            // 
            this.pnlDropBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDropBox.Controls.Add(this.pbBranch);
            this.pnlDropBox.Controls.Add(this.trvRepos);
            this.pnlDropBox.Controls.Add(this.pbCommit);
            this.pnlDropBox.Controls.Add(this.lblBranchName);
            this.pnlDropBox.Controls.Add(this.lblTitle);
            this.pnlDropBox.Controls.Add(this.lblBranch);
            this.pnlDropBox.Controls.Add(this.lblRepoName);
            this.pnlDropBox.Location = new System.Drawing.Point(0, 71);
            this.pnlDropBox.Name = "pnlDropBox";
            this.pnlDropBox.Size = new System.Drawing.Size(212, 149);
            this.pnlDropBox.TabIndex = 19;
            // 
            // pnlDragMeHelp
            // 
            this.pnlDragMeHelp.BackColor = System.Drawing.Color.Salmon;
            this.pnlDragMeHelp.Controls.Add(this.label1);
            this.pnlDragMeHelp.Controls.Add(this.lblInfo);
            this.pnlDragMeHelp.Location = new System.Drawing.Point(0, 26);
            this.pnlDragMeHelp.Name = "pnlDragMeHelp";
            this.pnlDragMeHelp.Size = new System.Drawing.Size(212, 39);
            this.pnlDragMeHelp.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(3, 14);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(206, 20);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Drag me to a good place";
            // 
            // DropWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 224);
            this.ControlBox = false;
            this.Controls.Add(this.pnlDragMeHelp);
            this.Controls.Add(this.pnlDropBox);
            this.Controls.Add(this.pbcApp);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(21, 21);
            this.Name = "DropWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "NAS-Git Drop Window";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pbcApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCommit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBranch)).EndInit();
            this.pnlDropBox.ResumeLayout(false);
            this.pnlDropBox.PerformLayout();
            this.pnlDragMeHelp.ResumeLayout(false);
            this.pnlDragMeHelp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbcApp;
        private System.Windows.Forms.PictureBox pbCommit;
        private System.Windows.Forms.PictureBox pbBranch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRepoName;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.TreeView trvRepos;
        private System.Windows.Forms.Panel pnlDropBox;
        private System.Windows.Forms.Panel pnlDragMeHelp;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label1;
    }
}