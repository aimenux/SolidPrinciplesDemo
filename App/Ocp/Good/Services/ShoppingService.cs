using System.Collections.Generic;
using System.Linq;
using App.Ocp.Good.Models;

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
}
