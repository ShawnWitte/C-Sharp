using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAdventure
{
    public class Enemy
    {
        private string name;
        private string roar;
        private double damage;

        public string getName()
        {
            return name;
        }

        public void setName(string newName)
        {
            name = newName;
        }

        public string getRoar()
        {
            return roar;
        }

        public void setRoar(string newRoar)
        {
            roar = newRoar;
        }

        public double getDamage()
        {
            return damage;
        }

        public void setDamage(double newDamage)
        {
            damage = newDamage;
        }

        public void enemyDisplay()
        {
            Console.WriteLine(getName() + " is now active");
        }

        public void enemyAttack()
        {
            Console.WriteLine(getName() + " attacks and does " + getDamage() + " damage");
        }

        public void enemyRoar()
        {
            Console.WriteLine(getName() + " yells out " + getRoar());
        }


    }
}
