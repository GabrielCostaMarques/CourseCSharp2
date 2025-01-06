using CourseCSharp2.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp2.Entities
{
    internal class OrderUser
    {
        public void OrderShow()
        {
            Order order = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);


            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus status = Enum.Parse<OrderStatus>("Delivered");


            Console.WriteLine(status);

            Console.WriteLine(txt);
        }
    }
}
