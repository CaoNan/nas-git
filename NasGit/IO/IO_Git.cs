using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace NasGit.IO {
    /// <summary>
    /// This class is a sigleton class used to run git commando's in windows.
    /// In order to prevent excess instance, and for easier to catch the output.
    /// To get a instance of this class, use "IO_Git.Git;"
    /// </summary>
    public  class IO_Git {
        /// <summary>
        /// implementation of sigleton
        /// </summary>
        private static IO_Git git;
        public static IO_Git Git {
            get {
                if (git == null) {
                    git = new IO_Git();
                }
                return git;
            }
        }
        /// <summary>
        /// In this instance contains the "git.exe" process, some cofigurations, and the arguments.
        /// </summary>
        private ProcessStartInfo start;
        /// <summary>
        /// delegate as a uniform of eventhandeler of event OutputDataRecevied
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void OutputDelegate(object sender, DataReceivedEventArgs e);
        /// <summary>
        /// This event will be trigged when new output is added in the output list. So the classed in logic layer can catch and show it on forms. 
        /// </summary>
        public event OutputDelegate OutputDataReceived;
        
        /// <summary>
        /// This list of string contains every output form the commando's.
        /// </summary>
        private List<string> output;
        public List<string> Output {
            get { return output; }
        }

        /// <summary>
        /// This private constructor will make sure this class is a sigleton class.
        /// </summary>
        private IO_Git() {
            try {
                start = new ProcessStartInfo(IO_Config.GIT_EXE_PATH);
            }catch(Exception exc){
                Debug.WriteLine(exc.Message);
                //todo: throw exception to upper layer.
            }
            output = new List<string>();

            //hide the cmd window
            start.CreateNoWindow = true;
            //redirect the output
            start.RedirectStandardOutput = true;
            //redirect the input
            start.RedirectStandardInput = true;
            //in order to redirect, this has to be set false.
            start.UseShellExecute = false;
        }
        /// <summary>
        /// This static methode will create a new repository, which is a copy of remote resource. 
        /// </summary>
        /// <param name="address">The address of the remote resource.</param>
        /// <param name="dir">The folder witch the repository will be created in.</param>
        /// <returns>The StreamReader instace contains the output.</returns>
        public void CloneFromRemote(string address,string dir="") {
            //set the arguments
            start.Arguments = "clone "+address+" "+dir; 
            //creat the process
            Process process = new Process();
            process.StartInfo = start;
            //every time the process send some output, the handler will be trigged.
            process.OutputDataReceived += new DataReceivedEventHandler(ReceiveOutput);
            //start process
            process.Start();
        }

        /// <summary>
        /// Run any git command
        /// </summary>
        /// <param name="argument">The argument is the complete git command, expect "git". For example: "add file.txt"</param>
        public void RunGitCommand(string argument) {
            Debug.WriteLine("Git Excute: git "+argument);
            start.Arguments = argument;
            Process process = new Process();
            process.OutputDataReceived += new DataReceivedEventHandler(ReceiveOutput);
            process.StartInfo = start;
            process.Start();
            process.BeginOutputReadLine();

            process.WaitForExit();
            process.Close();
        }

        /// <summary>
        /// EventHandeler for receving the output.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReceiveOutput(object sender, DataReceivedEventArgs e) {
            output.Add(e.Data);
            OutputDataReceived(output, e);
        }
    }
}
