using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountOperationApp
{
    class AccountCreation
    {
        public string accountNo;
        public string name;
        public double amount=0;

        public double Diposit(double newAmount) {

            return amount += newAmount;
        }
        public double Withdraw(double newAmount) {

            return amount -= newAmount;
        }
    }
}
