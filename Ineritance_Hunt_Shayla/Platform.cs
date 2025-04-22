using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ineritance_Hunt_Shayla
{
    class Platform : Game
    {

        // A contructor that takes the esrb and title parameters and passes them to the base class constructor.
        public Platform(string esrbParam, string titleParam) : base(esrbParam, titleParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
        }

        // A Describe method that returns a string describing the game and includes the title and esrb.
        public override string Describe()
        {
            return $"{Title} is a platform game rated {Esrb}!";
        }
    }
}
