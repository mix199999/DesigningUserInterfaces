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
        List<string> picturesPath = new List<string>()//pewnie da się inaczej
        {
            "C:/Users/Michau/source/repos/SupportServiceSystem/icons/cross.png",
            "C:/Users/Michau/source/repos/SupportServiceSystem/icons/crossIcon.png",
            "C:/Users/Michau/source/repos/SupportServiceSystem/icons/logo.png",
            "C:/Users/Michau/source/repos/SupportServiceSystem/icons/question.png"


        };
        public PhotoGallery()
        {
            InitializeComponent();
        }

        private void PhotoGallery_Load(object sender, EventArgs e)
        {
            PictureBox[] pictureBox = new PictureBox[picturesPath.Count];

            for (int i = 0; i < pictureBox.Length; i++)
            {
                pictureBox[i] = new PictureBox();
                pictureBox[i].Width = 214;//do zmiany
                pictureBox[i].Height = 50;//do zmiany
                pictureBox[i].BorderStyle = BorderStyle.FixedSingle;
                pictureBox[i].Click += picture_Click;
                pictureBox[i].ImageLocation = picturesPath[i];
            }

            foreach(PictureBox box in pictureBox)
            {
                picturesFlowPanel.Controls.Add(box);
            }
                

                       
            
        }

        private void picture_Click(object sender, EventArgs e)
        {
            var picture = sender as PictureBox;
            centerPictureBox.ImageLocation = picture.ImageLocation;
        }
    }



}
