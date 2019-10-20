using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class Drinks : IDrinklist
    {
        public List<IDrinklist> drinks = new List<IDrinklist>();

        private string _name;

        public Drinks(string name = "Drinks")
        {
            this._name = name;
        }

        public void Printdrinkinfo()
        {
            Console.WriteLine("\t" + _name + ": ");

            foreach (IDrinklist i in drinks)
                i.Printdrinkinfo();
        }

        public void AddDrink(IDrinklist drink)
        {
            drinks.Add(drink);
        }
    }
}
