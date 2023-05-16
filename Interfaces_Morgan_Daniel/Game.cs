using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Morgan_Daniel
{
    /// <summary>
    /// Implented the IGenre interface we made with an implemented constructor that takes are string parameters with automatic properties
    /// </summary>
    class Game : IGenre
    {
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        public Game(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        /// <summary>
        /// public method that says the game is starting with are Describe method that describes the game
        /// </summary>
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is starting! Game ONN!");
        }

        public string Describe()
        {
            return $"{Title} is a(n) {Genre} game, rated {Esrb}!";
        }
    }
}
