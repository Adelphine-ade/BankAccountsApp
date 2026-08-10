using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountsApp
{
    public class SavingsAccount:BankAccount
    {
 
        public decimal InterestRate { get; set; }

        public SavingsAccount(string owner, decimal interestRate):base(owner + " ("+interestRate+"%)")
        {
         InterestRate = interestRate;
        }
        public override string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "you can't deposit $" + amount;

            if (amount >= 50000)
                return "ALM Deposit limit Reached.";
            decimal interestAmount = (InterestRate / 100) * amount;
            Balance += amount + interestAmount;
            return "Deposit Completed Successfully.";

        }
    }
}
