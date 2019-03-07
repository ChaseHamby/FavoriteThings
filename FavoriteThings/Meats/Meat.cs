using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Meats
{
    class Meat
    {
        public Type Type { get; set; }
        public bool GrassFed { get; set; }
        public int Tastyness { get; set; }

        public Meat(Type type, int tastyness)
        {
            Type = type;
            Tastyness = tastyness;
        }
    }

    internal enum Type
    {
        Beef,
        Pork,
        Chicken,
        Lamb,
    }
}
