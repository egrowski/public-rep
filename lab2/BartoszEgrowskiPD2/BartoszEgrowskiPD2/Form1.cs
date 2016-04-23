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

namespace BartoszEgrowskiPD2
{
    public partial class FormMain : Form
    {
        private BindingList<Book> listOfBooks { get; set; } //zadeklarowanie listy książek widocznej dla drugiego Form'a
        public FormMain()
        {
            listOfBooks = new BindingList<Book>(); //konstruktor listy książek
            InitializeComponent();

            dataGridViewListOfBooks.DataSource = null; //wyzerowanie listy
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddData addData = new AddData(this); 
            addData.Show(); //konstruktor i wyświetlenie nowego okna
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewListOfBooks.SelectedRows)
            {
                dataGridViewListOfBooks.Rows.RemoveAt(item.Index); //usunięcie wybranego wpisu z listy
                pictureBoxCover.Image = null; // usunięcie obrazka przypisanego do wybranego wpisu
            }
        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("books.txt");
            for (int i = 0; i < (dataGridViewListOfBooks.RowCount - 1); i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    streamWriter.Write(dataGridViewListOfBooks.Rows[i].Cells[j].Value + "|");
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
                StreamReader streamReader = new StreamReader("books.txt");
                string content = streamReader.ReadToEnd();
                int split = content.Split('\n').Length;
                for (int j = 0; j < split - 1; j++)
                {
                    dataGridViewListOfBooks.Rows.Add(content.Split('\n')[j].Split('|'));
                }
                streamReader.Close();
                }
                catch
                {
                MessageBox.Show("Nie znaleziono pliku!");
                }
        }

        public void AddBook(Book book) //funkcja podpowiadająca za dodanie książki do listy
        {
            listOfBooks.Add(book);
            dataGridViewListOfBooks.DataSource = null;
            dataGridViewListOfBooks.DataSource = listOfBooks;
        }

        private void dataGridViewListOfBooksSelectionChanged(object sender, EventArgs e) //zdarzenie odświeżające pictureBox i textBoxDescription przy kliknięciu na element listy 
        {
            var grid = sender as DataGridView;
            if (grid.SelectedRows.Count > 0)
            {
                var index = grid.CurrentRow.Index;
                if (index < listOfBooks.Count)
                {
                    var currentBook = listOfBooks[index];

                    pictureBoxCover.ImageLocation = currentBook.CoverPath;
                    textBoxDescription.Text = currentBook.description;
                }           
            }
        }
    }
}
