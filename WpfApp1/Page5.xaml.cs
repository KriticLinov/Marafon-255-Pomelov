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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mainFrame_Copy.Navigate(new Page6());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainFrame_Copy1.Navigate(new Page4());
        }

        private void mainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
