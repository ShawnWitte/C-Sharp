using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAdventure.Enemies
{
    public class Demon : Enemy
    {
        public Demon()
        {
            setName("The Hellish One");
            setDamage(10);
            setRoar("\"Burn you foolish human!\"");
        }


    }
}
