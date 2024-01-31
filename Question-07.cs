// Write a Console Application program to simulate a basic ATM machine. Allow the user to check balance, deposit money, and withdraw money. Display appropriate messages based on user actions. (Create separate functions for individual operations.)


using System;

class Program
{
    static double balance = 1000; // Initial balance

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CheckBalance();
                    break;
                case 2:
                    DepositMoney();
                    break;
                case 3:
                    WithdrawMoney();
                    break;
                case 4:
                    Console.WriteLine("Exiting program. Thank you!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CheckBalance()
    {
        Console.WriteLine($"Your balance is: ${balance}");
    }

    static void DepositMoney()
    {
        Console.Write("Enter the amount to deposit: $");
        double amount = double.Parse(Console.ReadLine());

        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposit successful. Your new balance is: ${balance}");
        }
        else
        {
            Console.WriteLine("Invalid amount. Please enter a positive value.");
        }
    }

    static void WithdrawMoney()
    {
        Console.Write("Enter the amount to withdraw: $");
        double amount = double.Parse(Console.ReadLine());

        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawal successful. Your new balance is: ${balance}");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Insufficient funds. Withdrawal failed.");
        }
        else
        {
            Console.WriteLine("Invalid amount. Please enter a positive value.");
        }
    }
}