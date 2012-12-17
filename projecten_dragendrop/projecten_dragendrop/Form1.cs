using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace projecten_dragendrop
{
    public partial class frmDrop : Form
    {

        private TreeNode lastDragDestination = null;
        private DateTime lastDragDestinationTime;
        private bool firstTime = true;
        private string[] files;

        public frmDrop()
        {
            InitializeComponent();
            this.TopMost = true;
            btnLocalCommit.Enabled = false;
        }

         void pnlDropArea_DragEnter(object sender, DragEventArgs e)
        {
            // option false for exact path
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
            }

        }

         void pnlDropArea_DragDrop(object sender, DragEventArgs e) {

             // clear text first time
             if (this.firstTime == true) {
                 lblDropArea.Text = "";
                 this.firstTime = false;
             }

             string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);
             this.files = files;

             // show in GUI
             foreach (string file in files) {
                 lblDropArea.Text += file + '\n'; 
             }

             // treeview repos active
             trvRepos.Visible = true;
             trvRepos.Enabled = true;
            
        }

         void pnlDropArea_DragOver(object sender, DragEventArgs e) {

             this.trvRepos.ExpandAll();
             
         }

         private void frmDrop_Load(object sender, EventArgs e)
         {
             // ophalen lijst repo's en branches
         }

         

         private void btnLocalCommit_Click(object sender, EventArgs e)
         {
             Console.WriteLine("commit");
             Console.WriteLine(trvRepos.SelectedNode.FullPath);
             foreach (string file in this.files) { 
                Console.WriteLine(file);
             }
             
         }

         private void trvRepos_MouseClick(object sender, MouseEventArgs e)
         {
             btnLocalCommit.Visible = true;
             btnLocalCommit.Enabled = true;
         }

         private void pbcApp_Click(object sender, EventArgs e)
         {
             // go to app
             Application.OpenForms[0].Activate();
         }

    }
}
