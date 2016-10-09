using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InimesteKuvamine.Models
{
    public class Inimene
    {
        private string _eesnimi;
        private string _perenimi;
        private int _pikkus;
        public Inimene(string eesnimi, string perenimi, int pikkus)
        {
            _eesnimi = eesnimi;
            _perenimi = perenimi;
            _pikkus = pikkus;
        }

        public string Eesnimi
        {
            get { return _eesnimi; }
            set { _eesnimi = value; }
        }

        public string Perenimi
        {
            get { return _perenimi; }
            set { _perenimi = value; }
        }

        public int Pikkus
        {
            get { return _pikkus; }
            set { _pikkus = value; }
        }
    }
}
