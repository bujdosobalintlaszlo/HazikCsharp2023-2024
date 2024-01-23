using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6feladat
{
    class Vegyesbolt
    {
        static List<Termek> termekek = new List<Termek>();

        static void bevasarlok(string utvonal)
        { 
            StreamReader streamReader = new StreamReader(utvonal);
            while (!streamReader.EndOfStream)
            { 
                string[] line = streamReader.ReadLine().Split(';');

                if (line[0] == "salata")
                {
                    termekek.Add(new Salata(int.Parse(line[2]), int.Parse(line[1])));
                }
                else if (line[0] == "paradicsom")
                {
                    termekek.Add(new RohadtParadicsom(int.Parse(line[2]), int.Parse(line[1])));
                }
            }
            streamReader.Close();
        }
        static void mivanakosaramban()
        {
            StreamWriter w = new StreamWriter("kosar.txt");
            termekek.ForEach(x =>
            {
                if (x is Salata)
                {
                    w.WriteLine(((Salata)x).ToString());
                }
                else if (x is RohadtParadicsom)
                {
                    w.WriteLine(((RohadtParadicsom)x).ToString());
                }
            });
            w.Close();
        }
        public void futtat(string utvonal)
        {
            bevasarlok(utvonal);
            mivanakosaramban();
        }
    }
}
