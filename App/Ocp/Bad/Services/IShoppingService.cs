using App.Ocp.Bad.Models;

namespace App.Ocp.Bad.Services
{
    public interface IShoppingService
    {
        void AddItem(Item item);
        decimal GetTotalAmount();
    }
}
