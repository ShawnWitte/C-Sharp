using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Zoo
    {
        private string name;
        
        public Zoo(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public void PrintWelcome()
        {
            Console.WriteLine("Hello and welcome to " + this.name);
        }


        
        
    }
}
