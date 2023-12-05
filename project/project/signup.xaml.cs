using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Xml.Linq;

namespace project
{
    /// <summary>
    /// Interaction logic for signup.xaml
    /// </summary>
    public partial class signup : Page
    {
    cityEntities3 db=new cityEntities3();
        string gender;
     
        public signup()
        {
            InitializeComponent();
        }
        bool isValidpass(string pass)
        {
            bool upper, lower, num ;
            upper = lower = num = false;
            foreach(char c in pass)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    upper = true;
                }
                else if (c >= 'a' && c <= 'z')
                {
                    lower = true;
                }
                else if(c >= '0'&&c<='9')
                {
                     num = true;
                }

            }
            return upper=lower= num;


        }
     

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            login s = new login();
            this.NavigationService.Navigate(s);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            userr b = new userr();
            b.Username = uname.Text;
            b.Passwordd = upass.Text;
            b.Age = int.Parse(uage.Text);
            if (b.Age < 18 && b.Age > 60)
            {
                MessageBox.Show("invalid");
            }
            b.Phone_number = uphone.Text;
            db.userrs.Add(b);
            db.SaveChanges();
            MessageBox.Show("data is added");
        }
        private void male_Checked(object sender, RoutedEventArgs e)
        {
            gender = "male";

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            gender = "female";
        }
    }
}
