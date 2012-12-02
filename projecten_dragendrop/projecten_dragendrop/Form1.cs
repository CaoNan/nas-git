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
        public frmDrop()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(frmDrop_DragEnter);
            this.DragDrop += new DragEventHandler(frmDrop_DragDrop);
        }

         void frmDrop_DragEnter(object sender, DragEventArgs e) {

             // option false for exact path
             if (e.Data.GetDataPresent(DataFormats.FileDrop, false)) {
                 e.Effect = DragDropEffects.All;
             }
                
        }

         void frmDrop_DragDrop(object sender, DragEventArgs e) {
             
             string newLocation = "/files";
             string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop);
             foreach (string file in files) {
                 Console.WriteLine(file);
                 //File.Move(file, newLocation);
             }
            
        }
    }
}
