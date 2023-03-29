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
    public partial class ApplyAppointmentPage : Page
    {
        private Schedule _schedule;
        RegEntities _db = SourceCore.DataBase;

        public ApplyAppointmentPage(int scheduleId)
        {
            InitializeComponent();
            _schedule = _db.Schedule.FirstOrDefault(s => s.id == scheduleId);

            // Date and time of appointment
            DateTime date = _schedule.date.Value;
            AppointmentDateTextBlock.Text = date.ToString("dd.MM.yyyy");
            AppointmentTimeTextBlock.Text = $"{date.Hour}:{date.Minute}";

            // Room number;
            PersonSpecializations personSpecializations = _schedule.PersonSpecializations;
            long pipn = personSpecializations.Persons.pipn;
            CabinetTextBlock.Text = _db.PersonRooms.FirstOrDefault(pr => pr.personId == pipn).Rooms.number.ToString();

            // Specialization
            string specializationName = personSpecializations.Specializations.name;
            DoctorSpecializationTextBlock.Text = specializationName[0] + specializationName.ToLower().Substring(1);

            // Doctor name
            DoctorNameTextBlock.Text = personSpecializations.Persons.fullName;
        }

        private void OnApplyAppointmentButtonClick(object sender, RoutedEventArgs e)
        {
            if (_schedule.pipn == null)
            {
                
                return;
            }
            NavigationService.Navigate(new FinishedAppointmentPage());
        }

        private void OnRefuseAppointmentButtonClick(object sender, RoutedEventArgs e)
        {
            _db.Schedule.Remove(_schedule);
            _db.Entry(_schedule).State = System.Data.Entity.EntityState.Deleted;

            NavigationService.Navigate(new FinishedAppointmentPage(false));
        }
    }
}
