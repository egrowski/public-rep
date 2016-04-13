using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BartoszEgrowskiLab1
{
    public partial class Form1 : Form
    {
        int number = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //   number += 7;
            // if (number < 50)
            //   {
            // textBoxOpen.Text = number.ToString();
            // }
            //else
            // {
            //    BackColor = Color.Black;
            //}
            // MessageBox.Show("wartosc: " + textBoxOpen.Text);

            FormNewWindow formNewWindow = new FormNewWindow();
           // formNewWindow.lastNumber;
            int a = 0;
            Int32.TryParse(textBoxOpen.Text, out a);
            formNewWindow.lastNumber = a;
            formNewWindow.ShowDialog(); 
        }

    }
}
