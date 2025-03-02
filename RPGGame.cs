using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryGaming
{
    internal class RPGGame : IGame
    {
        public string getName()
        {
            return "Baldur's Gate 3";
        }

        public string getRating()
        {
            return "10/10";
        }

        public string getDescription()
        {
            return "Gather your party and return to the " +
                "Forgotten Realms in a tale of fellowship and betrayal, " +
                "sacrifice and survival, and the lure of absolute power";
        }
    }
}
