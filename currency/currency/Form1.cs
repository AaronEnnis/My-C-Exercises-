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

namespace currency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string currency1 = "";              //these are the 3 types of currency selected
        string currency2 = "";
        string currency3 = "";
        double answer1 = 0;
        double answer2 = 0;                 //these are the 2 answers that will be displayed
        double num1 = 0;
        double num2 = 0;                    //these are the 2 numbers to be converted
        


        private void btnConvert1_Click(object sender, EventArgs e)
        {
            checkCurrency1();
            firstConvert();          
        }

        private void btnConvert2_Click(object sender, EventArgs e)
        {

            checkCurrency2();
            secondConvert();
        }

        public void checkCurrency1()            //checks to find what currency the user is working with for the first conversion and converts accordingly
        {
            if (ckbEuro1.Checked == true)
            {
                currency1 = "euro";
            }
            else if (ckbSterling1.Checked == true)
            {
                currency1 = "sterling";
            }
            else if (ckbDollars1.Checked == true)
            {
                currency1 = "dollars";
            }

            if (ckbEuro2.Checked == true)
            {
                currency2 = "euro";
            }
            else if (ckbSterling2.Checked == true)
            {
                currency2 = "sterling";
            }
            else if (ckbDollars2.Checked == true)
            {
                currency2 = "dollars";
            }

        }

        public void checkCurrency2()                            //checks to find what currency the user is working with for the second conversion and converts accordingly
        {
            if (ckbEuro2.Checked == true)
            {
                currency2 = "euro";
            }
            else if (ckbSterling2.Checked == true)
            {
                currency2 = "sterling";
            }
            else if (ckbDollars2.Checked == true)
            {
                currency2 = "dollars";
            }

            if (ckbEuro3.Checked == true)
            {
                currency3 = "euro";
            }
            else if (ckbSterling3.Checked == true)
            {
                currency3 = "sterling";
            }
            else if (ckbDollars3.Checked == true)
            {
                currency3 = "dollars";
            }


        }

        public void firstConvert()
        {
            switch (currency1)
            {
                case "euro":
                                                                                  //from euro to either sterling or dollars
                    switch (currency2)              
                    {

                        case "euro":

                            lblAnswer1.Text = txtUserInput.Text;

                            break;
                        case "sterling":

                            num1 = Convert.ToDouble(txtUserInput.Text);     //converts the number selected in to a double so it can be converted
                            answer1 = num1 * 0.8659;
                            lblAnswer1.Text = answer1.ToString("#.##");    //turns the answer back in to a string so it can be displayed

                            break;
                        case "dollars":
                            num1 = Convert.ToDouble(txtUserInput.Text);
                            answer1 = num1 * 1.12;
                            lblAnswer1.Text = answer1.ToString("#.##");
                            break;

                        default:
                            lblAnswer1.Text = "No currency was picked";

                            break;

                    }
                    break;
                case "sterling":                //from sterling to either dollars or euro

                    switch (currency2)
                    {

                        case "euro":

                            num1 = Convert.ToDouble(txtUserInput.Text);
                            answer1 = num1 * 1.15;
                            lblAnswer1.Text = answer1.ToString("#.##");

                            break;
                        case "sterling":

                            lblAnswer1.Text = txtUserInput.Text;

                            break;
                        case "dollars":
                            num1 = Convert.ToDouble(txtUserInput.Text);
                            answer1 = num1 * 1.30;
                            lblAnswer1.Text = answer1.ToString("#.##");
                            break;

                        default:
                            lblAnswer1.Text = "No currency was picked";

                            break;

                    }

                    break;
                case "dollars":             //from dollars to either euro or sterling

                    switch (currency2)
                    {

                        case "euro":

                            num1 = Convert.ToDouble(txtUserInput.Text);
                            answer1 = num1 * 0.8907;
                            lblAnswer1.Text = answer1.ToString("#.##");

                            break;
                        case "sterling":
         
                            num1 = Convert.ToDouble(txtUserInput.Text);
                            answer1 = num1 * 0.7713;
                            lblAnswer1.Text = answer1.ToString("#.##");

                            break;
                        case "dollars":

                            lblAnswer1.Text = txtUserInput.Text;

                            break;

                        default:
                            lblAnswer1.Text = "No currency was picked";

                            break;

                    }
                    break;

                default:
                    lblAnswer1.Text = "No currency is selected";

                    break;


            }

        }

        public void secondConvert()         //this works the same as firstConvert() except it does it for the second conversion
        {
            switch (currency2)
            {
                case "euro":        //from euro to either sterling or dollars

                    switch (currency3)
                    {

                        case "euro":

                            lblAnswer2.Text = lblAnswer1.Text;

                            break;
                        case "sterling":

                            num2 = Convert.ToDouble(lblAnswer1.Text);
                            answer2 = num2 * 0.8659;
                            lblAnswer2.Text = answer2.ToString("#.##");

                            break;
                        case "dollars":
                            num2 = Convert.ToDouble(lblAnswer1.Text);
                            answer2 = num2 * 1.12;
                            lblAnswer2.Text = answer2.ToString("#.##");
                            break;

                        default:
                            lblAnswer2.Text = "No currency was picked";

                            break;

                    }
                    break;
                case "sterling":                //from sterling to either euro or dollars

                    switch (currency3)
                    {

                        case "euro":

                            num2 = Convert.ToDouble(lblAnswer1.Text);
                            answer2 = num2 * 1.15;
                            lblAnswer2.Text = answer2.ToString("#.##");

                            break;
                        case "sterling":

                            lblAnswer2.Text = lblAnswer1.Text;

                            break;
                        case "dollars":
                            num2 = Convert.ToDouble(lblAnswer1.Text);
                            answer2 = num2 * 1.30;
                            lblAnswer2.Text = answer2.ToString("#.##");
                            break;

                        default:
                            lblAnswer2.Text = "No currency was picked";

                            break;

                    }

                    break;
                case "dollars":         //from dollars to either euro or sterling

                    switch (currency3)
                    {

                        case "euro":

                            num2 = Convert.ToDouble(lblAnswer1.Text);
                            answer2 = num2 * 0.8907;
                            lblAnswer2.Text = answer2.ToString("#.##"); ;

                            break;
                        case "sterling":

                            num2 = Convert.ToDouble(lblAnswer1.Text);
                            answer2 = num2 * 0.7713;
                            lblAnswer2.Text = answer2.ToString("#.##"); 

                            break;
                        case "dollars":

                            lblAnswer2.Text = lblAnswer1.Text;

                            break;

                        default:
                            lblAnswer2.Text = "No currency was picked";

                            break;

                    }
                    break;

                default:
                    lblAnswer2.Text = "No currency is selected";

                    break;


            }
     

    }


        private void ckbEuro1_CheckedChanged(object sender, EventArgs e)            //these allow you to only check one check box in each set
        {
            ckbDollars1.Checked = false;
            ckbSterling1.Checked = false;            
        }

        private void ckbSterling1_CheckedChanged(object sender, EventArgs e)
        {
            ckbEuro1.Checked = false;
            ckbDollars1.Checked = false;                   
        }

        private void ckbDollars1_CheckedChanged(object sender, EventArgs e)
        {
            ckbEuro1.Checked = false;
            ckbSterling1.Checked = false;                          
        }

        private void ckbDollars2_CheckedChanged(object sender, EventArgs e)
        {
            ckbEuro2.Checked = false;
            ckbSterling2.Checked = false;
        }

        private void ckbSterling2_CheckedChanged(object sender, EventArgs e)
        {
            ckbEuro2.Checked = false;
            ckbDollars2.Checked = false;
        }

        private void ckbEuro2_CheckedChanged(object sender, EventArgs e)
        {
            ckbDollars2.Checked = false;
            ckbSterling2.Checked = false;
        }

        private void ckbEuro3_CheckedChanged(object sender, EventArgs e)
        {
            ckbDollars3.Checked = false;
            ckbSterling3.Checked = false;
        }

        private void ckbSterling3_CheckedChanged(object sender, EventArgs e)
        {
            ckbEuro3.Checked = false;
            ckbDollars3.Checked = false;
        }

        private void ckbDollars3_CheckedChanged(object sender, EventArgs e)
        {
            ckbEuro3.Checked = false;
            ckbSterling3.Checked = false;
        }

        private void btnReset_Click(object sender, EventArgs e)         //resets the converter
        {
            currency1 = "";
            currency2 = "";
            currency3 = "";
            answer1 = 0;
            answer2 = 0;
            num1 = 0;
            num2 = 0;

            lblAnswer1.Text = "";
            lblAnswer2.Text = "";
            txtUserInput.Text = "0.0";

            ckbDollars1.Checked = false;
            ckbDollars2.Checked = false;
            ckbDollars3.Checked = false;
            ckbEuro1.Checked = false;
            ckbEuro2.Checked = false;
            ckbEuro3.Checked = false;
            ckbSterling1.Checked = false;
            ckbSterling2.Checked = false;
            ckbSterling3.Checked = false;


        }

        private void txtUserInput_KeyPress(object sender, KeyPressEventArgs e)              //Only allows numbers to be entered in to the textbox
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
