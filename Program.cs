using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem1
{
    internal class SavingsAccount : Account
    {
        public override string AccountName()
        {
            return ("Ravi");
        }
        public override int AccountNumber()
        {
            return (14111198120181);
        }
        public override decimal AccountBalance()
        {
            return (14300);
        }
        public override string ATM()
        {
            return ("ATM is avilable");
        }
    }
}