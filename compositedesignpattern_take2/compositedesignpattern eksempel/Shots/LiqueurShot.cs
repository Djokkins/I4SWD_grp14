using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class LiqueurShot : IDrinklist
    {
        private string _name;
        private string _content;

        public LiqueurShot(string name = "Liqueur shot ", string content = "Vodka, Whisky, Tequila or Rum")
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
