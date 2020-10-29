using System;
using System.Collections.Generic;
using System.Text;

namespace MiniVille
{
    class RedCard : Cards
    {
        //Les cartes rouges se déclenche que lors du tour de l'autre joueur
        //public int AcVal; //Valeur d'activation
        //public string Color;
        //public string Name;
        //public int nbPieceRecue;
        //public int Cout; //Cout de la carte

        public RedCard(int val, string name, int nbPiece, int cout)
        {
            Color = "red";
            AcVal = val;
            this.name = name;
            nbPieceRecue = nbPiece;

        }
        public void CardTriggered(Player launcher, Player Owner)
        {
            Launcher.Pieces -= nbPieceRecue;
            Owner.Pieces += nbPieceRecue;
        }
    }
}
