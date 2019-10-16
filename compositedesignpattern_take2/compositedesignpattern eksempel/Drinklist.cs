using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class Drinklist : IDrinklist
    {
        private string _name;
        private string _content;

        private List<IDrinklist> shots = new List<IDrinklist>();
        private List<IDrinklist> drinks = new List<IDrinklist>();

        public Drink(string name, string content)
        {
            this._name = name;
            this._content = content;
        }

        void IDrinklist.Printdrinkinfo()
        {
            Console.WriteLine(_name + " have the following ingredients " + _content);
            //show all the shots ingredients
            foreach (IDrinklist i in shots)
                i.Printdrinkinfo();
        }

        public void AddShot(IDrinklist shot)
        {
            shots.Add(shot);
        }
        public void Adddrink(IDrinklist drink)
        {
            drink.Add(drink);
        }
    }
}
