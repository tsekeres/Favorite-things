using System;

namespace Favorite_things
{
    class Program
    {
        static void Main(string[] args)
        {
            var Hotspurs = new Soccer
            {
                JerseyColor = "Navy Blue and White",
                GoalsFor = 6,
                GoalsAgainst = 3
            };

            var SixPack = new Soccer
            {
                JerseyColor = "Red and Black",
                GoalsFor = 2,
                GoalsAgainst = 10
            };

            Console.WriteLine("Welcome to our team!");
            Hotspurs.Colors();

            Hotspurs.Score();
        }
    }
}
