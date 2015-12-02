using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2015_NJ_SE2_BP3H_OO_Programma
{
    abstract class Piet
    {
        public abstract bool IsCreatief
        {
            get;
        }
        public abstract bool KanRijmen
        {
            get;
        }
        public abstract bool SnaptComputers
        {
            get;
        }

        public Piet(bool isCreatief, bool kanRijmen, bool snaptComputers)
        {

        }

        public abstract override string ToString();
    }
}
