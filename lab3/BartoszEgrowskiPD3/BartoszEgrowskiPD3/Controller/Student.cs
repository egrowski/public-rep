using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BartoszEgrowskiPD3.Controller
{
    public class Student
    {
        public static void ShowStudentsWithPositiveGrades
            (SqlConnection sqlConnection, SqlDataAdapter sqlDataAdapter, DataGridView dataGridViewSchools)
        {
            sqlDataAdapter = new SqlDataAdapter
                ("SELECT students.Name AS Imię, Surname AS Nazwisko, GradeWord AS 'Ocena słownie', Subjects.name as Przedmiot FROM Grades JOIN StudentGrades ON Grades.ID = StudentGrades.GradeID JOIN Students ON StudentGrades.StudentID=Students.ID JOIN StudentSubjects ON Students.ID = StudentSubjects.StudentID JOIN Subjects ON StudentSubjects.SubjectID = Subjects.ID WHERE Grade>1", sqlConnection);
            //zapytanie sql
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridViewSchools.DataSource = dataTable;
            //wypełnienie datagridview danymi
            //analogicznie poniżej
        }

        public static void ShowAllStudents
            (SqlConnection sqlConnection, SqlDataAdapter sqlDataAdapter, DataGridView dataGridViewSchools)
        {
            sqlDataAdapter = new SqlDataAdapter
                ("SELECT Students.Name AS Imię, Surname AS Nazwisko, StreetAndNumber AS Adres, City AS Miasto, Schools.name AS Szkoła FROM Students JOIN Address ON Students.AddressID = Address.ID JOIN Schools ON Students.SchoolID = Schools.ID", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridViewSchools.DataSource = dataTable;
        }

        public static void ShowStudentsAtSelectedSchool
            (SqlConnection sqlConnection, SqlDataAdapter sqlDataAdapter, DataGridView dataGridViewSchools, 
            TextBox textBoxSchoolName)
        {
            string schoolName;
            schoolName = textBoxSchoolName.Text; //przypisanie wartości textBoxa pod zmienną
            sqlDataAdapter = new SqlDataAdapter
                ("SELECT Students.Name AS Imię, Surname AS Nazwisko, Schools.Name AS Szkoła FROM Students JOIN Schools ON Students.SchoolID = Schools.ID WHERE Schools.Name = '" + schoolName + "'", sqlConnection);
            //zapytanie sql
            DataTable dataTable = new DataTable();
            if (!(textBoxSchoolName.Text == "")) //co robić gdy w texBox'ie jest tekst
            {
                sqlDataAdapter.Fill(dataTable);
                dataGridViewSchools.DataSource = dataTable;
            }
            else //w przeciwnym wypadku
            {
                MessageBox.Show("Wpisz nazwę szkoły!");
            }
        }
        
        public static void ShowStudentsAttendingChosenSubject
            (SqlConnection sqlConnection, SqlDataAdapter sqlDataAdapter, DataGridView dataGridViewSchools,
            TextBox textBoxSubjectName)
        {
            string subjectName;
            subjectName = textBoxSubjectName.Text; //przypisanie wartości textBoxa pod zmienną
            sqlDataAdapter = new SqlDataAdapter
                ("SELECT Students.Name AS Imię, Surname AS Nazwisko, Subjects.Name AS Przedmiot FROM Students JOIN StudentSubjects ON Students.ID = StudentSubjects.StudentID JOIN Subjects ON StudentSubjects.SubjectID=Subjects.ID WHERE Subjects.Name = '" + subjectName + "'", sqlConnection);
            //zapytanie sql
            DataTable dataTable = new DataTable();
            if (!(textBoxSubjectName.Text == "")) //co robić gdy w texBox'ie jest tekst
            {
                sqlDataAdapter.Fill(dataTable);
                dataGridViewSchools.DataSource = dataTable;
            }
            else //w przeciwnym wypadku
            {
                MessageBox.Show("Wpisz przedmiot!");
            }
        }
    }
}
