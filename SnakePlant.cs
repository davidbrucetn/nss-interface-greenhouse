using System;

namespace Greenhouse
{
    public class SnakePlant : IGiftBasket, IPlant
    {
        public string Species { get; set; }
        public string Color { get; set; }
        public bool DroughtTolerant { get; set; }
        public int Price { get; set; }
        public int TotalWeight { get; set; }

        public void Report()
        {
            Console.WriteLine($"This is a {Color} snake plant of species {Species}. This plant {(DroughtTolerant ? "is" : "is not")} drought tolerant.");
        }
    }
}