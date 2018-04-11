using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine__Template_Method_
{
    class Tea : CaffeineBeverage
    {
        public override void brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void addCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override bool customerWantsCondiments()
        {
            Console.WriteLine("Do you want milk in your tea, like a true British man? (y/n)");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                return true;
            }

            else
            {
                Console.WriteLine("The machine says you're not a true Britt...");
                return false;
            }
        }
    }
}
