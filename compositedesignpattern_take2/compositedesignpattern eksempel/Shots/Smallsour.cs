using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class SmallSour : IDrinklist
    {
        private string _name;
        private string _content;

        public SmallSour(string name = "Small sour", string content = "Flavours: Apple, Cola, Peach, Liquorice etc.")
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
