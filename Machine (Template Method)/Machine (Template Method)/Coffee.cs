using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine__Template_Method_
{
    class Coffee : CaffeineBeverage
    {
        public override void brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override void addCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override bool customerWantsCondiments()
        {
            Console.WriteLine("Do you want milk and sugar with your coffee? (y/n)");
            string answer = Console.ReadLine();
            if(answer == "y")
            {
                return true;
            }

            else
            {
                return false;
            }

        }
    }
}
