using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsimenePraktikum
{
    class Program
    {
        static void Main(string[] args)
        {
            string kysimus = "Palun anna üks arv: ";

            int a = kysiKasutajaltArvu(kysimus);

            Console.WriteLine("Sisestatud arv oli: "+a);
        }

        static int kysiKasutajaltArvu(string kysimus)
        {
            int a;

            Console.Write(kysimus);
            string vastus = Console.ReadLine();
            
            if (int.TryParse(vastus, out a))
            {
                return a;
            }
            else
            {
                return kysiKasutajaltArvu(kysimus);
            }
        }
    }
}
