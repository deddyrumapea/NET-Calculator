using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private string numInput = "", operation = "";
        private double numFirst, numSecond;

        public Form1()
        {
            InitializeComponent();
        }

        private void updateMainDisplay(string text)
        {
            labelMainDisplay.Text = text;
        }

        private void updateSecondDisplay(string text)
        {
            labelSecondDisplay.Text = text;
        }

        private void clearEntry()
        {
            numInput = "";
            updateMainDisplay("0");
            buttonDecimal.Enabled = true;
        }

        private void allClear()
        {
            clearEntry();
            updateSecondDisplay("");
            operation = "";
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            if(numInput.Length < 12)
            { 
                numInput += (sender as Button).Text;
                updateMainDisplay(numInput);
            }
        }

        private void buttonOperation_Click(object sender, EventArgs e)
        {
            if (numInput == "") return;
            if (operation == "") numFirst = Convert.ToDouble(numInput);
            operation = (sender as Button).Text;
            updateSecondDisplay(numFirst + operation);
            clearEntry();
        }
        
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            // Check if the number is already fractional
            if (numInput != "" && Convert.ToDouble(numInput) % 1 != 0) return;

            numInput = labelMainDisplay.Text + ".";
            updateMainDisplay(numInput);
        }


        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (operation == "" || numInput == "") return; // Skip if there is no operation set
            
            numSecond = Convert.ToDouble(numInput);
            double result = 0.0;

            switch (operation)
            {
                case "+": result = numFirst + numSecond;
                    break;
                case "-": result = numFirst - numSecond;
                    break;
                case "×": result = numFirst * numSecond;
                    break;
                case "÷": result = numFirst / numSecond;
                    break;
                default: result = 0.0;
                    break;
            }

            // Update displays
            updateMainDisplay(Convert.ToString(result));
            updateSecondDisplay(numFirst + operation + numSecond);

            // Update numFirst and numInput
            numFirst = result;
            numInput = Convert.ToString(numFirst);

            // Reset operation
            operation = "";
        }

        private void buttonInverse_Click(object sender, EventArgs e)
        {
            if (numInput == "") return;
            if (numInput[0] != '-')
            {
                numInput = "-" + numInput;
            } else
            {
                numInput = numInput.Substring(1);
            }
            updateMainDisplay(numInput);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            allClear();
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int i;
            if (int.TryParse(e.KeyChar.ToString(), out i))
            {
                if (numInput.Length < 12)
                {
                    numInput += i;
                    updateMainDisplay(numInput);
                }
            }
        }
    }
}