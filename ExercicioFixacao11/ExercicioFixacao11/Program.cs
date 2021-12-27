using ExercicioFixacao11.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacao11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            List<Product> products = new List<Product>();
            string option;
            string prodName;
            double prodPrice;
            DateTime prodManuDate;
            double prodFee;

            Console.Write("Enter the number of products: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nProduct #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                option = Console.ReadLine();
                Console.Write("Name: ");
                prodName = Console.ReadLine();
                Console.Write("Price: ");
                prodPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                switch (option)
                {
                    case "c":
                        products.Add(new Product(prodName,prodPrice));
                        break;
                    case "u":
                        Console.Write("Manufacture date (DD/MM/YYYY)");
                        prodManuDate = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(prodName,prodPrice,prodManuDate));
                        break;
                    default:
                        Console.Write("Customs Fee: ");
                        prodFee = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        products.Add(new ImportedProduct(prodName,prodPrice,prodFee));
                        break;
                }
            }

            Console.WriteLine("\nPRICE TAGS:");

            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
