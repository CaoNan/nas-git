using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace NasGit {
    /// <summary>
    /// The static class used to run git commando's in windows
    /// </summary>
    public static class IO_Git {
        /// <summary>
        /// 
        /// </summary>
        public static ProcessStartInfo start = new ProcessStartInfo("git.exe");

        /// <summary>
        /// This static methode will create a new repository, which is a copy of remote resource. 
        /// </summary>
        /// <param name="address">The address of the remote resource.</param>
        /// <param name="dir">The folder witch the repository will be created in.</param>
        /// <returns>The StreamReader instace contains the output.</returns>
        public static StreamReader CloneFromRemote(string address,string dir="") {
            //set the command for cloning from remote
            start.Arguments = "clone "+address+" "+dir; 
            //hide the cmd window
            start.CreateNoWindow = true;
            //redirect the output
            start.RedirectStandardOutput = true;
            //redirect the input
            start.RedirectStandardInput = true;
            //in order to redirect, this has to be set false.
            start.UseShellExecute = false;
            //start the process
            Process process = Process.Start(start);

            process.EnableRaisingEvents = true;
            process.Exited += new EventHandler(ColneExit);

            //get the output stream
            return process.StandardOutput;
        }

        private static void ColneExit(object sender, EventArgs e) {
            throw new NotImplementedException();
        }
    }
}
