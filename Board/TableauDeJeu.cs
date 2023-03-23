using System;
public class TableauDeJeu
{
    public char[,] Monde;
    
    public const int Largeur = 15;
    public const int Hauteur = 15;   

    public void LimitTab()
    {
        for (int i = 0; i < 14; i++)
        { 
            for (int j = 0; j < 14; j++)
            {
                if (i == 0 || j == 0 || i == 13 ||j == 13)
                {
                    Monde[i,j] = '#';
                }
                else Monde[i, j] = ' ';
            }
        }
           
    }

    public TableauDeJeu()
    {
        // Création d'un tableau de 15x15
        Monde = new char[15, 15];
        LimitTab();

        
        
    }

    public void Afficher()
    {
        // Affichage du tableau
        for (int i = 0; i < 14; i++)
        {
            for (int j = 0; j < 14; j++)
            {
                Console.Write(Monde[i, j]);
            }
            Console.WriteLine();
        }
    }
}

