using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp.Classes
{
    class Expenditure
    {
        public int expID { get; set; }
        public string expType { get; set; }
        public string expName { get; set; }
        public double expAmount { get; set; }
    }
}
