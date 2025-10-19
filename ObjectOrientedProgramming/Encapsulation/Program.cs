// C# OOP - 2.2 Encapsulation

using System;

namespace ObjectOrientedProgramming.Encapsulation
{
    public class BankAccount
    {
        // Private field (hidden from outside)
        private decimal balance;

        // Public property (read-only from outside)
        public decimal Balance
        {
            get { return balance; }
            private set { balance = value; } // Only modifiable internally
        }

        // Constructor
        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        // Deposit method (controls adding money)
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: ${amount}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Withdraw method (controls removing money)
        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: ${amount}");
                return true;
            }
            else
            {
                Console.WriteLine("Withdrawal failed: insufficient funds or invalid amount.");
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(500);

            Console.WriteLine($"Initial Balance: ${account.Balance}");

            account.Deposit(200);
            account.Withdraw(100);
            account.Withdraw(700); // Should fail

            Console.WriteLine($"Final Balance: ${account.Balance}");
        }
    }
}

/* Expected Output when running 'dotnet run'

Initial Balance: $500
Deposited: $200
Withdrawn: $100
Withdrawal failed: insufficient funds or invalid amount.
Final Balance: $600
*/