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
    public partial class DoctorsAppointment : Page
    {
        int _currentPersonSpecialization;
        RegEntities _db = SourceCore.DataBase;

        public DoctorsAppointment()
        {
            InitializeComponent();
            PersonSpecializations ps = _db.PersonSpecializations.FirstOrDefault();
            _currentPersonSpecialization = ps.id;
            Persons doctor = _db.Persons.FirstOrDefault(d => d.pipn == ps.personId);
            SetDoctorData(doctor, ps);
        }

        private void OnApplyDoctorButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ChoiceAppointmentDatePage());
        }

        private void OnNextDoctorButtonClick(object sender, RoutedEventArgs e)
        {
            PersonSpecializations ps = _db.PersonSpecializations.FirstOrDefault(innerPS => innerPS.id > _currentPersonSpecialization);
            if (ps == null) ps = _db.PersonSpecializations.FirstOrDefault();

            _currentPersonSpecialization = ps.id;
            Persons doctor = _db.Persons.FirstOrDefault(d => d.pipn == ps.personId);
            SetDoctorData(doctor, ps);
        }

        private void OnPreviousDoctorButtonClick(object sender, RoutedEventArgs e)
        {
            PersonSpecializations ps = _db.PersonSpecializations.FirstOrDefault(innerPS => innerPS.id < _currentPersonSpecialization);
            if (ps == null) ps = _db.PersonSpecializations.OrderByDescending(psob => psob.id).FirstOrDefault();
            _currentPersonSpecialization = ps.id;
            Persons doctor = _db.Persons.FirstOrDefault(d => d.pipn == ps.personId);
            SetDoctorData(doctor, ps);
        }

        private void SetDoctorData(Persons doctor, PersonSpecializations spec)
        {
            int workTime = spec.workTime;
            string specialization = spec.Specializations.name;

            DoctorNameTextBlock.Text = doctor.fullName;
            DoctorSpecializationTextBlock.Text = specialization[0] + specialization.ToLower().Substring(1);
            DoctorWorkTimeTextBlock.Text = "Опыт работы " + (workTime == 0 ? "менее 1 года" : (workTime == 1 ? "1 год" : $"{workTime} лет"));
        }

        private void OnBackButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ServicesPage());
        }
    }
}
