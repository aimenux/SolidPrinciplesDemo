using App.OCP.Good.Models;

namespace App.OCP.Good.Services
{
    public interface IShoppingService
    {
        void AddItem(Item item);
        decimal GetTotalAmount();
    }
}
