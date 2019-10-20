using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class QualityShooters : IDrinklist
    {
        public List<IDrinklist> qualityShooters = new List<IDrinklist>();
        private string _name;
        private string _content;

        public QualityShooters(string name = "Quality Shooters")
        {
            this._name = name;
        }

        public void AddShot(IDrinklist bufQualityShooters)
        {
            qualityShooters.Add(bufQualityShooters);
        }

        public void Printdrinkinfo()
        {
            Console.WriteLine("\t" + _name + ": ");
            foreach (IDrinklist i in qualityShooters)
                i.Printdrinkinfo();
        }
    }
}
