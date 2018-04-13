using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleFactory
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string pizzaType)
        {
            Pizza pizza = CreatePizza(pizzaType);

            pizza.Prepare(); 
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }

   

    
}
