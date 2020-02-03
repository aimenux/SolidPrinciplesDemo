using App.Ocp.Good.Services;

namespace App.Ocp.Good.Strategies
{
    public class PricePerWeightStrategy : IPriceStrategy
    {
        public bool IsMatch(Item item)
        {
            return item.Type == ItemType.Weight;
        }

        public decimal ComputePrice(Item item)
        {
            const int kilo = 1000;
            return item.Quantity * 3m / kilo;
        }
    }
}
