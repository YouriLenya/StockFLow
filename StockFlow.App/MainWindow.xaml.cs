
using System.Windows;
using StockFlow.App.ViewModels;

namespace StockFlow.App;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        DataContext = new ProductsViewModel();
    }
}
