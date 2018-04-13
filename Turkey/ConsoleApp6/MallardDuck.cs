using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class MallardDuck : IDucks
    {
        void IDucks.fly()
        {
            Console.WriteLine("I'm flying");
        }

        

        void IDucks.quack()
        {
            Console.WriteLine("Quack");
        }

        
    }
}
