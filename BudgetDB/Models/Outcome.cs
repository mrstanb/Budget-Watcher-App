using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BudgetDB
{
   public class Outcome// : IOutcome
   {
       public Outcome(int id, decimal foodSpendings, decimal transportSpendings, decimal houseSpendings, decimal billSpendings, decimal leasureSpendings)
       {
           FoodSpendings = foodSpendings;
           TransportSpendings = transportSpendings;
           HouseSpendings = houseSpendings;
           BillSpendings = billSpendings;
           LeasureSpendings = leasureSpendings;
           SpendingsSum = foodSpendings + transportSpendings + houseSpendings + billSpendings + leasureSpendings;
           CurrentDate = DateTime.Today;
           this.BudgetId = id;
       }
        [Key]
        [Required]
        public int Id { get; set; }
    
        public int BudgetId { get; set; }
        [ForeignKey("BudgetId")]
       public virtual Budget Budget { get; set; }

       public decimal FoodSpendings { get; set; }
    
       public decimal TransportSpendings { get; set; }
   
       public decimal HouseSpendings { get; set; }

       public decimal BillSpendings { get; set; }

       public decimal LeasureSpendings { get; set; }
        
       public decimal SpendingsSum { get; set; }

       [Required]
       public DateTime CurrentDate { get; set; }

   }
}
