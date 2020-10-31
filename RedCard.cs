using System;
using System.Collections.Generic;
using System.Text;

namespace MiniVille
{
    class RedCard : Cards
    {
        //Les cartes rouges se déclenche que lors du tour de l'autre joueur


        public RedCard(int val, string name, int nbPiece, int cout) : base(val, name, nbPiece, cout)
        {
            Color = "red";
            AcVal = val;
            this.name = name;
            nbPieceRecue = nbPiece;
            Cout = cout;

        }
        public void CardTriggered(Player Launcher, Player Owner)
        {
            Launcher.Pieces -= nbPieceRecue;
            Owner.Pieces += nbPieceRecue;
        }
    }
}
