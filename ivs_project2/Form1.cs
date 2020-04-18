using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ivs_project2
{
    public partial class Form1 : Form
    {




        //
        // Inicializing variables
        //

        // result - variable, which contains the result of calculacions
        double result = 0;

        // operation - contains char, which symbolises mathematical operation, being held on the calculator 
        int operation = '0';

        // tmp - contains the result of previous calculations
        double tmp = 0;

        // wasInput - is necessary to determine calculator's status
        bool wasInput = true;





        //
        // Form inicialization
        //
        public Form1()
        {
            InitializeComponent();
        }





        // 
        // Section with events caused by pushing buttons
        // 

        // button_n_Click - methods - events handlers when pushing the buttons representing numbers
        public void button_1_Click(object sender, EventArgs e)
        {
            buttonInts(1);
        }

        public void button_2_Click(object sender, EventArgs e)
        {
            buttonInts(2);
        }

        public void button_3_Click(object sender, EventArgs e)
        {
            buttonInts(3);
        }

        public void button_4_Click(object sender, EventArgs e)
        {
            buttonInts(4);
        }

        public void button_5_Click(object sender, EventArgs e)
        {
            buttonInts(5);
        }

        public void button_6_Click(object sender, EventArgs e)
        {
            buttonInts(6);
        }

        public void button_7_Click(object sender, EventArgs e)
        {
            buttonInts(7);
        }

        public void button_8_Click(object sender, EventArgs e)
        {
            buttonInts(8);
        }

        public void button_9_Click(object sender, EventArgs e)
        {
            buttonInts(9);
        }

        public void button_0_Click(object sender, EventArgs e)
        {
            buttonInts(0);
        }
        //


        // Processing event of pushing the button representing comma ','
        public void button_dot_Click(object sender, EventArgs e)
        {
            buttonInts(',');
        }


        //  Processing event of pushing the sign change button '+/-'
        public void button_sign_Click(object sender, EventArgs e)
        {
            buttonInts('-');

        }



        //  Processing event of pushing the button representing input/output screen clearing 'C'
        public void button_delete_Click(object sender, EventArgs e)
        {
            buttonInts(-1);
            result = 0;
            operation = '0';
            tmp = 0;
            wasInput = true;
        }


        //  Processing event of pushing the button representing backspace '<'
        public void button_remove_Click(object sender, EventArgs e)
        {
            buttonInts(-2);
        }

        // !!!!!!!!!!!!!!!!!!!! ДОДЕЛАТЬ !!!!!!!!!!!!!!!!!!!!
        // Processing input from keyboard
        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ('0' <= e.KeyValue && e.KeyValue <= '9')
                buttonInts(e.KeyValue - 48);
            else if (e.KeyValue == 8)
                buttonInts(-2);
            else if (e.KeyValue == 'c' || e.KeyValue == 'C')
                buttonInts(-1);
            else if (e.KeyValue == '+')
                this.button_plus_Click(sender, e);
            else if (e.KeyValue == '-')
                this.button_minus_Click(sender, e);
            else if (e.KeyValue == '*')
                this.button_multiply_Click(sender, e);
            else if (e.KeyValue == '/')
                this.button_divide_Click(sender, e);
            else if (e.KeyValue == '=')
                this.button_equal_Click(sender, e);
        }


        // Processing event of pushing the buttons representing mathematical operations 
        public void button_plus_Click(object sender, EventArgs e)
        {
            operationButtonController('+');
        }

        public void button_minus_Click(object sender, EventArgs e)
        {
            operationButtonController('-');
        }

        public void button_multiply_Click(object sender, EventArgs e)
        {
            operationButtonController('*');
        }

        public void button_divide_Click(object sender, EventArgs e)
        {
            operationButtonController('/');

        }

        public void button_degree_Click(object sender, EventArgs e)
        {
            operationButtonController('^');
        }
        public void button_radical_Click(object sender, EventArgs e)
        {
            operationButtonController('√');
        }

        public void button_percent_Click(object sender, EventArgs e)
        {
            operationButtonController('%');
        }

        // Processing event of pushing the button representing factorial
        // This method represents a different pattern, because factorial is unary operator 
        public void button_factorial_Click(object sender, EventArgs e)
        {
            if (!label_result.Text.Equals("..."))
            {
                result = factorial(Convert.ToDouble(label_result.Text));
                label_result.Text = result.ToString();
                operation = '!';
            }
        }


        // Processing event of pushing the button representing equal sign '='
        public void button_equal_Click(object sender, EventArgs e)
        {
            if (operation == '+')
            {
                if (wasInput)
                {
                    tmp = Convert.ToDouble(label_result.Text);
                    result += Convert.ToDouble(label_result.Text);
                    label_result.Text = result.ToString();
                    wasInput = false;
                }
                else
                {
                    result += tmp;
                    label_result.Text = result.ToString();
                }
            }


            else if (operation == '-')
            {
                if (wasInput)
                {
                    tmp = Convert.ToDouble(label_result.Text);
                    result -= Convert.ToDouble(label_result.Text);
                    label_result.Text = result.ToString();
                    wasInput = false;
                }
                else
                {
                    result -= tmp;
                    label_result.Text = result.ToString();
                }
            }


            else if (operation == '*')
            {
                if (wasInput)
                {
                    tmp = Convert.ToDouble(label_result.Text);
                    result *= Convert.ToDouble(label_result.Text);
                    label_result.Text = result.ToString();
                    wasInput = false;
                }
                else
                {
                    result *= tmp;
                    label_result.Text = result.ToString();
                }
            }


            else if (operation == '/')
            {
                if (wasInput)
                {
                    tmp = Convert.ToDouble(label_result.Text);
                    result /= Convert.ToDouble(label_result.Text);
                    label_result.Text = result.ToString();
                    wasInput = false;
                }
                else
                {
                    result /= tmp;
                    label_result.Text = result.ToString();
                }
            }


            else if (operation == '^')
            {
                if (wasInput)
                {
                    tmp = Convert.ToDouble(label_result.Text);
                    if (result >= 0 || (result < 0 && (Convert.ToDouble(label_result.Text) >= 1 || Convert.ToDouble(label_result.Text) <= 0)))
                    {
                        result = Math.Pow(result, Convert.ToDouble(label_result.Text));
                        label_result.Text = result.ToString();
                        wasInput = false;
                    }
                    else
                    {
                        label_result.Text = "Error";
                        result = 0;
                        operation = '0';
                        tmp = 0;
                        wasInput = true;
                        return;
                    }
                }
                else
                {
                    if (result >= 0 || (result < 0 && tmp >= 1 || tmp <= 0))
                    {
                        result = Math.Pow(result, tmp);
                        label_result.Text = result.ToString();
                    }
                    else
                    {
                        label_result.Text = "Error";
                        result = 0;
                        operation = '0';
                        tmp = 0;
                        wasInput = true;
                        return;
                    }
                }
            }


            else if (operation == '√')
            {
                if (wasInput)
                {
                    tmp = Convert.ToDouble(label_result.Text);

                    if (result < 0 && Convert.ToDouble(label_result.Text) % 2 == 1)
                        result = Math.Sign(result) * Math.Pow(Math.Abs(result), 1 / Convert.ToDouble(label_result.Text));
                    else if (result < 0 && Convert.ToDouble(label_result.Text) % 2 != 1)
                    {
                        label_result.Text = "Error";
                        result = 0;
                        operation = '0';
                        tmp = 0;
                        wasInput = true;
                        return;
                    }
                    else
                        result = Math.Pow(result, 1 / Convert.ToDouble(label_result.Text));

                    label_result.Text = result.ToString();
                    wasInput = false;
                }
                else
                {
                    if (result < 0 && tmp % 2 == 1)
                        result = Math.Sign(result) * Math.Pow(Math.Abs(result), 1 / tmp);
                    else if (result < 0 && tmp % 2 != 1)
                    {
                        label_result.Text = "Error";
                        result = 0;
                        operation = '0';
                        tmp = 0;
                        wasInput = true;
                        return;
                    }
                    else
                        result = Math.Pow(result, 1 / tmp);
                
                    label_result.Text = result.ToString();
                }
            }


            else if (operation == '%')
            {
                if (wasInput)
                {
                    tmp = Convert.ToDouble(label_result.Text);
                    result = result / 100 * Convert.ToDouble(label_result.Text);
                    label_result.Text = result.ToString();
                    wasInput = false;
                }
                else
                {
                    result = result / 100 * tmp;
                    label_result.Text = result.ToString();
                }
            }
        }





        //
        // Functions sections
        //

        // Is activated by pushing the buttons representing mathematical operations
        // Accepts '+', '-', '*', '/', '%', '^', '√'
        public void operationButtonController(int op)
        {
            // Option 1:
            // Calculator is in it's initial state
            // User has entered just the first number and has pushed one of the buttons representing mathematical operations
            if (operation == '0')
            {
                if (!label_result.Text.Equals("...") && !label_result.Text.Equals("Error"))
                {
                    result += Convert.ToDouble(label_result.Text);
                    tmp = result;
                    wasInput = false;
                    operation = op;
                }
            }
            // Option 2:
            // An operation has already been held and user has entered a new number for calculations
            else if ((operation != '0') && wasInput)
            {
                operationController(operation);

                tmp = result;
                operation = op;
                wasInput = false;
                label_result.Text = result.ToString();
            }
            // Option 3;
            // An operation has already been held and user has not entered a new number for calculations
            else if ((operation != '0') && !wasInput)
            {
                tmp = result;
                operation = op;
            }

        }


        // Performs necessary mathematical operation according to the variable "op"
        // Accepts '+', '-', '*', '/', '%', '^', '√'
        public void operationController(int op)
        {
            if (op == '-')
                result -= Convert.ToDouble(label_result.Text);
            else if (op == '+')
                result += Convert.ToDouble(label_result.Text);
            else if (op == '*')
                result *= Convert.ToDouble(label_result.Text);
            else if (op == '/')
                result /= Convert.ToDouble(label_result.Text);
            else if (op == '^')
            {
                if (result > 0 || (result < 0 && (Convert.ToDouble(label_result.Text) >= 1 || Convert.ToDouble(label_result.Text) <= 0)))
                {
                    result = Math.Pow(result, Convert.ToDouble(label_result.Text));
                }
                else
                {
                    label_result.Text = "Error";
                    result = 0;
                    operation = '0';
                    tmp = 0;
                    wasInput = true;
                    return;
                }
            }
            else if (op == '√')
            {
                if (result < 0 && Convert.ToDouble(label_result.Text) % 2 == 1)
                    result = Math.Sign(result) * Math.Pow(Math.Abs(result), 1 / Convert.ToDouble(label_result.Text));
                else if (result < 0 && Convert.ToDouble(label_result.Text) % 2 != 1)
                {
                    label_result.Text = "Error";
                    result = 0;
                    operation = '0';
                    tmp = 0;
                    wasInput = true;
                    return;
                }
                else
                    result = Math.Pow(result, 1 / Convert.ToDouble(label_result.Text));
            }
            else if (op == '%')
                result = result / 100 * Convert.ToDouble(label_result.Text);
        }


        // Function outputting to the panel the results of calculations and processing requests for output
        // !!!!!!!!!!!!!!!!!!!!! ДОПИСАТЬ КОММЕНТАРИИ, РЕФАКТОРИНГ КОДА !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public void buttonInts(int value)
        {
            

            // Processing sign change
            if (value == '-')
            {
                if (!label_result.Text.Equals("..."))
                {
                    if (label_result.Text[0] == '-')
                        label_result.Text = label_result.Text.Remove(0, 1);
                    else
                        label_result.Text = label_result.Text.Insert(0, "-");
                }

                return;
            }


            // In case of pushing a mathematical operation button, and if after this event user has not entered data, clears information on panel and begins input on a empty line
            if (!wasInput)
            {
                label_result.Text = "...";
                wasInput = true;
            }

            // Processing Remove
            if (value == -2)
            {
                if (label_result.Text.Equals("..."))
                {
                    label_result.Text = "...";
                    return;
                }
                else if (label_result.Text.Equals("Error"))
                {
                    label_result.Text = "...";
                    return;
                }

                label_result.Text = label_result.Text.Remove(label_result.Text.Length - 1);

                if (label_result.Text.Length == 0)
                {
                    result = 0;
                    operation = '0';
                    tmp = 0;
                    wasInput = true;
                    label_result.Text = "...";
                    return;
                }
                return;
            }

            // Processing  Delete
            else if (value == -1)
            {
                label_result.Text = "...";
                return;
            }



            // Processing numbers or ','
            if (label_result.Text.Length <= 9)
            {
                // Float point setting
                if (value == ',')
                {
                    if (!label_result.Text.Equals("...") && !label_result.Text.Equals("Error"))
                        label_result.Text += ",";
                    else
                        wasInput = false;
                }

                // Processing numbers
                else
                {
                    if (label_result.Text.Equals("...") || label_result.Text.Equals("Error"))
                        label_result.Text = value.ToString();
                    else
                        label_result.Text += value.ToString();
                }
            }
            return;
        }


        // Factorial function
        static double factorial(double N)
        {
            if (N < 0) // in case of entering a negative number
                return 0; // returns 0
            if (N == 0) // in case of entering 0,
                return 1; // returns the factorial of 0 (= 1)
            else // in other cases
                return N * factorial(N - 1); // performing recursion
        }
    }
}
