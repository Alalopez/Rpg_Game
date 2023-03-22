using Rpg_Game.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game.Npj
{
    public class Loup : Monstre
    {
        public Loup(string race) : base(race,0, Dice.Throws(DiceType.D4))
        {
            
        }

    }
}
