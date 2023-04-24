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
using System.Windows.Shapes;
using AMONIC.Model;
using AMONIC.View;

namespace AMONIC.View
{
    /// <summary>
    /// Логика взаимодействия для WindowAddUser.xaml
    /// </summary>
    public partial class WindowAddUser : Window
    {
        public WindowAddUser()
        {
            InitializeComponent();
            Office.ItemsSource = AppData.db.Offices.ToList();
            CmbRole.ItemsSource = AppData.db.Roles.ToList();
            this.CmbRole.SelectedIndex = 1;

        }

        private void Btn_Save(object sender, RoutedEventArgs e)
        {
            Users people= new Users();
            Roles roles = new Roles();
            people.Email = Email.Text;
            people.FirstName = FN.Text;
            people.LastName = LN.Text;

            var CurrentOffice = Office.SelectedItem as Offices;
            people.OfficeID = CurrentOffice.ID;

            var CurrentDate = Date.SelectedDate.Value;
            people.Birthdate = CurrentDate;

            people.Password = Pass.Text;

            var CurrentRole = CmbRole.SelectedItem as Roles;

            people.RoleID = CurrentRole.ID;


            AppData.db.Users.Add(people);
            AppData.db.SaveChanges(); 
            WindowUsers windowUsers = new WindowUsers();
            MessageBox.Show("Add User!");
            this.Close();
            
        }

        private void Btn_Cancel(object sender, RoutedEventArgs e)
        {

        }
    }
}
