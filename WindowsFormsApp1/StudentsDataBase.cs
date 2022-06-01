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
    public partial class StudentsDataBase : Form
    {
        AddUser addUser = new AddUser();
        public StudentsDataBase()
        {
            InitializeComponent();

            this.addUser.addClickedEvent += addStudentDataBt_Click;
        }

        private void StudentsDataBase_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("Lp.",50,HorizontalAlignment.Left);
            listView1.Columns.Add("Imie i nazwisko",200,HorizontalAlignment.Center);
            listView1.Columns.Add("Rok urodzenia",150,HorizontalAlignment.Center);
            listView1.Columns.Add("Kraj",140,HorizontalAlignment.Center);          
        }

        private void addStudentBt_Click(object sender, EventArgs e)
        {           
            addUser.ShowDialog();
        }

        private void addStudentDataBt_Click(object sender, EventArgs e)
        {
            int index = listView1.Items.Count +1;
            ListViewItem item = new ListViewItem(new string[] {index.ToString(), addUser.NameTb.Text, addUser.BirthTb.Text,addUser.CountryTb.Text  });
          
            listView1.Items.Add(item);
            foreach (ListViewItem item2 in listView1.Items)
            {
                item2.BackColor = item2.Index % 2 == 0 ? Color.Gray : Color.White;
            }

            for (int i = 0; i <= listView1.Items.Count - 1; i++)
            {
                listView1.Items[i].SubItems[0].Text = i.ToString();
            }
        }

        private void deleteStudentBt_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }


            for(int i=0; i<=listView1.Items.Count-1;i++)
            {
               listView1.Items[i].SubItems[0].Text = i.ToString();
            }

            foreach (ListViewItem item2 in listView1.Items)
            {
                item2.BackColor = item2.Index % 2 == 0 ? Color.Gray : Color.White;
            }

        }

        private void showListBt_Click(object sender, EventArgs e)
        {
            

            foreach(ListViewItem item in listView1.Items)
            {
               MessageBox.Show(item.SubItems[0].Text + " "+ item.SubItems[1].Text+" " +item.SubItems[2].Text + " " + item.SubItems[3].Text, "ddd", MessageBoxButtons.OK);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
