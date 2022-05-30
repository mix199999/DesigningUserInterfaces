namespace WindowsFormsApp1
{
    partial class PhotoGallery
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
            this.picturesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.centerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.centerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picturesFlowPanel
            // 
            this.picturesFlowPanel.BackColor = System.Drawing.SystemColors.Control;
            this.picturesFlowPanel.Location = new System.Drawing.Point(2, 0);
            this.picturesFlowPanel.Name = "picturesFlowPanel";
            this.picturesFlowPanel.Size = new System.Drawing.Size(214, 438);
            this.picturesFlowPanel.TabIndex = 0;
            // 
            // centerPictureBox
            // 
            this.centerPictureBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.centerPictureBox.Location = new System.Drawing.Point(276, 27);
            this.centerPictureBox.Name = "centerPictureBox";
            this.centerPictureBox.Size = new System.Drawing.Size(461, 379);
            this.centerPictureBox.TabIndex = 0;
            this.centerPictureBox.TabStop = false;
            // 
            // PhotoGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.centerPictureBox);
            this.Controls.Add(this.picturesFlowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhotoGallery";
            this.Text = "PhotoGallery";
            this.Load += new System.EventHandler(this.PhotoGallery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.centerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel picturesFlowPanel;
        private System.Windows.Forms.PictureBox centerPictureBox;
    }
}