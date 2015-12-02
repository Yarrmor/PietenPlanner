using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2015_NJ_SE2_BP3H_OO_Programma
{
    class Provincie
    {
        public string Naam;
        public List<Gemeente> Gemeenten;

        public Provincie(string naam)
        {
            this.Naam = naam;
            this.Gemeenten = new List<Gemeente>();
        }

        public void VoegGemeenteToe(Gemeente gemeente)
        {

        }

        public Gemeente ZoekGemeente(string naam)
        {
            return null;
        }

        public override string ToString()
        {
            return this.Naam;
        }
    }
}
