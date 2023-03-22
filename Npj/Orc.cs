using Rpg_Game.Utils;

namespace Rpg_Game.Npj
{
    public class Orc : Monstre
    {
        public Orc(string race) : base(race, Dice.Throws(DiceType.D6), 0)
        {
            Stats[StatType.Force] += 1;
        }

    }
}
