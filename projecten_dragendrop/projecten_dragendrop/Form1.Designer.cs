namespace projecten_dragendrop
{
    partial class frmDrop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblText = new System.Windows.Forms.Label();
            this.nyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmbRepository = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(27, 114);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(228, 13);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Sleep een bestand of een map naar dit venster";
            // 
            // nyIcon
            // 
            this.nyIcon.Text = "notifyIcon1";
            this.nyIcon.Visible = true;
            // 
            // cmbRepository
            // 
            this.cmbRepository.FormattingEnabled = true;
            this.cmbRepository.Items.AddRange(new object[] {
            "rep1",
            "rep2"});
            this.cmbRepository.Location = new System.Drawing.Point(77, 12);
            this.cmbRepository.Name = "cmbRepository";
            this.cmbRepository.Size = new System.Drawing.Size(121, 21);
            this.cmbRepository.TabIndex = 1;
            // 
            // frmDrop
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmbRepository);
            this.Controls.Add(this.lblText);
            this.Name = "frmDrop";
            this.Text = "Dropvenster";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmDrop_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmDrop_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.NotifyIcon nyIcon;
        private System.Windows.Forms.ComboBox cmbRepository;
    }
}

