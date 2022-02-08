using System;

namespace FactoryDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaFactory factory = new PizzaFactory();
            PizzaStore store = new PizzaStore(factory);
            Pizza fajita=    store.OrderPizza("Special");
            Console.WriteLine("--------------------------------");

            Pizza kabab = store.OrderPizza("Kabab");

        }
    }
}
