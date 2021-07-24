using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Favorite_things
{
    class Soccer
    {
        public string JerseyColor { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }

        public void Score()
        {
            Console.WriteLine($"The score is {GoalsFor} to {GoalsAgainst}.");
        }

        public void Colors()
        {
            Console.WriteLine($"Our jerseys are {JerseyColor}.");
        }
    }
}
