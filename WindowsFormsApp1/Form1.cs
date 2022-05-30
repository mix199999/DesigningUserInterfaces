using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Button newButton = new Button();
        
        public Form1()
        {
            this.newButton.Click += new System.EventHandler(this.ukryjNowyButton);
            this.newButton.Visible = false;
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ustawButton.TabStop = false;
            this.formularzButton.TabStop=false;
            this.dodajButton.TabStop=false;
           
            newButton.Size = new Size(ustawButton.Width, ustawButton.Height);
            newButton.Text = "nowy";

            newButton.Location = new Point(ustawButton.Location.X + ustawButton.Width, ustawButton.Location.Y);
            
        }

        private void Tab_KeyPress(object sender, KeyPressEventArgs e)
        {      

        }

        private void ustawButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Text = titleTx.Text;
                this.Location = new Point(Int32.Parse(xPositionTx.Text), Int32.Parse(yPositionTx.Text));
                
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Podano zla wartosc!","blad",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if(newButton.Visible == false)
            {
                newButton.Visible = true;
                this.groupBox1.Controls.Add(newButton);
                newButton.Location = new Point(ustawButton.Location.X + ustawButton.Width, ustawButton.Location.Y);
                ustawButton.Location = new Point(newButton.Location.X - 2*newButton.Width, newButton.Location.Y);
            }
            


        }

        private void ukryjNowyButton(object sender, EventArgs e)
        {
            this.newButton.Visible = false;
            this.ustawButton.Location = new Point(ustawButton.Location.X + ustawButton.Width, ustawButton.Location.Y);
        }

        private void formularzButton_Click(object sender, EventArgs e)
        {
            formularzNad glownyForm = new formularzNad();
            this.Visible = false;
            glownyForm.ShowDialog();
        }
    }
}
