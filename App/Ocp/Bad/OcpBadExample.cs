using System;
using System.Collections.Generic;
using App.Extensions;
using App.Ocp.Bad.Models;
using App.Ocp.Bad.Services;

namespace App.Ocp.Bad
{
    public static class OcpBadExample
    {
        public static void Run()
        {
            ConsoleColor.Red.WriteLine(nameof(OcpBadExample));

            var shoppingService = new ShoppingService();
            foreach (var item in GetItems())
            {
                shoppingService.AddItem(item);
            }
            var total = shoppingService.GetTotalAmount();
            Console.WriteLine($"Total = {total}");
        }

        private static IEnumerable<Item> GetItems()
        {
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

            return items;
        }
    }
}
