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

            }
            else//if the user has entered a value
            {

            }
        }

        private void PicCoins1p_Click(object sender, EventArgs e)
        {
            HaveCreditsBeenEntered();//calling the check credits have been entered method
        }

        private void PicCoins2p_Click(object sender, EventArgs e)
        {
            HaveCreditsBeenEntered();//calling the check credits have been entered method
        }

        private void PicCoins5p_Click(object sender, EventArgs e)
        {
            HaveCreditsBeenEntered();//calling the check credits have been entered method
        }

        private void PicCoins10p_Click(object sender, EventArgs e)
        {
            HaveCreditsBeenEntered();//calling the check credits have been entered method
        }

        private void PicCoins20p_Click(object sender, EventArgs e)
        {
            HaveCreditsBeenEntered();//calling the check credits have been entered method
        }

        private void PicCoins50p_Click(object sender, EventArgs e)
        {
            HaveCreditsBeenEntered();//calling the check credits have been entered method
        }

        private void PicCoins100p_Click(object sender, EventArgs e)
        {
            HaveCreditsBeenEntered();//calling the check credits have been entered method
        }

        private void PicCoins200p_Click(object sender, EventArgs e)
        {
            HaveCreditsBeenEntered();//calling the check credits have been entered method
        }
    }
}







