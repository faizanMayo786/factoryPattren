using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesign
{
    class Special :Pizza
    {

        public Special()
        {
            name = "Special Pizza";
            crust = "Thick";
            dough = "dough";
            toopings.Add("tops");
        }

    }
}
