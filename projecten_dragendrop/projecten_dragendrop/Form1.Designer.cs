namespace projecten_dragendrop
{
    partial class frmDrop
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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("master");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("...");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("repo1", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("master");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("repo2", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrop));
            this.nyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnLocalCommit = new System.Windows.Forms.Button();
            this.trvRepos = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDropArea = new System.Windows.Forms.Label();
            this.pnlDropArea = new System.Windows.Forms.Panel();
            this.pbcApp = new System.Windows.Forms.PictureBox();
            this.pnlDropArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcApp)).BeginInit();
            this.SuspendLayout();
            // 
            // nyIcon
            // 
            this.nyIcon.Text = "notifyIcon1";
            this.nyIcon.Visible = true;
            // 
            // btnLocalCommit
            // 
            this.btnLocalCommit.Enabled = false;
            this.btnLocalCommit.Location = new System.Drawing.Point(146, 164);
            this.btnLocalCommit.Name = "btnLocalCommit";
            this.btnLocalCommit.Size = new System.Drawing.Size(115, 23);
            this.btnLocalCommit.TabIndex = 2;
            this.btnLocalCommit.Text = "lokale commit";
            this.btnLocalCommit.UseVisualStyleBackColor = true;
            this.btnLocalCommit.Visible = false;
            this.btnLocalCommit.Click += new System.EventHandler(this.btnLocalCommit_Click);
            // 
            // trvRepos
            // 
            this.trvRepos.AllowDrop = true;
            this.trvRepos.Enabled = false;
            this.trvRepos.Location = new System.Drawing.Point(129, 77);
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
            this.trvRepos.Size = new System.Drawing.Size(152, 70);
            this.trvRepos.TabIndex = 3;
            this.trvRepos.Visible = false;
            this.trvRepos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trvRepos_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "lijst sorteren op laatst gewijzgd?";
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "bij elke repo leeg veld met new branch om snel toe te voegen";
            this.label3.Visible = false;
            // 
            // lblDropArea
            // 
            this.lblDropArea.AutoSize = true;
            this.lblDropArea.Location = new System.Drawing.Point(3, 6);
            this.lblDropArea.Name = "lblDropArea";
            this.lblDropArea.Size = new System.Drawing.Size(220, 13);
            this.lblDropArea.TabIndex = 0;
            this.lblDropArea.Text = "Sleep een bestand of een map naar dit kader";
            // 
            // pnlDropArea
            // 
            this.pnlDropArea.AllowDrop = true;
            this.pnlDropArea.AutoScroll = true;
            this.pnlDropArea.AutoSize = true;
            this.pnlDropArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDropArea.Controls.Add(this.lblDropArea);
            this.pnlDropArea.Location = new System.Drawing.Point(78, 12);
            this.pnlDropArea.Name = "pnlDropArea";
            this.pnlDropArea.Size = new System.Drawing.Size(286, 47);
            this.pnlDropArea.TabIndex = 8;
            this.pnlDropArea.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlDropArea_DragDrop);
            this.pnlDropArea.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlDropArea_DragEnter);
            this.pnlDropArea.DragOver += new System.Windows.Forms.DragEventHandler(this.pnlDropArea_DragOver);
            // 
            // pbcApp
            // 
            this.pbcApp.Image = ((System.Drawing.Image)(resources.GetObject("pbcApp.Image")));
            this.pbcApp.Location = new System.Drawing.Point(12, 8);
            this.pbcApp.Name = "pbcApp";
            this.pbcApp.Size = new System.Drawing.Size(53, 51);
            this.pbcApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbcApp.TabIndex = 9;
            this.pbcApp.TabStop = false;
            this.pbcApp.Click += new System.EventHandler(this.pbcApp_Click);
            // 
            // frmDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(380, 69);
            this.Controls.Add(this.pbcApp);
            this.Controls.Add(this.trvRepos);
            this.Controls.Add(this.pnlDropArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLocalCommit);
            this.Name = "frmDrop";
            this.Text = "nas-git - dropvenster";
            this.Load += new System.EventHandler(this.frmDrop_Load);
            this.pnlDropArea.ResumeLayout(false);
            this.pnlDropArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon nyIcon;
        private System.Windows.Forms.Button btnLocalCommit;
        private System.Windows.Forms.TreeView trvRepos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDropArea;
        private System.Windows.Forms.Panel pnlDropArea;
        private System.Windows.Forms.PictureBox pbcApp;
    }
}

