using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Classes
{
    public class CreditCards
    {
        public int cardID { get; set; }
        public string cardName { get; set; }
        public double cardAmount { get; set; }
        public double cardLimit { get; set; }
        public double cardOwing { get; set; }
    }
}
