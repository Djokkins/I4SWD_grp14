using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class Applecakeshots : IDrinklist
    {
        private string _name;
        private string _content;

        public Applecakeshots(string name = "Applecakeshots", string content = "Vodka, Galliano and Apple Juice")
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
