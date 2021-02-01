using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persons
{
    public partial class Persons : Form
    {
        //Declara un onjeto de la clase Person
        //Instanciar la clase Person
        //Clase: Person y el objeto es person   
        Person person = new Person();
        public Persons()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            person.Name = txtName.Text;
            person.Direction = txtDirec.Text;
            person.DateNaci = calNaci.SelectionStart;
            //===========================================
            txtName.Text = "";
            txtDirec.Text = "";
            txtName.Focus();

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show(person.Name + " \n " 
                + person.Direction 
                + " \n y su fecha de nacimiento es " 
                + person.DateNaci.ToShortDateString());*/

            label5.Text = person.Name; 
            label6.Text = person.Direction;
            label7.Text = "La edad es " + person.calcAge().ToString();
            label8.Text = "Normalización del nombre " + person.normName();
        }
    }
}
