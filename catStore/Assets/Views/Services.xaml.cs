using catStore.Model;
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

namespace catStore.Assets.Views
{
    /// <summary>
    /// Логика взаимодействия для Services.xaml
    /// </summary>
    public partial class Services : Page
    {
        Core db = new Core();
        List<cats> arrayCalalog = new List<cats>();
        public Services()
        {
            InitializeComponent();
            arrayCalalog = db.db.cats.ToList();

            ComboBoxPrice.SelectedIndex = 0;
            ComboBoxCategory.SelectedIndex = 0;

            UpdateCatalog();

        }

        private void UpdateCatalog()
        {
            //arrayCalalog = db.db.cats.ToList();

            if (ComboBoxPrice.SelectedIndex == 0)
                arrayCalalog = arrayCalalog.OrderBy(x => x.price - x.price * x.discount / 100).ToList();
            else arrayCalalog = arrayCalalog.OrderByDescending(x => x.price - x.price * x.discount / 100).ToList();

            //сортировка по категориям и поиск

            ListViewCalalog.ItemsSource = arrayCalalog;
        }

        private void ComboBoxPrice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateCatalog();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateCatalog();
        }

        private void ComboBoxCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateCatalog();
        }
    }
}
