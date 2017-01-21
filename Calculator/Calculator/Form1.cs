using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



/*Aaron Ennis
 * 
 * C00190504
 *  
 */ 




namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1, num2, answer;      //these are the 2 numbers inputted and the result after the equation is complete
        int count = 0;
        string userInput = "empty";
        string operand = "";
        bool liveOperand = false;       //allows the user to only pick one operande at once
        bool multiOperation = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn1_Click(object sender, EventArgs e)
        {

            if (count != 0)
            {
                liveOperand = true;
            }

            if (liveOperand == false)
            {
                userInput = "1";
                textBox1.Text = textBox1.Text + userInput;
                liveOperand = true;
            }
            else 
            {
                if (multiOperation == true)
                {
                    textBox1.Text = null;
                    multipleOperations();
                }
                userInput = "1";
                textBox1.Text = textBox1.Text + userInput;
                multiOperation = false;
                liveOperand = true;

            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {

            if (count != 0)
            {
                liveOperand = true;
            }

            if (liveOperand == false)
            {
                userInput = "2";
                textBox1.Text = textBox1.Text + userInput;
                liveOperand = true;
            }
            else 
            {
                if (multiOperation == true)
                {
                    textBox1.Text = null;
                    multipleOperations();
                }
                userInput = "2";
                textBox1.Text = textBox1.Text + userInput;
                liveOperand = true;
                multiOperation = false;
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (count != 0)
            {
                liveOperand = true;
            }

            if (liveOperand == false)
            {
                userInput = "3";
                textBox1.Text = textBox1.Text + userInput;
                liveOperand = true;
            }
            else
            {
                if (multiOperation == true)
                {
                    textBox1.Text = null;
                    multipleOperations();
                }
                userInput = "3";
                textBox1.Text = textBox1.Text + userInput;
                liveOperand = true;
                multiOperation = false;
            
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {

            if (count != 0)
            {
                liveOperand = true;
            }

            if (liveOperand == false)
            {
                userInput = "4";
                textBox1.Text = textBox1.Text + userInput;
                liveOperand = true;
            }
            else
            {
                if (multiOperation == true)
                {
                    textBox1.Text = null;
                    multipleOperations();
                }
                userInput = "4";
                textBox1.Text = textBox1.Text + userInput;
                liveOperand = true;
                multiOperation = false;
              
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {

            if (count != 0)
            {
                liveOperand = true;
            }

            if (liveOperand == false)
            {
                userInput = "5";
                textBox1.Text = textBox1.Text + userInput;
                liveOperand = true;
            }
            else
            {
                if (multiOperation == true)
                {
                    textBox1.Text = null;
                    multipleOperations();
                }
                userInput = "5";
                textBox1.Text = textBox1.Text + userInput;
                liveOperand = true;
                multiOperation = false;
              
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {

            if (count != 0)
            {
                liveOperand = true;
            }

            if (liveOperand == false)
            { 
                userInput = "6";
                textBox1.Text = textBox1.Text + userInput;
                liveOperand = true;
            }
            else 
            {
                if (multiOperation == true)
                {
                    textBox1.Text = null;
                    multipleOperations();
                }
                userInput = "6";
                textBox1.Text = textBox1.Text + userInput;
                liveOperand = true;
                multiOperation = false;
              
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {

            if (count != 0)
            {
                liveOperand = true;
            }

            if (liveOperand == false)
            {
                userInput = "7";
                textBox1.Text = textBox1.Text + userInput;
                liveOperand = true;
            }
            else
            {
                if (multiOperation == true)
                {
                    textBox1.Text = null;
                    multipleOperations();
                }
                userInput = "7";
                textBox1.Text = textBox1.Text + userInput;
                liveOperand = true;
                multiOperation = false;
               
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {

            if (count != 0)
            {
                liveOperand = true;
            }

            if (liveOperand == false)
            {
                userInput = "8";
                textBox1.Text = textBox1.Text + userInput;
                liveOperand = true;
            }
            else 
            {
                if (multiOperation == true)
                {
                    textBox1.Text = null;
                    multipleOperations();
                }
                userInput = "8";
                textBox1.Text = textBox1.Text + userInput;
                liveOperand = true;
                multiOperation = false;
             
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {

            if (count != 0)
            {
                liveOperand = true;
            }

            if (liveOperand == false)
            {
                userInput = "9";
                textBox1.Text = textBox1.Text + userInput;
                liveOperand = true;
            }
            else 
            {
                if (multiOperation == true)
                {
                    textBox1.Text = null;
                    multipleOperations();
                }
                userInput = "9";
                textBox1.Text = textBox1.Text + userInput;
                liveOperand = true;
                multiOperation = false;
          
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {

            if(count != 0)
            {
                liveOperand = true;
            }


            if (liveOperand == false)
            {
                userInput = "0";
                textBox1.Text = textBox1.Text + userInput;
                liveOperand = true;
            }
            else 
            {
                if (multiOperation == true)
                {
                    textBox1.Text = null;
                    multipleOperations();
                }
                userInput = "0";
                textBox1.Text = textBox1.Text + userInput;     
                liveOperand = true;
                multiOperation = false;
              
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {

            if (liveOperand == false)
            {
                userInput = ".";
                textBox1.Text = textBox1.Text + userInput;
            }

            else
            { 
              if (multiOperation == true)
               {
                    textBox1.Text = null;
                    multipleOperations();
                }
                    userInput = ".";
                    textBox1.Text = textBox1.Text + userInput;
                    multiOperation = false;
               
            }
        }


        private void btnEqual_Click(object sender, EventArgs e)
        {
                calculateAnswer();   
        }


        private void btnReset_Click(object sender, EventArgs e)             //resets the calculator
        {
            textBox1.Text = null;
            num1 = 0; 
            num2 = 0; 
            answer = 0;
            userInput = "empty";
            operand = "";
            liveOperand = false;
            multiOperation = false;
            count = 0;

        }

        private void btnDivide_Click(object sender, EventArgs e)     
        {
            count++;
            if (liveOperand == true)
            {
                if (count == 1)
                {
                    num1 = double.Parse(textBox1.Text);             //turns the string in to a double so it can be added to the equation
                    textBox1.Text = null;
                    liveOperand = false;
                    operand = "divide";
                }
                else 
                {
                    liveOperand = false;
                    calculateAnswer();
                    operand = "divide";
                    multiOperation = true;
                }
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)      
        {
            count++;
            if (liveOperand == true)
            {
                if (count == 1)
                {
                    num1 = double.Parse(textBox1.Text);
                    textBox1.Text = null;
                    operand = "multiply";
                    liveOperand = false;
                }
                else 
                {
                    liveOperand = false;
                    calculateAnswer();
                    operand = "multiply";
                    multiOperation = true;
                }
            }
        }

     
        private void btnMinus_Click(object sender, EventArgs e)         
        {
            count++;
            if (liveOperand == true)
            {
                if (count == 1)
                {
                    num1 = double.Parse(textBox1.Text);
                    textBox1.Text = null;
                    operand = "minus";
                    liveOperand = false;
                }
                else
                {
                    liveOperand = false;
                    calculateAnswer();
                    operand = "minus";
                    multiOperation = true;
                }
            }
        }


        private void btnPlus_Click(object sender, EventArgs e)    
        {
            count++;
            if (liveOperand == true)
            {
                if (count == 1)
                {
                    num1 = double.Parse(textBox1.Text);
                    textBox1.Text = null;
                    operand = "plus";
                    liveOperand = false;
                }
                else 
                {
                    liveOperand = false;
                    calculateAnswer();
                    operand = "plus";
                    multiOperation = true;
                }
            }

        }


        public void calculateAnswer()
        {
            switch (operand)
            {

                case "plus":                                              //adds the 2 numbers selected
                    num2 = double.Parse(textBox1.Text);
                    answer = num1 + num2;
                    textBox1.Text = answer.ToString("0.######");
                    break;

                case "minus":
                    num2 = double.Parse(textBox1.Text);                 //takes away the second number from the first
                    answer = num1 - num2;
                    textBox1.Text = answer.ToString("0.######");
                    break;

                case "multiply":
                    num2 = double.Parse(textBox1.Text);         //multiplies the 2 numbers selected
                    answer = num1 * num2;
                    textBox1.Text = answer.ToString("0.######");
                    break;

                case "divide":
                    num2 = double.Parse(textBox1.Text);      //divides the first number by the second
                    answer = num1 / num2;
                    textBox1.Text = answer.ToString("0.######");
                    break;

            }

        }


        public void multipleOperations()
        {
            num1 = answer;
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)       //Only allows numbers to be entered in to the textbox
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
