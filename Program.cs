using Rpg_Game.Npj;


internal class Program
{
    private static void Main(string[] args)
    {
        TableauDeJeu tableau = new TableauDeJeu();
        tableau.Afficher();
        Random R = new Random();
        Humain h1 = new Humain("kiki");
        h1.x = R.Next(1, TableauDeJeu.Largeur - 1);
        h1.y = R.Next(1, TableauDeJeu.Hauteur - 1);

        List<Monstre> monstres = new List<Monstre>();
        for (int i = 0; i < 9; i++)
        {
            bool positionValide = true;
            Monstre monstre;
            int de = R.Next(1, 3);
            if (de == 1) monstre = new Loup("L");
            else if (de == 2) monstre = new Orc("O");
            else
            {
                monstre = new Dragonet("D");
            }
            do
            {
                monstre.x = R.Next(1, TableauDeJeu.Largeur - 1);
                monstre.y = R.Next(1, TableauDeJeu.Hauteur - 1);
                if (positionValide)
                {
                    foreach (Monstre autreMonstre in monstres)
                    {
                        if (Math.Abs(autreMonstre.x - monstre.x) <= 2 && Math.Abs(autreMonstre.y - monstre.y) <= 2)
                        {
                            positionValide = false;
                            break;
                        }
                    }
                }
            } while (monstre.x == h1.x && monstre.y == h1.y && !positionValide);
            monstres.Add(monstre);
        }
        

    }
}