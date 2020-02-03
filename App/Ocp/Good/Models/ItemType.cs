namespace App.Ocp.Good.Models
{
    public enum ItemType
    {
        // Price per unit
        Each,

        // Price per unit of weight, such as price per kilogram
        Weight,

        // Special discount prices: buy 3, get 1 for free
        Special
    }
}