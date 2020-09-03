using System;

namespace Greenhouse
{
    public class Rose : IBouquetItem, IPlant
    {
        public string Species { get; set; }
        public int StemLength { get; set; }
        public string Color { get; set; }
        public bool Thorny { get; set; }
        public int Price { get; set; }

        public void Report()
        {
            Console.WriteLine($"This is a {Color} rose of species {Species}. This flower {(Thorny ? "is" : "is not")} thorny.");
        }
    }
}