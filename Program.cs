using System;
using System.Collections.Generic;

namespace Greenhouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Rose redRose = new Rose()
            {
                StemLength = 6,
                Color = "red",
                Species = "KnockOut",
                Thorny = true,
                Price = 2
            };
            Rose yellowRose = new Rose()
            {
                StemLength = 8,
                Color = "yellow",
                Species = "Julia Child",
                Thorny = true,
                Price = 2
            };
            Tulip pinkTulip = new Tulip()
            {
                StemLength = 5,
                Color = "pink",
                Variegated = true,
                Species = "Pink Panther",
                Price = 2
            };
            Tulip whiteTulip = new Tulip()
            {
                StemLength = 4,
                Color = "white",
                Variegated = true,
                Species = "Franklin",
                Price = 2
            };
            Greenhouse DavidsGreenhouse = new Greenhouse();
            DavidsGreenhouse.BouquetItems = new List<IBouquetItem>()
            {
                redRose,
                yellowRose,
                pinkTulip,
                whiteTulip
            };
            DavidsGreenhouse.MakeBouquet();

            SnakePlant smallSnakePlant = new SnakePlant()
            {
                TotalWeight = 3,
                Species = "Mother in Law",
                DroughtTolerant = true,
                Price = 3,
                Color = "green"
            };
            Fern birdsNestFern = new Fern()
            {
                TotalWeight = 7,
                Species = "Giant",
                Price = 16,
                Color = "dark green"

            };

            DavidsGreenhouse.GiftBasketItems = new List<IGiftBasket>()
            {
                smallSnakePlant,
                birdsNestFern
            };

            DavidsGreenhouse.MakeGiftBasket();

            DavidsGreenhouse.OrderPlants = new List<IPlant>()
            {
                smallSnakePlant,
                birdsNestFern,
                yellowRose,
                pinkTulip,
                whiteTulip,
                redRose

            };

            DavidsGreenhouse.OrderReport();
        }
    }
}