using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game.Exceptions
{

    public class StatNegativeException : Exception
    {
        public StatNegativeException() : base("La stat ne peut être négative")
        {
        }

        public StatNegativeException(string? message) : base(message)
        {
        }
    }
}


