using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Snake snek = new Snake("Herman");
            snek.Greet();
            snek.Eat();

            Console.ReadLine();

            
        }
    }
}
