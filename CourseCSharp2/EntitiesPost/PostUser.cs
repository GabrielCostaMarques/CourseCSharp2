using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CourseCSharp2.EntitiesPost
{
    internal class PostUser
    {
        public void PostShow()
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("WOW that's awesome");

            Post post1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country",
                12
                );

            post1.AddComment(c1);
            post1.AddComment(c2);


            Console.WriteLine(post1.ToString());
        }




    }
}
