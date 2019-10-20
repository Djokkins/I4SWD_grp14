using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    class Program
    {
        public static Shot shot = new Shot();
        public static Drinks drinks = new Drinks();

        public List<IDrinklist> drinklists = new List<IDrinklist>();

        static void Main(string[] args)
        {
            Console.WriteLine("Drinklist:");

            shot.AddShot(new SmallSour());
            shot.AddShot(new LiqueurShot());
            shot.AddShot(new Tequila());
            shot.AddShot(new RussianCocaine());
            shot.Printdrinkinfo();

            drinks.AddDrink(new VodkaJuice());
            drinks.AddDrink(new GinTonic());
            drinks.AddDrink(new RumCoke());
            drinks.AddDrink(new BlueLagoon());
            drinks.Printdrinkinfo();


        }
    }
}
