﻿using System;
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
            setStartSize();

            //add listeners
            pbMove.MouseDown += DropWindow_MouseDown;
            pbcApp.MouseHover += DropWindow_MouseHover;
            pbcApp.DragOver += DropWindow_DragOver;
            this.DragOver += DropWindow_DragOver;
            
            //resize when mouse out
            this.MouseLeave += DropWindow_MouseLeave;

            //Change repo/branch
            lblRepoName.DragOver += lblRepoName_DragOver;
            

        }

        private void setStartSize() {
            this.Width = 50;
            this.Height = 50;
        }

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
            }
        }

        private void DropWindow_MouseHover(object sender, EventArgs e)
        {
            setLargeSize();
        }

        private void DropWindow_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            setLargeSize();
            //set mouse cursor
            e.Effect = DragDropEffects.Move;
        }

        private void DropWindow_MouseLeave(object sender, EventArgs e)
        {
            //check if mouse is still on the form
            if (!this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition))) {
                setStartSize();
            }
        }

        private void lblRepoName_DragOver(object sender, DragEventArgs e)
        {
            trvRepos.Visible = true;
            trvRepos.Enabled = true;
            trvRepos.DragOver += trvRepos_DragOver;
        }


        private void trvRepos_DragOver(object sender, DragEventArgs e)
        {
            Object dragDropObject = null;
            TreeNode dragDropNode = null;

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