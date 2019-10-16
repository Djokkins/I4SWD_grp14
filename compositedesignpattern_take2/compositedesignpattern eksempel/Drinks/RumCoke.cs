using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class RumCoke : IDrinklist
    {
        private string _name;
        private string _content;

        public RumCoke(string name = "Rum & Coke", string content = "4cl Rum and Coke")
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
