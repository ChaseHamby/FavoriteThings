using System;

namespace FavoriteThings
{
    class Program
    {
        class Movies
        {
            public string Title { get; set; }
            public string Rating { get; set; }
        }

        class Meats
        {
            public string Type { get; set; }
            public string Cooking { get; set; }
        }

        class Music
        {
            public string Type { get; set; }
            public string Name { get; set; }
        }

        class Coffee
        {
            public string Type { get; set; }
            public string Roast { get; set; }
        }
            static void Main(string[] args)
            {
            Coffee coffeeRoast = new Coffee
            {
                Type = "Whole Beans",
                Roast = "Blonde"
            };
            Music musicStuff = new Music
            {
                Type = "Noise Rock",
                Name = "Health"
            };
                Console.WriteLine("I love to grind {0} and drink {1} roast. After that, I enjoy listening to {2} band {3}", coffeeRoast.Type, coffeeRoast.Roast, musicStuff.Type, musicStuff.Name);
            Console.ReadLine();
            }
        }
    }

