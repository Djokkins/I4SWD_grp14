using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class Drinks : IDrinklist
    {
        //public List<IDrinklist> drinks = new List<IDrinklist>();
        private string _name;

        public Drinks(string name = "Drinks")
        {
            _name = name;
        }

        void IDrinklist.Printdrinkinfo()
        {
            Console.WriteLine("\t" + _name + ": ");

            VodkaJuice vodkaJuice = new VodkaJuice();
            IDrinklist iDrinklistVodkaJuice = vodkaJuice;
            iDrinklistVodkaJuice.Printdrinkinfo();

            GinTonic ginTonic = new GinTonic();
            IDrinklist iDrinklistGinTonic = ginTonic;
            iDrinklistGinTonic.Printdrinkinfo();

            RumCoke rumCoke = new RumCoke();
            IDrinklist iDrinklistRumCoke = rumCoke;
            iDrinklistRumCoke.Printdrinkinfo();

            BlueLagoon blueLagoon = new BlueLagoon();
            IDrinklist iDrinklistBlueLagoon = blueLagoon;
            iDrinklistBlueLagoon.Printdrinkinfo();



            //foreach (IDrinklist i in drinks)
            //    i.Printdrinkinfo();
        }

        //public void AddShot(IDrinklist drink)
        //{
        //    drinks.Add(drink);
        //}
    }
}
