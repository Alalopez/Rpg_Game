using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpg_Game;

namespace Rpg_Game.Extensions
{
    public static class ExtentionMethod
    {
        public static string ConcatFusion(this string nom1, string nom2)
        {
            return nom1.Substring(0, 2) + nom2.Substring(nom2.Length - 2, 2);
        }
    }
}

