using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Playstore;

namespace Playstore
{
    public interface IBankingSystem
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        decimal CalculateInterest();
        decimal ViewBalance();
    }
}
public class Bank
{
    public List<IBankingSystem> Accounts { get; private set; } // List to store accounts

    public Bank()
    {
        Accounts = new List<IBankingSystem>();
    }

    public void AddAccount(IBankingSystem account)
    {
        Accounts.Add(account);
        Console.WriteLine("Account added successfully.");
    }

    public void DisplayAllAccounts()
    {
        Console.WriteLine("Listing all accounts:");
        foreach (var account in Accounts)
        {
            Console.WriteLine($"Account Type: {account.GetType().Name}, Balance: {account.ViewBalance():C}");
        }
    }
}