using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryGaming
{
    public class GamingFactory
    {
        public IGame returnInstance;

        public IGame getGame(String GameType)
        {
            if (GameType.ToLower().Equals("action"))
            {
                returnInstance = new ActionGame();
            }
            else if (GameType.ToLower().Equals("RPG"))
            {
                returnInstance = new RPGGame();
            }
            else if (GameType.ToLower().Equals("simulator"))
            {
                returnInstance = new SimulatorGame();
            }
            else
            {
                returnInstance = new PlatformerGame();
            }
            return returnInstance;
        }
    }
}
