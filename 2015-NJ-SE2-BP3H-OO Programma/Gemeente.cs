using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2015_NJ_SE2_BP3H_OO_Programma
{
    class Gemeente
    {
        public string Naam;
        public Provincie Provincie;
        public int AantalKinderen;
        public int X;
        public int Y;

        public Gemeente(string naam, Provincie provincie, int aantalKinderen, int x, int y)
        {
            this.Naam = naam;
            this.Provincie = provincie;
            this.AantalKinderen = aantalKinderen;
            this.X = x;
            this.Y = y;
        }

        public int AfstandTot(Gemeente gemeente)
        {
            return 0;
        }

        public override string ToString()
        {
            return this.Naam + " " + this.AantalKinderen;
        }
    }
}
