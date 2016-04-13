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
    public partial class FormNewWindow : Form
    {
        public int lastNumber;
        public FormNewWindow()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            textBoxShow.Text = lastNumber.ToString();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Int32.Parse(textBoxShow.Text); i++)
            {
                textBoxDraw.Text += Environment.NewLine;
                for (int j = 0; j < i; j++)
                {
                    textBoxDraw.Text += i.ToString();

                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
