using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAdventure
{
    public class EnemyFactory
    {
        public Enemy makeEnemy(string newEnemyType)
        {
            Enemy newEnemy = null;

            if (newEnemyType.Equals("Dem"))
            {
                return new Enemies.Demon();
            }
            else if (newEnemyType.Equals("Dev"))
            {
                return new Enemies.Devil();
            }
            else if (newEnemyType.Equals("Orc"))
            {
                return new Enemies.Orc();
            }
            return newEnemy;
        }
    }
}
