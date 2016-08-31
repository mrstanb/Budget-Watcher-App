
using System.Data.Entity;
using BudgetDB;

namespace BudgetWatcher.Factories
{
public class OutcomeFactory : IOutcomeCreator
    {

        public Outcome GreateOutcome(int id, decimal food, decimal transport, decimal house, decimal bills, decimal leasure)
        {
            Outcome outcome = new Outcome(id, food, transport, house, bills, leasure);
            return outcome;
        }
    }
}
