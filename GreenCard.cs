﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MiniVille
{
    class GreenCard : Cards
    {
        //Les cartes vertes, pour être activées, ont besoin que leur propriétaire fasse leurs valeur d'activation au dé (et pas n'importe qui)

        public GreenCard(int val, string name, int nbPiece, int cout) : base(val, name, nbPiece, cout)
        {
            Color = "green";
            AcVal = val;
            this.name = name;
            nbPieceRecue = nbPiece;

        }
        public override void CardTriggered(Player Owner, Player L)
        {
            Owner.Pieces += nbPieceRecue;
        }
    }
}
