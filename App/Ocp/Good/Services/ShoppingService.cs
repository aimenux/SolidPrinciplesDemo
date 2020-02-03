using System.Collections.Generic;
using System.Linq;

namespace App.Ocp.Good.Services
{
    public class ShoppingService : IShoppingService
    {
        private readonly ICollection<Item> _items;
        private readonly IPriceService _priceService;

        public ShoppingService(IPriceService priceService)
        {
            _items = new List<Item>();
            _priceService = priceService;
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public decimal GetTotalAmount()
        {
            return _items.Sum(item => _priceService.ComputePrice(item));
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

        // Special discount prices: buy 3, get 1 for free
        Special
    }
}
