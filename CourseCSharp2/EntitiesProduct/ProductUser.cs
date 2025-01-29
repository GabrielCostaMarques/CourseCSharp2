using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp2.EntitiesProduct
{
    internal class ProductUser
    {
        public void ProductShow()
        {

            List<Product> products = new List<Product>();   

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)?: ");
                char m = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

               


                if (m == 'i')
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(name,price,fee));
                }
                else if (m == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime md = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name,price,md));
                    
                }
                else products.Add(new Product(name,price));

            }
                foreach (var item in products)
                {
                    Console.WriteLine(item.PriceTag());
                }
        }
    }
}
