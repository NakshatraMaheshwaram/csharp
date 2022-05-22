using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class CurrentAccount : Account
    {
        public override string AccountName()
        {
            return "Nakshatra";
        }
        public override int AccountNumber()
        {
            return 12345;
        }
        public override decimal AccountBalance()
        {
            return 40000;
        }
        public override string ATM()
        {
            return "ATM is available";
        }
    }
}

