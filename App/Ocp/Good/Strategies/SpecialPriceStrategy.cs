using App.Ocp.Good.Models;
using App.Ocp.Good.Services;

namespace App.Ocp.Good.Strategies
{
    public class SpecialPriceStrategy : IPriceStrategy
    {
        public bool IsMatch(Item item)
        {
            return item.Type == ItemType.Special;
        }

        public decimal ComputePrice(Item item)
        {
            const decimal discount4 = .15m;
            var result = item.Quantity * .3m;
            var setsOfFour = item.Quantity / 4;
            result -= setsOfFour * discount4;
            return result;
        }
    }
}