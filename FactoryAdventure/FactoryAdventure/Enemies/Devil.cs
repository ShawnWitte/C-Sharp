using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAdventure.Enemies
{
    public class Devil : Demon
    {
        public Devil()
        {
            setName("The Devil");
            setDamage(40);
            setRoar("You will join the dark side");
        }
    }
}
