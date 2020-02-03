using App.Ocp.Good.Models;

namespace App.Ocp.Good.Services
{
    public interface IShoppingService
    {
        void AddItem(Item item);
        decimal GetTotalAmount();
    }
}
