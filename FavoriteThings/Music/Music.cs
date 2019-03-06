using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Music
{
    abstract class Music
    {
        public int DarknessLevel {get; protected set;}
        public Style Style { get; protected set; }
        public bool Loud { get; protected set; }

        protected Music(Style style, bool loud, int darknessLevel)
        {
            Loud = loud;
            Style = style;
            DarknessLevel = darknessLevel;
        }

        public virtual string Sing()
        {
            return ("Doo doo doo doo!");
        }
    }

    internal enum Style
    {
        Rock,
        HipHop,
        Country,
        Electronic,
        BlackMetal,
        Blues
    }
}
