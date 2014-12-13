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
        private const decimal foodFeePerPerson = 25.00M; 
        
        private const decimal fancyCost = 15.00M;
        private const decimal fancyFee = 50M;
        private const decimal notFancyCost = 5.00M;
        private const decimal notFancyFee = 30M;
        
        private const decimal notHealthyCost = 20.00M;
        private const decimal healthyCost = 5.00M;
        private const decimal healthyDiscount = 0.05M;

        // This class does all of the cost calculations 
        public decimal CostOfParty(int numberOfGuests, bool fancy, bool healthy)
        {
            decimal totalCost = 0;

            // add food cost to total
            totalCost = totalCost + (numberOfGuests * foodFeePerPerson);
 
            // add cost of decorations per person
            if (fancy)
            {
                totalCost = totalCost + (numberOfGuests * fancyCost);
                totalCost += fancyFee;
            }
            else
            {
                totalCost = totalCost + (numberOfGuests * notFancyCost);
                totalCost += notFancyFee;
            }

            // add drinks cost and apply discount
            if (healthy)
            {
                totalCost = totalCost + (numberOfGuests * healthyCost);

                totalCost = totalCost - (numberOfGuests * healthyDiscount);
            }
            else
            {
                totalCost = totalCost + (numberOfGuests * notHealthyCost);
            }

            return totalCost;
            
        }
    }
}
