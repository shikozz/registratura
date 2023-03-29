using Registy.Base;
using Registy.Pages;
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

namespace Registy
{
    /// <summary>
    /// Interaction logic for PIPNModalWindow.xaml
    /// </summary>
    public partial class PIPNModalWindow : Window
    {
        DateTime _appointmentDateTime;
        PersonSpecializations _personSpecialization;
        RegEntities _db = SourceCore.DataBase;

        public PIPNModalWindow(int personSpecializationId, DateTime appointmentDateTime)
        {
            InitializeComponent();
            ErrorTextBlock.Visibility = Visibility.Hidden;
            _appointmentDateTime = appointmentDateTime;
            _personSpecialization = _db.PersonSpecializations.FirstOrDefault(ps => ps.id == personSpecializationId);
        }

        private void OnApplyButtonClick(object sender, RoutedEventArgs e)
        {
            bool result = long.TryParse(PIPNTextBlock.Text, out long pipn);
            if (!result)
            {
                ErrorTextBlock.Visibility = Visibility.Visible;
                return;
            } else if (!IsPIPNCorrect(pipn))
            {
                ErrorTextBlock.Visibility = Visibility.Visible;
                return;
            }

            ErrorTextBlock.Visibility = Visibility.Hidden;

            Schedule schedule = new Schedule
            {
                PersonSpecializations = _personSpecialization,
                date = _appointmentDateTime
            };

            try
            {
                _db.Schedule.Add(schedule);
                _db.SaveChanges();
                DialogResult = true;
            }
            catch (Exception err)
            {
                DialogResult = false;
                MessageBox.Show($"Something went wrong!\n\n{err}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private bool IsPIPNCorrect(long pipn)
        {
            int number = (int)(pipn / 100);
            int control = (int)(pipn % 100);

            int sum = 0;
            int i = 1;
            do
            {
                sum += number % 10 * i;
                number /= 10;
                i++;
            } while (number != 0);

            if (sum > 101) sum %= 101;
            if (sum == 100) sum = 0;
            return control == sum;
        }

        private void OnBackButtonClick(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
