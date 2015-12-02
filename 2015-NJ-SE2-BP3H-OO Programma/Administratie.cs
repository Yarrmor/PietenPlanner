using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _2015_NJ_SE2_BP3H_OO_Programma
{
    class Administratie
    {
        public Gemeente Thuisbasis;
        public List<Provincie> Provincies;

        public Administratie()
        {
            Provincies = new List<Provincie>();

            this.Importeer();
        }

        public void Importeer()
        {
            StreamReader sr = new StreamReader("coordinaten.csv");
            List<Gemeente> gemeenten = new List<Gemeente>();
            string line;
            string[] row = new string[5];
            while ((line = sr.ReadLine()) != null)
            {
                row = line.Split(';');

                VoegToe(row[0], row[1], Convert.ToInt32(row[4]), Convert.ToInt32(row[2]), Convert.ToInt32(row[3]));

                if(row[0] == "Meppel")
                {
                    Thuisbasis = new Gemeente(row[0], new Provincie(row[1]), Convert.ToInt32(row[4]), Convert.ToInt32(row[2]), Convert.ToInt32(row[3]));
                }
            }
        }

        public void VoegToe(string gemeente, string provincie, int aantalKinderen, int x, int y)
        {
            if(!Provincies.Any(prov => prov.Naam == provincie))
            {
                Provincies.Add(new Provincie(provincie));
            }

            Provincie provTemp = (from p in this.Provincies where p.Naam == provincie select p).FirstOrDefault();

            provTemp.Gemeenten.Add(new Gemeente(gemeente, provTemp, aantalKinderen, x, y));
        }

        public Provincie ZoekOpNaam(string naam)
        {
            Provincie provResult = (from p in this.Provincies where p.Naam == naam select new Provincie(p.Naam)).FirstOrDefault();

            return provResult;
        }

        public List<Piet> StelPosseSamen(Gemeente gemeente, List<CadeauType> cadeauTypes)
        {
            return null;
        }
    }
}
