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

    
    public partial class AddUser : Form
    {

        public EventHandler addClickedEvent;
        public AddUser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcja realizuje wywołanie zdarzenia addClickedEvent
        /// dzięki czemu w formularzu nadrzędnym można przesłonić tą metodę
        /// </summary>
        /// <param name="sender">class Button</param>

        private void addButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            EventHandler handler = addClickedEvent;     
            handler?.Invoke(button, e);
            
        }
    }
}
