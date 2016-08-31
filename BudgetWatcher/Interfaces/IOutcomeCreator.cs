
using BudgetDB;

namespace BudgetWatcher.Factories
{
  public interface IOutcomeCreator
    {
        Outcome GreateOutcome(int id, decimal food, decimal transport, decimal house, decimal bills, decimal leasure);
    }
}

//FoodSpendings = foodSpendings;
//           TransportSpendings = transportSpendings;
//           HouseSpendings = houseSpendings;
//           BillSpendings = billSpendings;
//           LeasureSpendings = leasureSpendings;
//           SpendingsSum = foodSpendings + transportSpendings + houseSpendings + billSpendings + leasureSpendings;
//           CurrentDate = DateTime.Today;