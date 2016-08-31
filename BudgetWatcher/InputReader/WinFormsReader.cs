
using System;
using System.Collections.Generic;

namespace BudgetWatcher.InputReader
{
   public static class WinFormsReader
    {
        public static decimal BudgetInput { get; set; }

        public static decimal[] SpendingsInput = new decimal[5];

    

       public static decimal ReadBudget(string budget)
       {
           decimal parsed;
            if (string.IsNullOrEmpty(budget))
            {
                return 0;
            }
            if (Decimal.TryParse(budget, out parsed))
           {
              return parsed;
           }
           else
           {
               throw new ArgumentException("Input for budget was invalid!");
           }
       }

        public static decimal ReadSpending(string spending)
        {
            decimal parsed;
            if (string.IsNullOrEmpty(spending))
            {
                return 0;
            }
            else if (Decimal.TryParse(spending, out parsed))
            {
                return parsed;
            }
            else
            {
                throw new ArgumentException("Input for spendings was incorrect!");
            }
        }
    }
}
