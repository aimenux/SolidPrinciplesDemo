using System;
using System.Collections.Generic;
using App.Extensions;
using App.Ocp.Good.Services;

namespace App.Ocp.Good
{
    public static class OcpGoodExample
    {
        public static void Run()
        {
            ConsoleColor.Green.WriteLine(nameof(OcpGoodExample));

            var items = new List<Item>
            {
                new Item
                {
                    Quantity = 2,
                    Type = ItemType.Each
                },
                new Item
                {
                    Quantity = 2,
                    Type = ItemType.Weight
                },
                new Item
                {
                    Quantity = 4,
                    Type = ItemType.Special
                }
            };
            var priceService = new PriceService();
            var shoppingService = new ShoppingService(priceService);
            foreach (var item in items)
            {
                shoppingService.AddItem(item);
            }
            var total = shoppingService.GetTotalAmount();
            Console.WriteLine($"Total = {total}");
        }
    }
}
