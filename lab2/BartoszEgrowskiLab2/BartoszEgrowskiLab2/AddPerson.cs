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
    public partial class AddPerson : Form
    {
        private FormMain _parent { get; set; }

        public AddPerson(FormMain parent)
        {
            _parent = parent;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            int ageTypeCheck;
            bool isAgeNumerical = int.TryParse(textBoxAge.Text, out ageTypeCheck);
            if (textBoxName.Text != "" && textBoxSurname.Text != "" && isAgeNumerical)
            {
                _parent.listOfPeople.Add(new Person(this.textBoxName.Text, this.textBoxSurname.Text, int.Parse(this.textBoxAge.Text)));
                _parent.dataGridViewListOfPeople.DataSource = null;
                _parent.dataGridViewListOfPeople.DataSource = _parent.listOfPeople;
                Close();
            }
            else
                MessageBox.Show("Uzupełnij właściwie pola: imię, nazwisko i wiek!");          
        }
    }
}
