using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1.BL
{
    public class DepositAccount : Account
    {
        public DepositAccount() : base()
        {
            Name = "Депозит без капитализации";
        }
        public DepositAccount(Client<Account> owner, double startBalance = 0, double interestRate = 0) : base(owner, startBalance, interestRate)
        {
            Name = "Депозит без капитализации";
        }

    }
}
