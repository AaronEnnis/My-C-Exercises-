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
 */

namespace menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string conversion = "";
        double userInput, answer;

        private void btnPoundToEuro_Click(object sender, EventArgs e)
        {
            conversion = "p2e";
            btnCtoF.Visible = false;
            btnPoundToEuro.Visible = false;
            btnIncheToFeet.Visible = false;
            lblAnswer.Visible = true;
            lblType1.Visible = true;
            lblType2.Visible = true;
            txtUserInput.Visible = true;
            btnConvert.Visible = true;
            btnMenu.Visible = true;

            lblConversion.Text = "Pound to Euro";
            lblType1.Text = "Pound";
            lblType2.Text = "Euro";
        }

        private void btnIncheToFeet_Click(object sender, EventArgs e)
        {
            conversion = "i2f";
            btnCtoF.Visible = false;
            btnPoundToEuro.Visible = false;
            btnIncheToFeet.Visible = false;
            lblAnswer.Visible = true;
            lblType1.Visible = true;
            lblType2.Visible = true;
            txtUserInput.Visible = true;
            btnConvert.Visible = true;
            btnMenu.Visible = true;

            lblConversion.Text = "Inche to Feet";
            lblType1.Text = "Inche";
            lblType2.Text = "Feet";
        }


        private void btnCtoF_Click(object sender, EventArgs e)
        {
            conversion = "c2f";
            btnCtoF.Visible = false;
            btnPoundToEuro.Visible = false;
            btnIncheToFeet.Visible = false;
            lblAnswer.Visible = true;
            lblType1.Visible = true;
            lblType2.Visible = true;
            txtUserInput.Visible = true;
            btnConvert.Visible = true;
            btnMenu.Visible = true;

            lblConversion.Text = "Celcius to Fahrenheit";
            lblType1.Text = "Celcius";
            lblType2.Text = "Fahrenheit";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            btnCtoF.Visible = true;
            btnPoundToEuro.Visible = true;
            btnIncheToFeet.Visible = true;
            lblAnswer.Visible = false;
            lblType1.Visible = false;
            lblType2.Visible = false;
            txtUserInput.Visible = false;
            btnConvert.Visible = false;
            btnMenu.Visible = false;

            txtUserInput.Text = "0.0";
            lblAnswer.Text = "";
            lblType1.Text = "";
            lblType2.Text = "";
            lblConversion.Text = "Pick the conversion you want to do";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            convert();
        }

        private void txtUserInput_KeyPress(object sender, KeyPressEventArgs e)               //Only allows numbers to be entered in to the textbox
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

        private void incheToFeetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cToFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conversion = "c2f";
            btnCtoF.Visible = false;
            btnPoundToEuro.Visible = false;
            btnIncheToFeet.Visible = false;
            lblAnswer.Visible = true;
            lblType1.Visible = true;
            lblType2.Visible = true;
            txtUserInput.Visible = true;
            btnConvert.Visible = true;
            btnMenu.Visible = true;

            lblConversion.Text = "Celcius to Fahrenheit";
            lblType1.Text = "Celcius";
            lblType2.Text = "Fahrenheit";
        }

        public void convert()
        {
            switch(conversion)
            {
                case "i2f":
                    userInput = Convert.ToDouble(txtUserInput.Text);           
                    answer = userInput / 12;
                    lblAnswer.Text = answer.ToString("0.##");
                    break;

                case "p2e":
                    userInput = Convert.ToDouble(txtUserInput.Text);
                    answer = userInput / 0.79;
                    lblAnswer.Text = answer.ToString("0.##");
                    break;

                case "c2f":
                    userInput = Convert.ToDouble(txtUserInput.Text);                    //fah = (celsius * 9/5) + 32
                    answer = (userInput * 9 / 5) + 32;
                    lblAnswer.Text = answer.ToString("0.##");
                    break;

            }
        }
    }
}
