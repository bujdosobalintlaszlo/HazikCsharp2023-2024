using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuhelyClassal
{
    class Ember
    {
        string vnev;
        List<string> knev;
        string munkakor;
        List<bool> munkaido;

        public string Vnev { get { return vnev; } }
        public List<string> Knev { get { return knev; } }
        public string Munkakor { get { return munkakor; } }

        public List<bool> Munkaido { get { return munkaido; } set { this.munkaido = value; } }
        
        public string TeljesNev { get { return vnev + " " + knev; } }

        public string Monogramm { get { return vnev[0] + "" + string.Concat(knev.Select(k => k[0])); } }
        public Ember(string sorocska) : this()
        {
            List<string> sor = sorocska.Split(' ').ToList();
            vnev = sor[0];
            knev = new List<string>();
            for (int i = 1; i < sor.Count - 1; i++)
            {
                knev.Add(sor[i]);
            }
            munkakor = sor.Last();
            munkaido = new List<bool>();
            for (int i = 0; i < 10; i++)
            {
                munkaido.Add(true);
            }

        }

        public Ember(string vnev, List<string> knev, string munkakor, List<bool> munkaido) : this(vnev)
        {
            this.knev = knev;
            this.munkakor = munkakor;
            this.munkaido = munkaido;
        }

        public Ember()
        {
           
        }
    }
}
