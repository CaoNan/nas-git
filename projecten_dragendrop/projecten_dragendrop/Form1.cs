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

             //this.trvRepos.ExpandAll();
             Icon dragDropObject = null;
             TreeNode dragDropNode = null;

             //always disallow by default
             //e.Effect = DragDropEffects.None;

             //make sure we have data to transfer
             if (e.Data.GetDataPresent(typeof(TreeNode)))
             {
                 dragDropNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
                 dragDropObject = (Icon)dragDropNode.Tag;
             }
             else if (e.Data.GetDataPresent(typeof(ListViewItem)))
             {
                 ListViewItem temp = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                 dragDropObject = (Icon)temp.Tag;
             }

             if (dragDropObject != null)
             {
                 TreeNode destinationNode = null;
                 //get current location
                 Point pt = new Point(e.X, e.Y);
                 pt = trvRepos.PointToClient(pt);
                 destinationNode = trvRepos.GetNodeAt(pt);
                 if (destinationNode == null)
                 {
                     return;
                 }

                 //if we are on a new object, reset our timer
                 //otherwise check to see if enough time has passed and expand the destination node
                 if (destinationNode != lastDragDestination)
                 {
                     lastDragDestination = destinationNode;
                     lastDragDestinationTime = DateTime.Now;
                 }
                 else
                 {
                     TimeSpan hoverTime = DateTime.Now.Subtract(lastDragDestinationTime);
                     if (hoverTime.TotalSeconds > 2)
                     {
                         destinationNode.Expand();
                     }
                 }
             }
         }

         private void frmDrop_Load(object sender, EventArgs e)
         {
             // ophalen lijst repo's en branches
         }

         

         private void btnLocalCommit_Click(object sender, EventArgs e)
         {
             Console.WriteLine("commit");
             Console.WriteLine(trvRepos.SelectedNode.FullPath);
         }

         private void trvRepos_MouseClick(object sender, MouseEventArgs e)
         {
             btnLocalCommit.Visible = true;
             btnLocalCommit.Enabled = true;
         }

         private void pbcApp_Click(object sender, EventArgs e)
         {
             // go to app
             Console.WriteLine("go to app");
         }

    }
}
