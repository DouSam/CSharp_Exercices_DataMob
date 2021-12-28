using ExercicioFixacao12.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacao12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            List<Taxpayer> taxpayers = new List<Taxpayer>();
            string option;
            string payerName;
            double payerIncome;
            double payerHealth;
            int payerEmployees;

            Console.Write("Enter the number of tax payers: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nTax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                option = Console.ReadLine();
                Console.Write("Name: ");
                payerName = Console.ReadLine();
                Console.Write("Anual Income: ");
                payerIncome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if (option == "i")
                {
                    Console.Write("Health expenditures: ");
                    payerHealth = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    taxpayers.Add(new Individual(payerHealth,payerName,payerIncome));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    payerEmployees = int.Parse(Console.ReadLine());
                    taxpayers.Add(new Company(payerEmployees,payerName,payerIncome));
                }
            }

            double sum = 0;

            Console.WriteLine("\nTAXES PAID:");

            foreach (Taxpayer payer in taxpayers)
            {
                Console.WriteLine(payer);
                sum += payer.Tax();
            }

            Console.WriteLine("\nTOTAL TAXES: $" + sum.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
