using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class RussianCocaine : IDrinklist
    {
        private string _name;
        private string _content;

        public RussianCocaine(string name = "Russian Cocaine", string content = "Vodka served with a wedge of Lime, dipped in Sugar and Coffee powder")
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
