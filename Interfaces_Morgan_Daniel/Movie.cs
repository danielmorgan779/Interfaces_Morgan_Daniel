using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Morgan_Daniel
{
    /// <summary>
    /// Implemented movie class with automatic properties
    /// </summary>
    class Movie : IGenre
    {
        public string Esrb { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        public Movie(string esrbParam, string genreParam, string titleParam)
        {
            Esrb = esrbParam;
            Genre = genreParam;
            Title = titleParam;
        }

        /// <summary>
        /// A public method that prints "Movie is starting ssh", also with are Describe method that describes the game
        /// </summary>
        public void PlayMovie()
        {
            Console.WriteLine($"{Title} is starting, SSSHHHhhhh!");
        }

        public string Describe()
        {
            return $"{Title} is a(n) {Genre} movie, rated {Esrb}!";
        }
    }
}
