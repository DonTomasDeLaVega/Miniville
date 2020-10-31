using System;
using System.Collections.Generic;
using System.Text;

namespace MiniVille
{
    class Game
    {
        public Piles deck;
        Player playerOne;
        Player playerTwo;

        public Game(int nbCartes) {
            deck = new Piles(nbCartes);
            playerOne = new Player(deck);
            playerTwo = new Player(deck);
        }
        public void DispDiffCards()
        {
            Console.WriteLine("Joueur 1:");
            Console.Write(playerOne.ToString());
            Console.WriteLine("Joueur 2:");
            Console.Write(playerTwo.ToString());
        }
    }
}
