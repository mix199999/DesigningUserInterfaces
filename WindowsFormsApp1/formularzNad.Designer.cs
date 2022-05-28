namespace WindowsFormsApp1
{
    partial class formularzNad
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.oknoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.przegladarkaObrazowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaDanychStudentowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oknoToolStripMenuItem,
            this.autorToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // oknoToolStripMenuItem
            // 
            this.oknoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.przegladarkaObrazowToolStripMenuItem,
            this.bazaDanychStudentowToolStripMenuItem});
            this.oknoToolStripMenuItem.Name = "oknoToolStripMenuItem";
            this.oknoToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.oknoToolStripMenuItem.Text = "Okno";
            // 
            // przegladarkaObrazowToolStripMenuItem
            // 
            this.przegladarkaObrazowToolStripMenuItem.Name = "przegladarkaObrazowToolStripMenuItem";
            this.przegladarkaObrazowToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.przegladarkaObrazowToolStripMenuItem.Text = "Przegladarka obrazow";
            this.przegladarkaObrazowToolStripMenuItem.Click += new System.EventHandler(this.przegladarkaObrazowToolStripMenuItem_Click);
            // 
            // bazaDanychStudentowToolStripMenuItem
            // 
            this.bazaDanychStudentowToolStripMenuItem.Name = "bazaDanychStudentowToolStripMenuItem";
            this.bazaDanychStudentowToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.bazaDanychStudentowToolStripMenuItem.Text = "Baza danych studentow";
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.autorToolStripMenuItem.Text = "Autor";
            // 
            // formularzNad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formularzNad";
            this.Text = "formularzNad";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem oknoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem przegladarkaObrazowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bazaDanychStudentowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
    }
}



