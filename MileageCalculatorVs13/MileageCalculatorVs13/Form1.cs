using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MileageCalculatorVs13
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;
        double milesTraveled;
        double reimburseRate = .39;
        double amountOwed;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            startingMileage = (int)startMiles.Value;
            endingMileage = (int)endMiles.Value;


            if (startingMileage < endingMileage)
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;

                amountOwedLabel.Text = "$" + amountOwed;
            }
            else
            {
                MessageBox.Show("The starting mileage must be less than the ending mileage.",
                    "Cannot Calculate Mileage");
            }
        } 
    }
}
