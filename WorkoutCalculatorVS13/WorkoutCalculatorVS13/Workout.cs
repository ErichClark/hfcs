using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutCalculatorVS13
{
    class Workout
    {
        
        private double caloriesPerMinute;
        private double workoutLengthInMinutes;

        public Workout(double workoutLengthInMinutes, double caloriesPerMinute)
        {
            this.caloriesPerMinute = caloriesPerMinute;
            WorkoutLengthInMinutes = workoutLengthInMinutes;
        }

        public double WorkoutLengthInMinutes
        {
            get
            {
                return workoutLengthInMinutes;
            }
            set
            {
                workoutLengthInMinutes = value;
            }
        }

        public double CaloriesPerMinute
        {
            get
            {
                return caloriesPerMinute;
            }
            set
            {
                caloriesPerMinute = value;
            }
        }

        public double CaloriesBurned()
        {
            return workoutLengthInMinutes * caloriesPerMinute;
        }
    }
}