using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp2.EntitiesEmployee
{
    internal class EmployeeUser
    {
        public void EmployeeShow()
        {
            Console.WriteLine("Enter the number of employees");
            int n= int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"Employee number #{i}");

                Console.Write("Outsourced? (y/n)?: ");
                char ch =char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours= int.Parse(Console.ReadLine());

                Console.Write("Value per Hour: ");
                double valuePerHour= double.Parse(Console.ReadLine()); 
                
                if ( ch=='y' ) {
                    Console.Write("Additional Charge: ");
                    double additionalCharge= double.Parse(Console.ReadLine());
                    list.Add(new OutSourcedEmployee(name, hours, valuePerHour, additionalCharge));

                }
                else
                {
                    list.Add(new Employee(name,hours, valuePerHour));
                }
            }
            Console.WriteLine("PAYMENTS");

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment());
            }
        }
    }
}
