using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Program: Population
  Author: Kyle McBride A02609917
  Date: 02/27/2014
  Description: Application that predicts the approximate size of a population of organisms. The application will 
               use text boxes to allow the user to enter the starting number of organisms, the average daily 
               population increase (as a percentage), and the number of days the organisms will be left to multiply.
                                          ***SEE CHANGELOG IN SOLUTION DIRECTORY***                             */

namespace Population
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                #region Variables
                //declaring variables for data user inputs
                double startingAmount;
                double rateOfIncrease;
                double daysOfIncrease;
                int loopCountAmount = 1;
                double currentAmount;
                #endregion
                #region Parse User Data
                //variable for calculations during loop
                currentAmount = int.Parse(numberOfOrganismsTxt.Text);
                #endregion

                #region Processing Data
                //checking to make sure initial amount of organisms was entered correctly and parsing the data
                if (double.TryParse(numberOfOrganismsTxt.Text, out startingAmount))
                {
                    //checking to make sure the rate of organism growth was entered correctly and parsing the data
                    if (double.TryParse(amountOfIncreaseTxt.Text, out rateOfIncrease))
                    {
                        //putting this data into the correct format for mathmatical calculations
                        rateOfIncrease /= 100;

                        //checking to make sure the amount of days the organism will grow is entered correctly and parsing
                        if (double.TryParse(daysToMultiplyTxt.Text, out daysOfIncrease))
                        {
                            //loop that displays data and does calculations
                            while (outputListBox.Items.Count < daysOfIncrease)
                            {
                                outputListBox.Items.Add("Day " + loopCountAmount + " = " + currentAmount);
                                currentAmount = (rateOfIncrease * currentAmount) + currentAmount;
                                loopCountAmount += 1;
                            }
                        }
                        else //error essage for not entering the amount of days
                        {
                            MessageBox.Show("Please enter the amount of days the organisms will grow.");
                        }
                    }
                    else //error message for not entering a percentage
                    {
                        MessageBox.Show("Please enter a rate in percentage(without the % character) for organsism growth.");
                    }
                }
                
                else //error message for not entering amount of organisms
                {
                    MessageBox.Show("Please enter how many organisms you are starting with.");
                }
                #endregion
                #region Exception
            }
            catch (Exception ex) //error message for any exceptions
            {
                MessageBox.Show(ex.Message);
            }
                #endregion
        }


        private void resetButton_Click(object sender, EventArgs e)
        {
            //clearing everything out
            numberOfOrganismsTxt.Text = "";
            amountOfIncreaseTxt.Text = "";
            daysToMultiplyTxt.Text = "";
            outputListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closing the application
            this.Close();
        }
    }
}
