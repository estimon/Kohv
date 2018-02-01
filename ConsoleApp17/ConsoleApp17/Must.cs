using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Must : Alus
    {

        public Must()
        {
            Nimi = "Must kohv";
            Hind = 2;
           
            
        }
        public int Mustaost(int Raha)
        {
            Console.WriteLine("Sa ostsid musta kohvi");
            var Sinurahad = Raha - 2;
            Console.WriteLine("Sul on alles " + Sinurahad + " eurot");
            return Raha - 2;
        }
        
    }



}
