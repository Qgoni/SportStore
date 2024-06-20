using SportStore.Data;
using SportStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SportStore.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageСlient.xaml
    /// </summary>
    public partial class PageСlient : Page
    {
        SportShopEntities1 db = new SportShopEntities1();
        private ManageStructur userI = new ManageStructur();

        public PageСlient(string fullName)
        {
            InitializeComponent();
            userI.FullNamePassing = fullName;
            NameFullUserText.Content = userI.FullNamePassing;
            var dbLoadProduct = db.Products.ToList();
            foreach (var product in dbLoadProduct)
            {
                if (string.IsNullOrEmpty(product.Image))
                {
                    product.Image = "/imgproduct/picture.png";
                }
                if (product.StockQuantity <= 0)
                {
                    product.Background = new SolidColorBrush(Colors.Gray);

                }
            }
            productListView.ItemsSource = dbLoadProduct;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack(); 
        }

        private void SearchTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = SearchTextbox.Text;
            var dbLoadProduct = db.Products.ToList();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                productListView.ItemsSource = dbLoadProduct;
            }
            else
            {
                var searchResults = dbLoadProduct.Where(product => product.Category.Contains(searchText) || product.Description.Contains(searchText)).ToList();
                productListView.ItemsSource = searchResults;
            }
        }
    }
}
