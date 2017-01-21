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

namespace multiConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double userInput = 0;
        double answer = 0;

        private void rdbInchToFeet_CheckedChanged(object sender, EventArgs e)
        {

            lblConversion.Text = "Inches to Feet";          //changes the labels according to the radiobutton selected
            lblType1.Text = "Inche";
            lblType2.Text = "Feet";
            lblAnswer.Text = "";

        }


        private void rdbPoundToEuro_CheckedChanged(object sender, EventArgs e)
        {
            lblConversion.Text = "Pound to Euro";
            lblType1.Text = "Pound";
            lblType2.Text = "Euro";
            lblAnswer.Text = "";
        }


        private void rdbCtoF_CheckedChanged(object sender, EventArgs e)
        {
            lblConversion.Text = "Celsius to Fahrenheit";
            lblType1.Text = "Celcius";
            lblType2.Text = "Fahrenheit";
            lblAnswer.Text = "";
        }


        private void btnConvert_Click(object sender, EventArgs e)
        {
            convert();
        }

        public void convert()
        {
            if (rdbInchToFeet.Checked == true)                      //converts the users input according to what radiobutton was selected
            {
                userInput = Convert.ToDouble(txtUserInput.Text);           
                answer = userInput / 12;
                lblAnswer.Text = answer.ToString("0.##");
            }
            else if (rdbPoundToEuro.Checked == true)
            {
                userInput = Convert.ToDouble(txtUserInput.Text);
                answer = userInput / 0.79;
                lblAnswer.Text = answer.ToString("0.##");
            }
            else if(rdbCtoF.Checked == true)
            {
                userInput = Convert.ToDouble(txtUserInput.Text);                    //fah = (celsius * 9/5) + 32
                answer = (userInput * 9/5) + 32;
                lblAnswer.Text = answer.ToString("0.##");
            }
            else
            {
                lblAnswer.Text = "No conversion selected";
            }
        }

        private void txtUserInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserInput_KeyPress(object sender, KeyPressEventArgs e)           //Only allows numbers to be entered in to the textbox
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
