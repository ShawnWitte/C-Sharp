using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("...");
        }

    }
}
