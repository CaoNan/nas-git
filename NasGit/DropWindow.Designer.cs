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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("master");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("...");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("repo1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("master");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("repo2", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.pbcApp = new System.Windows.Forms.PictureBox();
            this.pbMove = new System.Windows.Forms.PictureBox();
            this.pbCommit = new System.Windows.Forms.PictureBox();
            this.pbBranch = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRepoName = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.trvRepos = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pbcApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCommit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBranch)).BeginInit();
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
            this.pbcApp.Click += new System.EventHandler(this.pbcApp_Click);
            // 
            // pbMove
            // 
            this.pbMove.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pbMove.Image = ((System.Drawing.Image)(resources.GetObject("pbMove.Image")));
            this.pbMove.Location = new System.Drawing.Point(191, 0);
            this.pbMove.Name = "pbMove";
            this.pbMove.Size = new System.Drawing.Size(21, 22);
            this.pbMove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMove.TabIndex = 11;
            this.pbMove.TabStop = false;
            // 
            // pbCommit
            // 
            this.pbCommit.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbCommit.Image = ((System.Drawing.Image)(resources.GetObject("pbCommit.Image")));
            this.pbCommit.Location = new System.Drawing.Point(7, 31);
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
            this.pbBranch.Location = new System.Drawing.Point(7, 79);
            this.pbBranch.Name = "pbBranch";
            this.pbBranch.Size = new System.Drawing.Size(44, 42);
            this.pbBranch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBranch.TabIndex = 13;
            this.pbBranch.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(4, 134);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(89, 13);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Working on repo:";
            // 
            // lblRepoName
            // 
            this.lblRepoName.AllowDrop = true;
            this.lblRepoName.AutoSize = true;
            this.lblRepoName.Location = new System.Drawing.Point(99, 134);
            this.lblRepoName.Name = "lblRepoName";
            this.lblRepoName.Size = new System.Drawing.Size(61, 13);
            this.lblRepoName.TabIndex = 15;
            this.lblRepoName.Text = "RepoName";
            this.lblRepoName.Click += new System.EventHandler(this.lblRepoName_Click);
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Location = new System.Drawing.Point(13, 156);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(80, 13);
            this.lblBranch.TabIndex = 16;
            this.lblBranch.Text = "Current branch:";
            // 
            // lblBranchName
            // 
            this.lblBranchName.AllowDrop = true;
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.Location = new System.Drawing.Point(99, 156);
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
            this.trvRepos.Location = new System.Drawing.Point(57, 31);
            this.trvRepos.Name = "trvRepos";
            treeNode1.Name = "Node5";
            treeNode1.Text = "master";
            treeNode2.Name = "Node6";
            treeNode2.Text = "...";
            treeNode3.Name = "Node0";
            treeNode3.Text = "repo1";
            treeNode4.Name = "Node7";
            treeNode4.Text = "master";
            treeNode5.Name = "Node1";
            treeNode5.Text = "repo2";
            this.trvRepos.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5});
            this.trvRepos.Size = new System.Drawing.Size(152, 90);
            this.trvRepos.TabIndex = 18;
            this.trvRepos.Visible = false;
            // 
            // DropWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 177);
            this.ControlBox = false;
            this.Controls.Add(this.trvRepos);
            this.Controls.Add(this.lblBranchName);
            this.Controls.Add(this.lblBranch);
            this.Controls.Add(this.lblRepoName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBranch);
            this.Controls.Add(this.pbCommit);
            this.Controls.Add(this.pbMove);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCommit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBranch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbcApp;
        private System.Windows.Forms.PictureBox pbMove;
        private System.Windows.Forms.PictureBox pbCommit;
        private System.Windows.Forms.PictureBox pbBranch;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRepoName;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.TreeView trvRepos;
    }
}