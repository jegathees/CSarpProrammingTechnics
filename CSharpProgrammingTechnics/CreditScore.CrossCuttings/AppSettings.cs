using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditScore.CrossCuttings
{
    public class AppSettings
    {
        public string Secret { get; set; }

        public JWT jwt { get; set; }
    }

    public class JWT
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public double DurationInMinutes { get; set; }
    }
}
