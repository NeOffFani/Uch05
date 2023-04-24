using AMONIC.Model;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

namespace AMONIC.View
{
    /// <summary>
    /// Логика взаимодействия для WindowUsers.xaml
    /// </summary>
    public partial class WindowUsers : Window
    {
        public WindowUsers()
        {
            InitializeComponent();
            
            
            var alloOffices = Session1_XXEntities.GetContext().Offices.ToList();
            alloOffices.Insert(0, new Offices
            {
                Title = "All offices"
            });
            ComboBox.SelectedIndex = 0;
            ComboBox.ItemsSource = alloOffices;
            UpdateTable();
        }        

        public void UpdateTable()
        {
            var currrentUser = Session1_XXEntities.GetContext().Users.ToList();
            if(ComboBox.SelectedIndex >0 && ComboBox.SelectedIndex != 1)
            {
                currrentUser = currrentUser.Where(p=> p.OfficeID == ComboBox.SelectedIndex + 1).ToList();
            }
            else if(ComboBox.SelectedIndex == 1)
            {
                currrentUser = currrentUser.Where(p => p.Offices.Title == "Abu dhabi").ToList();
            }
            UsersGrid.ItemsSource = currrentUser;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            UsersGrid.ItemsSource = AppData.db.Users.ToList();
        }

        private void Btn_OFON(object sender, RoutedEventArgs e)
        {
            Users users = UsersGrid.SelectedItem as Users;
            if (users.Active == true)
            {
                users.Active = false;
                MessageBox.Show("Off");
                UsersGrid.Items.Refresh();
            }
            else
            {
                users.Active = true;
                MessageBox.Show("On");
                UsersGrid.Items.Refresh();
            }            
            
            Session1_XXEntities.GetContext().SaveChanges();
            AppData.db.SaveChanges();
        }


        private void Btn_CR(object sender, RoutedEventArgs e)
        {
            Users users = UsersGrid.SelectedItem as Users;
            if (users.RoleID == 1)
            {
                users.RoleID = 2;
                MessageBox.Show("Роль - пользователь!");
                UsersGrid.Items.Refresh();
            }
            else
            {
                users.RoleID = 1;
                MessageBox.Show("Роль - администратор!");
                UsersGrid.Items.Refresh();
            }

            Session1_XXEntities.GetContext().SaveChanges();
            AppData.db.SaveChanges();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateTable();
        }        

        private void AddUser(object sender, RoutedEventArgs e)
        {
            WindowAddUser windowAddUser = new WindowAddUser();
            windowAddUser.Show();
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Number(object sender, RoutedEventArgs e)
        {
            ManageFlightSchedules MF = new ManageFlightSchedules();
            MF.Show();
            this.Close();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

    }
}
