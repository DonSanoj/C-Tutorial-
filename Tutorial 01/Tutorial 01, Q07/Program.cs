using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_01__Q07
{
    internal class Program
    {

        static double balance = 0.00f;

        static void Main(string[] args)
        {
            Console.WriteLine("\n\tWelcome to the ATM Machine\n");

            while (true)
            {
                Console.WriteLine("\n\tChoose an option:\n");
                Console.WriteLine("\t1. Check Balance");
                Console.WriteLine("\t2. Deposit Money");
                Console.WriteLine("\t3. Withdraw Money");
                Console.WriteLine("\t4. Exit");
                Console.WriteLine();

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
                        Console.WriteLine("\n\tAre you sure, You want to exit?");
                        Console.WriteLine("\n\t1. Yes");
                        Console.WriteLine("\t2. No");
                        Console.WriteLine();

                        int exitChoice = int.Parse(Console.ReadLine());

                        switch (exitChoice)
                        {
                            case 1:
                                Console.WriteLine("Thank you for using ATM machine, Have a nice day!");
                                return;

                            case 2:
                                continue;

                            default:
                                Console.WriteLine("Invalid choice, please try again");
                                break;
                        }
                        return;

                    default:
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            }
        }

        static void CheckBalance()
        {
            Console.WriteLine($"\n\tYour current balance is {balance}");
        }

        static void DepositMoney()
        {
            Console.WriteLine("\n\tEnter the amount you want to deposit:");
            double amount = double.Parse(Console.ReadLine());

            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"\t\nDeposit successful\nYour new balance {balance}");
            }
            else
            {
                Console.WriteLine("Invalid amount. Deposit amount must be greater than zero.");
            }
        }

        static void WithdrawMoney()
        {
            Console.WriteLine("\n\tEnter the amount you want to withdrow:");
            double amount = double.Parse(Console.ReadLine());

            if (amount > 0)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                    Console.WriteLine($"\t\nWithdraw successful\nYour new balance {balance}");
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }
            else
            {
                Console.WriteLine("Invalid amount. Withdraw amount must be greater than zero.");
            }
        }
    }
}
