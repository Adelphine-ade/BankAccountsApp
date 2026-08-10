using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountsApp
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; protected set; }

        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        }
        public virtual string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "you can't deposit $" + amount;

            if (amount >= 50000)
                return "ALM Deposit limit Reached.";
            Balance += amount;
            return "Deposit Completed Successfully.";

        }
        public string Withdraw (decimal amount)
        {
            if (amount <= 0)
                return "you can't withdraw $" + amount;

            if (amount >= Balance)
                return "You don't have enough money.";
            Balance -= amount;
            return "Withdraw Completed Successfully.";

        }
    }
}