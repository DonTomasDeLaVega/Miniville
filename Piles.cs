using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniVille
{
    class Piles
    {
        public List<Cards> DiffCart;
        public BlueCard CDB = new BlueCard(1,"Champs de Blé", 1,1);
        public BlueCard Ferme = new BlueCard(1, "Ferme", 1, 2);
        public GreenCard Boulangerie = new GreenCard(2, "Boulangerie", 2, 1);
        public RedCard cafe = new RedCard(3, "Café", 1,2);
        public GreenCard superette = new GreenCard(5, "Superette", 3, 2);
        public BlueCard Foret = new BlueCard(5, "Forêt", 1, 2);
        public RedCard Resto = new RedCard(5, "Restaurant", 2, 4);
        public BlueCard Stade = new BlueCard(6, "Stade", 4, 6);

        public List<Cards> PileCards = new List<Cards>();
        public int NbCards = 30;
        public Random randint = new Random();

        public Piles(int nbCards)
        {
            NbCards = nbCards;
           DiffCart = new List<Cards> {
                CDB,
                Ferme,
                Boulangerie,
                cafe,
                superette,
                Foret,
                Resto,
                Stade

            };
            CreatePile();
            }
        public void CreatePile()
        {
            for (int i = 0; i < NbCards; i++)
            {
                PileCards.Add(DiffCart[randint.Next(0, DiffCart.Count)]);
            }
        }
        public Cards TirerCarte()
        {
            Cards DerCarte = PileCards[PileCards.Count - 1];
            PileCards.RemoveAt(PileCards.Count - 1);
            Shuffle();
            return DerCarte;
        }

        public void Shuffle()
        {
            PileCards.OrderBy(x => Guid.NewGuid()).ToList();
        }

        public override string ToString()
        {
            List<int> indexes = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                indexes.Add(0);
            }
            string toString = "";
            foreach (Cards c in PileCards)
            {
                if (c.name == "Champs de Blé") indexes[0]++;
                else if (c.name == "Ferme") indexes[1]++;
                else if (c.name == "Boulangerie") indexes[2]++;
                else if (c.name == "Café") indexes[3]++;
                else if (c.name == "Superette") indexes[4]++;
                else if (c.name == "Forêt") indexes[5]++;
                else if (c.name == "Restaurant") indexes[6]++;
                else if (c.name == "Stade") indexes[7]++;
            }
            toString += string.Format("\nBoulangerie (x{0}) | Ferme (x{1})\nChamps de Blé: {2} | Café : {3} |\nSuperette : {4} | Forêt : {5} |\nRestaurant : {6} | Stade : {7} |", indexes[2], indexes[1], indexes[0], indexes[3], indexes[4], indexes[5], indexes[6], indexes[7]);

            return toString;
        }
    }
}
