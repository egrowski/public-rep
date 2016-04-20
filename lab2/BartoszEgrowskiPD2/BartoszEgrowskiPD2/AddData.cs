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
        private FormMain _parent { get; set; }
        public AddData(FormMain parent)
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
            _parent.listOfBooks.Add(new Book(textBoxTitle.Text, textBoxAuthor.Text, comboBoxRating.Text));
            _parent.dataGridViewListOfBooks.DataSource = null;
            _parent.dataGridViewListOfBooks.DataSource = _parent.listOfBooks;
            Close();
        }

        private void buttonAddCover_Click(object sender, EventArgs e)
        {           
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _parent.pictureBoxCover.ImageLocation = openFileDialog.FileName;  
              
            }
        }
    }
}
