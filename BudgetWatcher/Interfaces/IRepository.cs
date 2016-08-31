
namespace BudgetWatcher.Repository
{
   public interface IRepository<TEntity> where TEntity : class
   {
       void AddBudget(TEntity type);
       void AddSpending(TEntity type);
       decimal TotalSpendings();
    //   void RemoveBudget();
       string GetReport();
       int GetBudgetId();
       decimal GetLastBudget();


   }
}
