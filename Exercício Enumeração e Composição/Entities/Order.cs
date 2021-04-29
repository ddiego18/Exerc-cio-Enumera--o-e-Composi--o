using System;
using System.Collections.Generic;
using System.Text;
using Exercício_Enumeração_e_Composição.Entities;
using Exercício_Enumeração_e_Composição.Entities.Enums;

namespace Exercício_Enumeração_e_Composição.Entities
{
    class Order
    {
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }
        public Client client { get; set; }

        public List<OrderItem> items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            this.moment = moment;
            this.status = status;
            this.client = client;
        }

        public void AddItem(OrderItem item)
        {
            items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            items.Remove(item);
        }

        public double total()
        {
            double sum = 0.0;
            foreach(OrderItem item in items)
            {
                sum += item.subTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + status);
            sb.AppendLine("Client: " + client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + total().ToString("F2"));
            return sb.ToString();
        }
    }
}
