
using CourseCSharp2.Entities;
using CourseCSharp2.EntitiesAccount;
using CourseCSharp2.EntitiesEmployee;
using CourseCSharp2.EntitiesPayment;
using CourseCSharp2.EntitiesPost;
using CourseCSharp2.EntitiesProduct;
using CourseCSharp2.EntitiesShape;
using CourseCSharp2.EntitiesWorker;


namespace CourseCSharp2
{
    class Program
    {
        static void Main(string[] args)
        {

            PayerUser user = new PayerUser();
            user.PayerShow();
        }
    }
}
