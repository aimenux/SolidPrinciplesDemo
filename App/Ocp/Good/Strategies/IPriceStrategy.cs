using App.Ocp.Good.Models;
using App.Ocp.Good.Services;

namespace App.Ocp.Good.Strategies
{
    public interface IPriceStrategy
    {
        bool IsMatch(Item item);
        decimal ComputePrice(Item item);
    }
}
