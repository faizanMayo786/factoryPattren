
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesign
{
    class PizzaStore
    {
        private PizzaFactory PizzaFactory;

        public PizzaStore(PizzaFactory pizza)
        {
            this.PizzaFactory = pizza;
        }
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = PizzaFactory.CreatePizza(type);
            pizza.Prepare();
            

            return pizza;
        }
    }
}
