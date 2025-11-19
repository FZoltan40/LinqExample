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
            new Game{Title = "Elden Ring", Genre = "Rpg", ReleaseYear = 2022, Rating = 9.8, Price = 70 },
            new Game{Title = "Stardew Valley", Genre = "Simulation", ReleaseYear = 2016, Rating = 9.0, Price = 15 },
            new Game{Title = "Tetris", Genre = "Puzzle", ReleaseYear = 1984, Rating = 8.9, Price = 10 },
        };
        static void Main(string[] args)
        {
            /*
             * Eldönti hogy található e adott feltétellel elem (True/False)
             * var existinGame = games.Any(game => game.ReleaseYear == 1985);
            Console.WriteLine(existinGame);*/

            /*foreach (var item in rpgGames)
            {
                Console.WriteLine(item.Title);
            }*/


            //Az Rpg kategóriába tartozó objektum a listából
            //var rpgGames = games.Where(game => game.Genre == "Rpg");

            /*
             * Összes Title tulajdonság a listából
             * var gameTitles = games.Select(game => game.Title);

           */


        }
    }
}
