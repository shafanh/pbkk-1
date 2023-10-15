using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((output_tb.Text == "0") || (isOperationPerformed))
                output_tb.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!output_tb.Text.Contains("."))
                    output_tb.Text = output_tb.Text + button.Text;

            }
            else
                output_tb.Text = output_tb.Text + button.Text;
        }

        private void operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                eq_b.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(output_tb.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }   
        }

        private void button4_click(object sender, EventArgs e)
        {
            output_tb.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            output_tb.Text = "0";
            resultValue = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    output_tb.Text = (resultValue + Double.Parse(output_tb.Text)).ToString();
                    break;
                case "-":
                    output_tb.Text = (resultValue - Double.Parse(output_tb.Text)).ToString();
                    break;
                case "*":
                    output_tb.Text = (resultValue * Double.Parse(output_tb.Text)).ToString();
                    break;
                case "/":
                    output_tb.Text = (resultValue / Double.Parse(output_tb.Text)).ToString();
                    break;
                default:
                    break;
            }

            resultValue = Double.Parse(output_tb.Text);
            labelCurrentOperation.Text = "";
        }

    }
}
