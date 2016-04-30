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
    public class Grade
    {
        public static void ShowAllGrades
            (SqlConnection sqlConnection, SqlDataAdapter sqlDataAdapter, DataGridView dataGridViewSchools)
        {
            sqlDataAdapter = new SqlDataAdapter
                ("SELECT Name AS Imię, Surname AS Nazwisko, Grade AS Ocena, GradeWord AS 'Ocena słownie', Title AS 'Praca domowa' FROM Grades JOIN StudentGrades ON Grades.ID = StudentGrades.GradeID JOIN Students ON StudentGrades.StudentID=Students.ID JOIN StudentHomeworks ON Students.ID = StudentHomeworks.StudentID JOIN Homeworks ON StudentHomeworks.HomeworkID = Homeworks.ID", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridViewSchools.DataSource = dataTable;
        }

        public static void ShowSelectedStudentGrades
            (SqlConnection sqlConnection, SqlDataAdapter sqlDataAdapter, DataGridView dataGridViewSchools, 
            TextBox textBoxStudentName, TextBox textBoxStudentSurname)
        {
                string name;
                string surname;
                name = textBoxStudentName.Text;
                surname = textBoxStudentSurname.Text;
                sqlDataAdapter = new SqlDataAdapter
                    ("SELECT Name AS Imię, Surname AS Nazwisko, Grade AS Ocena, GradeWord AS 'Ocena słownie', Title AS 'Praca domowa' FROM Grades JOIN StudentGrades ON Grades.ID = StudentGrades.GradeID JOIN Students ON StudentGrades.StudentID=Students.ID JOIN StudentHomeworks ON Students.ID = StudentHomeworks.StudentID JOIN Homeworks ON StudentHomeworks.HomeworkID = Homeworks.ID WHERE Name = '" + name + "' OR Surname = '" + surname + "'", sqlConnection);
                DataTable dataTable = new DataTable();
                if (!(textBoxStudentName.Text == "" && textBoxStudentSurname.Text == ""))
                {
                    sqlDataAdapter.Fill(dataTable);
                    dataGridViewSchools.DataSource = dataTable;
                }
                else
                {
                    MessageBox.Show("Wpisz imię lub nazwisko ucznia!");
                }
        }
    }
}
