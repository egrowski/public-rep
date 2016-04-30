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
    public class Parents
    {
        public static void ShowParentsOfSelectedStudent
            (SqlConnection sqlConnection, SqlDataAdapter sqlDataAdapter, DataGridView dataGridViewSchools,
            TextBox textBoxStudentName, TextBox textBoxStudentSurname)
        {
            string name;
            string surname;
            name = textBoxStudentName.Text;
            surname = textBoxStudentSurname.Text;
            sqlDataAdapter = new SqlDataAdapter
                ("SELECT Parents.Name AS Imię, Parents.Surname AS Nazwisko, StreetAndNumber AS Adres, City AS Miasto FROM Parents JOIN Address ON Parents.AddressID = Address.ID JOIN StudentParents ON Parents.ID=StudentParents.ParentID JOIN Students ON StudentParents.StudentID = Students.ID WHERE students.Name = '" + name + "' AND students.Surname = '" + surname + "'", sqlConnection);
            DataTable dataTable = new DataTable();
            if (!(textBoxStudentName.Text == "" || textBoxStudentSurname.Text == ""))
            {
                sqlDataAdapter.Fill(dataTable);
                dataGridViewSchools.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Wpisz imię i nazwisko ucznia!");
            }
        }
    }
}
