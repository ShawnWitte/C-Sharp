using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();

            WildTurkey turkey = new WildTurkey();
            IDucks turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The Turkey says..");
            turkey.gobble();
            turkey.fly();
            Console.WriteLine("");

            Console.WriteLine("The Duck says...");
            testDuck(duck);
            Console.WriteLine("");

            Console.WriteLine("The TurkeyAdapter says...");
            testDuck(turkeyAdapter);
            Console.ReadLine();
            
        }
        static void testDuck(IDucks duck)
        {
            duck.quack();
            duck.fly();
        }
    }
}
