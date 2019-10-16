using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class BlueLagoon : IDrinklist
    {
        private string _name;
        private string _content;

        public BlueLagoon(string name = "Blue Lagoon", string content = "4cl Vodka, Blue Curacão, Sprite")
        {
            this._name = name;
            this._content = content;
        }

        public void Printdrinkinfo()
        {
            Console.WriteLine("\t" + "\t" + _name + ": Has content: " + _content);
        }
    }
}
