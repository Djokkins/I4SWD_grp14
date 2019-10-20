using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class Jagerbomb : IDrinklist
    {
        private string _name;
        private string _content;

        public Jagerbomb(string name = "Jagerbomb", string content = "2cl Jägermeister with Energy Drink")
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
