using ExercicioFixacao10.Entities.Enums;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacao10.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; private set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem orderItem)
        {
            Items.Add(orderItem);
        }

        public void RmItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }

        public double Total()
        {
            double sum = 0;

            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Order moment: ");
            stringBuilder.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            stringBuilder.Append("Order status: ");
            stringBuilder.AppendLine(Status.ToString());
            stringBuilder.Append("Client: ");
            stringBuilder.AppendLine(Client.ToString());
            stringBuilder.AppendLine("Order items: ");

            foreach (OrderItem item in Items)
            {
                stringBuilder.AppendLine(item.ToString());
            }

            stringBuilder.Append("Total price: ");
            stringBuilder.AppendLine($"${Total().ToString("F2",CultureInfo.InvariantCulture)}");

            return stringBuilder.ToString();
        }
    }
}
