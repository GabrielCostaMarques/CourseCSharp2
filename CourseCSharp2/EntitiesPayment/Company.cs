using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp2.EntitiesPayment
{
    internal class Company : Payer
    {

        public int Employees { get; set; }

        public Company()
        {
        }

        public Company(string name, double currentIncome, int employees) : base(name, currentIncome)
        {
            Employees = employees;
        }



        public override double Tax()
        {
            double taxRate = Employees > 10 ? 0.14:0.16;
            return CurrentIncome * taxRate;
        }
    }
}
