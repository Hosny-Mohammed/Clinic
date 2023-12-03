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
    /// Interaction logic for UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    { 
         ClinicEntities1 DB = new ClinicEntities1();
        public UserPage()
        {
            InitializeComponent();
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            Pateint table = new Pateint();
            table.Name = Name_txt.Text;
            table.Address = Address_txt.Text;
            table.age = int.Parse(Age_txt.Text);
           if (Date_txt.Text == "" || Date_txt.Text == "XXX-YY-NN")
            {
             table.Date_ = DateTime.Now;
            }
            else
            {
              table.Date_ = Convert.ToDateTime(Date_txt.Text);
            }
            table.Doc_Name = DoctorName_txt.Text;
            DB.Pateints.Add(table);
            DB.SaveChanges();
            MessageBox.Show("The Data is added");
        }
    }
}
