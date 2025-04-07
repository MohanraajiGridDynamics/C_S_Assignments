// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    public static void Main()
    {
        Account account1 = new Account(1,"Mohan", 99999);
        account1.PrintDetails();
        account1.Deposit(10000);
        account1.Withdraw(100);
        Console.WriteLine();
        
        Account account2 = new Account(1,"Jake", 10999);
        account2.PrintDetails();
        account2.Deposit(100);
        account2.Withdraw(10000);
        Console.WriteLine();
        
        Account account3 = new Account(1,"Jenifer", 99);
        account3.PrintDetails();
        account3.Deposit(23410);
        account3.Withdraw(10000);
        Console.WriteLine();
        
        Account account4 = new Account(1,"Abinaya", 90009);
        account4.PrintDetails();
        account4.Deposit(5540);
        account4.Withdraw(10000);
        Console.WriteLine();
        
        Account account5 = new Account(1,"Saranya", 99000);
        account5.PrintDetails();
        account5.Deposit(1010);
        account5.Withdraw(1430);
        Console.WriteLine();
    }
}


class Account
{
    
    public int accountNumber{get; set;}
    public string accName{get; set;}
    public double accBalance{get; set;}

   // private int AccountNumber;
   // private string AccountName;

    public Account(int accNo, string name, double balance)
    {
        accountNumber = accNo;
        accName = name;
        accBalance = balance;
    }
    
    public void Withdraw(double amount)
    {
        Console.WriteLine($"You withdraw ${amount} from {accName}");
        accBalance -= amount;
        PrintDetails();
        
    }

    public void Deposit(double amount)
    {
        Console.WriteLine($"You deposit ${amount} from {accName}");
        accBalance += amount;
        PrintDetails();
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Account Number : {accountNumber}");
        Console.WriteLine($"Account Holder Name : {accName}");
        Console.WriteLine($"Availabe Balance : {accBalance}");
    }
}