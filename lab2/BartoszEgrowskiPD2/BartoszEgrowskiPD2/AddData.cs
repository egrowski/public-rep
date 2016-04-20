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
        private Book _currentBook { get; set; }
        private FormMain _parent { get; set; }
        public AddData(FormMain parent)
        {
            _parent = parent;
            _currentBook = new Book();
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            _currentBook.author = textBoxAuthor.Text;
            _currentBook.description = textBoxDescription.Text;
            _currentBook.title = textBoxTitle.Text;

            _parent.AddBook(_currentBook);
            Close();
        }

        private void buttonAddCover_Click(object sender, EventArgs e)
        {           
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _currentBook.CoverPath = openFileDialog.FileName;  
              
            }
        }
    }
}
