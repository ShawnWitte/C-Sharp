using SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore store = new PortlandPizzaStore();
            store.OrderPizza("Cheese");
            store = new HillsboroPizzaStore();
            store.OrderPizza("Clam");

            Console.ReadLine();
        }
    }
}
