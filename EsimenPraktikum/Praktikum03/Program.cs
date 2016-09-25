using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum03
{
    class Ristkylik
    {

        private int _pikkus;
        private int _laius;

        public Ristkylik(int pikkus, int laius)
        {
            _laius = laius;
            _pikkus = pikkus;
        }

        public int ArvutaPindala()
        {
            return _laius*_pikkus;
        }

        public int ArvutaYmberMoot()
        {
            return 2*_laius + 2*_pikkus;
        }

        public bool KasOnVordsed(Ristkylik ristkylik)
        {
            return _laius == ristkylik._laius && _pikkus == ristkylik._pikkus;
        }

        public bool KasOnRuut()
        {
            return _laius == _pikkus;
        }
    }

    class Loo
    {
        static void Main()
        {
            Ristkylik rist = new Ristkylik(3, 3);
            Ristkylik rist2 = new Ristkylik(3, 3);

            Console.WriteLine("Pindala "+rist.ArvutaPindala());
            Console.WriteLine("Ümbermõõt "+rist.ArvutaYmberMoot());
            Console.WriteLine("Kas on ruut? "+rist.KasOnRuut());
            Console.WriteLine("Pindala " + rist2.ArvutaPindala());
            Console.WriteLine("Ümbermõõt " + rist2.ArvutaYmberMoot());
            Console.WriteLine("Kas on ruut? " + rist2.KasOnRuut());
            Console.WriteLine("Kas on võrdsed?" + rist2.KasOnVordsed(rist));
            Console.ReadLine();
        }
    }
}
