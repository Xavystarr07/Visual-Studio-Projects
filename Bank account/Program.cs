using System;
class BankAccount
{
    // Properties
    public int AccountNumber { get; set; }
    public string AccountHolderName { get; set; }
    public double Balance { get; private set; }

    // Constructor
    public BankAccount(int accountNumber, string accountHolderName, double balance)
    {
        AccountNumber = accountNumber;
        AccountHolderName = accountHolderName;
        Balance = balance;
    }

    // Method to deposit money
    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance: {Balance}");
    }

    // Method to withdraw money
    public virtual void Withdraw(double amount)
    {
        Balance -= amount;
        Console.WriteLine($"Withdrawn {amount}. New balance: {Balance}");
    }
}

class SavingsAcc : BankAccount
{
    // Constructor
    public SavingsAcc(int accountNumber, string accountHolderName, double balance)
        : base(accountNumber, accountHolderName, balance)
    {
    }

    // Override Withdraw method to impose minimum balance requirement
    public override void Withdraw(double amount)
    {

        if (Balance - amount >= 100) // Minimum balance requirement
        {
            base.Withdraw(amount);
        }
        else
        {
            Console.WriteLine("Withdrawal failed: Minimum balance requirement not met.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create objects of BankAccount and SavingsAccount
        BankAccount account1 = new BankAccount(1, "Xavier Chetty", 500);
        SavingsAcc account2 = new SavingsAcc(2, "Jaou Linen", 1000);

        // Deposit and withdraw from both accounts
        account1.Deposit(200);
        account1.Withdraw(100);

        account2.Deposit(300);
        account2.Withdraw(200);
    }
}
