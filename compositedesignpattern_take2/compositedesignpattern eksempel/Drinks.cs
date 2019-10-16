using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class drink : IDrinklist
    {
        private string _name;
        private string _content;

        public drink(string name, string content)
        {
            this._name = name;
            this._content = content;
        }

        void IDrinklist.Printdrinkinfo()
        {
            Console.WriteLine(_name + " have the following ingredients " + _content);
        }
    }
}
