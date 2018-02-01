using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Latte : Must
    {
        public Latte()
        {
            Nimi = "Latte";
            Hind = 5;

        }
        public int Mustaost(int Raha)
        {
            Console.WriteLine("Sa ostsid Latte");
            var Sinurahad = Raha - 5;
            Console.WriteLine("Sul on alles " + Sinurahad + " eurot");
            return Raha - 5;
        }



    }
}
