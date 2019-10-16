﻿using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class Drink : IDrinklist
    {
        private string name;
        private string ingredients;

        private List<IDrinklist> shots = new List<IDrinklist>();

        public Drink(string name, string ingredients)
        {
            this.name = name;
            this.ingredients = ingredients;
        }

        void IDrinklist.Printdrinkinfo()
        {
            Console.WriteLine(name + " have the following ingredients " + ingredients);
            //show all the shots ingredients
            foreach (IDrinklist i in shots)
                i.Printdrinkinfo();
        }

        public void AddShot(IDrinklist shot)
        {
            shots.Add(shot);
        }
    }
}
