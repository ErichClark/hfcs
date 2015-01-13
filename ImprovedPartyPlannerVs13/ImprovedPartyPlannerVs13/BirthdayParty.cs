using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprovedPartyPlannerVs13
{
    class BirthdayParty
    {
        private const decimal FOOD_FEE_PER_PERSON = 25.00M;

        private const decimal FANCY_COST = 7.50M;
        private const decimal FANCY_FEE = 30M;

        private const decimal NOT_FANCY_COST = 15M;
        private const decimal NOT_FANCY_FEE = 50M;

        private const decimal SMALL_CAKE_GUEST_LIMIT = 4;
        private bool IsSmallCake = true;
        public bool LettersWillFit = true;

        private const decimal SMALL_CAKE_LETTER_LIMIT = 16;
        private const decimal SMALL_CAKE_COST = 40M;
        
        private const decimal BIG_CAKE_LETTER_LIMIT = 40;
        private const decimal BIG_CAKE_COST = 75M;

        private const decimal COST_PER_LETTER = 0.25M;

        public string decideCakeSize(int numberOfBirthdayGuests)
        {
            // decides if small or large cake is used
            if (numberOfBirthdayGuests <= SMALL_CAKE_GUEST_LIMIT)
            {
                IsSmallCake = true;
                return "Small cake- 16 characters max";
            }
            else
            {
                IsSmallCake = false;
                return "Large cake- 40 characters max";
            }
        }
        
        //This class does all Birthday Party Calculations
        public decimal CostOfBirthdayParty(int numberOfGuests, bool fancy, string lettering)
        {
            // Holds, resets totalCost variable, number of cake letters 
            decimal totalCost = 0;
            int numberOfCakeLetters = lettering.Length;

            

            // adds food cost to total
            totalCost = totalCost + (numberOfGuests * FOOD_FEE_PER_PERSON);

            // adds cost of decorations per person
            if (fancy)
            {
                totalCost = totalCost + (numberOfGuests * FANCY_COST);
                totalCost += FANCY_FEE;
            }
            else
            {
                totalCost = totalCost + (numberOfGuests * NOT_FANCY_COST);
                totalCost += NOT_FANCY_FEE;
            }

            if (IsSmallCake)
            {
                if (numberOfCakeLetters < SMALL_CAKE_LETTER_LIMIT)
                {
                    cakeSizeLabel.Text = "small";
                }
            }


            return totalCost;
        }
    }
}
