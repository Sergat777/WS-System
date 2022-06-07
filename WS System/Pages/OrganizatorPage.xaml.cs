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
    /// Interaction logic for OrganizatorPage.xaml
    /// </summary>
    public partial class OrganizatorPage : Page
    {
        Entities.User organizator;

        public OrganizatorPage(Entities.User user)
        {
            InitializeComponent();
            organizator = user;

            Classes.ElementManager.Header.Visibility = Visibility.Visible;
            Classes.ElementManager.Title.Text = "ТЕХНИЧЕСКАЯ ДИРЕКЦИЯ";
            Classes.ElementManager.Greeting.Text = $"Добрый день, {user.LastNameUser} {user.FirstNameUser} {user.PatronymicUser}!";
        }
    }
}
