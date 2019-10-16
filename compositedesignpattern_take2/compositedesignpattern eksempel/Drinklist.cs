using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class Drinklist : IDrinklist
    {
        private string _name;
        private string _content;
        private Shot shot = new Shot();
        private Drinks drinks = new Drinks();

        public Drinklist(string name)
        {
            this._name = name;
        }

        void IDrinklist.Printdrinkinfo()
        {
            //show all the shots ingredients
            foreach (IDrinklist i in shot.shots)
                i.Printdrinkinfo();

            foreach (IDrinklist i in drinks.drinks)
                i.Printdrinkinfo();
        }
    }
}
