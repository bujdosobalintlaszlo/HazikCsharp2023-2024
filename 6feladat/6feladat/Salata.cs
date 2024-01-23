using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6feladat
{
    class Salata : Termek
    {
        int db;

        public Salata(int db,int egysegar) : base(egysegar,"salata")
        {
            this.db = db;
        }

        public override int MennyibeKerul() => db * egysegar;

        public override string ToString() => $"{db}db salata, {MennyibeKerul()}forint";
    }
}
