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

namespace Cilinic_WPF
{
    /// <summary>
    /// Interaction logic for UsersManagement.xaml
    /// </summary>
    public partial class UsersManagement : Page
    {
        ClinicEntities1 DB = new ClinicEntities1();
        public UsersManagement()
        {
            InitializeComponent();
            DataGrid_Admin.ItemsSource = DB.Admins.ToList();
            DataGrid_User.ItemsSource = DB.Users.ToList();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (Combo.SelectedIndex == 0)
            {
                if (ID_txt.Text != "")
                {
                    var nn = DB.Admins.FirstOrDefault(x => x.User_Name.Contains(ID_txt.Text));
                    DB.Admins.Remove(nn);
                    DB.SaveChanges();
                    MessageBox.Show("Z user is Deleted Successfuly");
                    DataGrid_Admin.ItemsSource = DB.Admins.ToList();
                }
                else
                {
                    MessageBox.Show("U must enter data");
                }
            }
            else if (Combo.SelectedIndex == 1)
            {
                if (ID_txt.Text != "")
                {
                    var nn = DB.Users.FirstOrDefault(x => x.User_Name.Contains(ID_txt.Text));
                    DB.Users.Remove(nn);
                    DB.SaveChanges();
                    MessageBox.Show("Z user is Deleted Successfuly");
                    DataGrid_User.ItemsSource = DB.Users.ToList();
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
