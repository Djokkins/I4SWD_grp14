using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class Tequila : IDrinklist
    {
        private string _name;
        private string _content;

        public Tequila(string name = "Tequila", string content = "Served with Salt and a slice of Lemon")
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
