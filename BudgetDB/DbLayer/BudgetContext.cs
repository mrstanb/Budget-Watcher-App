
using System.Data.Entity;

namespace BudgetDB
{
   public class BudgetContext : DbContext
    {
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<Outcome> Outcomes { get; set; }
    }
}
