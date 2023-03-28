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
using Registy.Base;

namespace Registy.Pages
{
    /// <summary>
    /// Interaction logic for ChoiceAppointmentDatePage.xaml
    /// </summary>
    public partial class ChoiceAppointmentDatePage : Page
    {
        private Orders _order;
        private DateTime _pickedDate;
        private RegEntities _db = SourceCore.DataBase;

        public ChoiceAppointmentDatePage(int orderId)
        {
            InitializeComponent();
            AppointmentDate.SelectedDate = DateTime.Now.AddDays(1);
            AppointmentDate.DisplayDateStart = DateTime.Now.AddDays(1);
            AppointmentDate.DisplayDateEnd = DateTime.Now.AddDays(14);

            _order = _db.Orders.FirstOrDefault(o => o.id == orderId);

            ErrorTextBlock.Visibility = Visibility.Hidden;
        }

        private void OnBackButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ServicesPage());
        }

        private bool IsDateBusy()
        {
            if (_pickedDate.Hour < 10) return true;
            return _db.Schedule.FirstOrDefault(s => s.date == _pickedDate) != null;
        }

        private void OnApplyDateButtonClick(object sender, RoutedEventArgs e)
        {
            if (TimePicker.SelectedIndex == -1)
            {
                ErrorTextBlock.Text = "Вы не выбрали время!";
                ErrorTextBlock.Visibility = Visibility.Visible;
                return;
            }

            if (IsDateBusy())
            {
                ErrorTextBlock.Text = "Данная дата уже занята, выберите другую!";
                ErrorTextBlock.Visibility = Visibility.Visible;
                return;
            }

            ErrorTextBlock.Visibility = Visibility.Hidden;

            Schedule schedule = new Schedule
            {
                pipn = _order.PersonSpecializations.personId,
                date = _pickedDate,
                orderId = _order.id,
            };

            try
            {
                _db.Schedule.Add(schedule);
                _db.SaveChanges();
            } catch (Exception err)
            {
                MessageBox.Show($"Something went wrong!\n\n{err}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            NavigationService.Navigate(new ApplyAppointmentPage(schedule.id));
        }

        private void OnChangedDate(object sender, SelectionChangedEventArgs e)
        {
            int hours = AppointmentDate.SelectedDate.Value.Hour;
            int minutes = AppointmentDate.SelectedDate.Value.Minute;

            _pickedDate = (DateTime)AppointmentDate.SelectedDate;
            _pickedDate.AddHours(hours);
            _pickedDate.AddMinutes(minutes);
        }
    }
}
