namespace WindowsFormsApp1
{
    partial class StudentsDataBase
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
            this.showListBt = new System.Windows.Forms.Button();
            this.addStudentBt = new System.Windows.Forms.Button();
            this.deleteStudentBt = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // showListBt
            // 
            this.showListBt.Location = new System.Drawing.Point(32, 407);
            this.showListBt.Name = "showListBt";
            this.showListBt.Size = new System.Drawing.Size(198, 38);
            this.showListBt.TabIndex = 1;
            this.showListBt.Text = "Wyswetl wiersze listy";
            this.showListBt.UseVisualStyleBackColor = true;
            this.showListBt.Click += new System.EventHandler(this.showListBt_Click);
            // 
            // addStudentBt
            // 
            this.addStudentBt.Location = new System.Drawing.Point(302, 407);
            this.addStudentBt.Name = "addStudentBt";
            this.addStudentBt.Size = new System.Drawing.Size(202, 38);
            this.addStudentBt.TabIndex = 2;
            this.addStudentBt.Text = "Dodaj studenta";
            this.addStudentBt.UseVisualStyleBackColor = true;
            this.addStudentBt.Click += new System.EventHandler(this.addStudentBt_Click);
            // 
            // deleteStudentBt
            // 
            this.deleteStudentBt.Location = new System.Drawing.Point(591, 404);
            this.deleteStudentBt.Name = "deleteStudentBt";
            this.deleteStudentBt.Size = new System.Drawing.Size(153, 41);
            this.deleteStudentBt.TabIndex = 3;
            this.deleteStudentBt.Text = "Usun studenta";
            this.deleteStudentBt.UseVisualStyleBackColor = true;
            this.deleteStudentBt.Click += new System.EventHandler(this.deleteStudentBt_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(104, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(600, 334);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // StudentsDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.deleteStudentBt);
            this.Controls.Add(this.addStudentBt);
            this.Controls.Add(this.showListBt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentsDataBase";
            this.Text = "StudentsDataBase";
            this.Load += new System.EventHandler(this.StudentsDataBase_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button showListBt;
        private System.Windows.Forms.Button addStudentBt;
        private System.Windows.Forms.Button deleteStudentBt;
        private System.Windows.Forms.ListView listView1;
    }
}