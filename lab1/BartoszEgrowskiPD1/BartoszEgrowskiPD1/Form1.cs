﻿using System;
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
                    if (textBoxResult.Text == "0")
                    {
                        DivideByZero divideByZero = new DivideByZero();
                        divideByZero.Show();
                    }
                    else
                    textBoxResult.Text = (resultValue / double.Parse(textBoxResult.Text)).ToString();
                    break;
                case "%":
                    textBoxResult.Text = (resultValue % double.Parse(textBoxResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = double.Parse(textBoxResult.Text);
            operationPerformed = "";
            labelResult.Text = "";
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "1":
                    buttonOne.PerformClick();                 
                    break;
                case "2":
                    buttonTwo.PerformClick();
                    break;
                case "3":
                    buttonThree.PerformClick();
                    break;
                case "4":
                    buttonFour.PerformClick();
                    break;
                case "5":
                    buttonFive.PerformClick();
                    break;
                case "6":
                    buttonSix.PerformClick();
                    break;
                case "7":
                    buttonSeven.PerformClick();
                    break;
                case "8":
                    buttonEight.PerformClick();
                    break;
                case "9":
                    buttonNine.PerformClick();
                    break;
                case "0":
                    buttonZero.PerformClick();
                    break;
                case "+":
                    buttonPlus.PerformClick();
                    break;
                case "-":
                    buttonMinus.PerformClick();
                    break;
                case "*":
                    buttonMultiplication.PerformClick();
                    break;
                case "/":
                    buttonDiv.PerformClick();
                    break;
                case "%":
                    buttonModulo.PerformClick();
                    break;
                case ",":
                    buttonComma.PerformClick();
                    break;
                case ".":
                    buttonComma.PerformClick();
                    break;
                /* case "Enter":
                     buttonEqual.PerformClick();
                     break;
                 case "back":
                     buttonClear.PerformClick();
                     break;                          */
                default:
                    break;
            }
        }

        private void buttonNegative_Click(object sender, EventArgs e)
        {
            double negative = double.Parse(textBoxResult.Text) * (-1);
            textBoxResult.Text = negative.ToString();
        }
    }
}
