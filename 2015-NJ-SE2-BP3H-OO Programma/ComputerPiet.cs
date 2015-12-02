using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2015_NJ_SE2_BP3H_OO_Programma
{
    class ComputerPiet : Piet
    {
        public override bool IsCreatief
        {
            get
            {
                return false;
            }
        }
        public override bool KanRijmen
        {
            get
            {
                return false;
            }
        }
        public override bool SnaptComputers
        {
            get
            {
                return true;
            }
        }

        public ComputerPiet(bool isCreatief, bool kanRijmen, bool snaptComputers)
            :base(isCreatief, kanRijmen, snaptComputers)
        {

        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
