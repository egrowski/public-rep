using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BartoszEgrowskiPD2
{

    public partial class AddData : Form
    {
        private Book currentBook { get; set; } 
        private FormMain parent { get; set; } //zmienna pomocnicza
        public AddData(FormMain parentSecondary)
        {
            parent = parentSecondary;
            currentBook = new Book(); //konstruktor bieżącego wpisu
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            currentBook.author = textBoxAuthor.Text;
            currentBook.description = textBoxDescription.Text;
            currentBook.title = textBoxTitle.Text;
            currentBook.rating = comboBoxRating.Text;
            //ustawienie wartości bieżącego wpisu jako dane wpisane w odpowiednich polach
            parent.AddBook(currentBook); //dodanie bieżącego wpisu do listy
            Close();
        }

        private void buttonAddCover_Click(object sender, EventArgs e)
        {           
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                currentBook.CoverPath = openFileDialog.FileName;    //otwarcie pliku z wybranej lokalizacji                
            }
        }
    }
}
