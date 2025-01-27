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

            Console.WriteLine("Enter cliente data:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Console.Write("Bith date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());


            Console.WriteLine("");
            Console.WriteLine("Enter order data:");
            Console.WriteLine("");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name,email,birthdate);
            Order order = new Order(DateTime.Now,status,client);
            
            Console.Write("How many items to this order?: ");
            int quantity = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");

                Console.Write("Product Name: ");
                string prodName = Console.ReadLine();

                Console.Write("Product Price: ");
                double prodPrice = double.Parse(Console.ReadLine());

                Console.Write("Quantity: ");
                int prodQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(prodName,prodPrice);
                OrderItem item = new OrderItem(prodQuantity,prodPrice,product);

                order.AddItem(item);
            }

            



            Console.WriteLine(order);
        }
    }
}
