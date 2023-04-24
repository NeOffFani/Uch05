using AMONIC.Model;
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

namespace AMONIC.View
{
    /// <summary>
    /// Логика взаимодействия для ManageFlightSchedules.xaml
    /// </summary>
    public partial class ManageFlightSchedules : Window
    {
        Session2_XXEntities db = new Session2_XXEntities();
        public ManageFlightSchedules()
        {
            InitializeComponent();
        }

        public void SortBy()
        {
            var searchFlight = db.Schedules.ToList();
            if (Dt_Out.SelectedDate != null)
                searchFlight = searchFlight.Where(p => p.Date == Dt_Out.SelectedDate).ToList();
            if (Cmb_From.SelectedIndex >0)
                searchFlight = searchFlight.Where(p => p.Routes.DepartureAirportID == (Cmb_From.SelectedItem as Airports).ID).ToList();
            if (Cmb_To.SelectedIndex > 0)
                searchFlight = searchFlight.Where(p => p.Routes.ArrivalAirportID == (Cmb_To.SelectedItem as Airports).ID).ToList();
            if (Cmb_Sortby.SelectedIndex == 0)
                searchFlight = searchFlight.OrderBy(p => p.Date).ToList();
            else if (Cmb_Sortby.SelectedIndex == 1)
                searchFlight = searchFlight.OrderBy(p => p.EconomyPrice).ToList();
            if (Txb_flightNum.SelectedIndex > 0)
                searchFlight = searchFlight.Where(p => p.FlightNumber == (Txb_flightNum.SelectedItem as Schedules).FlightNumber).ToList();
            FlightGrid.ItemsSource = searchFlight;
        }

        private void Btn_Delete(object sender, RoutedEventArgs e)
        {
            Schedules users = FlightGrid.SelectedItem as Schedules;
            if (users.Confirmed == true)
            {
                users.Confirmed = false;
                MessageBox.Show("Off");
                FlightGrid.Items.Refresh();
            }
            else
            {
                users.Confirmed = true;
                MessageBox.Show("On");
                FlightGrid.Items.Refresh();
            }

            Session1_XXEntities.GetContext().SaveChanges();
            AppData.db.SaveChanges();
        }



        private void Btn_Import(object sender, RoutedEventArgs e)
        {
            WindowAddFlight windowAddFlight = new WindowAddFlight();
            windowAddFlight.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FlightGrid.ItemsSource = AppData.db1.Schedules.ToList();
            Cmb_From.ItemsSource = AppData.db1.Airports.ToList();
            Cmb_To.ItemsSource = AppData.db1.Airports.ToList();
            Txb_flightNum.ItemsSource = AppData.db1.Schedules.ToList();
           
        }



        private void Cmb_From_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Txb_flightNum_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Btn_Apply1(object sender, RoutedEventArgs e)
        {
            SortBy();
        }

        private void Btn_Delete1(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить пользователя?", "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var CurrentUser2 = FlightGrid.SelectedItem as Schedules;
                AppData.db1.Schedules.Remove(CurrentUser2);
                AppData.db1.SaveChanges();
                FlightGrid.ItemsSource = AppData.db1.Schedules.ToList();
                MessageBox.Show("Удалено");
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

            Edit WER = new Edit((sender as Button).DataContext as Schedules);
            WER.Show();
        }
    }
}
