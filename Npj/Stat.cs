
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game.Npj
{
    public enum StatType
    {
        Pv,
        Force,
        Endurance,
       
    }
    public class Stats
    {
        private Dictionary<StatType, int> _stats;
        public Dictionary<StatType, int> StatList
        {
            get { return _stats = _stats ?? new Dictionary<StatType, int>(); }
        }
        public int this[StatType type]
        {
            get
            {
                if (!StatList.TryGetValue(type, out int stat))
                    return 0;
                return stat;
            }
            set
            {
                if (value < 0)
                    StatList[type] = 0;
                else
                {
                    if (!StatList.ContainsKey(type))
                        StatList.Add(type, 0);
                    StatList[type] = value;
                }
            }
        }
        public int GenerateModif(int stat)
        {
            int modif = 2;

            if (stat < 15)
            {
                modif = 1;
                if (stat < 10)
                    modif = 0;
                if (stat < 5)
                    modif = -1;
            }
            else
                modif = 2;
            return modif;
        }
        
    }
}
