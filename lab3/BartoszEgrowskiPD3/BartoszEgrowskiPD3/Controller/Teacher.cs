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
    public class Teacher
    {
        public static void ShowAllTeachers
            (SqlConnection sqlConnection, SqlDataAdapter sqlDataAdapter, DataGridView dataGridViewSchools)
        {
            sqlDataAdapter = new SqlDataAdapter
                ("SELECT Teachers.Name AS Imię, Surname AS Nazwisko, Subjects.name AS Przedmiot, StreetAndNumber AS Adres, City AS Miasto, Schools.name AS Szkoła FROM Teachers JOIN Address ON Teachers.AddressID = Address.ID JOIN Schools ON Teachers.SchoolID = Schools.ID JOIN Subjects ON Teachers.SubjectID=Subjects.ID", sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridViewSchools.DataSource = dataTable;
        }
       
        public static void ShowTeachersWorkingAtSelectedSchool
            (SqlConnection sqlConnection, SqlDataAdapter sqlDataAdapter, DataGridView dataGridViewSchools,
            TextBox textBoxSchoolName)
        {
            string schoolName;
            schoolName = textBoxSchoolName.Text; //przypisanie wartości textBoxa pod zmienną
            sqlDataAdapter = new SqlDataAdapter
                ("SELECT Teachers.Name AS Imię, Surname AS Nazwisko, Schools.Name AS Szkoła FROM Teachers JOIN Schools ON Teachers.SchoolID = Schools.ID WHERE Schools.Name = '" + schoolName + "'", sqlConnection);
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
    }
}
