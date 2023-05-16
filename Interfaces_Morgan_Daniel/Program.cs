using System;

namespace Interfaces_Morgan_Daniel
{
    class Program
    {
        /// <summary>
        /// Created are game object and described it while calling the PlayGame method. Same thing with are movie object. Then it prints both to the console
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Game myGame = new Game("E", "FPS", "ZombCube");
            Console.WriteLine(myGame.Describe());
            myGame.PlayGame();

            Movie myMovie = new Movie("PG", "Adventure/Comedy", "Rango");
            Console.WriteLine(myMovie.Describe());
            myMovie.PlayMovie();
        }
    }
}
