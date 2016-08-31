




namespace BudgetDB
{

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Budget// : IBudget
    {
        public Budget(decimal totalBudget)
        {
            this.TotalBudget = totalBudget;
            this.BudgetSetDate = DateTime.Today;
        }

        public Budget()
        {
            
        }
       
        public int Id { get; set; }
    //    public int BudgetId { get; set; }
        [Required]
        public decimal TotalBudget { get; set; }
        [Required]
        public DateTime BudgetSetDate { get; set; }
    
        public List<Outcome> Outcomes { get; set; }



   //     public void SetBudget(decimal budgetMoney)



    //    public bool IsAbleToSpend(Outcome outcome)
    //    {
    //        decimal sum = outcomes.Select(x => x.GetTotalSpendings()).Sum() + outcome.GetTotalSpendings();
    //        if (TotalBudget <= sum)
    //        {
    //            return false;
    //            //   throw new ArgumentException("Your budget is too small to perform required spending!");
    //        }
    //        return true;
    //    }

    //    public void AddSpending(Outcome outcome)
    //    {
    //        if (IsAbleToSpend(outcome))
    //        {
    //          this.Outcomes.Add(outcome);  
    //        }
    //        else
    //        {
    //            throw new ArgumentException("this spending will excide you budget!");
    //        }   
    //    }
     }
}
