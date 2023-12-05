using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for forgetpassword.xaml
    /// </summary>
    public partial class forgetpassword : Page
    {
      cityEntities3 db= new cityEntities3();
        public forgetpassword()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userr u = db.userrs.FirstOrDefault(x => x.Phone_number == ph.Text);
            u.Passwordd = pass.Text;
            u.Passwordd=cpass.Text;
            db.userrs.AddOrUpdate(u);
            db.SaveChanges();
            MessageBox.Show("data updated");
        }
    }
}
