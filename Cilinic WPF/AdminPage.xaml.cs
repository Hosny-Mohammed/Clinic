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

namespace Cilinic_WPF
{
    /// <summary>
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        ClinicEntities1 DB = new ClinicEntities1();
        public AdminPage()
        {
            InitializeComponent();
            Data_Grid.ItemsSource = DB.Pateints.ToList();
        }

     
        private void Update_btn_Click(object sender, RoutedEventArgs e)
        {
            int ID = int.Parse(ID_txt.Text);
            var Search = DB.Pateints.FirstOrDefault(x => x.ID == ID);
            if (Search != null)
            {
                if(Date_txt.Text == "" || Date_txt.Text == "XXX-YY-NN") { 
                Search.Date_ = DateTime.Now;
                }
                else
                {
                    Search.Date_ = Convert.ToDateTime(Date_txt.Text); 
                }
                Search.Doc_Name = DocName_txt.Text;
            }
            else
            {
                MessageBox.Show("This User is not exicted");
            }
            DB.Pateints.AddOrUpdate(Search);
            DB.SaveChanges();
            Data_Grid.ItemsSource = DB.Pateints.ToList();
        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int ID = int.Parse(ID_txt.Text);
                var search = DB.Pateints.FirstOrDefault(x => x.ID == ID);
                DB.Pateints.Remove(search);
                DB.SaveChanges();
                Data_Grid.ItemsSource = DB.Pateints.ToList();
            }
            catch
            {
                MessageBox.Show("Error");
            }
            
        }

        private void Refrsh_btn_Click(object sender, RoutedEventArgs e)
        {
            Data_Grid.ItemsSource = DB.Pateints.ToList();
        }

        private void Search_btn_Click(object sender, RoutedEventArgs e)
        {
            int ID = int.Parse(ID_txt.Text);
            var UserSearch = DB.Pateints.Where(x => x.ID == ID);
            Data_Grid.ItemsSource = UserSearch.ToList();
        }
    }
}
