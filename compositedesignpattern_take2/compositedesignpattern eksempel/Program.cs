using System;
using System.Collections.Generic;
using System.Text;

namespace compositedesignpattern_eksempel
{
    class Program
    {
        public static Beer beer = new Beer();
        public static Shot shot = new Shot();
        public static QualityShooters qualityShooters = new QualityShooters();
        public static Drinks drinks = new Drinks();

        static void Main(string[] args)
        {
            Console.WriteLine("Drinklist:");

            Console.WriteLine("\tBeers:");
            beer.Printdrinkinfo();

            Console.Write("\n");
            shot.AddShot(new SmallSour());
            shot.AddShot(new LiqueurShot());
            shot.AddShot(new Tequila());
            shot.AddShot(new RussianCocaine());
            shot.Printdrinkinfo();

            Console.Write("\n");
            qualityShooters.AddShot(new Jagerbomb());
            qualityShooters.AddShot(new GallianoHotShots());
            qualityShooters.AddShot(new Applecakeshots());
            qualityShooters.Printdrinkinfo();

            Console.Write("\n");
            drinks.AddDrink(new VodkaJuice());
            drinks.AddDrink(new GinTonic());
            drinks.AddDrink(new RumCoke());
            drinks.AddDrink(new BlueLagoon());
            drinks.AddDrink(new TequilaSunrise());
            drinks.Printdrinkinfo();
        }
    }
}
