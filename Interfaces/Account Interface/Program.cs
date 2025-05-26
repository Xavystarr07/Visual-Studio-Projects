using System;

// Define the interface IAccount
interface IAccount
{
    void Deposit(double amount);
    void Withdraw(double amount);
    void Credit(double amount);
}

// Implement the Account class
class Account : IAccount
{
    private double startingBalance;
    private double currentBalance;
    private double overdraft;

    // Constructor to initialize startingBalance and currentBalance
    public Account(double startingBalance)
    {
        this.startingBalance = startingBalance;
        this.currentBalance = startingBalance;
        this.overdraft = 0; // Assuming overdraft is initially zero
    }

    // Implementing methods from the interface
    public void Deposit(double amount)
    {
        currentBalance += amount;
        Console.WriteLine($"Deposited: {amount:C}. Current Balance: {currentBalance:C}");
    }

    public void Withdraw(double amount)
    {
        if (currentBalance - amount >= overdraft)
        {
            currentBalance -= amount;
            Console.WriteLine($"Withdrawn: {amount:C}. Current Balance: {currentBalance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient funds!");
        }
    }

    public void Credit(double amount)
    {
        currentBalance += amount;
        Console.WriteLine($"Credited: {amount:C}. Current Balance: {currentBalance:C}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an object of type Account
        Account account = new Account(1000); // Starting balance is 1000

        // Call the methods
        account.Deposit(500);
        account.Withdraw(200);
        account.Credit(300);
    }
}
