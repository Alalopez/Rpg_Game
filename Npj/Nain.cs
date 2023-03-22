using Rpg_Game.npj;
using System.Net.NetworkInformation;

namespace Rpg_Game.Npj
{
    public class Nain : Hero
    {
        public Nain(string name,int nbor, int nbcuir) : base(name, nbor, nbcuir)
        {
            Stats[StatType.Endurance] += 2;

        }
    }
    
}
