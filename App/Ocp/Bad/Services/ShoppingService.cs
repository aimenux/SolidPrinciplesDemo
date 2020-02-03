using System;
using System.Collections.Generic;

namespace App.Ocp.Bad.Services
{
    public class ShoppingService : IShoppingService
    {
        private readonly ICollection<Item> _items;

        public ShoppingService()
        {
            _items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public decimal GetTotalAmount()
        {
            var total = 0m;
            foreach (var item in _items)
            {
                switch (item.Type)
                {
                    case ItemType.Each:
                        total += item.Quantity * 4m;
                        break;
                    case ItemType.Weight:
                        const int kilo = 1000;
                        total += item.Quantity * 3m / kilo;
                        break;
                    case ItemType.Special:
                    {
                        const decimal discount4 = .15m;
                        total += item.Quantity * .3m;
                        var setsOfFour = item.Quantity / 4;
                        total -= setsOfFour * discount4;
                        break;
                    }
                    default:
                        throw new ArgumentOutOfRangeException($"{item.Type}");
                }
            }
            return total;
        }
    }

    public class Item
    {
        public int Quantity { get; set; }
        public ItemType Type { get; set; }
    }

    public enum ItemType
    {
        // Price per unit
        Each,

        // Price per unit of weight, such as price per kilogram
        Weight,

        // Special discount price : buy 3, get 1 for free
        Special
    }
}
