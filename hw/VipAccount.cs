using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    class VipAccount : Account
    {
        public VipAccount(int accountNumber, double balance) : base(accountNumber, balance)
        {

        }
        public override void Withdraw(double amount)
        {
            if (balance - amount >= -5000)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Not enough money");
            }
        }

    }
}
