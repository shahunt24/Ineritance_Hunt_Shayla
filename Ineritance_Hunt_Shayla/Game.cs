using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ineritance_Hunt_Shayla
{
    abstract class Game
    {
        public string Esrb { get; set; } // An automatic property for ESRB rating.

        public string Title { get; set; } // An automatic property for the title of the game.

        // Constructor that initializes the properties with the provided parameters.
        public Game(string esrbParam, string titleParam)
        {
            Esrb = esrbParam;
            Title = titleParam;
        }

        /// <summary>
        /// Prints the title of the game and says it's starting.
        /// </summary>
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is starting!");
        }

        public abstract string Describe();

    }
}
