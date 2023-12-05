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

namespace project
{
    /// <summary>
    /// Interaction logic for pageadmin.xaml
    /// </summary>
    public partial class pageadmin : Page
    {
        public pageadmin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            search b= new search();
            this.NavigationService.Navigate(b);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            delete y= new delete();
            this.NavigationService.Navigate(y);
        }
    }
}
