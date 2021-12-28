using ExercicioFixacao13.Entities;
using ExercicioFixacao13.Entities.Exceptions;
using System;
using System.Globalization;

namespace ExercicioFixacao13
{
    class Program
    {
        static void Main(string[] args)
        {
            int accNumber;
            string accHolder;
            double accBalance;
            double accLimit;
            double amount;

            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            accNumber = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            accHolder = Console.ReadLine();
            Console.Write("Initial balance: ");
            accBalance = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            accLimit = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Account account = new Account(accNumber,accHolder,accBalance,accLimit);

            Console.Write("\nEnter amount for withdraw: ");
            try
            {
                amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amount);
                Console.Write("New Balance: " + account.Balance.ToString("F2",CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}
