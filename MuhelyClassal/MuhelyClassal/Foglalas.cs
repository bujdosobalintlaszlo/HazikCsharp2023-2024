using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhelyClassal
{
    class Foglalas
    {
        string munkakor;
        int mettol, meddig;
        public string Munkakor { get { return munkakor; } }
        public int Mettol { get { return mettol; } }
        public int Meddig { get { return meddig; } }
        public Foglalas(string sorocska) : this()
        {
            List<string> adatok = sorocska.Split(' ').ToList();
            munkakor = adatok[0];
            mettol = int.Parse(adatok[1]);
            meddig = int.Parse(adatok[2]);
        }

        public Foglalas(string munkakor, int mettol, int meddig) : this(munkakor)
        {
            this.mettol = mettol;
            this.meddig = meddig;
        }

        public Foglalas()
        { 
        
        }
    }
}
