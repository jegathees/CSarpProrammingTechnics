using System;
using System.Collections.Generic;
using System.Text;

namespace CreditScore.DAL
{
    public class AmountOwed : IAmountOwed
    {
        public int GetAmountOwned()
        {
            return 100;
        }
    }
}
