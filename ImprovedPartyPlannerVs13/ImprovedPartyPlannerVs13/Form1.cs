using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImprovedPartyPlannerVs13
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public int numberOfDinnerGuestsHolder;
        public decimal DinnerCost;

        BirthdayParty birthdayParty;
        public int numberOfBirthdayGuestsHolder;
        public string messageHolder;
        public int cakeLettersLeft;
        public decimal BirthdayCost;
        
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty();
            birthdayParty = new BirthdayParty();

            UpdateDinnerDisplay();
            UpdateBirthdayDisplay();

        }

        private void UpdateBirthdayDisplay()
        {
            
            // Reads number of Birthday guests from UpDown
            numberOfBirthdayGuestsHolder = (int)birthdayUpDown.Value;
            //Based on that, retreives cake size and displays that info
            cakeSizeLabel.Text = birthdayParty.decideCakeSize(numberOfBirthdayGuestsHolder);

            // Grabs cake message
            messageHolder = (string)cakeMessage.Text;
            // Sends the string from the textbox to be counted and returns characters left
            cakeLettersLeft = birthdayParty.lettersLeft(messageHolder);
            // Displays how many characters remain or are over limit
            additionalCharactersLabel.Text = cakeLettersLeft.ToString();
            // Turns the character remaining label red (white letters) if over the limit,
            // green (black letters) if under character limit 
            if (cakeLettersLeft < 0)
            {
                additionalCharactersLabel.BackColor = Color.Red;
                additionalCharactersLabel.ForeColor = Color.White;
            }
            else
            {
                additionalCharactersLabel.BackColor = Color.SpringGreen;
                additionalCharactersLabel.ForeColor = Color.Black;

            }

            // Calculates Birthday Party cost, displays cost
            BirthdayCost = birthdayParty.CostOfBirthdayParty(numberOfBirthdayGuestsHolder, !fancyBirthdayOption.Checked);
            birthdayCostBox.Text = BirthdayCost.ToString("c");


        }



        private void UpdateDinnerDisplay()
        {
            

            numberOfDinnerGuestsHolder = (int)dinnerGuestCountUpDown.Value;
            DinnerCost = dinnerParty.CostOfParty(numberOfDinnerGuestsHolder, !healthyBox.Checked, !fancyBox.Checked);

            costDisplay.Text = DinnerCost.ToString("c");
        }

        private void guestCountUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateDinnerDisplay();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDinnerDisplay();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDinnerDisplay();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateBirthdayDisplay();
        }

        private void birthdayPartyTab_Click(object sender, EventArgs e)
        {
            UpdateBirthdayDisplay();
        }

        private void birthdayUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateBirthdayDisplay();
        }

        private void fancyBirthdayOption_CheckedChanged(object sender, EventArgs e)
        {
            UpdateBirthdayDisplay();
        }

        private void cakeMessage_TextChanged(object sender, EventArgs e)
        {
            UpdateBirthdayDisplay();
        }


    }
}
