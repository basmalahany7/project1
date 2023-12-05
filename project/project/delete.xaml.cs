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
    /// Interaction logic for delete.xaml
    /// </summary>
    public partial class delete : Page
    {
        cityEntities3 db=new cityEntities3();
        public delete()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userr n = db.userrs.Remove(db.userrs.FirstOrDefault(x => x.Phone_number == del.Text));
            db.SaveChanges();
            MessageBox.Show("data is deleted");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            dgg.ItemsSource=db.userrs.ToList();
        }
    }
}
