
using System;
using System.Collections.Generic;
using System.Text;

namespace MiniVille
{
    class Player
    {
        public int Pieces = 3;
        public List<Cards> main = new List<Cards>();
        public string nomJoueur;
        public Piles deck;
        public Player(Piles deck)
        {
            this.deck = deck;
            main.Add(new BlueCard(1, "Champs de Blé", 1, 1));
            main.Add(new GreenCard(2, "Boulangerie", 2, 1));
        }
        public override string ToString()
        {
            List<int> indexes = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                indexes.Add(0);
            }
            string toString = string.Format("Pièces : {0}",Pieces);
            foreach (Cards c in main)
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
            toString += string.Format("\nBoulangerie (x{0}) | Ferme (x{1})\nChamps de Blé: {2} | Café : {3} |\nSuperette : {4} | Forêt : {5} |\nRestaurant : {6} | Stade : {7} |\n\n", indexes[2], indexes[1], indexes[0], indexes[3], indexes[4], indexes[5], indexes[6], indexes[7]);

            return toString;
        }
        public void ChangeNom()
        {
            Console.WriteLine("Quel est votre nom ?");
            nomJoueur = Console.ReadLine();
        }

    }
}

