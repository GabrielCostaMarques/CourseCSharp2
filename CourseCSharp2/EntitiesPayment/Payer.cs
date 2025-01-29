using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp2.EntitiesPayment
{
    internal abstract class Payer
    {
        public string Name { get; set; }
        public double CurrentIncome { get; set; }

        public Payer() { }

        public Payer(string name, double currentIncome)
        {
            Name = name;
            CurrentIncome = currentIncome;
        }

        public abstract double Tax();


        public override string ToString()
        {
            return Name + " $" + Tax();
        }
    }
}
