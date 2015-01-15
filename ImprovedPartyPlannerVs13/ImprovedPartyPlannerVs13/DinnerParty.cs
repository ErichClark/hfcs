using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprovedPartyPlannerVs13
{
    class DinnerParty : Party
    {
        // This class does all Dinner Party cost calculations 
        public decimal CostOfParty(int numberOfGuests, bool fancy, bool healthy)
        {
            // resets totalCost variable 
            totalCost = 0;

            // decides if large group fee will be charged, adds charge
            totalCost += assessLargePartyFee(numberOfGuests);

            // adds food cost to total
            totalCost += assessFoodCost(numberOfGuests);
 
            // add cost of decorations per person
            totalCost += assessDecorationCost(fancy, numberOfGuests);

            // add drinks cost or applies discount
            totalCost = assessHealthyCost(healthy, numberOfGuests);

            return totalCost;
            
        }
    }
}
