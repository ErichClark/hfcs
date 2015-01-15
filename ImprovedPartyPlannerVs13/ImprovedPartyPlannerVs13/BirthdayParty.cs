using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprovedPartyPlannerVs13
{
    class BirthdayParty
    {
        private decimal totalCost = 0;
        private const decimal FOOD_FEE_PER_PERSON = 25.00M;

        private const decimal FANCY_COST = 7.50M;
        private const decimal FANCY_FEE = 30M;

        private const decimal NOT_FANCY_COST = 15M;
        private const decimal NOT_FANCY_FEE = 50M;

        private const decimal SMALL_CAKE_GUEST_LIMIT = 4;
        private bool IsSmallCake = true;
        private int numberOfCakeLetters = 0;
        public bool LettersWillFit = true;

        private const int SMALL_CAKE_LETTER_LIMIT = 16;
        private const decimal SMALL_CAKE_COST = 40M;
        
        private const int BIG_CAKE_LETTER_LIMIT = 40;
        private const decimal BIG_CAKE_COST = 75M;

        private const decimal COST_PER_LETTER = 0.25M;
        private const int LARGE_PARTY_LIMIT = 12;
        private const decimal LARGE_PARTY_FEE = 100M;

        public string decideCakeSize(int numberOfBirthdayGuests)
        {
            // decides if small or large cake is used, 
            // and returns cake description
            if (numberOfBirthdayGuests <= SMALL_CAKE_GUEST_LIMIT)
            {
                IsSmallCake = true;
                return "Small cake- " + SMALL_CAKE_LETTER_LIMIT + " characters max.";
            }
            else
            {
                IsSmallCake = false;
                return "Large cake- " + BIG_CAKE_LETTER_LIMIT + " characters max.";
            }
        }

        public int lettersLeft( int numberOfCharacters)
        {
            if (IsSmallCake)
            {
                return SMALL_CAKE_LETTER_LIMIT - numberOfCharacters;
            }
            else
            {
                return BIG_CAKE_LETTER_LIMIT - numberOfCharacters;
            }
                

        }

        public int letteringLength(string actualMessage)
        {
            numberOfCakeLetters = actualMessage.Length;
            return numberOfCakeLetters;
        }

        
        //This class does all Birthday Party Cost Calculations
        public decimal CostOfBirthdayParty(int numberOfGuests, bool fancy, string lettering)
        {
            // Holds, resets totalCost variable 
            totalCost = 0;
            
            // Decides if large group fee will be charged, adds charge
            if (numberOfGuests > LARGE_PARTY_LIMIT)
                totalCost += LARGE_PARTY_FEE;

            // adds food cost to total
            totalCost += (numberOfGuests * FOOD_FEE_PER_PERSON);

            // adds cost of decorations per person
            if (fancy)
            {
                totalCost += (numberOfGuests * FANCY_COST);
                totalCost += FANCY_FEE;
            }
            else
            {
                totalCost += (numberOfGuests * NOT_FANCY_COST);
                totalCost += NOT_FANCY_FEE;
            }

            // small cake letter costs
            if (IsSmallCake)
            {
                totalCost += SMALL_CAKE_COST;
                if (numberOfCakeLetters < SMALL_CAKE_LETTER_LIMIT)
                    totalCost += (numberOfCakeLetters * COST_PER_LETTER);
                else
                    totalCost += (SMALL_CAKE_LETTER_LIMIT * COST_PER_LETTER);
            }

            // large cake letter costs
            if (!IsSmallCake)
            {
                totalCost += BIG_CAKE_COST;
                if (numberOfCakeLetters < BIG_CAKE_LETTER_LIMIT)
                    totalCost += (numberOfCakeLetters * COST_PER_LETTER);
                else
                    totalCost += (BIG_CAKE_LETTER_LIMIT * COST_PER_LETTER);
            }

            return totalCost;
        }
    }
}
