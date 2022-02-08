using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesign
{
  public abstract  class Pizza
    {

        protected string name;
        protected string crust;
        protected string dough;
        protected List<string> toopings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Preparing\t{name}");
            Console.WriteLine($"Crust\t{crust}");
            Console.WriteLine($"Dough\t{dough}");

            foreach (var item in toopings)
            {
                Console.WriteLine($"Toppings\t{item}");
            }
        }

    }
}
