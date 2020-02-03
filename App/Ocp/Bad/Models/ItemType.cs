namespace App.OCP.Bad.Models
{
    public enum ItemType
    {
        // Price per unit
        Each,

        // Price per unit of weight, such as price per kilogram
        Weight,

        // Special discount price : buy 3, get 1 for free
        Special
    }
}