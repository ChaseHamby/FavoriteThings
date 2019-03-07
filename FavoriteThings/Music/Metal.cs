using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Music
{
    class Metal : Music
    {
        public Metal()
            : base(Style.BlackMetal, true, 7)
        {
        }
        public int DarkLevel { get; set; }
        public bool IsItSlayer { get; set; }

        public override string Sing()
        {
            return ("Reigning Blood!!!!");
        }

        public void Destroy(int howMuchDestruction)
        {
            Console.WriteLine($"I just destroyed {howMuchDestruction} souls listening to this {Style} band" +
                $" with a darkness level of {DarknessLevel}!");
        }
    }
}
