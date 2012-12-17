using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace NasGit
{
    public partial class DropWindow : Form
    {
        //ref http://stackoverflow.com/questions/4577141/move-window-without-border
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private const int LARGE_WIDTH = 212;
        private const int LARGE_HEIGHT = 220;
        TreeNode lastDragDestination = null;
        DateTime lastDragDestinationTime;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public DropWindow()
        {
            InitializeComponent();

            //add listeners
            pbMove.MouseDown += DropWindow_MouseDown;
            this.MouseDown += DropWindow_MouseDown;
            pbcApp.MouseHover += DropWindow_MouseHover;
            pbcApp.DragOver += DropWindow_DragOver;
            this.DragOver += DropWindow_DragOver;
            
            //resize when mouse out
            this.MouseLeave += DropWindow_MouseLeave;

            //Change repo/branch
            lblRepoName.DragOver += lblRepoName_DragOver;

            //Do action
            this.DragDrop += DropWindow_DragDrop;
            setStartSize();

        }

        /// <summary>
        /// Minimize drop window
        /// </summary>
        private void setStartSize() {
            this.Width = 21;
            this.Height = 21;
        }

        /// <summary>
        /// Maximize drop window
        /// </summary>
        private void setLargeSize()
        {
            this.Width = LARGE_WIDTH;
            this.Height = LARGE_HEIGHT;
        }

        /// <summary>
        /// Move window function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DropWindow_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);

                //TODO: save dropwindow location
            }
        }

        /// <summary>
        /// Make window bigger when hovering over it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DropWindow_MouseHover(object sender, EventArgs e)
        {
            setLargeSize();
        }

        /// <summary>
        /// Make window bigger when hovering over it with files
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DropWindow_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            setLargeSize();
            //set mouse cursor
            e.Effect = DragDropEffects.Move;
        }

        /// <summary>
        /// Make window smaller when leaving
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DropWindow_MouseLeave(object sender, EventArgs e)
        {
            //check if mouse is still on the form
            if (!this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition))) {
                setStartSize();
            }
        }

        /// <summary>
        /// When files are dropped, do something
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DropWindow_DragDrop(object sender, DragEventArgs e)
        {
            //get dropped files
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            
            //check where files were dropped
            if (pbCommit.ClientRectangle.Contains(pbCommit.PointToClient(Control.MousePosition)))
            {
                //do Commit
                //is repo and branch set correctly?
                if (lblBranchName.Text == "...") { 
                    //show textbox to enter new branch
                    string branchName = Microsoft.VisualBasic.Interaction.InputBox("Branch name", "Please enter a new branch name", "Default", 0, 0);
                    lblBranchName.Text = branchName; 
                }
            }
            //Obsolete because we can select a new branch when doing a commit
            if (pbBranch.ClientRectangle.Contains(pbBranch.PointToClient(Control.MousePosition)))
            {
                //doBranch
            }
        }

        /// <summary>
        /// When dragging over the repo name, show the treeview to change repo/branch
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblRepoName_DragOver(object sender, DragEventArgs e)
        {
            trvRepos.Visible = true;
            trvRepos.Enabled = true;
            trvRepos.DragOver += trvRepos_DragOver;
        }

        /// <summary>
        /// Select the required repo/branch when hovering over the treeview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trvRepos_DragOver(object sender, DragEventArgs e)
        {
            //always disallow by default
            e.Effect = DragDropEffects.Scroll;

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
                if (hoverTime.TotalSeconds > 1)
                {
                    destinationNode.Expand();
                    if (destinationNode.Level == 0)
                    {
                        lblRepoName.Text = destinationNode.Text;
                    }
                    else {
                        lblBranchName.Text = destinationNode.Text;
                    }
                }
            }
        }

        /// <summary>
        /// Focus main window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbcApp_Click(object sender, EventArgs e)
        {
            //open main form
            bringMainToFront();
        }

        private void bringMainToFront() {
            //open main form
            /*if (Application.OpenForms[0].InvokeRequired)
            {
                this.Invoke(new MethodInvoker(bringMainToFront));
                return;
            }
            Application.OpenForms[0].Activate();*/
        }

        private void lblRepoName_Click(object sender, EventArgs e)
        {

        }
    }
}
