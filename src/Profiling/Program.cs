using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
 *  @file Program.cs
 *  The file contains profiling program for math library.
 *  @authors Pastushenko Vladislav
 *  @date April 2020
 */


namespace Profiling
{
    class Program
    {
        static void Main(string[] args)
        {

           
            ivs_project2.Form1 profilingForm = new ivs_project2.Form1();
            EventArgs e = new EventArgs();

            // Put information from stdin to variable data
            int symb = Console.Read();
            string data = "";
            for ( ; symb > -1; symb = Console.Read())
            {
                data += (char)symb;

                if (symb == '$')
                    break;
            }
            data += '$';
            

            // Variable N will contain quantity of numbers in stdin
            int N = 0;
            bool skip = false;
            for (int i = 0; i < data.Length; i++)
            {
                bool wasInput = input(data[i], profilingForm, e);

                if (!wasInput && !skip)
                {
                    N++;
                    profilingForm.button_plus_Click(profilingForm, e);
                    skip = true;
                }
                else if (wasInput)
                    skip = false;
            }
            




            profilingForm.button_degree_Click(profilingForm, e);
            profilingForm.button_2_Click(profilingForm, e);
            profilingForm.button_equal_Click(profilingForm, e);

            string operand1 = profilingForm.label_result.Text;

            profilingForm.button_delete_Click(profilingForm, e);


            skip = false;
            for (int i = 0; i < data.Length; i++)
            {
                bool wasInput = input(data[i], profilingForm, e);

                if (!wasInput && !skip)
                {
                    profilingForm.button_plus_Click(profilingForm, e);
                    skip = true;
                }
                else if (wasInput)
                    skip = false;
            }



            profilingForm.button_divide_Click(profilingForm, e);
            for (int i = 0; i < N.ToString().Length; i++)
                input(N.ToString()[i], profilingForm, e);

            profilingForm.button_equal_Click(profilingForm, e);


            profilingForm.button_degree_Click(profilingForm, e);
            profilingForm.button_2_Click(profilingForm, e);
            profilingForm.button_equal_Click(profilingForm, e);


            profilingForm.button_multiply_Click(profilingForm, e);
            for (int i = 0; i < N.ToString().Length; i++)
                input(N.ToString()[i], profilingForm, e);
            profilingForm.button_equal_Click(profilingForm, e);

            string operand2 = profilingForm.label_result.Text;
            profilingForm.button_delete_Click(profilingForm, e);



            for (int i = 0; i < operand1.ToString().Length; i++)
                input(operand1.ToString()[i], profilingForm, e);

            profilingForm.button_minus_Click(profilingForm, e);
            for (int i = 0; i < operand2.ToString().Length; i++)
                input(operand2.ToString()[i], profilingForm, e);

            profilingForm.button_equal_Click(profilingForm, e);

            profilingForm.button_divide_Click(profilingForm, e);
            for (int i = 0; i < (N-1).ToString().Length; i++)
                input((N-1).ToString()[i], profilingForm, e);
            profilingForm.button_equal_Click(profilingForm, e);

            profilingForm.button_radical_Click(profilingForm, e);
            profilingForm.button_2_Click(profilingForm, e);
            profilingForm.button_equal_Click(profilingForm, e);



            string result = profilingForm.label_result.Text;

            Console.WriteLine(result);
        }

        static bool input(char symb, ivs_project2.Form1 profilingForm, EventArgs e)
        {
            bool res = false;
            switch (symb)
            {
                case '0':
                    profilingForm.button_0_Click(profilingForm, e);
                    res = true;
                    break;
                case '1':
                    profilingForm.button_1_Click(profilingForm, e);
                    res = true;
                    break;
                case '2':
                    profilingForm.button_2_Click(profilingForm, e);
                    res = true;
                    break;
                case '3':
                    profilingForm.button_3_Click(profilingForm, e);
                    res = true;
                    break;
                case '4':
                    profilingForm.button_4_Click(profilingForm, e);
                    res = true;
                    break;
                case '5':
                    profilingForm.button_5_Click(profilingForm, e);
                    res = true;
                    break;
                case '6':
                    profilingForm.button_6_Click(profilingForm, e);
                    res = true;
                    break;
                case '7':
                    profilingForm.button_7_Click(profilingForm, e);
                    res = true;
                    break;
                case '8':
                    profilingForm.button_8_Click(profilingForm, e);
                    res = true;
                    break;
                case '9':
                    profilingForm.button_9_Click(profilingForm, e);
                    res = true;
                    break;
                case ',':
                    profilingForm.button_dot_Click(profilingForm, e);
                    res = true;
                    break;
                case '-':
                    profilingForm.button_0_Click(profilingForm, e);
                    profilingForm.button_sign_Click(profilingForm, e);
                    res = true;
                    break;
            }

            return res;
        }
    }
}
