using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAdventure.Enemies
{
    public class Orc : Enemy
    {
        public Orc()
        {
            setName("Mr. Orc");
            setDamage(20);
            setRoar("\"RAAAAAAAAAWR!\"");
        }
    }
}
