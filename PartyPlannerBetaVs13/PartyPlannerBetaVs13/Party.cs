using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlannerBetaVs13
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

        protected int numberOfGuests;
        protected bool fancy;
        protected decimal baseCost;
        protected decimal totalCost;
        protected bool IsSmallCake;
        protected int numberOfCakeLetters;
        protected decimal letteringCost;


        public decimal BasePartyCost()
        {
            // resets totalCost variable 
            baseCost = 0;

            // decides if large group fee will be charged, adds charge
            if (numberOfGuests > LARGE_PARTY_LIMIT)
                baseCost += LARGE_PARTY_FEE;

            // adds food cost to total
            baseCost += (numberOfGuests * FOOD_FEE_PER_PERSON);

            // add cost of decorations per person
            if (fancy)
            {
                baseCost += (numberOfGuests * FANCY_COST);
                baseCost += FANCY_FEE;
            }
            else
            {
                baseCost += (numberOfGuests * NOT_FANCY_COST);
                baseCost += NOT_FANCY_FEE;
            }

            return baseCost;
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
