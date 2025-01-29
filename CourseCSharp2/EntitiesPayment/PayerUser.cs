using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp2.EntitiesPayment
{
    internal class PayerUser
    {
        public void PayerShow()
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());


            List<Payer> payers = new List<Payer>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual Income: ");
                double income = double.Parse(Console.ReadLine());


                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double expenditures = double.Parse(Console.ReadLine());

                    payers.Add(new Individual(name, income, expenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int emp = int.Parse(Console.ReadLine());
                    payers.Add(new Company(name, income, emp));
                }


            }

            Console.WriteLine("TAXES PAID: ");

            double total = 0;
            foreach (Payer payer in payers)
            {  
                Console.WriteLine(payer); 
                total += payer.Tax();
            }

            Console.WriteLine("Total Taxes");
            Console.WriteLine(total);

            
        }
    }
}
