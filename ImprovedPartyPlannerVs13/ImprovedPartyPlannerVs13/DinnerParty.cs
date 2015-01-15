using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprovedPartyPlannerVs13
{
    class DinnerParty
    {
        
        // All fee variables are private, constant, and all in one place
        // NO MAGIC NUMBERS and a minimal quantity of variables

        private const int LARGE_PARTY_LIMIT = 12;
        private const decimal LARGE_PARTY_FEE = 100M;
        private const decimal FOOD_FEE_PER_PERSON = 25.00M; 
        
        private const decimal FANCY_COST = 15.00M;
        private const decimal FANCY_FEE = 50M;
        private const decimal NOT_FANCY_COST = 5.00M;
        private const decimal NOT_FANCY_FEE = 30M;
        
        private const decimal NOT_HEALTHY_COST = 20.00M;
        private const decimal HEALTHY_COST = 5.00M;
        private const decimal HEALTHY_DISCOUNT = 0.05M;

        private decimal totalCost;

        // This class does all of the cost calculations 
        public decimal CostOfParty(int numberOfGuests, bool fancy, bool healthy)
        {
            // resets totalCost variable 
            totalCost = 0;

            // Decides if large group fee will be charged, adds charge
            if (numberOfGuests > LARGE_PARTY_LIMIT)
                totalCost += LARGE_PARTY_FEE;

            // add food cost to total
            totalCost = totalCost + (numberOfGuests * FOOD_FEE_PER_PERSON);
 
            // add cost of decorations per person
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

            // add drinks cost and apply discount
            if (healthy)
            {
                totalCost = totalCost + (numberOfGuests * HEALTHY_COST);

                totalCost = totalCost - (numberOfGuests * HEALTHY_DISCOUNT);
            }
            else
            {
                totalCost = totalCost + (numberOfGuests * NOT_HEALTHY_COST);
            }

            return totalCost;
            
        }
    }
}
