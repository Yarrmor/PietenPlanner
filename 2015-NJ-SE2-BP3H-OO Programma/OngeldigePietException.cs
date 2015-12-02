using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2015_NJ_SE2_BP3H_OO_Programma
{
    class OngeldigePietException : Exception
    {
        public OngeldigePietException()
        {

        }

        public OngeldigePietException(string message)
            : base(message)
        {

        }

        public OngeldigePietException(string message, Exception inner)
            : base(message, inner)
        {

        }
    }
}
