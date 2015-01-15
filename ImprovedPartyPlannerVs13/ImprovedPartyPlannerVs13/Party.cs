using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprovedPartyPlannerVs13
{
    // The parent Party Class includes all fee constants
    // and fee calculators.
    // Child party classes can be assembled using Party methods 
    class Party
    {
        protected const int LARGE_PARTY_LIMIT = 12;
        protected const decimal LARGE_PARTY_FEE = 100M;
        protected const decimal FOOD_FEE_PER_PERSON = 25.00M;

        protected const decimal FANCY_COST = 7.50M;
        protected const decimal FANCY_FEE = 30M;
        protected const decimal NOT_FANCY_COST = 15M;
        protected const decimal NOT_FANCY_FEE = 50M;
        
        protected const decimal SMALL_CAKE_GUEST_LIMIT = 4;
        protected const int SMALL_CAKE_LETTER_LIMIT = 16;
        protected const decimal SMALL_CAKE_COST = 40M;
        protected const int BIG_CAKE_LETTER_LIMIT = 40;
        protected const decimal BIG_CAKE_COST = 75M;
        protected const decimal COST_PER_LETTER = 0.25M;

        protected const decimal NOT_HEALTHY_COST = 20.00M;
        protected const decimal HEALTHY_COST = 5.00M;
        protected const decimal HEALTHY_DISCOUNT = 0.95M;

        protected decimal totalCost;
        protected decimal decorationCost;
        protected bool IsSmallCake;
        protected int numberOfCakeLetters;
        protected decimal letteringCost;
        

        protected decimal assessFoodCost(int numberOfGuests)
        {
            // adds food cost to total
            return (numberOfGuests * FOOD_FEE_PER_PERSON);
        }

        protected decimal assessLargePartyFee(int numberOfGuests)
        {
            if (numberOfGuests > LARGE_PARTY_LIMIT)
                return LARGE_PARTY_FEE;

            else return 0M;
        }

        protected decimal assessDecorationCost(bool fancy, int numberOfGuests)
        {
            decorationCost = 0;
            
            // adds cost of decorations per person
            if (fancy)
            {
                decorationCost += (numberOfGuests * FANCY_COST);
                decorationCost += FANCY_FEE;
            }
            else
            {
                decorationCost += (numberOfGuests * NOT_FANCY_COST);
                decorationCost += NOT_FANCY_FEE;
            }
            return decorationCost;
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

        protected decimal assessHealthyCost(bool healthy, int numberOfGuests)
        {
            if (healthy)
            {
                totalCost += (numberOfGuests * HEALTHY_COST);

                totalCost *= HEALTHY_DISCOUNT;
            }
            else
            {
                totalCost += (numberOfGuests * NOT_HEALTHY_COST);
            }

            return totalCost;
        }
    }
        
}

