using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace Cilinic_WPF
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Page
    {
        ClinicEntities1 Db = new ClinicEntities1();
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUP_btn_Click(object sender, RoutedEventArgs e)
        {
            if(Combo.SelectedIndex == 0)
            {
                if (UserName_txt.Text != "" && Password_txt.Text != "")
                {
                    Admin table = new Admin();
                    table.User_Name = UserName_txt.Text;
                    table.User_Password = Password_txt.Text;
                    Db.Admins.Add(table);
                    Db.SaveChanges();
                    MessageBox.Show("Z user is added Successfuly");
                    this.NavigationService.GoBack();
                }
                else
                {
                    MessageBox.Show("U must enter data");
                }
            }else if(Combo.SelectedIndex == 1)
            {
                if (UserName_txt.Text != "" && Password_txt.Text != "")
                {
                    User table = new User();
                    table.User_Name = UserName_txt.Text;
                    table.User_Password = Password_txt.Text;
                    Db.Users.Add(table);
                    Db.SaveChanges();
                    MessageBox.Show("Z user is added Successfuly");
                    this.NavigationService.GoBack();
                }
                else
                {
                    MessageBox.Show("U must enter data");
                }
            }
            else
            {
                MessageBox.Show("U must choose kinda user ");
            }
        }
    }
}
