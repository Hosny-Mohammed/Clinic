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
    /// Interaction logic for ForgetPage.xaml
    /// </summary>
    public partial class ForgetPage : Page
    {
        ClinicEntities1 DB = new ClinicEntities1();
        public ForgetPage()
        {
            InitializeComponent();
        }

        private void Forget_btn_Click(object sender, RoutedEventArgs e)
        {
            if (Combo.SelectedIndex == 0)
            {
                if(UserName_txt.Text != "" && Password_txt.Text != "")
                {
                    var nn = DB.Admins.FirstOrDefault(x => x.User_Name == UserName_txt.Text);
                    if (nn != null)
                    {
                        Admin table = new Admin();
                        table.User_Password = Password_txt.Text;
                        DB.Admins.Add(table);
                        DB.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("This User is not found");
                    }
                }
                else
                {
                    MessageBox.Show("U must enter data");
                }
            }
            else if (Combo.SelectedIndex == 1)
            {
                if (UserName_txt.Text != "" && Password_txt.Text != "")
                {
                    var nn = DB.Users.FirstOrDefault(x => x.User_Name == UserName_txt.Text);
                    if (nn != null)
                    {
                        User table = new User();
                        table.User_Password = Password_txt.Text;
                        DB.Users.Add(table);
                        DB.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("This User is not found");
                    }
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
