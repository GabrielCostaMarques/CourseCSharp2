using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp2.EntitiesAccount
{
    //sealed serve para que a classe nao seja herdada (tenha uma subclasse)
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //selando o método para ele nao ser sobreposto novamente em outra subclasse'
        public sealed override void WithDraw(double amount)
        {
            //reaproveitando a função da superclasse e adicionando 2 reais
            base.WithDraw(amount);
            Balance -= 2.0;
        }
    }
}
