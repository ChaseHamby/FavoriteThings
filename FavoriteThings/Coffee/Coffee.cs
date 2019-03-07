using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Coffee
{
    class Coffee
    {
        public Roast Roast { get; set; }
        public Type Type { get; set; }
        public int CaffeineContent { get; set; }

        public Coffee(Roast roast, Type type, int caffeineContent)
        {
            Roast = roast;
            Type = type;
            CaffeineContent = caffeineContent;
        }
    }

    internal enum Roast
    {
        Blonde,
        Black,
        Full
    }

    internal enum Type
    {
        Espresso,
        FrenchPress,
        Chemex,
        Drip
    }
}
