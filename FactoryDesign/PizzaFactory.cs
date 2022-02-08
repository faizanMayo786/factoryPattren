using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesign
{
    class PizzaFactory
    {
        public Pizza CreatePizza(string type)
        {

            if (type.Equals("Special"))
            {
                return new Special();
            }else if (type.Equals("Kabab"))
            {
                return new Kabab();
            }
            else
            {
                return new Fajita();
            }
        }

        
    }
}
