using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyFactory enemyFactory = new EnemyFactory();
            Enemy theEnemy = null;

            Console.WriteLine("What kind of enemy do you want to spawn? Dem / Dev / Orc?");
            string typeEnemy = Console.ReadLine();
            theEnemy = enemyFactory.makeEnemy(typeEnemy);

            enemyStuff(theEnemy);
            Console.ReadLine();
        }

        public static void enemyStuff(Enemy anEnemy)
        {
            anEnemy.enemyDisplay();
            anEnemy.enemyAttack();
            anEnemy.enemyRoar();
        }
    }
}
