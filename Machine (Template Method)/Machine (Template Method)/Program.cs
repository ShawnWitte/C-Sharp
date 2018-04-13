using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine__Template_Method_
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();
            Coffee coffee = new Coffee();

            Console.WriteLine("\nMaking tea...");
            tea.prepareRecipe();

            Console.WriteLine("\nMaking coffee");
            coffee.prepareRecipe();

            Console.ReadLine();

        }
    }
}
