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
        //public Cards cafe = new Cards(3, "red", "Café", 1, 2);
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
   /*         DiffCart = new List<Cards> {
                CDB,
                Ferme,
                Boulangerie,
                cafe,
                superette,
                Foret,
                Resto,
                Stade

            };*/
            CreatePile();
            }
        public void CreatePile()
        {
            for (int i = 0; i < NbCards; i++)
            {
                PileCards.Add(DiffCart[randint.Next(0, DiffCart.Count+1)]);
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
            string toString = string.Format("");
            foreach (Cards c in PileCards)
            {
                toString += string.Format(c.ToString());
            }
            return toString;
        }
    }
}
