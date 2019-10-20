using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class GallianoHotShots : IDrinklist
    {
        private string _name;
        private string _content;

        public GallianoHotShots(string name = "Galliano Hot Shots", string content = "Galliano, Coffee and Whipped Cream")
        {
            this._name = name;
            this._content = content;
        }

        public void Printdrinkinfo()
        {
            Console.WriteLine("\t"+"\t" + _name + ": Has content: " + _content);
        }
    }
}
