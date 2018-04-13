using SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaProject
{
    public class HillsboroPizzaStore : PizzaStore
    {
        // hillsboro-style preparation for all pizzas
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IIngredientFactory ingredientFactory =
                new HillsboroIngredientFactory();

            if (type == "Cheese")
                pizza = new CheesePizza(ingredientFactory);
            else if (type == "Clam")
                pizza = new ClamPizza(ingredientFactory);
            else if (type == "Suede")
                pizza = new ShoePizza(ingredientFactory);

            return pizza;
        }
    }
}
