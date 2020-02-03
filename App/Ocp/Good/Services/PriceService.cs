using System.Collections.Generic;
using System.Linq;
using App.Ocp.Good.Strategies;

namespace App.Ocp.Good.Services
{
    public class PriceService : IPriceService
    {
        private readonly ICollection<IPriceStrategy> _strategies;

        public PriceService()
        {
            _strategies = new List<IPriceStrategy>
            {
                new PricePerUnitStrategy(),
                new PricePerWeightStrategy(),
                new SpecialPriceStrategy()
            };
        }

        public decimal ComputePrice(Item item)
        {
            return _strategies.First(x => x.IsMatch(item)).ComputePrice(item);
        }
    }
}