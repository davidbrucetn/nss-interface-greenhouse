using System;

namespace Greenhouse
{
    public class Tulip : IBouquetItem, IPlant
    {
        public string Species { get; set; }
        public int StemLength { get; set; }
        public string Color { get; set; }
        public bool Variegated { get; set; }
        public int Price { get; set; }

        public void Report()
        {
            Console.WriteLine($"This is a {Color} tulip of species {Species}. This flower {(Variegated ? "is" : "is not")} variegated.");
        }
    }
}