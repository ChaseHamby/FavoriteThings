using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Movies
{
    class Horror : Movie
    {
        public Horror() 
            : base(Genre.Horror, Rating.R)
        {
        }

        public bool Scary { get; set; }
        public int ScareFactor { get; set; }

        public void scaryAsShit(int ScareFactor)
        {
            Console.WriteLine($"This {Genre} movie had a scare factor of {ScareFactor} and a {Rating} rating! " +
                $"It's pretty messed up.");
        }
    }
}
