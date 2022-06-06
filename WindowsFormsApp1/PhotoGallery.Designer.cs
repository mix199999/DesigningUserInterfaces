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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.centerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picturesFlowPanel
            // 
            this.picturesFlowPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picturesFlowPanel.Location = new System.Drawing.Point(2, 0);
            this.picturesFlowPanel.Name = "picturesFlowPanel";
            this.picturesFlowPanel.Size = new System.Drawing.Size(256, 454);
            this.picturesFlowPanel.TabIndex = 0;
            //this.picturesFlowPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.picturesFlowPanel_Paint);
            // 
            // centerPictureBox
            // 
            this.centerPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.centerPictureBox.Location = new System.Drawing.Point(358, 57);
            this.centerPictureBox.Name = "centerPictureBox";
            this.centerPictureBox.Size = new System.Drawing.Size(386, 313);
            this.centerPictureBox.TabIndex = 0;
            this.centerPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 389);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "USUN OBRAZEK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhotoGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(809, 453);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}