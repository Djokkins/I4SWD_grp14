using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class Shot : IDrinklist
    {
        private string _name;
        private string _content;

        public Shot(string name, string content)
        {
            this._name = name;
            this._content = _content;
        }

        void IDrinklist.Printdrinkinfo()
        {
            Console.WriteLine(_name + " have the following ingredients " + _content);
        }
    }
}
