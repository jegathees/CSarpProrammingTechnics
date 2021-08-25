using CreditScore.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditScore.DAL
{
    public class CreditScoreService : ICreditScoreService
    {
        private readonly IAmountOwed _amountOwed;
        private readonly ICreditMix _creditMix;
        private readonly IGetPaymentHistory _getPaymentHistory;
        private readonly ILengthOfCreditHistory _lengthOfCreditHistory;
        private readonly INewCredit _newCredit;

        public CreditScoreService(IAmountOwed amountOwed, ICreditMix creditMix, 
            IGetPaymentHistory getPaymentHistory, ILengthOfCreditHistory lengthOfCreditHistory, INewCredit newCredit)
        {
            _amountOwed = amountOwed;
            _creditMix = creditMix;
            _getPaymentHistory = getPaymentHistory;
            _lengthOfCreditHistory = lengthOfCreditHistory;
            _newCredit = newCredit;
        }
        public int GetCreditScore()
        {
            return _amountOwed.GetAmountOwned() + _creditMix.GetCreditMix() + _getPaymentHistory.GetPaymentistory()
                + _lengthOfCreditHistory.GetLengthOfCreditHistory() + _newCredit.GetNewCredit();
        }

    }
}
