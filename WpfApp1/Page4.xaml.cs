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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void checkBox2_Copy1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Page5());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Page5());
        }

        private void Button_Click42(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Page5());
        }
    }
}
