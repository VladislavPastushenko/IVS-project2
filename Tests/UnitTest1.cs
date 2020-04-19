using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tests


// ***************************************************

{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]

        // Tests of basic inputting
        public void EnteringTests()
        {
            // Creating of new object for testing
            ivs_project2.Form1 testedForm = new ivs_project2.Form1();
            EventArgs e = new EventArgs();

            // Controlling if current text on the panel is equal to '...'
            Assert.IsTrue(testedForm.label_result.Text.Equals("..."));

            // Emulation of clicking on buttons '1' and '2'
            testedForm.button_1_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);

            // Controlling if current text on the panel is equal to
            Assert.IsTrue(testedForm.label_result.Text.Equals("12"));

            testedForm.button_remove_Click(testedForm, e);

            Assert.IsTrue(testedForm.label_result.Text.Equals("1"));

            testedForm.button_2_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_4_Click(testedForm, e);
            testedForm.button_5_Click(testedForm, e);

            Assert.IsTrue(testedForm.label_result.Text.Equals("12345"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_6_Click(testedForm, e);
            testedForm.button_7_Click(testedForm, e);
            testedForm.button_8_Click(testedForm, e);
            testedForm.button_9_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);

            Assert.IsTrue(testedForm.label_result.Text.Equals("67890"));

            testedForm.button_remove_Click(testedForm, e);
            testedForm.button_remove_Click(testedForm, e);

            Assert.IsTrue(testedForm.label_result.Text.Equals("678"));


            testedForm.button_remove_Click(testedForm, e);
            testedForm.button_remove_Click(testedForm, e);
            testedForm.button_remove_Click(testedForm, e);

            Assert.IsTrue(testedForm.label_result.Text.Equals("..."));

        }

        [TestMethod]

        // Tests of plus
        // Created by Yahor Senichak
        public void PlusTests()
        {
            ivs_project2.Form1 testedForm = new ivs_project2.Form1();
            EventArgs e = new EventArgs();

            testedForm.button_2_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_plus_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("46"));

            testedForm.button_delete_Click(testedForm, e);


            testedForm.button_2_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_dot_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);

            testedForm.button_plus_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("46,23"));

            testedForm.button_delete_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_plus_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("0"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_2_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_sign_Click(testedForm, e);
            testedForm.button_plus_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("-1"));

        }

        [TestMethod]

        // Tests of minus
        // Created by Viktoryia Tomason
        public void MinusTests()
        {
            ivs_project2.Form1 testedForm = new ivs_project2.Form1();
            EventArgs e = new EventArgs();
            // Emulation of clicking on buttons '-' 
            testedForm.button_minus_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("..."));

            testedForm.button_minus_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("..."));

            testedForm.button_2_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_minus_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("0"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_7_Click(testedForm, e);
            testedForm.button_8_Click(testedForm, e);
            testedForm.button_dot_Click(testedForm, e);
            testedForm.button_9_Click(testedForm, e);
            testedForm.button_minus_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_dot_Click(testedForm, e);
            testedForm.button_9_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);

            Assert.IsTrue(testedForm.label_result.Text.Equals("78"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_minus_Click(testedForm, e);
            testedForm.button_minus_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("..."));

            testedForm.button_1_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_plus_Click(testedForm, e);
            testedForm.button_7_Click(testedForm, e);
            testedForm.button_minus_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("19"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_1_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_plus_Click(testedForm, e);
            testedForm.button_7_Click(testedForm, e);
            testedForm.button_sign_Click(testedForm, e);
            testedForm.button_plus_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("8"));

        }

        [TestMethod]

        // Tests of multiply
        // Created by Yahor Senichak
        public void MultiplyTests()
        {
            ivs_project2.Form1 testedForm = new ivs_project2.Form1();
            EventArgs e = new EventArgs();

            testedForm.button_2_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_multiply_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("529"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_2_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_multiply_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("0"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_2_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_dot_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_multiply_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("0"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_2_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_dot_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_multiply_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_dot_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_multiply_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("539,6329"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_8_Click(testedForm, e);
            testedForm.button_4_Click(testedForm, e);
            testedForm.button_multiply_Click(testedForm, e);
            testedForm.button_1_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_sign_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("-1008"));

        }

        [TestMethod]

        // Tests of divide
        // Created by Viktoryia Tomason
        public void DivideTests()
        {
            ivs_project2.Form1 testedForm = new ivs_project2.Form1();
            EventArgs e = new EventArgs();
            // Emulation of clicking on buttons '/' 
            testedForm.button_divide_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("..."));

            testedForm.button_divide_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("..."));

            testedForm.button_divide_Click(testedForm, e);
            testedForm.button_divide_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("..."));

            testedForm.button_remove_Click(testedForm, e);

            testedForm.button_7_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_divide_Click(testedForm, e);
            testedForm.button_9_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("8"));
            testedForm.button_divide_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("4"));
            testedForm.button_equal_Click(testedForm, e);//with equal
            testedForm.button_divide_Click(testedForm, e);
            testedForm.button_4_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("0,5"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_1_Click(testedForm, e);
            testedForm.button_5_Click(testedForm, e);
            testedForm.button_divide_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("1"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_0_Click(testedForm, e);
            testedForm.button_dot_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_5_Click(testedForm, e);
            testedForm.button_divide_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_dot_Click(testedForm, e);
            testedForm.button_1_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);

            Assert.IsTrue(testedForm.label_result.Text.Equals("0,5"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_4_Click(testedForm, e);
            testedForm.button_divide_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("∞"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_8_Click(testedForm, e);
            testedForm.button_5_Click(testedForm, e);
            testedForm.button_divide_Click(testedForm, e);
            testedForm.button_5_Click(testedForm, e);
            testedForm.button_plus_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("34"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_9_Click(testedForm, e);
            testedForm.button_1_Click(testedForm, e);
            testedForm.button_divide_Click(testedForm, e);
            testedForm.button_1_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_sign_Click(testedForm, e);
            testedForm.button_divide_Click(testedForm, e);
            testedForm.button_7_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("-1"));
        }


        [TestMethod]

        // Tests of degree
        // Created by Yahor Senichak
        public void DegreeTests()
        {
            ivs_project2.Form1 testedForm = new ivs_project2.Form1();
            EventArgs e = new EventArgs();

            testedForm.button_2_Click(testedForm, e);
            testedForm.button_degree_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("8"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_1_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_4_Click(testedForm, e);
            testedForm.button_degree_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("1"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_0_Click(testedForm, e);
            testedForm.button_degree_Click(testedForm, e);
            testedForm.button_9_Click(testedForm, e);
            testedForm.button_9_Click(testedForm, e);
            testedForm.button_9_Click(testedForm, e);
            testedForm.button_9_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("0"));


            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_0_Click(testedForm, e);
            testedForm.button_dot_Click(testedForm, e);
            testedForm.button_5_Click(testedForm, e);
            testedForm.button_degree_Click(testedForm, e);
            testedForm.button_1_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("0,0009765625"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_1_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_degree_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_dot_Click(testedForm, e);
            testedForm.button_5_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);

            Assert.IsTrue(testedForm.label_result.Text.Equals("10"));


            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_0_Click(testedForm, e);
            testedForm.button_dot_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_5_Click(testedForm, e);
            testedForm.button_degree_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_dot_Click(testedForm, e);
            testedForm.button_5_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("0,5"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_sign_Click(testedForm, e);
            testedForm.button_5_Click(testedForm, e);
            testedForm.button_degree_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("25"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_1_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_degree_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_sign_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("0,01"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_8_Click(testedForm, e);
            testedForm.button_1_Click(testedForm, e);
            testedForm.button_sign_Click(testedForm, e);
            testedForm.button_degree_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_dot_Click(testedForm, e);
            testedForm.button_5_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("Error"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_1_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_sign_Click(testedForm, e);
            testedForm.button_degree_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_dot_Click(testedForm, e);
            testedForm.button_1_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("Error"));

        }

        [TestMethod]

        // Tests of radical
        // Created by Viktoryia Tomason
        public void RadicalTests()
        {
            ivs_project2.Form1 testedForm = new ivs_project2.Form1();
            EventArgs e = new EventArgs();

            // Emulation of clicking on buttons '√'
            testedForm.button_radical_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("2"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_2_Click(testedForm, e);
            testedForm.button_5_Click(testedForm, e);
            testedForm.button_6_Click(testedForm, e);
            testedForm.button_radical_Click(testedForm, e);
            testedForm.button_4_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);

            // Controlling if current text on the panel is equal to
            Assert.IsTrue(testedForm.label_result.Text.Equals("4"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_8_Click(testedForm, e);
            testedForm.button_sign_Click(testedForm, e);
            testedForm.button_radical_Click(testedForm, e);
            testedForm.button_3_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);

            // Controlling if current text on the panel is equal to
            Assert.IsTrue(testedForm.label_result.Text.Equals("-2"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_4_Click(testedForm, e);
            testedForm.button_sign_Click(testedForm, e);
            testedForm.button_radical_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);

            // Controlling if current text on the panel is equal to
            Assert.IsTrue(testedForm.label_result.Text.Equals("Error"));

            testedForm.button_2_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_4_Click(testedForm, e);
            testedForm.button_8_Click(testedForm, e);
            testedForm.button_radical_Click(testedForm, e);
            testedForm.button_1_Click(testedForm, e);
            testedForm.button_1_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);

            // Controlling if current text on the panel is equal to
            Assert.IsTrue(testedForm.label_result.Text.Equals("2"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_2_Click(testedForm, e);
            testedForm.button_5_Click(testedForm, e);
            testedForm.button_radical_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_sign_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);

            // Controlling if current text on the panel is equal to//
            Assert.IsTrue(testedForm.label_result.Text.Equals("0,2"));        }

        [TestMethod]

        // Tests of percent
        // Created by Viktoryia Tomason
        public void PercentTests()
        {
            // Creating of new object for testing
            ivs_project2.Form1 testedForm = new ivs_project2.Form1();
            EventArgs e = new EventArgs();
            // Emulation of clicking on buttons '%'
            testedForm.button_percent_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("..."));

            testedForm.button_percent_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("..."));

            testedForm.button_6_Click(testedForm, e);
            testedForm.button_percent_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);

            // Controlling if current text on the panel is equal to
            Assert.IsTrue(testedForm.label_result.Text.Equals("1,2"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_9_Click(testedForm, e);
            testedForm.button_percent_Click(testedForm, e);
            testedForm.button_1_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);

            // Controlling if current text on the panel is equal to
            Assert.IsTrue(testedForm.label_result.Text.Equals("9"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_7_Click(testedForm, e);
            testedForm.button_percent_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_dot_Click(testedForm, e);
            testedForm.button_5_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);

            // Controlling if current text on the panel is equal to
            Assert.IsTrue(testedForm.label_result.Text.Equals("0,035"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_4_Click(testedForm, e);
            testedForm.button_percent_Click(testedForm, e);
            testedForm.button_1_Click(testedForm, e);
            testedForm.button_5_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);

            // Controlling if current text on the panel is equal to
            Assert.IsTrue(testedForm.label_result.Text.Equals("6"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_6_Click(testedForm, e);
            testedForm.button_percent_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("0,36"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_8_Click(testedForm, e);
            testedForm.button_sign_Click(testedForm, e);
            testedForm.button_percent_Click(testedForm, e);
            testedForm.button_2_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_equal_Click(testedForm, e);

            // Controlling if current text on the panel is equal to
            Assert.IsTrue(testedForm.label_result.Text.Equals("-1,6"));
        }

        [TestMethod]

        // Tests of factorial
        // Created by Yahor Senichak
        public void FactorialTests()
        {
            ivs_project2.Form1 testedForm = new ivs_project2.Form1();
            EventArgs e = new EventArgs();


            Assert.IsTrue(testedForm.label_result.Text.Equals("..."));

            testedForm.button_factorial_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("..."));
            testedForm.button_delete_Click(testedForm, e);


            testedForm.button_5_Click(testedForm, e);
            testedForm.button_factorial_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("120"));

            testedForm.button_delete_Click(testedForm, e);


            testedForm.button_1_Click(testedForm, e);
            testedForm.button_0_Click(testedForm, e);
            testedForm.button_factorial_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("3628800"));

            testedForm.button_delete_Click(testedForm, e);


            testedForm.button_0_Click(testedForm, e);
            testedForm.button_factorial_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("1"));

            testedForm.button_delete_Click(testedForm, e);

            
            testedForm.button_1_Click(testedForm, e);
            testedForm.button_1_Click(testedForm, e);
            testedForm.button_sign_Click(testedForm, e);
            testedForm.button_factorial_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("0"));

            testedForm.button_delete_Click(testedForm, e);

            testedForm.button_1_Click(testedForm, e);
            testedForm.button_7_Click(testedForm, e);
            testedForm.button_factorial_Click(testedForm, e);
            Assert.IsTrue(testedForm.label_result.Text.Equals("355687428096000"));
        }
    }
}