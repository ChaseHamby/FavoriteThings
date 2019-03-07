using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Meats
{
    class Beef : Meat
    {
        public Beef() 
            : base(Type.Beef, 10)
        {
        }

        public Cut Cut { get; set; }

        public void Good(Cut cut)
        {
            Console.WriteLine($"I give this {Cut.Ribeye} cut of {Type} a score of {Tastyness}!");
        }
    }

    internal enum Cut
    {
        Ribeye,
        NewYorkStrip,
        Flank,
        FiletMignon,
        Sirloin
    }
}
