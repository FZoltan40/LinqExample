using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    internal class Program
    {
        public static List<Game> games = new List<Game> 
        { 
            new Game{Title = "Legend of Zelda", Genre = "Adventure", ReleaseYear = 1986, Rating = 9.5, Price = 60 },
            new Game{Title = "Super Mario Bros", Genre = "Platformer", ReleaseYear = 1985, Rating = 9.2, Price = 50 },
            new Game{Title = "Elden Ring", Genre = "Rpg", ReleaseYear = 2022, Rating = 9.8, Price = 68 },
            new Game{Title = "Stardew Valley", Genre = "Rpg", ReleaseYear = 2016, Rating = 9.0, Price = 15 },
            new Game{Title = "Tetris", Genre = "Rpg", ReleaseYear = 1984, Rating = 8.9, Price = 10 },
        };
        static void Main(string[] args)
        {
            var gameCategories = games.Select(g => g.Genre)
                .Distinct();
            foreach (var item in gameCategories)
            {
                Console.WriteLine(item);
            }
            /*
             * Legkisebb-legnagyobb elem kiválasztás rendezéssel
             * var cheapestGame = games.OrderByDescending(g=> g.Price)
                .First();
            Console.WriteLine(cheapestGame.Title);*

            /*Összetett lekérések listából
             * var cheapRpgGames = games
                .Where(g => g.Genre == "Rpg" && g.Price < 70)
                .OrderByDescending(g => g.Rating)
                .Select(g => $"{g.Title} - {g.Price} - {g.Rating}");

            foreach (var item in cheapRpgGames)
            {
                Console.WriteLine(item);
            }*/
            /* 
             * Csoportosítás kategóriákra
             * var groupByGenre = games.GroupBy(genre => genre.Genre);
             foreach (var group in groupByGenre)
             {
                 Console.WriteLine(group.Key+":");

                 foreach (var game in group)
                 {
                     Console.WriteLine(game.Title);
                 }
             }*
             /*
             Legmagasabb ár meghatározása
             var highestPrice = games.Max(price=> price.Price);
             Console.WriteLine(highestPrice);

             Legmagasabb árú játék adatainak a meghatározása
             var mostExpensiveGame = games.First(game=> game.Price == highestPrice); 
             Console.WriteLine(mostExpensiveGame.Title);*/

            /*var avargePrice = games.Average(price => price.Price);
            Console.WriteLine(avargePrice);*/
            /*
             * Elemek rendezése
             * var sortedByYear = games.OrderByDescending(game => game.ReleaseYear);
            foreach (var item in sortedByYear)
            {
                Console.WriteLine($" {item.Title} - {item.ReleaseYear}");
            }*/

            /*
             * Eldönti hogy található e adott feltétellel elem (True/False)
             * var existinGame = games.Any(game => game.ReleaseYear == 1985);
            Console.WriteLine(existinGame);*/

            //Az Rpg kategóriába tartozó objektum a listából
            //var rpgGames = games.Where(game => game.Genre == "Rpg");

            /*
             * Összes Title tulajdonság a listából
             * var gameTitles = games.Select(game => game.Title);

           */


        }
    }
}
