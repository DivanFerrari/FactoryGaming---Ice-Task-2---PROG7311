using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryGaming
{
    internal class ActionGame : IGame
    {
        public string getName()
        {
            return "Call of Duty: Black Ops 2";
        }

        public string getRating()
        {
            return "15/10";
        }

        public string getDescription()
        {
            return "Call of Duty®: Black Ops II " +
                "propels players into a near future," +
                " 21st Century Cold War, where technology " +
                "and weapons have converged to create a new generation of warfare";
        }
    }
}
