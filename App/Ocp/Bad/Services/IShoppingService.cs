using App.OCP.Bad.Models;

namespace App.OCP.Bad.Services
{
    public interface IShoppingService
    {
        void AddItem(Item item);
        decimal GetTotalAmount();
    }
}
