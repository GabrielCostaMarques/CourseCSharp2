using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp2.EntitiesAccount
{
    internal class AccountUser
    {
        public void AccountShow()
        {
            Account account = new Account(1001, "Alex", 0.0);
            BusinessAccount businessAccount = new BusinessAccount(1002, "Maria", 0.0, 500);

            //UPCASTING

            Account account1 = businessAccount;
            Account account2 = new BusinessAccount(1003, "BOB", 200, 200);
            Account account3 = new SavingsAccount(1004, "Ana", 0, 0.01);


            //DOWNCASTING


            BusinessAccount account4 = (BusinessAccount)account2;
            account4.Loan(100);

            //BusinessAccount businessAccount5 = (BusinessAccount)account3;

            if (account3 is BusinessAccount)
            {
                //BusinessAccount account5 = (BusinessAccount)account3;
                BusinessAccount account5 = account3 as BusinessAccount;
                account5.Loan(200);
            Console.WriteLine("Loan");
            }



            if (account3 is SavingsAccount)
            {
                SavingsAccount account5 = (SavingsAccount)account3;
                account5.UpdateBalance();
                Console.WriteLine("Update");
            }
        }
    }
}
