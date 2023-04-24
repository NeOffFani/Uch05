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
using System.Windows.Navigation;
using System.Windows.Shapes;
using AMONIC.View;

namespace AMONIC
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click_Btn_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Click_Btn_Log(object sender, RoutedEventArgs e)
        {
            var CurrentUser = AppData.db.Users.FirstOrDefault(u => u.FirstName == Txb_Name.Text && u.Password == Txb_Pass.Text);
            if (CurrentUser != null && CurrentUser.Active == true)
            {
                    MessageBox.Show("Вы вошли в аккаунт администратора!");
                    WindowUsers windowUsers = new WindowUsers();
                    this.Close();
                    windowUsers.ShowDialog();
            }
            else
            {
                MessageBox.Show("Заблокированый пользователь или неверные данные!");
            }
        }
    }
}
