using System;
using System.IO;
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
        public List<Person> listOfPeople { get; set; }
        List<Grade> listOfGrades = new List<Grade>();
        public FormMain()
        {
            InitializeComponent();
            Person person = new Person();
            person.name = "Bartosz";
            person.surname = "Egrowski";
            person.age = 28;
            SuperPerson superperson = new SuperPerson("Michal", "Kowalski", 35, 6);

            listOfPeople = new List<Person>();
            listOfPeople.Add(person);
            listOfPeople.Add(new Person("Marcin", "Nowak", 26));
            listOfPeople.Add(new Person("Wojciech", "Szczepinski", 65));
            listOfPeople.Add(new Person("Artur", "Wrobel", 46));
            listOfPeople.Add(new Person("Pawel", "Wrzesinski", 66));
            listOfPeople.Add(new Person("Marcin", "Arturowicz", 56));

            dataGridViewListOfPeople.DataSource = null;
            dataGridViewListOfPeople.DataSource = listOfPeople;

          //  dataGridViewGrades.DataSource = null;
          //  dataGridViewGrades.DataSource = listOfGrades;
        }

        private void buttonAddGrade_Click(object sender, EventArgs e)
        {
             if (dataGridViewListOfPeople.SelectedRows.Count > 0)
             {
                 listOfPeople[dataGridViewListOfPeople.SelectedRows[0].Index].listOfGrades.Add(new Grade(double.Parse(textBoxGradeValue.Text), textBoxGradeName.Text));
                dataGridViewGrades.DataSource = null;
                dataGridViewGrades.DataSource = listOfPeople[dataGridViewListOfPeople.SelectedRows[0].Index].listOfGrades;
            }
             else
                 MessageBox.Show("wybierz kogoś z listy");
        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            AddPerson addPerson = new AddPerson(this);
            addPerson.Show();
        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("osoby.txt");
            for (int i = 0; i < (dataGridViewListOfPeople.RowCount - 1); i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    streamWriter.Write(dataGridViewListOfPeople.Rows[i].Cells[j].Value + "|");
                }
                streamWriter.WriteLine();
            }
            streamWriter.Close();
            MessageBox.Show("Zapisano!");
        }

        private void toolStripMenuItemLoad_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader streamReader = new StreamReader("osoby.txt");
                string content = streamReader.ReadToEnd();
                int split = content.Split('\n').Length;
                for (int i = 0; i < split - 1; i++)
                {
                    dataGridViewListOfPeople.Rows.Add(content.Split('n')[i].Split('|'));
                }
                streamReader.Close();
            }
            catch
            {
                MessageBox.Show("Nie znaleziono pliku!");
            }           
                
            }
        }
    }

