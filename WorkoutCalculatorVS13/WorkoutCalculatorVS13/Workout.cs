using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutCalculatorVS13
{
    class Workout
    {
        public double CaloriesBurned { get; private set; }
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
                CaloriesBurned = workoutLengthInMinutes * caloriesPerMinute;
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
                CaloriesBurned = workoutLengthInMinutes * caloriesPerMinute;
            }
        }

        
    }
}