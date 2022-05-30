using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class AddUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.birthTb = new System.Windows.Forms.TextBox();
            this.countryTb = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie i nazwisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "rok urodzenia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "kraj";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(244, 71);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(100, 22);
            this.nameTb.TabIndex = 3;
            // 
            // birthTb
            // 
            this.birthTb.Location = new System.Drawing.Point(244, 129);
            this.birthTb.Name = "birthTb";
            this.birthTb.Size = new System.Drawing.Size(100, 22);
            this.birthTb.TabIndex = 4;
            // 
            // countryTb
            // 
            this.countryTb.Location = new System.Drawing.Point(244, 196);
            this.countryTb.Name = "countryTb";
            this.countryTb.Size = new System.Drawing.Size(100, 22);
            this.countryTb.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(171, 260);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(215, 87);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Dodaj!";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 405);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.countryTb);
            this.Controls.Add(this.birthTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox birthTb;
        private System.Windows.Forms.TextBox countryTb;
        private System.Windows.Forms.Button addButton;

        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public TextBox NameTb { get => nameTb; set => nameTb = value; }
        public TextBox BirthTb { get => birthTb; set => birthTb = value; }
        public TextBox CountryTb { get => countryTb; set => countryTb = value; }
        public Button AddButton { get => addButton; set => addButton = value; }
    }
}