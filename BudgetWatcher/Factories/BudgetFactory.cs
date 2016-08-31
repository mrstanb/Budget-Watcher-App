
using System;
using BudgetDB;
using BudgetWatcher.Interfaces;

namespace BudgetWatcher.Factories
{
public class BudgetFactory : IBudgetCreator
    {
        public Budget CreateBudget(decimal budget)
        {

            if (budget <= 0)
            {
             throw new ArgumentException("Budget cannot be negative or equals to zero!");
            }
            
            Budget bg = new Budget(budget);
            return bg;
        }
    }
}
