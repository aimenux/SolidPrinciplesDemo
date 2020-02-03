using App.OCP.Good.Models;

namespace App.OCP.Good.Strategies
{
    public interface IPriceStrategy
    {
        bool IsMatch(Item item);
        decimal ComputePrice(Item item);
    }
}
