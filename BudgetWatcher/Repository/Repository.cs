using System;
using System.Linq;
using System.Text;
using BudgetDB;

namespace BudgetWatcher.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly BudgetContext Context;

        public Repository()
        {
            this.Context = new BudgetContext();
        }

        public void AddBudget(TEntity type)
        {
            this.Context.Set<TEntity>().Add(type);
            this.Context.SaveChanges();
        }

        public void AddSpending(TEntity type)
        {

            this.Context.Set<TEntity>().Add(type);
            this.Context.SaveChanges();
        }

        public decimal TotalSpendings()
        {
            int bId = GetBudgetId();
            if (this.Context.Outcomes.Where(x => x.BudgetId == bId).Any())
            {
               return this.Context.Outcomes.Where(x => x.BudgetId == bId).Select(x => x.SpendingsSum).Sum();
            }
            return 0;
        }

        public int GetBudgetId()
        {
           var obj = this.Context.Budgets.ToList().LastOrDefault();
            return obj.Id;
        }

        public decimal GetLastBudget()
        {
            int bId = GetBudgetId();
            return Context.Budgets.Where(x => x.Id == bId).ToList().First().TotalBudget;
        }

     //   public void RemoveBudget(TEntity type)
     //   {
     ////       Budget type = new Budget();
     //       var budget = (Budget)type;
     //       this.Context.Budgets.Remove(type);
     //   }


        public string GetReport()
        {
            if (Context.Budgets.Any())
            {
                string dt = Context.Budgets.Select(x => x.BudgetSetDate).ToList().LastOrDefault().ToString();
                int spaceIndex = dt.IndexOf(' ') - (dt.IndexOf('.') + 1);
                string budgetDate = dt.Substring(dt.IndexOf('.') + 1, spaceIndex);

                int bId = GetBudgetId();
                string totay = DateTime.Today.ToString().Split(' ')[0];

                StringBuilder sb = new StringBuilder();
                sb.Append("Monthly budget: ");
                sb.Append(Context.Budgets.ToList().Select(x => x.TotalBudget).LastOrDefault());
                sb.Append("\nfor: ");
                sb.Append(budgetDate);
         //       sb.Append(Context.Budgets.Select(x => x.BudgetSetDate).First());
                sb.Append("\nTotal money spent: ");
                if (Context.Outcomes.Where(x => x.BudgetId == bId).Any())
                {
                    sb.Append(Context.Outcomes.Where(x => x.BudgetId == bId).Select(x => x.SpendingsSum).Sum());
                    sb.Append("\n-spent for food: ");
                    sb.Append(Context.Outcomes.Where(x => x.BudgetId == bId).Select(x => x.FoodSpendings).Sum());
                    sb.Append("\n-spent for transport: ");
                    sb.Append(Context.Outcomes.Where(x => x.BudgetId == bId).Select(x => x.TransportSpendings).Sum());
                    sb.Append("\n-spent for accomodation: ");
                    sb.Append(Context.Outcomes.Where(x => x.BudgetId == bId).Select(x => x.HouseSpendings).Sum());
                    sb.Append("\n-spent for bills: ");
                    sb.Append(Context.Outcomes.Where(x => x.BudgetId == bId).Select(x => x.BillSpendings).Sum());
                    sb.Append("\n-spent for leisure: ");
                    sb.Append(Context.Outcomes.Where(x => x.BudgetId == bId).Select(x => x.LeasureSpendings).Sum());
                    sb.Append("\nToday's date is: ");
                    sb.Append(totay);
//  one more line   ///     
                    return sb.ToString();
                }
                 sb.Append("\nYou have not spent any money yet!");
                sb.Append("\nToday's date is: ");
                sb.Append(totay);
                return sb.ToString();
            }
            return "You have not set budget yet!";
        }

    }
}
