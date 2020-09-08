using System;
using SocialMedia.Entities;

namespace SocialMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Wow, that's awesome!");
            Comment c2 = new Comment("Have a nice Trip!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Treveling to New Zelland",
                "I'm going to visit this bealtiful country!",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good Night!");
            Comment c4 = new Comment("May the force be with you");
            Post p2 = new Post(
                DateTime.Parse("28/07/2020 23:14:19"),
                "Good night guys",
                "See you tomorrow!",
                5);
            p1.AddComment(c3);
            p1.AddComment(c4);

                );

        }
    }
}
