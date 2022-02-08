using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesign
{
    class Kabab:Pizza
    {

        public Kabab()
        {

            name = "Kabab Pizza";
            crust = "Thin";
            dough = "Medium";

            toopings.Add("Beef Sauce");
            toopings.Add("Beef");

        }
    }
}
