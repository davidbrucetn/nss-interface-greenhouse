using System;

namespace Greenhouse
{
    public class Fern : IGiftBasket, IPlant
    {
        public string Species { get; set; }
        public string Color { get; set; }
        public int TotalWeight { get; set; }
        public int Price { get; set; }

        public void Report()
        {
            Console.WriteLine($"This is a {Color} fern of species {Species}.");
        }
    }
}