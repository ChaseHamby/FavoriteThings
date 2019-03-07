using FavoriteThings.Coffee;
using FavoriteThings.Meats;
using FavoriteThings.Movies;
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
            // Console.WriteLine(beastMusic.Sing());

            var horrorFilm = new Horror();
            horrorFilm.scaryAsShit(7);

            var beefyStuff = new Beef();
            beefyStuff.Good(Cut.Ribeye);

            var strongCoffee = new Espresso();
            strongCoffee.Perky();

            Console.WriteLine();
            Console.ReadLine();
        }

    }
}

