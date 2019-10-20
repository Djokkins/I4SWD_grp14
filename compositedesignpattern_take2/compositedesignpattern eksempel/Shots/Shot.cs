using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class Shot : IDrinklist
    {
        public List<IDrinklist> shots = new List<IDrinklist>();
        private string _name;

        public Shot(string name = "Shots")
        {
            this._name = name;
        }

        public void AddShot(IDrinklist bufShot)
        {
            shots.Add(bufShot);
        }

        public void Printdrinkinfo()
        {
            Console.WriteLine("\t" + _name + ": ");
            foreach (IDrinklist i in shots)
                i.Printdrinkinfo();
        }
    }
}
