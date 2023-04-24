using AMONIC.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AMONIC.View
{
    /// <summary>
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        private Schedules _currentSchedules = new Schedules();

        public Edit(Schedules selectedSchedules)
        {
            InitializeComponent();

            if (selectedSchedules != null)
            {
                _currentSchedules = selectedSchedules;
            }

            DataContext = _currentSchedules;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

                Session2_XXEntities.GetContext().Schedules.AddOrUpdate(_currentSchedules);

                Session2_XXEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
                Close();

        }
    }
}
