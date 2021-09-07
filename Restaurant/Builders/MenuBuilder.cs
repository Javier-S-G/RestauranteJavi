using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant.Builders
{
    public class MenuBuilder
    {
        
        private string _firstDish;
        private string _dessert;
        private string _drink;
        private string _menuType;
        private decimal _price;
        private List<Menu> _menu;
        
        public MenuBuilder()
        {
            
            Reset();
        }
        public void Reset()
        {
            _firstDish = "";         
            _dessert = "";
            _drink = "";
            _price = 0;
            _menuType = "";          
        }
        public MenuBuilder SetMenuType(string menuType)
        {
            _menuType= menuType;
            return this;
        }
        public MenuBuilder SetCarnivorousFirstDish()
        {           
               _firstDish = "Ternasco de Aragon";
                return this;                       
        }
        public MenuBuilder SetVeganFirstDish()
        {
            _firstDish = "Hummus";
            return this;
        }
        public MenuBuilder SetKidFirstDish()
        {
            _firstDish = "Plato Combinado";
            return this;
        }

        public MenuBuilder SetDrinkType(string drink)
        {
            _drink = drink;
            return this;
        }
        public MenuBuilder SetDessertType(string dessert)
        {
            _dessert = dessert;
            return this;
        }
        public MenuBuilder SetPrice(decimal price)
        {
            _price = price;
            return this;
        }

        public Menu Build()
        {
            return new Menu(_firstDish, _price, _dessert,_drink,_menuType);
        }


    }
}
