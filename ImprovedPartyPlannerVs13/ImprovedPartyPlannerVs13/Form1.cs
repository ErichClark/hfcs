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
        public string cakeSize;
        public decimal DinnerCost = 0;

        BirthdayParty birthdayParty;
        public int numberOfBirthdayGuestsHolder;
        public decimal BirthdayCost = 0;
        
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
            
            throw new NotImplementedException();
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

        }

        private void birthdayPartyTab_Click(object sender, EventArgs e)
        {
            UpdateBirthdayDisplay();
        }
    }
}
