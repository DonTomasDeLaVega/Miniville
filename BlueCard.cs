using System;
using System.Collections.Generic;
using System.Text;

namespace MiniVille
{
    class BlueCard : Cards
    {
        public int AcVal; //Valeur d'activation
        public string Color;
        public string name;
        public int nbPieceRecue;
        public int Cout; //Cout de la carte
        public BlueCard() : base(val, name, nbPiece, cout)
        {
            Color = "blue";
            AcVal = val;
            this.name = name;
            nbPieceRecue = nbPiece;

        }
    }
}
