using System;
using System.Collections.Generic;
using System.Text;

namespace MiniVille
{
    class BlueCard : Cards
    {
        //Les cartes bleues peuvent être activées n'importent quand si un joueur fait un certain chiffre au dés
        //public int AcVal; //Valeur d'activation
        //public string Color;
       // public string Name;
        //public int nbPieceRecue;
        //public int Cout; //Cout de la carte
        //public Player Owner;
        public BlueCard(int val, string name, int nbPiece,int cout)
        {
            Color = "blue";
            AcVal = val;
            this.name = name;
            nbPieceRecue = nbPiece;
        }
        public void CardTriggered(Player O)
        {
            O.Pieces += nbPieceRecue;
        }
    }
}
