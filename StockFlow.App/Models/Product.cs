
namespace StockFlow.App.Models;

public class Product
{
    public int Id { get; set; }

    public string Reference { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

    public int MinimumStock { get; set; }

    // Propriété calculée : état du stock
    public bool IsLowStock => Quantity < MinimumStock;
}