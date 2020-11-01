using System;
using System.Collections.Generic;
using System.Text;

namespace MiniVille
{
    class BlueCard : Cards
    {
        //Les cartes bleues peuvent être activées n'importent quand si un joueur fait un certain chiffre au dés

        public BlueCard(int val, string name, int nbPiece,int cout) : base(val, name, nbPiece, cout)
        {
            Color = "blue";
            AcVal = val;
            this.name = name;
            nbPieceRecue = nbPiece;
        }
        public override void CardTriggered(Player O, Player L)
        {
            O.Pieces += nbPieceRecue;
        }
    }
}
