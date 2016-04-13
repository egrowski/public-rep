using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BartoszEgrowskiPD1
{
    public partial class FormCalc : Form
    {
        double resultValue = 0;
        string operationPerformed = "";
        bool isOperationPerformed = false;

        public FormCalc()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {            
            if ((textBoxResult.Text == "0") || (isOperationPerformed))
                textBoxResult.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ",")
            {
                if (!textBoxResult.Text.Contains(","))
                    textBoxResult.Text = textBoxResult.Text + button.Text;
            }
            else
            textBoxResult.Text = textBoxResult.Text + button.Text;          
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                buttonEqual.PerformClick();
                operationPerformed = button.Text;
                isOperationPerformed = true;
                labelResult.Text = resultValue + " " + operationPerformed;
            }
           
                operationPerformed = button.Text;
                resultValue = double.Parse(textBoxResult.Text);
                isOperationPerformed = true;
                labelResult.Text = resultValue + " " + operationPerformed;
                
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "0";
            resultValue = 0;
            labelResult.Text = "";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBoxResult.Text = (resultValue + double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "-":
                    textBoxResult.Text = (resultValue - double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "*":
                    textBoxResult.Text = (resultValue * double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "/":
                    textBoxResult.Text = (resultValue / double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "%":
                    textBoxResult.Text = (resultValue % double.Parse(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = double.Parse(textBoxResult.Text);
            labelResult.Text = "";
        }
    }
}
