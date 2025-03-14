
using System;

class Account
{
    private string name;
    private double balance;

    public Account(string name, double initialBalance)
    {
        this.name = name;
        this.balance = initialBalance < 0 ? 0 : initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    public void Withdrawal(double amount)
    {
        if (amount > 0 && balance >= amount)
        {
            balance -= amount;
        }
    }

    public double GetBalance()
    {
        return balance;
    }

    public override string ToString()
    {
        return $"{name}: {balance} USD";
    }
}

class Program
{
    static void Main()
    {
        Account heikkisAccount = new Account("Heikki's account", 100.00);
        Account heikkisSwissAccount = new Account("Heikki's account in Switzerland", 1000000.00);

        heikkisAccount.Withdrawal(20);
        Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount.GetBalance());

        heikkisSwissAccount.Deposit(200);
        Console.WriteLine("The balance of Heikki's other account is now: " + heikkisSwissAccount.GetBalance());
    }
}
