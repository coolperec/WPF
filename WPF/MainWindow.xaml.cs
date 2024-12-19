using System.Collections.ObjectModel;
using System.Windows;

namespace WpfAppLists
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> Products { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Products = new ObservableCollection<Product>
            {
                new Product { Name = "Товар 1", Description = "Описание товара 1", Manufacturer = "Производитель 1", Price = 100.00M, Stock = 10, ImagePath = "path/to/image1.jpg" },
                new Product { Name = "Товар 2", Description = "Описание товара 2", Manufacturer = "Производитель 2", Price = 200.00M, Stock = 5, ImagePath = "path/to/image2.jpg" },
                new Product { Name = "Товар 3", Description = "Описание товара 3", Manufacturer = "Производитель 3", Price = 300.00M, Stock = 20, ImagePath = "path/to/image3.jpg" },
            };

            ProductList.ItemsSource = Products;
        }
    }
}