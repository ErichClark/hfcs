using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprovedPartyPlannerVs13
{
    class BirthdayParty : Party
    {
        //This class does all Birthday Party Cost Calculations
        public decimal CostOfBirthdayParty(int numberOfGuests, bool fancy, string lettersOnCake)
        {
            // Resets totalCost variable 
            totalCost = 0;
            
            // Decides if large group fee will be charged, adds charge
            totalCost += assessLargePartyFee(numberOfGuests);

            // adds food cost to total
            totalCost += assessFoodCost(numberOfGuests);

            // adds cost of decorations per person
            totalCost += assessDecorationCost(fancy, numberOfGuests);

            // cake and lettering costs
            totalCost += assessLetteringCost(lettersOnCake);

            return totalCost;
        }
    }
}
