using System;
using System.Collections.Generic;
using System.Text;

namespace CreditScore.DAL
{
    public class NewCredit : INewCredit
    {
        public int GetNewCredit()
        {
            return 150;
        }
    }
}
