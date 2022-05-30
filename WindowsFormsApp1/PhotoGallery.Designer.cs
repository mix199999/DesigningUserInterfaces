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
            this.deletePicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.centerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picturesFlowPanel
            // 
            this.picturesFlowPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picturesFlowPanel.Location = new System.Drawing.Point(3, 0);
            this.picturesFlowPanel.Margin = new System.Windows.Forms.Padding(4);
            this.picturesFlowPanel.Name = "picturesFlowPanel";
            this.picturesFlowPanel.Size = new System.Drawing.Size(285, 489);
            this.picturesFlowPanel.TabIndex = 0;
            // 
            // centerPictureBox
            // 
            this.centerPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.centerPictureBox.Location = new System.Drawing.Point(481, 13);
            this.centerPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.centerPictureBox.Name = "centerPictureBox";
            this.centerPictureBox.Size = new System.Drawing.Size(417, 382);
            this.centerPictureBox.TabIndex = 0;
            this.centerPictureBox.TabStop = false;
            // 
            // deletePicture
            // 
            this.deletePicture.Location = new System.Drawing.Point(615, 425);
            this.deletePicture.Name = "deletePicture";
            this.deletePicture.Size = new System.Drawing.Size(145, 64);
            this.deletePicture.TabIndex = 1;
            this.deletePicture.Text = "usun obraz";
            this.deletePicture.UseVisualStyleBackColor = true;
            this.deletePicture.Click += new System.EventHandler(this.deletePicture_Click);
            // 
            // PhotoGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(936, 511);
            this.Controls.Add(this.deletePicture);
            this.Controls.Add(this.centerPictureBox);
            this.Controls.Add(this.picturesFlowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhotoGallery";
            this.Text = "PhotoGallery";
            this.Load += new System.EventHandler(this.PhotoGallery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.centerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel picturesFlowPanel;
        private System.Windows.Forms.PictureBox centerPictureBox;
        private System.Windows.Forms.Button deletePicture;
    }
}