using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Coffee
{
    class Espresso : Coffee
    {
        public Espresso() 
            : base(Roast.Black, Type.Espresso, 200)
        {
        }

        public void Perky()
        {
            Console.WriteLine($"No wonder this {Type} is so {Roast}, it has a caffeine content of {CaffeineContent}!");
        }
    }
}
