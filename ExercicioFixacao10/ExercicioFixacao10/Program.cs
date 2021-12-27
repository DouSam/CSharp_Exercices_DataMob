using ExercicioFixacao10.Entities;
using ExercicioFixacao10.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioFixacao10
{
    class Program
    {
        static void Main(string[] args)
        {
            string clientName;
            string clientEmail;
            DateTime clientBirth;

            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            clientName = Console.ReadLine();
            Console.Write("Email: ");
            clientEmail = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            clientBirth = DateTime.Parse(Console.ReadLine());

            Client client = new Client(clientName,clientEmail,clientBirth);

            OrderStatus orderStatus;
            int n;
            Console.WriteLine("\nEnter order data: ");
            Console.Write("Status: ");
            orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now,orderStatus,client);

            Console.Write("\nHow many items have this order? ");
            n = int.Parse(Console.ReadLine());

            string productName;
            double productPrice;
            int productQuantity;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                productName = Console.ReadLine();
                Console.Write("Product price: ");
                productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                productQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(productQuantity, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine("\nORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
