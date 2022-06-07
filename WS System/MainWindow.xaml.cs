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

namespace WS_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Classes.ElementManager.MainAppFrame = mainFrame;
            Classes.ElementManager.Header = header;
            Classes.ElementManager.Title = title;
            Classes.ElementManager.Greeting = greeting;

            Classes.ElementManager.MainAppFrame.Navigate(new Pages.AuthPage());
        }

        private void btExit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Classes.ElementManager.MainAppFrame.Navigate(new Pages.AuthPage());
        }
    }
}
