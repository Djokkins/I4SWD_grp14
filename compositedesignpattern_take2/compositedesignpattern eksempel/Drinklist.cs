using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class Drinklist : IDrinklist
    {
        private string _name;
        private Shot shot = new Shot();
        private Drinks drinks = new Drinks();

        public Drinklist(string name = "Drinklist")
        {
            _name = name;
        }

        void IDrinklist.Printdrinkinfo()
        {
            Console.WriteLine(_name + ": ");

            //show all the shots ingredients
            IDrinklist iDrinklistShots = shot;
            iDrinklistShots.Printdrinkinfo();

            IDrinklist iDrinklistDrinks = drinks;
            iDrinklistDrinks.Printdrinkinfo();
        }
    }
}
