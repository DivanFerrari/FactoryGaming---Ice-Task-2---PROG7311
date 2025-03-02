using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryGaming
{
    internal class SimulatorGame : IGame
    {
        public string getName()
        {
            return "Goat Simulator 3";
        }

        public string getRating()
        {
            return "30/10";
        }

        public string getDescription()
        {
            return "MAAAAAAAAAAAAAA";
        }
    }
}
