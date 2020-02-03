using System;
using System.Collections.Generic;
using App.Ocp.Bad.Models;

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
}
