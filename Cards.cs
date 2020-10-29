using System;
using System.Collections.Generic;
using System.Text;

namespace MiniVille
{
    class Cards
    {
        public int AcVal; //Valeur d'activation
        public string Color;
        public string name;
        public int nbPieceRecue;
        public int Cout; //Cout de la carte
        public bool vol;
        //public Player Launcher;

        public Cards(int val, string col, string name, int nbPiece, int cout,Player launcher)
        {
            this.AcVal = val;
            this.Color = col;
            this.name = name;
            this.nbPieceRecue = nbPiece;
            this.Cout = cout;
            //Trouver le joueur propriétaire de la carte construite. Comment?
            //Launcher.Pieces -= nbPieceRecue; 
        }
        public Cards(int val, string name, int nbPiece, int cout)
        {
            this.AcVal = val;
            //this.Color = col;
            this.name = name;
            this.nbPieceRecue = nbPiece;
            this.Cout = cout;
            //Launcher.Pieces -= nbPieceRecue; 
        }
        public override string ToString()
        {
            string toString = string.Format("{0}\n+----+\n|{1}   |\n|    |\n|    |\n|{2}  {3}|\n+-----+", name, AcVal, nbPieceRecue, Cout);
            //Penser à changer la couleur du cw
            return toString;
        }
        
    }
}
