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
        private List<Book> _listOfBooks { get; set; }
        public FormMain()
        {
            _listOfBooks = new List<Book>();
            InitializeComponent();

            dataGridViewListOfBooks.DataSource = null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddData addData = new AddData(this);
            addData.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewListOfBooks.SelectedRows)
            {
                dataGridViewListOfBooks.Rows.RemoveAt(item.Index);
            }
        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("ksiazki.txt");
            for (int i = 0; i < (dataGridViewListOfBooks.RowCount - 1); i++)
            {
                for (int j = 0; j < 3; j++)
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
                StreamReader streamReader = new StreamReader("ksiazki.txt");
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

        public void AddBook(Book book)
        {
            _listOfBooks.Add(book);
            dataGridViewListOfBooks.DataSource = null;
            dataGridViewListOfBooks.DataSource = _listOfBooks;
        }

        private void dataGridViewListOfBooks_SelectionChanged(object sender, EventArgs e)
        {
            var grid = sender as DataGridView;
            if (grid.SelectedRows.Count > 0)
            {
                var idx = grid.CurrentRow.Index;
                if (idx < _listOfBooks.Count)
                {
                    var currentBook = _listOfBooks[idx];

                    pictureBoxCover.ImageLocation = currentBook.CoverPath;
                    textBoxDescription.Text = currentBook.description;
                }
                
            }
        }
    }
}
