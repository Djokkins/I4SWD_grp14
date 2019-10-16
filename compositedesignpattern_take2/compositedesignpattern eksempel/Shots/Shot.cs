using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    public class Shot : IDrinklist
    {
        //public List<IDrinklist> shots = new List<IDrinklist>();
        private string _name;
        private string _content;

        public Shot(string name = "Shots")
        {
            _name = name;
            //AddShot(new SmallSour());
        }

        void IDrinklist.Printdrinkinfo()
        {
            Console.WriteLine("\t" + _name + ": ");

            SmallSour smallSour = new SmallSour();
            IDrinklist iDrinklistSmallSour = smallSour;
            iDrinklistSmallSour.Printdrinkinfo();

            LiqueurShot liqueurShot = new LiqueurShot();
            IDrinklist iDrinklistLiqueurShot = liqueurShot;
            iDrinklistLiqueurShot.Printdrinkinfo();

            Tequila tequila = new Tequila();
            IDrinklist iDrinklistTequila = tequila;
            iDrinklistTequila.Printdrinkinfo();

            RussianCocaine russianCocaine = new RussianCocaine();
            IDrinklist iDrinklistRussianCocaine = russianCocaine;
            iDrinklistRussianCocaine.Printdrinkinfo();


            //foreach (IDrinklist i in shots)
            //    i.Printdrinkinfo();
        }

        //public void AddShot(IDrinklist shot)
        //{
        //    shots.Add(shot);
        //}
    }
}
