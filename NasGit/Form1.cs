using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using NasGit.Logic;
using System.IO;

namespace NasGit {
    public partial class Form1 : Form {
        
        private GitEngine engine;
        
        public Form1() {
        
            InitializeComponent();
            engine = new GitEngine();
        
        }

        private void tsbAddRepository_Click(object sender, EventArgs e)
        {
            if (fbdAddRepository.ShowDialog() == System.Windows.Forms.DialogResult.OK) {

                //The response is current shown in the output window below.
                engine.AddNewRepository(fbdAddRepository.SelectedPath);

                /*
                //Check if we can create a new repo in this directory
                if (Directory.EnumerateFileSystemEntries(fbdAddRepository.SelectedPath).Any()) { 
                    //dir not empty, ask for permission
                    if (MessageBox.Show("This directory is not empty, are you sure you want to continue?", "Attention", MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        //string cmd = " -q ";
                        //IO_Git.Git.RunGitCommand(cmd);
                    }
                }*/
            }
        }
    }
}
