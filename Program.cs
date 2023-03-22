using Rpg_Game.npj;
using Rpg_Game.Npj;

Humain h= new Humain("DANTE",0,0);
h.Affiche();
Nain n = new Nain("Petiot", 0, 0);
n.Affiche();
Loup l = new Loup("LouLou");
l.Affiche();
Dragonet d = new Dragonet("FeuFeu");
d.Affiche();
h.Frapper(d);
d.Affiche();
n.Frapper(l);
l.Affiche();

