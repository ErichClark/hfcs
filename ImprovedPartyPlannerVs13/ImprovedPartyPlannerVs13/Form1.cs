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
        public int numberOfGuestsHolder;
        public decimal Cost = 0;
        
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty();

            UpdateDisplay();

        }

        private void UpdateDisplay()
        {
            

            numberOfGuestsHolder = (int)guestCountUpDown.Value;
            Cost = dinnerParty.CostOfParty(numberOfGuestsHolder, !healthyBox.Checked, !fancyBox.Checked);

            costDisplay.Text = Cost.ToString("c");
        }

        private void guestCountUpDown_ValueChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDisplay();
        }
    }
}
