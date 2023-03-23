using Rpg_Game.npj;
using Rpg_Game.Utils;


namespace Rpg_Game.Npj

{
    
    public class Monstre : Personnage
    {
        
        public Monstre(string race, int nbor, int nbcuir ) : base(DiceType.D6, nbor, nbcuir)
        {
            Race = race;
            NbOr = nbor;
            NbCuir = nbcuir;      
        }

        public string Race { get; set; }
        public void Frapper(Hero h) {
            if (h.IsAlive)

            {
                Console.WriteLine($"PV {h.Name} : {h.Pv}  |  Pv {Race} : {Pv}");
                Console.WriteLine($"{Race} Frappe {h.Name}");
                h.Stats[StatType.Pv] -= GenerateDegat();
                Console.WriteLine($"PV {h.Name} : {h.Pv}  |  Pv {Race} : {Pv}");
                if (!h.IsAlive)
                    h.RaiseDieEvent();
            }
            else Console.WriteLine($"{h.Name} est Fuckiing Dead!!!");
                    
                    }
        public override string ToString()
        {
            return $"{Race}:\n" + base.ToString();
        }
        
    }
}

