﻿namespace WindowsFormsApp1
{
    partial class frame
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DoubleBuffered = true;
            this.Name = "frame";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frame_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frame_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frame_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
