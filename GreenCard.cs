using System;
using System.Collections.Generic;
using System.Text;

namespace MiniVille
{
    class GreenCard
    {
        //Les cartes vertes, pour être activées, ont besoin que leur propriétaire fasse leurs valeur d'activation au dé (et pas n'importe qui)
        public int AcVal; //Valeur d'activation
        public string Color;
        public string name;
        public int nbPieceRecue;
        public int Cout; //Cout de la carte

        public GreenCard(int val, string name, int nbPiece, int cout)
        {
            Color = "red";
            AcVal = val;
            this.name = name;
            nbPieceRecue = nbPiece;

        }
        public void CardTriggered(Player Owner)
        {
            Owner.Pieces += nbPieceRecue;
        }
    }
}
