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
        DIE de;

        public Game(int nbCartes) {
            deck = new Piles(nbCartes);
            playerOne = new Player(deck);
            playerTwo = new Player(deck);
            de = new DIE();
        }
        public void DispPlayerCards()
        {
            Console.WriteLine("Joueur 1:");
            Console.Write(playerOne.ToString());
            Console.WriteLine("Joueur 2:");
            Console.Write(playerTwo.ToString());
        }
        public void RunGame()
        {
            int value;
            while(playerOne.Pieces < 20 && playerTwo.Pieces < 20)
            {
                Console.WriteLine("Appuyez sur entrée pour lancer le dé, joueur 1!");
                Console.ReadLine();
                de.Lancer();
                value = de.Face;
                foreach (BlueCard c in playerOne.main) //tour du j1, on verifie ses bluecard
                {
                    if(c.AcVal == value)
                    {
                        c.CardTriggered(playerOne);
                    }
                }
                foreach (GreenCard c in playerOne.main) //tour du j1, on verifie ses greenCards
                {
                    if (c.AcVal == value)
                    {
                        c.CardTriggered(playerOne);
                    }
                }
                foreach (GreenCard c in playerTwo.main) //tour du j1, on verifie les green cards ennemies
                {
                    if (c.AcVal == value)
                    {
                        c.CardTriggered(playerTwo);
                    }
                }
                foreach (RedCard c in playerTwo.main) //tour du j1, on verifie les redCards du j2
                {
                    if (c.AcVal == value)
                    {
                        c.CardTriggered(playerOne,playerTwo);
                    }
                }
                //Achat d'une carte maintenant:
                Cards piochee = deck.TirerCarte();
                Console.WriteLine("Tu as pioché cette carte : {0}\nVeux tu l'acheter? (Pour la modique somme de {1} pièces.)\n(Vous avez {2} pièces)\n(marquer o pour oui, et n pour non.)",piochee.ToString(),piochee.Cout, playerOne.Pieces);
                string choix = null;
                while (choix != "o" && choix != "o")
                {
                    choix = Console.ReadLine();
                }
                //###########################################################





            }
        }
    }
}
