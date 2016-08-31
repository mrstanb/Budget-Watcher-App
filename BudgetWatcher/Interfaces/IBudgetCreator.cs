
using System;
using BudgetDB;

namespace BudgetWatcher.Interfaces
{
public interface IBudgetCreator
{
    Budget CreateBudget(decimal budget);
}
}
