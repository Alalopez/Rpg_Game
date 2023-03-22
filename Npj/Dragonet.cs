using Rpg_Game.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game.Npj
{
    public class Dragonet :Monstre
    {
        public Dragonet(string race) : base(race,Dice.Throws(DiceType.D6), Dice.Throws(DiceType.D4)) 
        {
            Stats[StatType.Endurance] += 1;
        }

    }
}
