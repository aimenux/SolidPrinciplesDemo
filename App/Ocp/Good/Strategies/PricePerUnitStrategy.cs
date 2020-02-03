using App.OCP.Good.Models;

namespace App.OCP.Good.Strategies
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
