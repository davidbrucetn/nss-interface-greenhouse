using System;
using System.Collections.Generic;

namespace Greenhouse
{
    public class Greenhouse
    {

        public List<IGiftBasket> GiftBasketItems { get; set; }
        public List<IBouquetItem> BouquetItems { get; set; }

        public List<IPlant> OrderPlants { get; set; }

        public void MakeBouquet()
        {
            Console.WriteLine("You made a bouquet; the current stem lengths are ");
            // Only have access to properties of IBouquetItem interface - StemLength
            BouquetItems.ForEach(item => Console.WriteLine($"{item.StemLength}"));
        }

        public void MakeGiftBasket()
        {
            int totalWeightOfBasket = 0;
            Console.WriteLine("You made a gift basket.");
            GiftBasketItems.ForEach(item => totalWeightOfBasket = totalWeightOfBasket + item.TotalWeight);
            Console.WriteLine($"Your gift basket weighs {totalWeightOfBasket} lbs.");
        }

        public void OrderReport()
        {
            int totalPrice = 0;
            Console.WriteLine("Your current order contains: ");
            OrderPlants.ForEach(plant =>
            {
                totalPrice = totalPrice + plant.Price;
                plant.Report();
            });
            Console.WriteLine($"The order total was ${totalPrice}.");
        }
    }
}