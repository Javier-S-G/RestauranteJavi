using Restaurant.Builders;
using Restaurant.Models;
using System;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            /* Vegan vg = new Vegan();

              foreach(string x in vg._main) {
                 Console.WriteLine(x);*/

            MenuBuilder menuCarnivorous = new MenuBuilder().SetCarnivorousFirstDish()
                                                       .SetDrinkType("Water")
                                                       .SetDessertType("Chocolate Pie")
                                                       .SetPrice(20);
            Console.WriteLine(menuCarnivorous);
        }
    }
}
