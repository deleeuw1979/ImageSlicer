namespace WindowsFormsApp1
{
    partial class board
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(board));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.frame1 = new WindowsFormsApp1.frame();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frame1
            // 
            this.frame1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.frame1.Location = new System.Drawing.Point(11, 11);
            this.frame1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.frame1.Name = "frame1";
            this.frame1.Size = new System.Drawing.Size(40, 40);
            this.frame1.TabIndex = 4;
            this.frame1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frame1_KeyUp);
            this.frame1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.frame1_PreviewKeyDown);
            // 
            // board
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1023, 561);
            this.ControlBox = false;
            this.Controls.Add(this.frame1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "board";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private frame frame1;
    }
}

