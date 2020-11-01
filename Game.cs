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

        public Game(int nbCartes)
        {
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
            while (playerOne.Pieces < 20 && playerTwo.Pieces < 20)
            {
                Console.WriteLine("Appuyez sur entrée pour lancer le dé, joueur 1!");
                Console.ReadLine();
                Console.Clear();
                de.Lancer();
                Console.WriteLine(de.ToString());
                value = de.Face;
                foreach (Cards cards in playerOne.main) //tour du j1, on verifie ses bluecard
                {
                    if (cards.GetType() == typeof(BlueCard))
                    {
                        BlueCard tmp = (BlueCard)cards;
                        tmp.CardTriggered(playerOne);
 
                    }
                }
                foreach (Cards cards in playerOne.main) //tour du j1, on verifie ses greencard
                {
                    if (cards.GetType() == typeof(GreenCard))
                    {
                        GreenCard tmp = (GreenCard)cards;
                        tmp.CardTriggered(playerOne);
                    }
                }
                foreach (Cards cards in playerTwo.main) //tour du j1, on verifie les green cards ennemies
                {
                    if (cards.GetType() == typeof(GreenCard))
                    {
                        GreenCard tmp = (GreenCard)cards;
                        tmp.CardTriggered(playerTwo);
                    }
                }
                foreach (Cards cards in playerTwo.main) //tour du j1, on verifie les redCards du j2
                {
                    if (cards.GetType() == typeof(RedCard))
                    {
                        RedCard tmp = (RedCard)cards;
                        tmp.CardTriggered(playerOne, playerTwo);
                    }
                }
                DispPlayerCards();
                //Achat d'une carte maintenant:
                Cards piochee = deck.TirerCarte();
                Console.WriteLine("Tu as pioché cette carte : {0}\nVeux tu l'acheter? (Pour la modique somme de {1} pièces.)\n(Vous avez {2} pièces)\n", piochee.ToString(), piochee.Cout, playerOne.Pieces);
                string choix = null;
                while (choix != "o" && choix != "n")
                {
                    Console.WriteLine("(Marquez o pour oui, et n pour non.)");
                    choix = Console.ReadLine();
                }
                if (choix == "o")
                {
                    playerOne.main.Add(piochee);
                    Console.WriteLine("Vous avez pioché la carte!");
                }
                else if (choix =="n")
                {
                    Console.WriteLine("La carte a brulé, devant vous. Et par la carte, je veux dire l'établissement. Tout à cramé. Pouf, plus rien.");
                }

                //###########################################################
                Console.WriteLine("Appuyez sur entrée pour lancer le dé, joueur 2!");
                Console.ReadLine();
                Console.Clear();
                de.Lancer();
                Console.WriteLine(de.ToString());
                value = de.Face;
                foreach (Cards cards in playerTwo.main) //tour du j2, on verifie ses bluecard
                {
                    if (cards.GetType() == typeof(BlueCard))
                    {
                        BlueCard tmp = (BlueCard)cards;
                        tmp.CardTriggered(playerTwo);
                    }
                }
                foreach (Cards cards in playerTwo.main) //tour du j2, on verifie ses greenCards
                {
                    if (cards.GetType() == typeof(GreenCard))
                    {
                        GreenCard tmp = (GreenCard)cards;
                        tmp.CardTriggered(playerTwo);
                    }
                }
                foreach (Cards cards in playerOne.main) //tour du j2, on verifie les green cards ennemies
                {
                    if (cards.GetType() == typeof(GreenCard))
                    {
                        GreenCard tmp = (GreenCard)cards;
                        tmp.CardTriggered(playerOne);
                    }
                }
                foreach (Cards cards in playerOne.main) //tour du j2, on verifie les redCards du j1
                {
                    if (cards.GetType() == typeof(RedCard))
                    {
                        RedCard tmp = (RedCard)cards;
                        tmp.CardTriggered(playerTwo, playerOne);
                    }
                }

                DispPlayerCards();
                //Achat d'une carte maintenant:
                piochee = deck.TirerCarte();
                Console.WriteLine("Tu as pioché cette carte : {0}\nVeux tu l'acheter? (Pour la modique somme de {1} pièces.)\n(Vous avez {2} pièces)\n", piochee.ToString(), piochee.Cout, playerOne.Pieces);
                choix = null;
                while (choix != "o" && choix != "n")
                {
                    Console.WriteLine("(Marquez o pour oui, et n pour non.)");
                    choix = Console.ReadLine();
                }
                if (choix == "o")
                {
                    playerOne.main.Add(piochee);
                    Console.WriteLine("Vous avez pioché la carte!");
                }
                else if (choix == "n")
                {
                    Console.WriteLine("La carte a brulé, devant vous. Et par la carte, je veux dire l'établissement. Tout à cramé. Pouf, plus rien.");
                }

            }
            Console.Clear();
            if (playerOne.Pieces >= 20)
            {
                if (playerTwo.Pieces >= 20)
                {
                    if (playerOne.Pieces != playerTwo.Pieces)
                    {
                        Console.WriteLine("Égalité! Les deux joueurs ont dépassés les 20 pièces en même temps! (Mais le Joueur {0} a plus de pièces)", playerTwo.Pieces > playerOne.Pieces ? "2" : "1");
                    }
                }
                else
                {
                    Console.WriteLine("Le joueur 1 a gagné!");
                }
            }
            else
            {
                Console.WriteLine("Le joueur 2 a gagné!");

            }

            DispPlayerCards();
        }
    }
}
