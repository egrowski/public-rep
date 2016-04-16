using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BartoszEgrowskiLab2
{
    public partial class FormMain : Form
    {
        List<Person> listOfPeople = new List<Person>();
        List<Grade> listOfGrades = new List<Grade>();
        public FormMain()
        {
            InitializeComponent();
            Person person = new Person();
            person.name = "Bartosz";
            person.surname = "Egrowski";
            person.age = 25;
            SuperPerson superperson = new SuperPerson("Michal", "Kowalski", 35, 6);
            //MessageBox.Show(superperson.text);

            
            listOfPeople.Add(person);
            listOfPeople.Add(new Person("Marcin", "Nowak", 26));
            listOfPeople.Add(new Person("Wojciech", "Szczepinski", 65));
            listOfPeople.Add(new Person("Artur", "Wrobel", 46));
            listOfPeople.Add(new Person("Pawel", "Wrzesinski", 66));
            listOfPeople.Add(new Person("Marcin", "Arturowicz", 56));

            dataGridViewListOfPeople.DataSource = null;
            dataGridViewListOfPeople.DataSource = listOfPeople;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            dataGridViewListOfPeople.DataSource = null;
            dataGridViewListOfPeople.DataSource = listOfPeople;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listOfPeople.Add(new Person(textBoxName.Text, textBoxSurname.Text, int.Parse(textBoxAge.Text)));
        }

        private void buttonAddGrade_Click(object sender, EventArgs e)
        {
            if (dataGridViewListOfPeople.SelectedRows.Count > 0)
            {
                listOfPeople[dataGridViewListOfPeople.SelectedRows[0].Index].listOfGrades.Add(new Grade(5, "piątka"));
            }
            else
                MessageBox.Show("wybierz kogoś z listy");
        }

        private void buttonShowGrade_Click(object sender, EventArgs e)
        {
            //dataGridViewGrades.DataSource = null;
            listOfGrades = listOfPeople[dataGridViewListOfPeople.SelectedRows[0].Index].listOfGrades;
            dataGridViewGrades.DataSource = listOfGrades;
               //var a = listOfPeople[dataGridViewListOfPeople.SelectedRows[0].Index].listOfGrades;
               //  MessageBox.Show(a);
        }
    }
}
