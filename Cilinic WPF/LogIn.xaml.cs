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
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
        ClinicEntities1 DB = new ClinicEntities1();
        public LogIn()
        {
            InitializeComponent();
          //  DB.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('Pateints', RESEED, 1);");
        }

        private void LogIn_btn_Click(object sender, RoutedEventArgs e)
        {
            if(Combo.SelectedItem != null)
            {
                if(Combo.SelectedIndex == 0)
                {
                    var Find =  DB.Admins.FirstOrDefault(x => x.User_Name==UserName_txt.Text);
                    if(Find != null && Find.User_Password == Password_txt.Text) 
                    {
                        AdminPage adminPage = new AdminPage();
                        this.NavigationService.Navigate(adminPage);
                        MessageBox.Show("Enter Successfully");
                        UserName_txt.Text = "";
                        Password_txt.Text = "";
                        Combo.SelectedItem = null;
                    }
                    else
                    {
                        MessageBox.Show("Password or User Name is incorrect");
                    }
                }else if(Combo.SelectedIndex == 1)
                {
                    var Find = DB.Users.FirstOrDefault(x => x.User_Name.Contains(UserName_txt.Text));
                    if (Find != null && Find.User_Password == Password_txt.Text)
                    {
                        UserPage userpage = new UserPage();
                        this.NavigationService.Navigate(userpage);
                        MessageBox.Show("Enter Successfully");
                        UserName_txt.Text = "";
                        Password_txt.Text = "";
                        Combo.SelectedItem = null;
                    }
                    else
                    {
                        MessageBox.Show("Password or User Name is incorrect");
                    }
                }
                
            }else
             {
                MessageBox.Show("U must choose kinda user ");
             }
            
        }

        private void SinUp_btn_Click(object sender, RoutedEventArgs e)
        {
            SignUp signUp = new SignUp();
            this.NavigationService.Navigate(signUp);
        }

        private void Forget_btn_Click(object sender, RoutedEventArgs e)
        {
            ForgetPage forgetPage = new ForgetPage();
            this.NavigationService.Navigate(forgetPage);
        }

        private void Management_btn_Click(object sender, RoutedEventArgs e)
        {
            if (Combo.SelectedItem != null)
            {
                if (Combo.SelectedIndex == 0)
                {
                    var Find = DB.Admins.FirstOrDefault(x => x.User_Name == UserName_txt.Text);
                    if (Find != null && Find.User_Password == Password_txt.Text)
                    {
                        UsersManagement users = new UsersManagement();
                        this.NavigationService.Navigate(users);
                        MessageBox.Show("Enter Successfully");
                        UserName_txt.Text = "";
                        Password_txt.Text = "";
                        Combo.SelectedItem = null;
                    }
                    else
                    {
                        MessageBox.Show("Password or User Name is incorrect");
                    }
                }
                else if (Combo.SelectedIndex == 1)
                {
                    MessageBox.Show("U should be an admin");
                }

            }
            else
            {
                MessageBox.Show("U must choose kinda user ");
            }
        }
    }
}
