using App.OCP.Good.Models;

namespace App.OCP.Good.Services
{
    public interface IPriceService
    {
        decimal ComputePrice(Item item);
    }
}
