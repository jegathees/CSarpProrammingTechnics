using System;
using System.Collections.Generic;
using System.Text;

namespace CreditScore.DAL
{
    public class CreditMix : ICreditMix
    {
        public int GetCreditMix()
        {
            return 50;
        }
    }
}
