using System;
using System.Collections.Generic;
using System.Text;

namespace MiniVille
{
    class Game
    {

        Piles deck = new Piles(30);
        public Game() {

        }
        public override string ToString()
        {
            string toString = string.Format(deck.ToString);
            return toString;
        }
    }
}
