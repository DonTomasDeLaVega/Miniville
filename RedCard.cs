using System;
using System.Collections.Generic;
using System.Text;

namespace MiniVille
{
    class RedCard
    {
        //Les cartes rouges se déclenche que lors du tour de l'autre joueur
        public int AcVal; //Valeur d'activation
        public string Color;
        public string Name;
        public int nbPieceRecue;
        public int Cout; //Cout de la carte

        public RedCard(int val, string name, int nbPiece, int cout)
        {
            Color = "red";
            AcVal = val;
            Name = name;
            nbPieceRecue = nbPiece;

        }
        public void CardTriggered(Player Launcher, Player Owner)
        {
            Launcher.Pieces -= nbPieceRecue;
            Owner.Pieces += nbPieceRecue;
        }
    }
}
