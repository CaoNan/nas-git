using LibGit2Sharp;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;
using NasGit.IO;

namespace NasGit {
    public partial class Form1 : Form {
        string mCurrentCommit = "";
        Repository currentRepo;
        Thread DropWindowThread;
        RepositoryConfigCollection mLocalRepositories;
		
        /// <summary>
        /// Initialise form
        /// </summary>
        public Form1() {
            InitializeComponent();
            //add listerners
            lvCommits.SelectedIndexChanged += lvCommits_SelectedIndexChanged;
            tcRepositories.SelectedIndexChanged += tcRepositories_TabIndexChanged;

            startDropForm();
            
            
            //Load configuration and repositories
            mLocalRepositories = IO_Config.GetAllRepositoriesConfig();

            //foreach item in config.repositories
            if (mLocalRepositories.Count > 0) { 
                foreach (RepositoryConfigElement repo in mLocalRepositories)
                {
                    addRepositoryToView(repo.LocalPath, repo.Name);
                }
                //load selected repo commits
                //TODO: Should be last selected repo on previous close if possible
                loadRepository(mLocalRepositories[0].LocalPath);
            }   
        }


        public static void ThreadProc()
        {
            Application.Run(new DropWindow());
        }

        private void startDropForm()
        {
            DropWindowThread = new Thread(new ThreadStart(ThreadProc));
            DropWindowThread.SetApartmentState(ApartmentState.STA);
            DropWindowThread.Start();
        }

        /// <summary>
        /// Load a repository and show details on the form
        /// </summary>
        /// <param name="path"></param>
        private void loadRepository(string path) {
            currentRepo = new Repository(path);
            lvModifiedFiles.Items.Clear();
            lblBranch.Text = "";
            lblUser.Text = "";
            lblChangeset.Text = "";
            buildCommitLog();

            //select last commit if working dir has no changes
            //TODO: check working dir changes
            //changeCommit(lvCommits.Items[0].SubItems[0].Text);
            lvCommits.Focus();
            if (lvCommits.Items.Count > 0) { 
                lvCommits.Items[0].Selected = true;
            }
        }

        /// <summary>
        /// Add new tabpage for repository
        /// </summary>
        /// <param name="repoIdentifier">local repo identifier</param>
        /// <param name="repoName">Name to be dispayed</param>
        private void addRepositoryToView(string repoIdentifier, string repoName) {
            tcRepositories.TabPages.Add(repoIdentifier, repoName);
        }



        /// <summary>
        /// Change the screen to a new commit
        /// </summary>
        /// <param name="sha">sha hash of requested commit</param>
        private void changeCommit(string sha) {
            currentRepo = new Repository(mLocalRepositories[0].LocalPath);

            //Commit currentCommit = (Commit)currentRepo.Commits.Where(Commit => Commit.Id.Sha == sha).First();
            Commit currentCommit = (Commit)currentRepo.Lookup(new ObjectId(sha), GitObjectType.Commit);

            //update file list
            fillFileList(currentCommit.Tree);
            
            //update labels
            lblUser.Text = currentCommit.Committer.Name;
            lblChangeset.Text = "(" + currentCommit.Id.ToString().Substring(0,6) + ") " + currentCommit.MessageShort;
            //lblBranch.Text = currentCommit.

        }

        /// <summary>
        /// Fill the list of changed files
        /// </summary>
        /// <param name="currentTree">Tree being looked at</param>
        private void fillFileList(Tree currentTree) {
            lvModifiedFiles.Items.Clear();
            addTree(currentTree);
        }
        
        /// <summary>
        /// Recursive function to loop through commit trees
        /// </summary>
        /// <param name="t">current tree</param>
        /// <param name="prefix">current directory</param>
        private void addTree(Tree t, string prefix = "") {
            foreach (TreeEntry te in t)
            {
                Debug.WriteLine(te.Target.GetType());
                if (te.Target.GetType().ToString() == "LibGit2Sharp.Tree")
                {
                    Tree b = (Tree)te.Target;
                    addTree(b, prefix + "/" + te.Name);
                }
                else {
                    ListViewItem itm = new ListViewItem(new string[2]{prefix + "/" + te.Name, te.Target.Sha});
                    lvModifiedFiles.Items.Add(itm);
                }
            }
        }


        /// <summary>
        /// Build a log of commits for current repository
        /// </summary>
        private void buildCommitLog(){
            lvCommits.Items.Clear();

            using (currentRepo)
            {
                foreach (Commit c in currentRepo.Commits)
                {
                    ListViewItem itm = new ListViewItem(new string[4]{c.Id.ToString(), c.MessageShort, c.Author.Name, c.Author.When.ToString()});
                    lvCommits.Items.Add(itm);
                }
            }
        }
        
        /// <summary>
        /// Try to add a new repository, will discover if directory already is version controlled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAddRepository_Click(object sender, EventArgs e)
        {
            //resize window
            Form1.ActiveForm.Height += 65;
            pnlAddRepo.Visible = true;

            askForLocalDirectory();
        }

        /// <summary>
        /// Clone a repository, localy or remote
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbCloneRepository_Click(object sender, EventArgs e)
        {
            //resize window
            Form1.ActiveForm.Height += 65;
            txtRepoPath.Enabled = true;
            btnAddRepository.Text = "Clone repository";
            pnlAddRepo.Visible = true;
            lblLocalPath.Visible = true;
            txtLocalPath.Visible = true;

            askForLocalDirectory();
        }

        /// <summary>
        /// Show folder browse dialog to select local repository path
        /// </summary>
        private void askForLocalDirectory() {
            if (fbdAddRepository.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bool continueCreation = false;

                //Check if we can create a new repo in this directory
                if (Directory.EnumerateFileSystemEntries(fbdAddRepository.SelectedPath).Any())
                {
                    //dir not empty, ask for permission
                    if (MessageBox.Show("This directory is not empty, are you sure you want to continue?", "Attention", MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.Yes)
                    {
                        continueCreation = true;
                    }
                }
                else
                {
                    continueCreation = true;
                }

                if (continueCreation)
                {
                    if (txtRepoPath.Enabled)
                    {
                        txtLocalPath.Text = fbdAddRepository.SelectedPath;
                    }
                    else { 
                        txtRepoPath.Text = fbdAddRepository.SelectedPath;
                    }
                    
                }
                else
                {
                    hideAddRepoPanel();
                }
            }
            else
            {
                hideAddRepoPanel();
            }
        }

        /// <summary>
        /// Show the changes made in this commit
        /// </summary>
        /// <param name="sha">sha hash of the file</param>
        private void showDiff(string sha) {
            //Working dir diff NOT GOOD
            //TreeChanges tc = currentRepo.Diff.Compare();
            //Blob a = (Blob) currentRepo.Lookup(sha, GitObjectType.Blob);
            //Commit c = (Commit)currentRepo.Lookup(mCurrentCommit, GitObjectType.Commit);
            //TreeEntry t = (TreeEntry)c.Tree.Where(Tree => Tree.Target.Sha == sha).First();

            //Blob b = (Blob)currentRepo.Lookup("24d243a3d1d8ed5894b92a1b0c0ecceb2a71c0a5", GitObjectType.Blob);

            //ContentChanges cc = currentRepo.Diff.Compare(a, b);

            //currentRepo.Diff.Compare(
            //WE NEED THE DIFF OF SELECTED COMMIT
            //TreeEntryChanges tec = tc.Modified.Where(TreeEntryChanges => TreeEntryChanges.Oid.Sha == sha).First();


        }

        /// <summary>
        /// When new commit is selected, update filelist and info labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvCommits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCommits.SelectedItems.Count > 0) {
                mCurrentCommit = lvCommits.SelectedItems[0].Text;
                changeCommit(mCurrentCommit);
            }
            
        }

        /// <summary>
        /// When a file in this commit is selected, show the differences with previous version
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvModifiedFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvModifiedFiles.SelectedItems.Count > 0)
            {
                showDiff(lvModifiedFiles.SelectedItems[0].SubItems[1].Text);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tcRepositories_TabIndexChanged(object sender, System.EventArgs e)
        {
            //load repo config.reposiroties[identifier]
            loadRepository(mLocalRepositories[tcRepositories.SelectedIndex].LocalPath);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRepository_Click(object sender, EventArgs e)
        {
            RepositoryConfigElement newRepo = new RepositoryConfigElement();
            newRepo.Name = txtRepoName.Text;
            //check if we are adding or cloning a repo
            if (txtRepoPath.Enabled)
            {
                this.UseWaitCursor = true;
                Repository.Clone(txtRepoPath.Text, txtLocalPath.Text);

                newRepo.LocalPath = txtLocalPath.Text;
                newRepo.RemoteURL = txtRepoPath.Text;
                mLocalRepositories = IO_Config.AddRepositoryConfig(newRepo);
                addRepositoryToView(newRepo.LocalPath, newRepo.Name);

                this.UseWaitCursor = false;
            }else{
                if (Repository.Discover(fbdAddRepository.SelectedPath) != null)
                {
                    //repository available here, import it
                    newRepo.LocalPath = txtRepoPath.Text;
                    mLocalRepositories = IO_Config.AddRepositoryConfig(newRepo);
                    addRepositoryToView(newRepo.LocalPath, newRepo.Name);
                }
                else
                {
                    //create new repository
                    try
                    {
                        //config.add repository
                        currentRepo = Repository.Init(txtRepoPath.Text);
                        newRepo.LocalPath = txtRepoPath.Text;
                        mLocalRepositories = IO_Config.AddRepositoryConfig(newRepo);
                        addRepositoryToView(newRepo.LocalPath, newRepo.Name);
                    }
                    catch (RepositoryNotFoundException rne)
                    {
                        MessageBox.Show(rne.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            tcRepositories.SelectTab(tcRepositories.TabCount - 1);
            hideAddRepoPanel();
        }

        /// <summary>
        /// Cancel button pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelAddRepo_Click(object sender, EventArgs e)
        {
            hideAddRepoPanel();
        }

        /// <summary>
        /// Hide add repositorie controls
        /// </summary>
        private void hideAddRepoPanel() { 
            if (txtRepoPath.Enabled) {
                txtRepoPath.Enabled = false;
                btnAddRepository.Text = "Add repository";
                lblLocalPath.Visible = false;
                txtLocalPath.Visible = false;
            }
            txtRepoPath.Text = "";
            txtRepoName.Text = "";
            Form1.ActiveForm.Height -= 65;
            pnlAddRepo.Visible = false;
        }

    }
}