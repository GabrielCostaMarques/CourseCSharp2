using CourseCSharp2.Entities.Enums; 
using CourseCSharp2.Entities; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CourseCSharp2.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

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
        public void RemoveItem(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }


        public double Total()
        {

            double sum = 0.0;
            foreach (OrderItem orderItem in Items)
            {
                sum += orderItem.SubTotal();
            } 
            return sum;
        }


        public override string ToString()
        {
                      
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY");
            sb.AppendLine(Moment.ToString("dd/mm/yyyy HH:mm:ss"));
            sb.AppendLine("Order Status:" + Status);
            sb.AppendLine("Client: "+Client);
            sb.AppendLine("Order items:");

            foreach (OrderItem orderItem in Items)
            {
                sb.AppendLine(orderItem.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();  

        }

    }
}
