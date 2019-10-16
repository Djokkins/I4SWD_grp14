using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class Shot : IDrinklist
    {
        public List<IDrinklist> shots = new List<IDrinklist>();
        private string _name;
        private string _content;

        public Shot()
        {

        }

        void IDrinklist.Printdrinkinfo()
        {
            foreach (IDrinklist i in shots)
                i.Printdrinkinfo();
        }

        public void AddShot(IDrinklist shot)
        {
            shots.Add(shot);
        }
    }
}
