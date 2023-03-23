using Rpg_Game;
using Rpg_Game.Extensions;
using Rpg_Game.Npj;
using Rpg_Game.Utils;



namespace Rpg_Game.npj

{
    //public delegate void Competence ();
    public class Hero : Personnage
    {
        public int nbor;
        public int nbcuir;
        public Action Competence1;
        public Func<int, int, float> test;
        //public Competence Competence1;
        public Action Competence2;
        public Action Combo;

        public Hero(string name) : base(DiceType.D10,0,0)
        {
            Name = name;
              

            
        }
        public string Name { get; set; }
        public void SeSoigner()
        {
            Stats[StatType.Pv] += 10;
        }
        public void Frapper(Monstre m)
        {

            if (m.IsAlive)

            {
                Console.WriteLine($"PV {Name}: {Pv}  |  Pv {m.Race}: {m.Pv}");
                Console.WriteLine($"{Name} Frappe {m.Race}");
                m.Stats[StatType.Pv] -= GenerateDegat();
                Console.WriteLine($"PV {Name}: {Pv}  |  Pv {m.Race}: {m.Pv}");
                if (!m.IsAlive)
                    m.RaiseDieEvent();
            }
            else Console.WriteLine($"{m.Race} Il est Mourut"); 
                
        }
        



        public static Hero operator +(Hero p1, Hero p2)
        {
            Console.WriteLine("Fuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu Sion!");
            Hero fusion = new Hero(p1.Name.ConcatFusion(p2.Name));
            fusion.Stats[StatType.Pv] = p1.Stats[StatType.Pv] + p2.Stats[StatType.Pv];
            fusion.Stats[StatType.Force] = p1.Stats[StatType.Force] + p2.Stats[StatType.Force];
            fusion.Stats[StatType.Endurance] = p1.Stats[StatType.Endurance] + p2.Stats[StatType.Endurance];
            
            return fusion;
        }
        public override string ToString()
        {
            return $"{Name}:\n" + base.ToString();
        }
        public void Loot(Monstre m)
        {
            Console.WriteLine($"Mon personnage : {Name} loot le monstre : {m.Race}");
            NbOr += m.NbOr;
            NbCuir += m.NbCuir;
            
        }
    }
}
