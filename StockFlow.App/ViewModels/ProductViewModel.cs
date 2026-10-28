
using System.Collections.ObjectModel;
using StockFlow.App.Models;

namespace StockFlow.App.ViewModels;

public class ProductsViewModel
{
    public ObservableCollection<Product> Products { get; }

    public ProductsViewModel()
    {
        Products = new ObservableCollection<Product>
        {
            new Product
            {
                Id = 1,
                Reference = "PRD-001",
                Name = "Roulement SKF",
                Quantity = 3,
                MinimumStock = 10,
                UnitPrice = 25.50m
            },
            new Product
            {
                Id = 2,
                Reference = "PRD-002",
                Name = "Vis M8",
                Quantity = 150,
                MinimumStock = 50,
                UnitPrice = 0.20m
            },
            new Product
            {
                Id = 3,
                Reference = "PRD-003",
                Name = "Moteur électrique",
                Quantity = 2,
                MinimumStock = 5,
                UnitPrice = 350m
            }
        };
    }
}
