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

namespace WS_System.Pages
{
    /// <summary>
    /// Interaction logic for AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
            Classes.ElementManager.Header.Visibility = Visibility.Collapsed;
        }

        private void btEnter_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Entities.User user = Entities.WS_SystemEntities.GetContext().User.FirstOrDefault(u =>
            u.PINUser == tbPIN.Text && u.PasswordUser == tbPassword.Text);

            if (user != null)
            {
                MessageBox.Show($"Добро пожаловать, {user.FirstNameUser} {user.LastNameUser}!", "Уведомление",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                if (user.roleId == 6)
                {
                    Classes.ElementManager.MainAppFrame.Navigate(new OrganizatorPage(user));
                }
            }
            else
                MessageBox.Show("Пользователь не обнаружен\nПроверьте правильность введенных данных", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
