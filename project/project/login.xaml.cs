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
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
       cityEntities3 db=new cityEntities3();
        public login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (comm.Text == "admin")
            {
                adminn n= db.adminns.FirstOrDefault(x=>x.admin_name==name.Text&&x.admin_pass==password.Text);
                if (n.admin_name == name.Text && n.admin_pass == password.Text)
                {
                    pageadmin b=new pageadmin();
                    this.NavigationService.Navigate(b);
                }
            }
            if (comm.Text == "user")
            {
                userr q = db.userrs.FirstOrDefault(x => x.Username == name.Text&&x.Passwordd==password.Text);
                if (q.Username == name.Text && q.Passwordd == password.Text)
                {
                    profile n = new profile();
                    this.NavigationService.Navigate(n);
                }
            }
           
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            signup p= new signup();
            this.NavigationService.Navigate(p);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            forgetpassword m=new forgetpassword();
            this.NavigationService.Navigate(m);

        }
    }
}
