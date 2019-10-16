using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class Supervisor : IDrinklist
    {
        private string name;
        private int happiness;

        private List<IDrinklist> subordinate = new List<IDrinklist>();

        public Supervisor(string name, int happiness)
        {
            this.name = name;
            this.happiness = happiness;
        }

        void IDrinklist.Printdrinkinfo()
        {
            Console.WriteLine(name + " showed happiness level of " + happiness);
            //show all the subordinate's happiness level
            foreach (IDrinklist i in subordinate)
                i.Printdrinkinfo();
        }

        public void AddSubordinate(IDrinklist employee)
        {
            subordinate.Add(employee);
        }
    }
}
