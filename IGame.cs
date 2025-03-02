using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryGaming
{
    public interface IGame
    {
        String getName();
        String getRating();
        String getDescription();
    }
}
