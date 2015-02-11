using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkoutCalculatorVS13
{
    public partial class Form1 : Form
    {
        Workout workout;
        public Form1()
        {
            InitializeComponent();
            workout = new Workout(5, 1);
            updateDisplay();
        }

        private void updateDisplay()
        {
            caloriesLabel.Text = workout.CaloriesBurned().ToString();
        }

        private void minutes_UpDown_ValueChanged(object sender, EventArgs e)
        {
            workout.WorkoutLengthInMinutes = (double)minutes_UpDown.Value;
            updateDisplay();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            workout.CaloriesPerMinute = (double)caloriesPerMinute_UpDown.Value;
            updateDisplay();
        }


    }
}
