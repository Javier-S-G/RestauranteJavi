using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Models
{
   public class Menu
    {

        public string _main;          
        public decimal _price;
        public string _dessert;
        public string _drink;
        public string _menuType;

        public Menu(string main, decimal price, string dessert, string drink, string menuType)
        {
            _main = main;
            _price = price;
            _dessert = dessert;
            _drink = drink;
            _menuType = menuType;
        }
        public override string ToString()
        {
            return $"Menu: {_menuType},Dish: {_main},Dessert:{_dessert}, price: {_price}.";
        }
    }
}
