using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine__Template_Method_
{
    public abstract class CaffeineBeverage
    {
        public virtual void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            if (customerWantsCondiments())
            {
                addCondiments();
            }
        }
        public abstract void brew();

        public abstract void addCondiments();
        void boilWater()
        {
            Console.WriteLine("Boiling water");
        }

        void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public abstract bool customerWantsCondiments();
    }
}
