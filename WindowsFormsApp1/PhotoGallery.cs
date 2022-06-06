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

    
    public partial class PhotoGallery : Form
    {

        /// <summary>
        ///Lista z zaimportowanymi do projektu przykładowymi zdjęciami
        /// </summary>
        List<Bitmap> picturesList = new List<Bitmap>()
        {
            new Bitmap(Properties.Resources.zd1),
             new Bitmap(Properties.Resources.zd2),
              new Bitmap(Properties.Resources.zd3)
        };
        public PhotoGallery()
        {
            InitializeComponent();
        }



        /// <summary>
        ///Metoda po załadowaniu się formularza jako piersze określa 
        ///parametry dla bocznego flowPanel-u, które pozwalają zaimplementować
        ///pionowe  przewijanie
        ///
        /// następnie tworzona jest tablica PictureBox-ów o wielkości równej
        /// sumie elemntów listy picturesList
        /// 
        /// kolejnym krokiem jest przypisanie opowiednich parametrów elementom
        /// z tablicy oraz metody przechwytującej zdarzenie kliknięcie  
        /// </summary>
        private void PhotoGallery_Load(object sender, EventArgs e)
        {
            this.picturesFlowPanel.FlowDirection = FlowDirection.TopDown;
            this.picturesFlowPanel.AutoScroll = true;
            this.picturesFlowPanel.WrapContents = false;

            PictureBox[] pictureBox = new PictureBox[picturesList.Count];

            for (int i = 0; i < pictureBox.Length; i++)
            {
                pictureBox[i] = new PictureBox();
                pictureBox[i].Width = 200;
                pictureBox[i].Height = 150;
                pictureBox[i].Image = picturesList[i];
                pictureBox[i].SizeMode = PictureBoxSizeMode.StretchImage; // dopasowanie rozmiaru zdjęcia do wielkości pictureBox-a
                pictureBox[i].BorderStyle = BorderStyle.FixedSingle;
                pictureBox[i].Click += picture_Click;
                
            }

            foreach(PictureBox box in pictureBox)
            {
                picturesFlowPanel.Controls.Add(box);
            }
                

                       
            
        }

        /// <summary>
        /// metoda przypisuje sender-owi parametry PictureBox-a
        /// dzięki czemu możemy wykorzystać dostępne dla niego metody
         
        /// </summary>

        private void picture_Click(object sender, EventArgs e)
        {
            var picture = sender as PictureBox;
            centerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            centerPictureBox.Image = picture.Image;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            centerPictureBox.Image=null;
        }
    }



}
