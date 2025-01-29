using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp2.EntitiesPayment
{
    internal class Individual : Payer
    {

        public double BillWithHealht { get; set; }

        public Individual() { }

        public Individual(string name, double currentIncome, double billWithHealht) : base(name, currentIncome)
        {
            BillWithHealht = billWithHealht;
        }

        public override double Tax()
        {
            double taxRate = CurrentIncome > 20000 ? 0.25 : 0.15;
            double healthDiscount = BillWithHealht > 0 ? BillWithHealht * 0.5 : BillWithHealht;

            return (CurrentIncome * taxRate) - healthDiscount;

        }
    }
}
