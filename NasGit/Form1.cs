using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using NasGit.IO;
using System.IO;

namespace NasGit {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void tsbAddRepository_Click(object sender, EventArgs e)
        {
            if (fbdAddRepository.ShowDialog() == System.Windows.Forms.DialogResult.OK) { 
                //Check if we can create a new repo in this directory
                if (Directory.EnumerateFileSystemEntries(fbdAddRepository.SelectedPath).Any()) { 
                    //dir not empty, ask for permission
                    if (MessageBox.Show("This directory is not empty, are you sure you want to continue?", "Attention", MessageBoxButtons.YesNoCancel) == System.Windows.Forms.DialogResult.OK)
                    {
                        //string cmd = " -q ";
                        //IO_Git.Git.RunGitCommand(cmd);
                    }
                }
            }
        }
    }
}
