using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class TequilaSunrise  : IDrinklist
    {
        private string _name;
        private string _content;

        public TequilaSunrise(string name = "Tequila Sunrise ", string content = "4cl Tequila, Orange Juice, Grenadine")
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
