using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NasGit.IO;
using System.Diagnostics;

namespace NasGit.Logic {
    /// <summary>
    /// 
    /// </summary>
    public class GitEngine {
        /**
         * This is the path of current repository, where the git command will be excuted. 
         * Every time user change the repository form the UI, this should be changed too.
         */
        public string currentRepPath; 

        /// <summary>
        /// Constructor. The git engine will use the default git.exe path which defined in IO_Config.
        /// </summary>
        public GitEngine() {
            IO_Git.Git.OutputDataReceived += new IO_Git.OutputDelegate(OutputReceivedHandeler);
        }
        /// <summary>
        /// Constructor. The constructor will change the path for git.exe in IO_Config.
        /// </summary>
        /// <param name="gitExePath"></param>
        public GitEngine(string gitExePath) {
            IO_Config.GIT_EXE_PATH = gitExePath;
            IO_Git.Git.OutputDataReceived += new IO_Git.OutputDelegate(OutputReceivedHandeler);
        }

        /// <summary>
        /// Run git command in current repository
        /// </summary>
        public void RunCommandInRepository(string command){
            try {
                IO_Git.Git.RunGitCommand(command + " " + currentRepPath);
            }
            catch (Exception e){
                Debug.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Run git command in given repository
        /// </summary>
        /// <param name="path"></param>
        public void RunCommandInRepository(string command,string path) {
            try {
                IO_Git.Git.RunGitCommand(command + " " + path);
            }
            catch (Exception e) {
                Debug.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Add a new local repository in given path.
        /// </summary>
        /// <param name="path"></param>
        public void AddNewRepository(string path) {
            try {
                IO_Git.Git.RunGitCommand("init"+" "+path);
            }catch(Exception e){
                Debug.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Handeler which get the output from the command.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OutputReceivedHandeler(object sender, System.Diagnostics.DataReceivedEventArgs e) {
            Debug.WriteLine("Git Response: " + e.Data);
        }
    }
}
