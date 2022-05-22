using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public interface IAccount
    {
        string AccontName();
        int AccountNumber();
        decimal AccountBalance();

    }
    interface IAccountTransaction
    {
        int Transaction();
    }
    public class SalaryAccount : IAccount, IAccountTransaction
    {
        public string AccontName()
        {
            return "Nakshatra";
        }

        public decimal AccountBalance()
        {
            return 50000;
        }

        public int AccountNumber()
        {
            return 181229;
        }

        int Transaction()
        {
            return 1430;
        }

        int IAccountTransaction.Transaction()
        {
            return 1430;
        }
    }

}