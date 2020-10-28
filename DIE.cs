using System;
using System.Collections.Generic;
using System.Text;

namespace MiniVille
{
    class DIE
    {
        public int NbFaces;
        public Random RandInt = new Random();
        public int Face { get; protected set; }
        public DIE()
        {
            NbFaces = 6;
        }
        public DIE(int nbFaces)
        {
            NbFaces = nbFaces;
        }

        public virtual void Lancer()
        {
            Face = RandInt.Next(1, NbFaces + 1);// jet de dé 
        }
        public override string ToString()
        {

            string toString = string.Format("+---+\n| {0} |\n+---+", Face);// motif dé
            return toString;

        }

    }

}


