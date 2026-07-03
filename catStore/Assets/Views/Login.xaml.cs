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
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        Core db = new Core();
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string nick = loginTextBox.Text;
            string password = passwordTextBox.Password;

            if (nick == string.Empty || password == string.Empty)
                MessageBox.Show("Заполните поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                if (db.db.Users.FirstOrDefault(x => x.nickname == nick) != null)
                {
                    var user = db.db.Users.FirstOrDefault(x => x.nickname == nick && x.password == password);
                    if (user != null)
                    {
                        App.CurrentUser = user;
                        this.NavigationService.Navigate(new Services());
                    }
                    else MessageBox.Show("Пароль неверный", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                } else
                {
                    MessageBox.Show("Нет пользователя с таким никнеймом", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                    
            }
        }
    }
}
