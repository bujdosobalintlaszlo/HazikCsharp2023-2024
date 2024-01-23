using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6feladat
{
    abstract class Termek
    {
        protected int egysegar;
        string nev;

        public Termek(int egysegar, string nev)
        {
            this.egysegar = egysegar;
            this.nev = nev;
        }

        abstract public int MennyibeKerul();

        public override string ToString() => $"{nev} {egysegar}Ft";
    }
}
