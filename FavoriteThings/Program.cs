using FavoriteThings.Music;
using System;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var beastMusic = new Metal();
            beastMusic.Destroy(50);
            beastMusic.Sing();

            Console.WriteLine(beastMusic);
            Console.ReadLine();
        }

    }
}

