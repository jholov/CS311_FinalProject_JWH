using System.Drawing.Text;

namespace CS311_FinalProject_JWH
{
    public partial class Form1 : Form
    {
        private Boolean swapStatus = false;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnSwap_Click(object sender, EventArgs e)
        {
            //Changes Conversions that are acceptable
            if (swapStatus == false)
            {

                rdoFeet.Checked = false;
                rdoMiles.Checked = false;
                rdoFahrenheit.Checked = false;
                rdoPounds.Checked = false;
                rdoOunces.Checked = false;
                rdoMeters.Checked = false;
                rdoKilometers.Checked = false;
                rdoCelsius.Checked = false;
                rdoKilograms.Checked = false;
                rdoGrams.Checked = false;

                rdoMeters.Enabled = true;
                rdoKilometers.Enabled = true;
                rdoCelsius.Enabled = true;
                rdoKilograms.Enabled = true;
                rdoGrams.Enabled = true;
                rdoFeet.Enabled = true;
                rdoMiles.Enabled = true;
                rdoFahrenheit.Enabled = true;
                rdoPounds.Enabled = true;
                rdoOunces.Enabled = true;

               

                picArrow.Image = Image.FromFile("..//..//..//img//leftarrow.png");

                swapStatus = true;
            }
            else if(swapStatus == true )
            {
                rdoFeet.Checked = false;
                rdoMiles.Checked = false;
                rdoFahrenheit.Checked = false;
                rdoPounds.Checked = false;
                rdoOunces.Checked = false;
                rdoMeters.Checked = false;
                rdoKilometers.Checked = false;
                rdoCelsius.Checked = false;
                rdoKilograms.Checked = false;
                rdoGrams.Checked = false;

                rdoMeters.Enabled = true;
                rdoKilometers.Enabled = true;
                rdoCelsius.Enabled = true;
                rdoKilograms.Enabled = true;
                rdoGrams.Enabled = true;
                rdoFeet.Enabled = true;
                rdoMiles.Enabled = true;
                rdoFahrenheit.Enabled = true;
                rdoPounds.Enabled = true;
                rdoOunces.Enabled = true;


                picArrow.Image = Image.FromFile("..//..//..//img//rightarrow.png");

                swapStatus = false;
            }

        }

        private void rdoMeters_CheckedChanged(object sender, EventArgs e)
        {

            //Accepts & Blocks conversions
            if (swapStatus == false)
            {
                rdoKilograms.Enabled = true;
                rdoCelsius.Enabled = true;
                rdoKilograms.Enabled = true;
                rdoGrams.Enabled = true;
                rdoFeet.Enabled = true;
                rdoMiles.Enabled = true;
                rdoFahrenheit.Enabled = false;
                rdoPounds.Enabled = false;
                rdoOunces.Enabled = false;

                rdoFahrenheit.Checked = false;
                rdoPounds.Checked = false;
                rdoOunces.Checked = false;

            }
        }

        private void rdoKilometers_CheckedChanged(object sender, EventArgs e)
        {
            //Accepts & Blocks conversions
            if (swapStatus == false)
            {
                rdoMeters.Enabled = true;
                rdoCelsius.Enabled= true;
                rdoKilograms.Enabled = true;
                rdoGrams.Enabled = true;
                rdoFeet.Enabled = true;
                rdoMiles.Enabled = true;
                rdoFahrenheit.Enabled = false;
                rdoPounds.Enabled = false;
                rdoOunces.Enabled = false;

                rdoFahrenheit.Checked = false;
                rdoPounds.Checked = false;
                rdoOunces.Checked = false;
            }
        }
        private void rdoCelsius_CheckedChanged(object sender, EventArgs e)
        {
            //Accepts & Blocks conversions
            if (swapStatus == false)
            {
                rdoMeters.Enabled = true;
                rdoKilometers.Enabled = true;
                rdoKilograms.Enabled = true;
                rdoGrams.Enabled = true;
                rdoFeet.Enabled = false;
                rdoMiles.Enabled = false;
                rdoFahrenheit.Enabled = true;
                rdoPounds.Enabled = false;
                rdoOunces.Enabled = false;

                rdoFeet.Checked = false;
                rdoMiles.Checked = false;
                rdoPounds.Checked = false;
                rdoOunces.Checked = false;
            }
        }
        private void rdoKilograms_CheckedChanged(object sender, EventArgs e)
        {
            //Accepts & Blocks conversions
            if (swapStatus == false)
            {
                rdoMeters.Enabled = true;
                rdoKilometers.Enabled = true;
                rdoCelsius.Enabled = true;
                rdoGrams.Enabled = true;
                rdoFeet.Enabled = false;
                rdoMiles.Enabled = false;
                rdoFahrenheit.Enabled = false;
                rdoPounds.Enabled = true;
                rdoOunces.Enabled = true;

                rdoFeet.Checked = false;
                rdoMiles.Checked = false;
                rdoFahrenheit.Checked = false;
            }
        }

        private void rdoGrams_CheckedChanged(object sender, EventArgs e)
        {
            //Accepts & Blocks conversions
            if (swapStatus == false)
            {
                rdoMeters.Enabled = true;
                rdoKilometers.Enabled = true;
                rdoCelsius.Enabled = true;
                rdoKilograms.Enabled = true;
                rdoFeet.Enabled = false;
                rdoMiles.Enabled = false;
                rdoFahrenheit.Enabled = false;
                rdoPounds.Enabled = true;
                rdoOunces.Enabled = true;

                rdoFeet.Checked = false;
                rdoMiles.Checked = false;
                rdoFahrenheit.Checked = false;
            }
        }

        private void rdoFeet_CheckedChanged(object sender, EventArgs e)
        {
            //Accepts & Blocks conversions
            if (swapStatus == true)
            {
                rdoMeters.Enabled = true;
                rdoKilometers.Enabled = true;
                rdoCelsius.Enabled = false;
                rdoKilograms.Enabled = false;
                rdoGrams.Enabled = false;
                rdoMiles.Enabled = true;
                rdoFahrenheit.Enabled = true;
                rdoPounds.Enabled = true;
                rdoOunces.Enabled = true;

                rdoCelsius.Checked = false;
                rdoKilograms.Checked = false;
                rdoGrams.Checked = false;

            }
        }

        private void rdoMiles_CheckedChanged(object sender, EventArgs e)
        {
            //Accepts & Blocks conversions
            if (swapStatus == true)
            {
                rdoMeters.Enabled = true;
                rdoKilometers.Enabled = true;
                rdoCelsius.Enabled = false;
                rdoKilograms.Enabled = false;
                rdoGrams.Enabled = false;
                rdoFeet.Enabled = true;
                rdoFahrenheit.Enabled = true;
                rdoPounds.Enabled = true;
                rdoOunces.Enabled = true;

                rdoCelsius.Checked = false;
                rdoKilograms.Checked = false;
                rdoGrams.Checked = false;

            }
        }

        private void rdoFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            //Accepts & Blocks conversions
            if (swapStatus == true)
            {
                rdoMeters.Enabled = false;
                rdoKilometers.Enabled = false;
                rdoCelsius.Enabled = true;
                rdoKilograms.Enabled = false;
                rdoGrams.Enabled = false;
                rdoFeet.Enabled = true;
                rdoMiles.Enabled = true;
                rdoPounds.Enabled = true;
                rdoOunces.Enabled = true;

                rdoMeters.Checked = false;
                rdoKilometers.Checked = false;
                rdoKilograms.Checked = false;
                rdoGrams.Checked = false;

            }
        }

        private void rdoPounds_CheckedChanged(object sender, EventArgs e)
        {
            //Accepts & Blocks conversions
            if (swapStatus == true)
            {
                rdoMeters.Enabled = false;
                rdoKilometers.Enabled = false;
                rdoCelsius.Enabled = false;
                rdoKilograms.Enabled = true;
                rdoGrams.Enabled = true;
                rdoFeet.Enabled = true;
                rdoMiles.Enabled = true;
                rdoFahrenheit.Enabled = true;
                rdoOunces.Enabled = true;

                rdoMeters.Checked = false;
                rdoKilometers.Checked = false;
                rdoCelsius.Checked = false;

            }
        }

        private void rdoOunces_CheckedChanged(object sender, EventArgs e)
        {
            //Accepts & Blocks conversions
            if (swapStatus == true)
            {
                rdoMeters.Enabled = false;
                rdoKilometers.Enabled = false;
                rdoCelsius.Enabled = false;
                rdoKilograms.Enabled = true;
                rdoGrams.Enabled = true;
                rdoFeet.Enabled = true;
                rdoMiles.Enabled = true;
                rdoFahrenheit.Enabled = true;
                rdoPounds.Enabled = true;

                rdoMeters.Checked = false;
                rdoKilometers.Checked = false;
                rdoCelsius.Checked = false;

            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string inputCheck = txtInput.Text;
            double unitOutput = 0;

            //Checks to make sure something is entered
            if (inputCheck == "")

            {
                lblOutput.Text = "Please Enter Unit Amount";
            }
            //Uses the appropriate formula for conversions
            else
            {
                double unitInput = double.Parse(txtInput.Text);

                if (swapStatus == false)
                {
                    if (rdoMeters.Checked == true && rdoFeet.Checked == true)
                    {
                        unitOutput = unitInput / .3048;
                    }
                    if (rdoMeters.Checked == true && rdoMiles.Checked == true)
                    {
                        unitOutput = unitInput / 1609.34;
                    }
                    if (rdoKilometers.Checked == true && rdoFeet.Checked == true)
                    {
                        unitOutput = unitInput * 3280.84;
                    }
                    if (rdoKilometers.Checked == true && rdoMiles.Checked == true)
                    {
                        unitOutput = unitInput * .621371;
                    }
                    if (rdoCelsius.Checked == true && rdoFahrenheit.Checked == true)
                    {
                        unitOutput = (unitInput * 9 / 5) + 32;
                    }
                    if (rdoKilograms.Checked == true && rdoPounds.Checked == true)
                    {
                        unitOutput = unitInput * 2.20462;
                    }
                    if (rdoKilograms.Checked == true && rdoOunces.Checked == true)
                    {
                        unitOutput = unitInput * 35.274;
                    }
                    if (rdoGrams.Checked == true && rdoPounds.Checked == true)
                    {
                        unitOutput = unitInput * .00220462;
                    }
                    if (rdoGrams.Checked == true && rdoOunces.Checked == true)
                    {
                        unitOutput = unitInput * .035274;
                    }
                    lblOutput.Text = unitOutput.ToString("N3");

                }
                if (swapStatus == true)
                {
                    if (rdoFeet.Checked == true && rdoMeters.Checked == true)
                    {
                        unitOutput = unitInput * .3048;
                    }
                    if (rdoFeet.Checked == true && rdoKilometers.Checked == true)
                    {
                        unitOutput = unitInput * .0003048;
                    }
                    if (rdoMiles.Checked == true && rdoMeters.Checked == true)
                    {
                        unitOutput = unitInput * 1609.344;
                    }
                    if (rdoMiles.Checked == true && rdoKilometers.Checked == true)
                    {
                        unitOutput = unitInput * 1.60934;
                    }
                    if (rdoFahrenheit.Checked == true && rdoCelsius.Checked == true)
                    {
                        unitOutput = (unitInput - 32) * 5 / 9;
                    }
                    if (rdoPounds.Checked == true && rdoKilograms.Checked == true)
                    {
                        unitOutput = unitInput * .453592;
                    }
                    if (rdoPounds.Checked == true && rdoGrams.Checked == true)
                    {
                        unitOutput = unitInput * 453.592;
                    }
                    if (rdoOunces.Checked == true && rdoKilograms.Checked == true)
                    {
                        unitOutput = unitInput * .0283495;
                    }
                    if (rdoOunces.Checked == true && rdoGrams.Checked == true)
                    {
                        unitOutput = unitInput * 28.3495;
                    }
                    lblOutput.Text = unitOutput.ToString("N3");
                }

            }//end else statement
        }//end btnConvert_Click
    }//end Form1
}