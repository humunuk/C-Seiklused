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
            string kysimus = "Kui vana sa oled?: ";

            int a = KysiKasutajaltArvu(kysimus);

            if (a > 17)
            {
                Console.WriteLine("Juba täisealine!");
            }
            else
            {
                Console.WriteLine("Veel mitte täisealine");
            }

        }

        static int KysiKasutajaltArvu(string kysimus)
        {
            int a;

            var vastus = LooKonsooliRida(kysimus);

            if (int.TryParse(vastus, out a))
            {
                return a;
            }
            else
            {
                return KysiKasutajaltArvu(kysimus);
            }
        }

        private static string LooKonsooliRida(string kysimus)
        {
            Console.Write(kysimus);
            string vastus = Console.ReadLine();
            return vastus;
        }

        static decimal FahrenHeitToKelvin(string kysimus)
        {
            decimal kelvin;
            decimal fahren;

            var vastus = LooKonsooliRida(kysimus);

            if (decimal.TryParse(vastus, out fahren))
            {
                kelvin = fahren;
            }
            else
            {
                return FahrenHeitToKelvin("Anna Fahrenheit");
            }

            return kelvin;
        }
    }
}
