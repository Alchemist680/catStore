using catStore.Assets.Views;
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

namespace catStore
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Core db = new Core();
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.NavigationService.Navigate(new Login());
        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.NavigationService.GoBack();
        }

        private void mainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            string pageTitle = ((Page)mainFrame.Content).Title;
            titleTextBlock.Text = pageTitle;

            if (mainFrame.CanGoBack)
                buttonBack.Visibility = Visibility.Visible;
            else buttonBack.Visibility = Visibility.Collapsed;
        }
    }
}
