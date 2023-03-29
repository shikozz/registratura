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
    public partial class ChoiceAppointmentDatePage : Page
    {
        private int _personSpecializationId;
        private DateTime _pickedDate;
        private TimeSpan _pickedTime;
        private RegEntities _db = SourceCore.DataBase;

        public ChoiceAppointmentDatePage(int personSpecializationId)
        {
            InitializeComponent();
            AppointmentDate.SelectedDate = DateTime.Now.AddDays(1);
            AppointmentDate.DisplayDateStart = DateTime.Now.AddDays(1);
            AppointmentDate.DisplayDateEnd = DateTime.Now.AddDays(14);

            TimePicker.SelectedIndex = 1;

            _personSpecializationId = personSpecializationId;

            ErrorTextBlock.Visibility = Visibility.Hidden;
        }

        private void OnBackButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ServicesPage());
        }

        private bool IsDateBusy()
        {
            if (_pickedTime.Hours < 10 || _pickedTime.Hours > 18) return true;

            _pickedDate = _pickedDate.Add(_pickedTime);
            return _db.Schedule.FirstOrDefault(s => s.date == _pickedDate && s.orderId == _personSpecializationId) != null;
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

            bool? result = new PIPNModalWindow(_personSpecializationId, _pickedDate).ShowDialog();

            if (result != null && result != false)
            {
                Schedule schedule = _db.Schedule.FirstOrDefault(s => s.date == _pickedDate && s.PersonSpecializations.id == _personSpecializationId);
                NavigationService.Navigate(new ApplyAppointmentPage(schedule.id));
            }
        }

        private void OnChangedDate(object sender, SelectionChangedEventArgs e)
        {
            int hours = _pickedDate.Hour;
            int minutes = _pickedDate.Minute;

            _pickedDate = (DateTime)AppointmentDate.SelectedDate;
            _pickedDate.AddHours(hours);
            _pickedDate.AddMinutes(minutes);
        }

        private void OnChangedTime(object sender, SelectionChangedEventArgs e)
        {
            string time = TimePicker.SelectedValue.ToString();
            string[] splitted = time.Split(':');

            int.TryParse(splitted[1], out int hours);
            int.TryParse(splitted[2], out int minutes);

            _pickedTime = new TimeSpan(hours, minutes, 0);
        }
    }
}
