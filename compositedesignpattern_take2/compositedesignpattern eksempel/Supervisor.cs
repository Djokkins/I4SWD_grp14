using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class Supervisor : IEmployee
    {
        private string name;
        private int happiness;

        private List<IEmployee> subordinate = new List<IEmployee>();

        public Supervisor(string name, int happiness)
        {
            this.name = name;
            this.happiness = happiness;
        }

        void IEmployee.ShowHappiness()
        {
            Console.WriteLine(name + " showed happiness level of " + happiness);
            //show all the subordinate's happiness level
            foreach (IEmployee i in subordinate)
                i.ShowHappiness();
        }

        public void AddSubordinate(IEmployee employee)
        {
            subordinate.Add(employee);
        }
    }
}
