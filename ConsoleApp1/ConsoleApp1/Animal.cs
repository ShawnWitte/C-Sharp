using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animal
    {
        private string name;

        public void Greet()
        {
            Console.WriteLine("Hi, I am " + name + ", nice to meet you");

        }

        public void Eat() {
            Console.WriteLine("I am eating");
        }
        

    }
}
