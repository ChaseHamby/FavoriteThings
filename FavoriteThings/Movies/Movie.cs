using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Movies
{
    class Movie
    {

        public Genre Genre { get; set; }
        public Rating Rating { get; set; }

        public Movie(Genre genre, Rating rating)
        {
            Genre = genre;
            Rating = rating;
        }
    }

    internal enum Genre
    {
        Action,
        Western,
        Horror,
        Comedy,
        Drama
    }

    internal enum Rating
    {
        G,
        PG,
        PG13,
        R,
        NC17
    }
}
