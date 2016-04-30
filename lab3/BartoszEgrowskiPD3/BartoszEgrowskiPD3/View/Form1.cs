using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BartoszEgrowskiPD3.Controller;

namespace BartoszEgrowskiPD3
{
    public partial class FormMain : Form
    {
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;
        public FormMain()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection
                ("Server = EGR; Database = BartoszEgrowskiSchoolDatabase; Trusted_Connection = Yes"); //połączenie z bazą
        }

        private void buttonShowAllGrades_Click(object sender, EventArgs e)
        {
            Grade.ShowAllGrades(sqlConnection, sqlDataAdapter, dataGridViewSchools); //funkcja wyświetlająca wszystkie oceny jakie otrzymali uczniowie i zadania za jakie te oceny otrzymali
        }

        private void buttonShowSelectedStudentGrades_Click(object sender, EventArgs e)
        {
            Grade.ShowSelectedStudentGrades 
                (sqlConnection, sqlDataAdapter, dataGridViewSchools, textBoxStudentName, textBoxStudentSurname); //funkcja wyświetlająca oceny wybranego ucznia i zadanie za jakie tą ocenę zdobył
        }

        private void buttonShowStudentsWithPositiveGrades_Click(object sender, EventArgs e)
        {
            Student.ShowStudentsWithPositiveGrades
            (sqlConnection, sqlDataAdapter, dataGridViewSchools); //funkcja wyświetlająca wszystkich uczniów posiadających pozytywne oceny i przedmioty z których te oceny otrzymali
        }

        private void buttonShowAllStudents_Click(object sender, EventArgs e)
        {
            Student.ShowAllStudents(sqlConnection, sqlDataAdapter, dataGridViewSchools); //funkcja wyświetlająca wszystkich uczniów wraz z adresem i szkołą do której chodzą
        }

        private void buttonShowParents_Click(object sender, EventArgs e)
        {
            Parents.ShowParentsOfSelectedStudent(sqlConnection, sqlDataAdapter, dataGridViewSchools, textBoxStudentName, textBoxStudentSurname);//funkcja wyświetlająca dane rodziców wybranego studenta
        }

        private void buttonShowAllTeachers_Click(object sender, EventArgs e)
        {
            Teacher.ShowAllTeachers(sqlConnection, sqlDataAdapter, dataGridViewSchools); //funkcja wyświetlająca wszystkich nauczycieli wraz z adresem, przedmiotem którego uczą i szkołą w której uczą
        }

        private void buttonShowStudentsAtSelectedSchool_Click(object sender, EventArgs e)
        {
            Student.ShowStudentsAtSelectedSchool
            (sqlConnection, sqlDataAdapter, dataGridViewSchools, textBoxSchoolName);
        }

        private void buttonShowTeachersWorkingAtSelectedSchool_Click(object sender, EventArgs e)
        {
            Teacher.ShowTeachersWorkingAtSelectedSchool
            (sqlConnection, sqlDataAdapter, dataGridViewSchools, textBoxSchoolName);
        }

        private void buttonShowStudentsAttendingChosenSubject_Click(object sender, EventArgs e)
        {
            Student.ShowStudentsAttendingChosenSubject(sqlConnection, sqlDataAdapter, dataGridViewSchools, textBoxSubjectName); //funkcja wyświetlająca uczniów uczęszczających na wybrany przedmiot
        }
    }
}
