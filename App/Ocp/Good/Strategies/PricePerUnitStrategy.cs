using App.Ocp.Good.Models;
using App.Ocp.Good.Services;

namespace App.Ocp.Good.Strategies
{
    public class PricePerUnitStrategy : IPriceStrategy
    {
        public bool IsMatch(Item item)
        {
            return item.Type == ItemType.Each;
        }

        public decimal ComputePrice(Item item)
        {
            return item.Quantity * 4m;
        }
    }
}
