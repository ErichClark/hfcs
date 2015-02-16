using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PartyPlannerBetaVs13
{
    class BirthdayParty : Party
    {
        private decimal birthdayCost = 0;

        public decimal CalculateBirthdayCost()
        {
            // Parent Party class takes care of per-person 
            // food and decorations costs. 
            birthdayCost = BasePartyCost();


            
            return birthdayCost;
        }
        
        
        public string assessCakeSize(int numberOfGuests)
        {
            
            // decides if small or large cake is used, 
            // and returns cake description string
            if (numberOfGuests <= SMALL_CAKE_GUEST_LIMIT)
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

        public int assessLettersLeft(string messageForCake)
        {
            // Counts number of cake letters,
            // then updates the numberOfCakeLetters variable 
            numberOfCakeLetters = messageForCake.Length;
            if (IsSmallCake)
                return SMALL_CAKE_LETTER_LIMIT - numberOfCakeLetters;

            else
                return BIG_CAKE_LETTER_LIMIT - numberOfCakeLetters;
        }

        protected decimal assessLetteringCost(string cakeMessage)
        {
            letteringCost = 0;
            numberOfCakeLetters = cakeMessage.Length;
            if (IsSmallCake)
            {
                letteringCost += SMALL_CAKE_COST;
                if (numberOfCakeLetters < SMALL_CAKE_LETTER_LIMIT)
                    letteringCost += (numberOfCakeLetters * COST_PER_LETTER);
                else
                    // Will not charge over maximum character count
                    letteringCost += (SMALL_CAKE_LETTER_LIMIT * COST_PER_LETTER);
            }

            // large cake and letter costs
            if (!IsSmallCake)
            {
                letteringCost += BIG_CAKE_COST;
                if (numberOfCakeLetters < BIG_CAKE_LETTER_LIMIT)
                    letteringCost += (numberOfCakeLetters * COST_PER_LETTER);
                else
                    // Will not charge over maximum character count
                    letteringCost += (BIG_CAKE_LETTER_LIMIT * COST_PER_LETTER);
            }
            return letteringCost;
        }
    }
}
