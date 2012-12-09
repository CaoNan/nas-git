using LibGit2Sharp;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NasGit {
    public partial class Form1 : Form {
        string mRepo = "C:/Users/Sander/Documents/GitHub/nas-git/";
        string mCurrentCommit = "";
        Repository currentRepo;
		
        /// <summary>
        /// Initialise form
        /// </summary>
        public Form1() {
            InitializeComponent();

            //Load configuration and repositories
            

            //foreach item in config.repositories
            addRepositoryToView("1", "Test");
            
            
            
        }

        private void loadRepository(string path) {
            currentRepo = new Repository(path);

            buildCommitLog();
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
            currentRepo = new Repository(mRepo);

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
            lvCommits.Clear();

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
            if (fbdAddRepository.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
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
                else {
                    continueCreation = true;
                }

                if (continueCreation) {
                    if (Repository.Discover(fbdAddRepository.SelectedPath) != null)
                    {
                        //repository available here, import it
                        //config.add repository
                        string existingRepo = Repository.Discover(fbdAddRepository.SelectedPath);
                        
                    }
                    else { 
                        //create new repository
                        try
                        {
                            currentRepo = Repository.Init(fbdAddRepository.SelectedPath);
                            MessageBox.Show("Repository aangemaakt");
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
            }
        }

        /// <summary>
        /// Clone a repository, localy or remote
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbCloneRepository_Click(object sender, EventArgs e)
        {
            
            //Repository.Clone();
        }
        //
        ///
        ///
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
        }

    }
}