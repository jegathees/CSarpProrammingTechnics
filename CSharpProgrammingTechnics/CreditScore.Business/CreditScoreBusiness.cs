using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreditScore.DAL;

namespace CreditScore.Business
{
    public class CreditScoreBusiness : ICreditScoreBusiness
    {
        private readonly ICreditScoreService _creditScoreService;

        public CreditScoreBusiness(ICreditScoreService creditScoreService)
        {
            _creditScoreService = creditScoreService;
        }
        public int GetCreditScore()
        {
            return _creditScoreService.GetCreditScore();
        }
    }
}
