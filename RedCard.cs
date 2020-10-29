using System;
using System.Collections.Generic;
using System.Text;

namespace MiniVille
{
    class RedCard : Cards
    {
        public int AcVal; //Valeur d'activation
        public string Color;
        public string name;
        public int nbPieceRecue;
        public int Cout; //Cout de la carte
        public Player Launcher;

        public RedCard(Player launcher) : base(val, name, nbPiece, cout)
        {
            Color = "red";
            AcVal = val;
            this.name = name;
            nbPieceRecue = nbPiece;
            Launcher = launcher;

        }

    }
}
