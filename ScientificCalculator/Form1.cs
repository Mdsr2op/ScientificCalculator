using System;
using System.Windows.Forms;

namespace ScientificCalculator
{
    public partial class Calculator : Form
    {
        private double result = 0;
        private string operation = "";
        private bool isOperationPerformed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (txtDisplay.Text == "0" || isOperationPerformed)
                txtDisplay.Clear();

            isOperationPerformed = false;
            txtDisplay.Text += button.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!isOperationPerformed)
            {
                btnEquals_Click(sender, e);
            }
            operation = button.Text;
            result = double.Parse(txtDisplay.Text);
            isOperationPerformed = true;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double secondOperand;
            if (!double.TryParse(txtDisplay.Text, out secondOperand))
            {
                MessageBox.Show("Invalid input.");
                return;
            }
            try
            {
                switch (operation)
                {
                    case "+":
                        txtDisplay.Text = (result + secondOperand).ToString();
                        break;
                    case "-":
                        txtDisplay.Text = (result - secondOperand).ToString();
                        break;
                    case "*":
                        txtDisplay.Text = (result * secondOperand).ToString();
                        break;
                    case "/":
                        if (secondOperand == 0)
                            throw new DivideByZeroException();
                        txtDisplay.Text = (result / secondOperand).ToString();
                        break;
                    case "^":
                        txtDisplay.Text = Math.Pow(result, secondOperand).ToString();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            isOperationPerformed = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
            operation = "";
            isOperationPerformed = false;
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtDisplay.Text);
            if (num < 0)
            {
                MessageBox.Show("Invalid input for square root.");
            }
            else
            {
                txtDisplay.Text = Math.Sqrt(num).ToString();
            }
            isOperationPerformed = true;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtDisplay.Text);
            if (num <= 0)
            {
                MessageBox.Show("Logarithm is undefined for zero or negative numbers.");
            }
            else
            {
                txtDisplay.Text = Math.Log10(num).ToString();
            }
            isOperationPerformed = true;
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtDisplay.Text);
            double radians = num * Math.PI / 180;
            txtDisplay.Text = Math.Sin(radians).ToString();
            isOperationPerformed = true;
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtDisplay.Text);
            double radians = num * Math.PI / 180;
            txtDisplay.Text = Math.Cos(radians).ToString();
            isOperationPerformed = true;
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double num = double.Parse(txtDisplay.Text);
            double radians = num * Math.PI / 180;
            txtDisplay.Text = Math.Tan(radians).ToString();
            isOperationPerformed = true;
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(txtDisplay.Text, out num))
            {
                if (num < 0)
                {
                    MessageBox.Show("Factorial is not defined for negative numbers.");
                }
                else
                {
                    txtDisplay.Text = Factorial(num).ToString();
                }
            }
            else
            {
                MessageBox.Show("Invalid input for factorial. Enter an integer.");
            }
            isOperationPerformed = true;

        }

        private long Factorial(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }
}
