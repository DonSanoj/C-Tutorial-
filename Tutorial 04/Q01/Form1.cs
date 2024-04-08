//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Q01
//{
//    public partial class Form1 : Form
//    {
//        public Form1()
//        {
//            InitializeComponent();
//            numerInputs.KeyPress += numberInputs_KeyPress;
//        }

//        private void numberInputs_KeyPress(object sender, KeyPressEventArgs e)
//        {
//            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
//            {
//                // Cancel non-numeric characters
//                e.Handled = true;
//            }
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q01
{
    public partial class Form1 : Form
    {
        private bool allowNonNumericInput = false;

        public Form1()
        {
            InitializeComponent();
            numberInputs.KeyPress += numberInputs_KeyPress;
        }

        string calTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void numberInputs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!allowNonNumericInput)
            {
                // Check if the pressed key is a digit or a control character (like Backspace or Delete)
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    // Cancel non-numeric characters
                    e.Handled = true;
                }
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            numberInputs.Text += "0";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            numberInputs.Text += ".";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            numberInputs.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            numberInputs.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            numberInputs.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            numberInputs.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            numberInputs.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            numberInputs.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            numberInputs.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            numberInputs.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            numberInputs.Text += "9";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            numberInputs.Text = "";
        }

        private void btnPluseorMinus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(numberInputs.Text))
            {
                if (int.TryParse(numberInputs.Text, out int currentValue))
                {
                    currentValue = -currentValue;
                    numberInputs.Text = currentValue.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid number format");
                }
            }
        }

        private void btnPluse_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(numberInputs.Text);

            numberInputs.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(numberInputs.Text);

            numberInputs.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(numberInputs.Text);

            numberInputs.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(numberInputs.Text);

            numberInputs.Clear();
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            numberInputs.Text += "%";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(numberInputs.Text);
            numberInputs.Clear();

            if (option.Equals("+"))
            {
                result = num1 + num2;
            }
            else if (option.Equals("-"))
            {
                result = num1 - num2;
            }
            else if (option.Equals("*"))
            {
                result = num1 * num2;
            }
            else if (option.Equals("/"))
            {
                if (num2 == 0)
                {
                    numberInputs.Text = "Error";
                }
                else
                {
                    result = num1 / num2;
                }
            }

            numberInputs.Text += result;
        }
    }
}

