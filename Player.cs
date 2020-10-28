using System;
using System.Collections.Generic;
using System.Text;

namespace MiniVille
{
    class Player
    {
        public int Pieces = 3;
        public List<Cards> main = new List<Cards>();
        public Piles deck;
        public Player(Piles deck)
        {
            this.deck = deck;
            this.main.Add(new Cards(1, "blue", "Champs de Blé", 1, 1));
            this.main.Add(new Cards(2, "green", "Boulangerie", 2, 1));
        }
    }
}
