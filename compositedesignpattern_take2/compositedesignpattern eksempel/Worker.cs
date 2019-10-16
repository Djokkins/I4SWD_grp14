using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class Worker : IDrinklist
    {
        private string name;
        private int happiness;

        public Worker(string name, int happiness)
        {
            this.name = name;
            this.happiness = happiness;
        }

        void IDrinklist.Printdrinkinfo();
        {
            Console.WriteLine(name + " showed happiness level of " + happiness);
        }
    }
}
