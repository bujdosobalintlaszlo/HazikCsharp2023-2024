using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MuhelyClassal
{
    class Program
    {
        static void EmberekKiir(List<Ember> l) => l.ForEach(x => Console.WriteLine(x.TeljesNev+"\n"));
        static void MonogarmmKiir(List<Ember> l) => l.ForEach(x => Console.WriteLine(x.Monogramm+"\n"));
        static void Tablazat(List<Ember> l1) => l1.ForEach(x => Console.WriteLine(x.TeljesNev +" "+Megvizsgal(x.Munkaido)));
        static List<string> MegVizsgal(List<bool> m)
        {
            List<string> retvals = new List<string>();
            m.ForEach(x => retvals.Add(x ? "+" : "-"));
            return retvals;
        }
        static int TudunkFoglalni(List<Ember> l, int hanyadik, Foglalas foglalas)
        {
            if (foglalas.Meddig == 0)
            {
                for (int i = 0; i <= l[hanyadik].Munkaido.Count - foglalas.Meddig; i++)
                {
                    int j = i;
                    while (j < i + foglalas.Meddig && l[hanyadik].Munkaido[j])
                    {
                        j++;
                    }
                    if (j == i + foglalas.Meddig)
                    {
                        return i;
                    }
                }
                return -1;
            }
            else
            {
                int i = foglalas.Mettol - 8;
                while (i <= foglalas.Meddig - 8 && l[hanyadik].Munkaido[i])
                {
                    i++;
                }
                if (i == foglalas.Meddig - 7)
                {
                    return foglalas.Mettol - 8;
                }
                else

                {
                    return -1;
                }

            }
        }
            static void Main(string[] args)
            {
            List<Ember> emberek = Array.ConvertAll(File.ReadAllLines("nevek.txt"), (sor) => new Ember(sor)).ToList();
            List<Foglalas> foglalasok = Array.ConvertAll(File.ReadAllLines("menetrend.txt"), (sor) => new Foglalas(sor)).ToList();
            EmberekKiir(emberek);
            MonogarmmKiir(emberek);
            Tablazat(emberek);
            foreach (var foglalas in foglalasok)
            {
                List<Ember> munkakor = emberek.FindAll(x => x.Munkakor == foglalas.Munkakor).OrderByDescending(a => a.Munkaido.Where(y => y).Count()).ToList();
                int i = 0;
                while (i < munkakor.Count && TudunkFoglalni(munkakor, i, foglalas) == -1)
                {
                    i++;
                }
                if (i < munkakor.Count)
                {
                    if (foglalas.Meddig == 0)
                    {
                        int idopont = TudunkFoglalni(munkakor, i, foglalas);
                        for (int j = idopont; j <= idopont + foglalas.Meddig; j++)
                        {
                            munkakor[i].Munkaido[j] = false;
                        }
                    }
                    else
                    {
                        for (int j = foglalas.Meddig - 8; j <= foglalas.Meddig - 8; j++)
                        {
                            munkakor[i].Munkaido[j] = false;

                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("siker");
                    Console.ForegroundColor = ConsoleColor.White;
                    Tablazat(emberek);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("nem siker");
                    Console.ForegroundColor = ConsoleColor.White;
                    Tablazat(emberek);
                }
            }
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
