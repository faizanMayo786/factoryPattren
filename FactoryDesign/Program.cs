using System;

namespace FactoryDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaFactory factory = new PizzaFactory();
            PizzaStore store = new PizzaStore(factory);
            Pizza fajita = store.OrderPizza("Special");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------Hellow------------------");
            Console.WriteLine("--------Hellow------------------");
            Pizza kabab = store.OrderPizza("Kabab");
            Pizza Fajita = store.OrderPizza("Fajita");

        }
    }
}
