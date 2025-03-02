using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryGaming
{
    internal class PlatformerGame : IGame
    {
        public string getName()
        {
            return "Super Mario Bros";
        }

        public string getRating()
        {
            return "10/10";
        }

        public string getDescription()
        {
            return "It's-a-me, Mario!";
        }
    }
}
