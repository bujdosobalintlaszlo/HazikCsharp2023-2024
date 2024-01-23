using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6feladat
{
    class RohadtParadicsom : Termek,Akciozhato
    {
        double tomeg;

        public RohadtParadicsom(double tomeg,int egysegar) : base(egysegar, "rohadt paradicsom")
        {
            this.tomeg = tomeg;
        }
        public override int MennyibeKerul() => (int)Math.Round(tomeg * egysegar,1);

        public int akciosAr() => (int)Math.Round(egysegar*0.8,1);

        public override string ToString() => $"{tomeg}kg rohadt paradicsom - {MennyibeKerul()}";
    }
}
