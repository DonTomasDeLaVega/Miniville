using System;
using System.Collections.Generic;
using System.Text;

namespace MiniVille
{
    class Piles
    {
        List<Cards> PileCards = new List<Cards>();
        int NbCards = 5;
        public Piles(int nbCards)
        {
            NbCards = nbCards;

        }
        public void CreatePile()
        {
            for (int i = 0; i < NbCards; i++)
            {
                PileCards.Add(Cards);
            }
        }
        public Cards TirerCarte()
        {
            return PileCards[PileCards.Count - 1];
        }
        public void Shuffle()
        {
            PileCards.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}
