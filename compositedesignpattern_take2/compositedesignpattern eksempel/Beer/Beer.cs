using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class Beer : IDrinklist
    {
        private string _name;
        private string _content;

        public Beer(string name = "Beer", string content = "First – 20 kr | Refill – 15 kr")
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
