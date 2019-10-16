using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class VodkaJuice : IDrinklist
    {
        private string _name;
        private string _content;

        public VodkaJuice(string name = "Vodka Juice", string content = "4cl Vodka with Apple- or Orange Juice")
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
