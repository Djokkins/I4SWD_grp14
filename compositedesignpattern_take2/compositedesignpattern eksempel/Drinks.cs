using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class drink : IDrinklist
    {
        private string name;
        private int ingredients;

        public drink(string name, int happiness)
        {
            this.name = name;
            this.ingredients = ingredients;
        }

        void IDrinklist.Printdrinkinfo()
        {
            Console.WriteLine(name + " have the following ingredients " + ingredients);
        }
    }
}
