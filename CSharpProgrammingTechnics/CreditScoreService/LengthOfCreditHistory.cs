using System;
using System.Collections.Generic;
using System.Text;

namespace CreditScore.DAL
{
    public class LengthOfCreditHistory : ILengthOfCreditHistory
    {
        public int GetLengthOfCreditHistory()
        {
            return 35;
        }
    }
}
