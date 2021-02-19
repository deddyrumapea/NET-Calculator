using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        string numInput = "", numFirst = "", numSecond = "";
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            labelDisplay.Text += "1";
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            labelDisplay.Text += "2";
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            labelDisplay.Text += "3";
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            labelDisplay.Text += "4";
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            labelDisplay.Text += "5";
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            labelDisplay.Text += "6";
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            labelDisplay.Text += "7";
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            labelDisplay.Text += "8";
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            labelDisplay.Text += "9";
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            labelDisplay.Text += "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            operation = '+';
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            operation = '.';
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            operation = '-';
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            operation = '*';
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            operation = '/';
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            operation = '=';
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            operation = 'C';
        }

        private void buttonClearEntry_Click(object sender, EventArgs e)
        {
            operation = 'CE';
        }
    }
}
