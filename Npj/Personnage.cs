
using Rpg_Game.Npj;
using Rpg_Game.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static Rpg_Game.Utils.Dice;

namespace Rpg_Game
{
    public abstract class Personnage
    {
        public int NbOr;
        public int NbCuir;
        public event Action<Personnage> OnDieEvent;
        public static int CurrentId = 1;
        public bool IsAlive => Pv > 0;
   
        public Personnage(DiceType dice, int nbor,int nbcuir) : this( , nbor,nbcuir)
        {
            GenerateRandomStat(dice);
            NbOr = nbor;
            NbCuir = nbcuir; 
            Id = CurrentId++;
            Stats = new Stats();
        }
        public int Id { get; set; }
        public int Pv
        {
            get
            {
                return Stats[StatType.Pv];
            }
        }
        public Stats Stats { get; set; }



        public void GenerateRandomStat(DiceType dice)
        {
            Random random = new Random();
            Stats[StatType.Pv] = Dice.Throws(dice, 5, 3);
            Stats[StatType.Force] = Dice.Throws(dice, 5, 3);
            Stats[StatType.Endurance] = Dice.Throws(dice, 5, 3);
            GeneratePVStat();
        }

        public void GeneratePVStat()
        {
            Stats[StatType.Pv] = Stats[StatType.Endurance] + Stats.GenerateModif(Stats[StatType.Endurance]);
        }
        public int GenerateDegat()
        {
           
            int Degat = Dice.Throws(DiceType.D4) + Stats.GenerateModif(Stats[StatType.Force]);
            return Degat;
        }



        public override string ToString()
        {
            return $"Pv : {Pv}\n" +
                   $"Force : {Stats[StatType.Force]}\n" +
                   $"Endurance : {Stats[StatType.Endurance]}\n" +
                   $"Id : {Id}\n";
        }
        public virtual void Affiche()
        { 
            Console.WriteLine(ToString()); 
        }

        public void RaiseDieEvent()
        {
            OnDieEvent?.Invoke(this);
            Console.WriteLine("Meurt");

        }
    }
}
