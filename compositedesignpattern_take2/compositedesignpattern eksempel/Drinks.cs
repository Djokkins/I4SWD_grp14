using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class Drinks : IDrinklist
    {
        public List<IDrinklist> drinks = new List<IDrinklist>();
        private string _name;
        private string _content;

        public Drinks()
        {

        }

        void IDrinklist.Printdrinkinfo()
        {
            foreach (IDrinklist i in drinks)
                i.Printdrinkinfo();
        }

        public void AddShot(IDrinklist drink)
        {
            drinks.Add(drink);
        }
    }
}
