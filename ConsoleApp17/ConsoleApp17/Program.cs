using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {

            

        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Tere tulemast statoili! Mida soovite osta?");
            Console.WriteLine("1 = Must kohv");

            var Asi = Console.ReadLine();
            var Raha = 100;
            var Esimene = new Must();
            if (Asi == "1")
            {
                Raha = Esimene.Mustaost(Raha);
                goto start;
            }
            Console.ReadLine();
        }
    }
}
