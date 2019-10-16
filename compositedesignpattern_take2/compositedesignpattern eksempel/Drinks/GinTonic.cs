using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class GinTonic  : IDrinklist
    {
        private string _name;
        private string _content;

        public GinTonic(string name = "Gin & Tonic ", string content = "4cl Gin and Tonic")
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
