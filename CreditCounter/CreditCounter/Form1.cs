using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCounter
{
    public partial class lblHowManyCredits : Form
    {
        int int_ButtonValueLastClicked; //Global variable to keep track of the coin value last clicked
        decimal decimal_ButtonValueLastClicked;//Global variable to keep track of the decimal value of the coin last clicked
        int ValueEntered = 0;
        bool bool_HasCreditBeenEntered = false;//Global varaible to see if the user has entered a cost per credit

        public lblHowManyCredits()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void HaveCreditsBeenEntered() //Method for checking if a value has been enterd into the cost per credit text box
        {
            if (string.IsNullOrEmpty(txtboxCostPerCredit.Text) || txtboxCostPerCredit.Text == "0")//If statement, checks for an empty text box or a value of 0
            {
                MessageBox.Show("You have not set the Cost of a Credit");//Alerts the user that they havent entered a credit
                bool_HasCreditBeenEntered = false;

            }
            else//if the user has entered a value
            {
                bool_HasCreditBeenEntered = true;
                UpDateCoinsEnteredLabels();//calling the method to update lables in coins entered groupbox
                UpdateInt_DecValues();//calling the method to update the text box to show total value in pence
                CreditReached();//calling method to update the amount of credits the user has got
            }
        }
        private void UpDateCoinsEnteredLabels()//method for updating the lables in the coins entered group box
        {
            switch (int_ButtonValueLastClicked)//switch case statement checking the button value last clicked variable
            {
                case 1://if button value last clicked is 1
                    lblCoinsEntered1P.Text = Convert.ToString(Convert.ToInt32(lblCoinsEntered1P.Text) + 1);//updating the 1p label by 1
                    break;
                case 2://if button value last clicked is 2
                    lblCoinsEntered2P.Text = Convert.ToString(Convert.ToInt32(lblCoinsEntered2P.Text) + 1);//updating the 2p label by 1
                    break;
                case 5://if button value last clicked is 5
                    lblCoinsEntered5P.Text = Convert.ToString(Convert.ToInt32(lblCoinsEntered5P.Text) + 1);//updating the 5p label by 1
                    break;
                case 10://if button value last clicked is 10
                    lblCoinsEntered10P.Text = Convert.ToString(Convert.ToInt32(lblCoinsEntered10P.Text) + 1);//updating the 10p label by 1
                    break;
                case 20://if button value last clicked is 20
                    lblCoinsEntered20P.Text = Convert.ToString(Convert.ToInt32(lblCoinsEntered20P.Text) + 1);//updating the 20p label by 1
                    break;
                case 50://if button value last clicked is 50
                    lblCoinsEntered50P.Text = Convert.ToString(Convert.ToInt32(lblCoinsEntered50P.Text) + 1);//updating the 50p label by 1
                    break;
                case 100://if button value last clicked is 100
                    lblCoinsEntered100P.Text = Convert.ToString(Convert.ToInt32(lblCoinsEntered100P.Text) + 1);//updating the £1 label by 1
                    break;
                case 200://if button value last clicked is 200
                    lblCoinsEntered200P.Text = Convert.ToString(Convert.ToInt32(lblCoinsEntered200P.Text) + 1);//updating the £2 label by 1
                    break;
            }
        }

        private void UpdateInt_DecValues()//method for updating the interger and decimal total coin values
        {
            txtboxTotalValueP.Text = Convert.ToString(Convert.ToInt32(txtboxTotalValueP.Text) + int_ButtonValueLastClicked);//Adding the current value of the total value in p text box to the value of coin last clicked
            txtboxTotalValueMeasures.Text = Convert.ToString(Convert.ToDecimal(txtboxTotalValueMeasures.Text) + decimal_ButtonValueLastClicked);//Adding the current decimal value of the total value entered and the decimal value of coin last clicked

        }

        private void CreditReached()//method for checking if the user has gained a credit
        {
            int CreditLimit = Convert.ToInt32(txtboxCostPerCredit.Text);//creating a new variable so that we know what the credit cap is, also assinging the cost per credit value to it.
            int WorkingOut = 0;//creating a new variable will hold temporary values that help with the following working out.
            int remainder = 0;//creating a new variable so i can assign the remainder value to it

            int updateNOClbl = Convert.ToInt32(txtboxNumberOfCredits.Text);//creating a variable to store the number of credits the user already has
            ValueEntered = ValueEntered + int_ButtonValueLastClicked;//a counter so that every time a button is clicked the value will increase 

            if (ValueEntered >= CreditLimit)//if statement to see if a credit is needed
            { //if a credit is needed
                WorkingOut = (ValueEntered / CreditLimit); //working out how many credits
                remainder = (ValueEntered % CreditLimit); //working out the remainder so the users money isnt wasted

                txtboxNumberOfCredits.Text = Convert.ToString(updateNOClbl + WorkingOut);//finally updating the numbe rof credits that the user has

                ValueEntered = remainder; //assigning the global variable the value of the remainder of the previous %
            }

        }




        private void PicCoins1p_Click(object sender, EventArgs e)
        {
            
            int_ButtonValueLastClicked = 1; //assining the coin value to the button value last clicked variable
            decimal_ButtonValueLastClicked = 0.01m; //assinging the decimal coin value to the button last clicked variable
            HaveCreditsBeenEntered();//calling the check credits have been entered method
            
        }

        private void PicCoins2p_Click(object sender, EventArgs e)
        {
            
            int_ButtonValueLastClicked = 2; //assining the coin value to the button value last clicked variable
            decimal_ButtonValueLastClicked = 0.02m; //assinging the decimal coin value to the button last clicked variable
            HaveCreditsBeenEntered();//calling the check credits have been entered method
            
        }

        private void PicCoins5p_Click(object sender, EventArgs e)
        {
            
            int_ButtonValueLastClicked = 5; //assining the coin value to the button value last clicked variable
            decimal_ButtonValueLastClicked = 0.05m; //assinging the decimal coin value to the button last clicked variable
            HaveCreditsBeenEntered();//calling the check credits have been entered method
            
        }

        private void PicCoins10p_Click(object sender, EventArgs e)
        {
            
            int_ButtonValueLastClicked = 10; //assining the coin value to the button value last clicked variable
            decimal_ButtonValueLastClicked = 0.10m; //assinging the decimal coin value to the button last clicked variable
            HaveCreditsBeenEntered();//calling the check credits have been entered method
            
        }

        private void PicCoins20p_Click(object sender, EventArgs e)
        {
            
            int_ButtonValueLastClicked = 20; //assining the coin value to the button value last clicked variable
            decimal_ButtonValueLastClicked = 0.20m; //assinging the decimal coin value to the button last clicked variable
            HaveCreditsBeenEntered();//calling the check credits have been entered method
            
        }

        private void PicCoins50p_Click(object sender, EventArgs e)
        {
            
            int_ButtonValueLastClicked = 50; //assining the coin value to the button value last clicked variable
            decimal_ButtonValueLastClicked = 0.50m; //assinging the decimal coin value to the button last clicked variable
            HaveCreditsBeenEntered();//calling the check credits have been entered method
            
        }

        private void PicCoins100p_Click(object sender, EventArgs e)
        {
            
            int_ButtonValueLastClicked = 100; //assining the coin value to the button value last clicked variable
            decimal_ButtonValueLastClicked = 1.00m; //assinging the decimal coin value to the button last clicked variable
            HaveCreditsBeenEntered();//calling the check credits have been entered method
            
        }

        private void PicCoins200p_Click(object sender, EventArgs e)
        {
            
            int_ButtonValueLastClicked = 200; //assining the coin value to the button value last clicked variable
            decimal_ButtonValueLastClicked = 2.00m; //assinging the decimal coin value to the button last clicked variable
            HaveCreditsBeenEntered();//calling the check credits have been entered method
            
        }

        private void lblHowManyCredits_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {//when the reset button is clicked we want to make sure that all the labels, textboxes and variables have been reset.
            int_ButtonValueLastClicked = 0;
            ValueEntered = 0;
            bool_HasCreditBeenEntered = false;
            decimal_ButtonValueLastClicked = 0.00m;

            txtboxCostPerCredit.Text = "0";
            txtboxNumberOfCredits.Text = "0";
            txtboxTotalValueP.Text = "0";
            txtboxTotalValueMeasures.Text = "0.00";

            lblCoinsEntered1P.Text = "0";
            lblCoinsEntered2P.Text = "0";
            lblCoinsEntered5P.Text = "0";
            lblCoinsEntered10P.Text = "0";
            lblCoinsEntered20P.Text = "0";
            lblCoinsEntered50P.Text = "0";
            lblCoinsEntered100P.Text = "0";
            lblCoinsEntered200P.Text = "0";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}







