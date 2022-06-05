namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xPositionTx = new System.Windows.Forms.TextBox();
            this.yPositionTx = new System.Windows.Forms.TextBox();
            this.titleTx = new System.Windows.Forms.TextBox();
            this.ustawButton = new System.Windows.Forms.Button();
            this.formularzButton = new System.Windows.Forms.Button();
            this.dodajButton = new System.Windows.Forms.Button();
            this.titleLb = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y";
            // 
            // xPositionTx
            // 
            this.xPositionTx.Location = new System.Drawing.Point(109, 28);
            this.xPositionTx.Name = "xPositionTx";
            this.xPositionTx.Size = new System.Drawing.Size(100, 22);
            this.xPositionTx.TabIndex = 3;
            this.xPositionTx.TextChanged += new System.EventHandler(this.xPositionTx_TextChanged);
            this.xPositionTx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tab_KeyPress);
            // 
            // yPositionTx
            // 
            this.yPositionTx.Location = new System.Drawing.Point(109, 61);
            this.yPositionTx.Name = "yPositionTx";
            this.yPositionTx.Size = new System.Drawing.Size(100, 22);
            this.yPositionTx.TabIndex = 4;
            this.yPositionTx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tab_KeyPress);
            // 
            // titleTx
            // 
            this.titleTx.Location = new System.Drawing.Point(109, 96);
            this.titleTx.Name = "titleTx";
            this.titleTx.Size = new System.Drawing.Size(100, 22);
            this.titleTx.TabIndex = 5;
            this.titleTx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tab_KeyPress);
            // 
            // ustawButton
            // 
            this.ustawButton.Location = new System.Drawing.Point(109, 134);
            this.ustawButton.Name = "ustawButton";
            this.ustawButton.Size = new System.Drawing.Size(75, 43);
            this.ustawButton.TabIndex = 6;
            this.ustawButton.Text = "Ustaw";
            this.ustawButton.UseVisualStyleBackColor = true;
            this.ustawButton.Click += new System.EventHandler(this.ustawButton_Click);
            // 
            // formularzButton
            // 
            this.formularzButton.Location = new System.Drawing.Point(29, 201);
            this.formularzButton.Name = "formularzButton";
            this.formularzButton.Size = new System.Drawing.Size(250, 40);
            this.formularzButton.TabIndex = 7;
            this.formularzButton.Text = "Formularz dokumentu";
            this.formularzButton.UseVisualStyleBackColor = true;
            this.formularzButton.Click += new System.EventHandler(this.formularzButton_Click);
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(29, 247);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(250, 40);
            this.dodajButton.TabIndex = 8;
            this.dodajButton.Text = "Dodaj przycisk do formularza";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // titleLb
            // 
            this.titleLb.AutoSize = true;
            this.titleLb.Location = new System.Drawing.Point(61, 96);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(39, 16);
            this.titleLb.TabIndex = 9;
            this.titleLb.Text = "Tytuł";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.titleLb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.xPositionTx);
            this.groupBox1.Controls.Add(this.yPositionTx);
            this.groupBox1.Controls.Add(this.ustawButton);
            this.groupBox1.Controls.Add(this.titleTx);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 183);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pozycja formularza";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 314);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.formularzButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox xPositionTx;
        private System.Windows.Forms.TextBox yPositionTx;
        private System.Windows.Forms.TextBox titleTx;
        private System.Windows.Forms.Button ustawButton;
        private System.Windows.Forms.Button formularzButton;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Label titleLb;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

