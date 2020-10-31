using System;
using System.Collections.Generic;
using System.Text;

namespace MiniVille
{
    class Game
    {
        public Piles deck;

        public Game(int nbCartes) {
            deck = new Piles(30);

        }
        public void DispDiffCards()
        {
            Console.Write(deck.ToString());
        }
    }
}
