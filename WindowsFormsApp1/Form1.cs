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
            this.newButton.Click += new System.EventHandler(this.ukryjNowyButton);  //przechwycenie eventu ukrywania przycisku
            this.newButton.Visible = false;         //ukrycie przycisku
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ustawButton.TabStop = false;       //blokada przechodzenia tabem miedzy przyciskami
            this.formularzButton.TabStop = false;
            this.dodajButton.TabStop = false;

            newButton.Size = new Size(ustawButton.Width, ustawButton.Height);  // nowy przycisk
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
                this.Text = titleTx.Text;                 //pobranie tytulu i ustawienie go
                this.Location = new Point(Int32.Parse(xPositionTx.Text), Int32.Parse(yPositionTx.Text));        //pobranie lokalizacji i ustawienie jej

            }
            catch (System.FormatException)
            {
                MessageBox.Show("Podano zla wartosc!", "blad", MessageBoxButtons.OK, MessageBoxIcon.Error);         //obsluga bledow podawania informacji
            }
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (newButton.Visible == false)
            {
                newButton.Visible = true;           //widok nowego przycisku
                this.groupBox1.Controls.Add(newButton);     //dodanie przycisku do groupboxa
                newButton.Location = new Point(ustawButton.Location.X + ustawButton.Width, ustawButton.Location.Y);  //ustawienie lokalizacji przyciskow
                ustawButton.Location = new Point(newButton.Location.X - 2 * newButton.Width, newButton.Location.Y);
            }



        }

        private void ukryjNowyButton(object sender, EventArgs e)
        {
            this.newButton.Visible = false;         //ukrycie przycisku
            this.ustawButton.Location = new Point(ustawButton.Location.X + ustawButton.Width, ustawButton.Location.Y);      //powrot przycisku glownego na swoje miejsce
        }

        private void formularzButton_Click(object sender, EventArgs e)
        {
            formularzNad glownyForm = new formularzNad();       //stworzenie nowego formularza
            this.Visible = false;       //ukrycie aktualnego formularaza
            glownyForm.ShowDialog();        //otwarcie nowego formularza po kliknieciu        }
        }

        private void xPositionTx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
