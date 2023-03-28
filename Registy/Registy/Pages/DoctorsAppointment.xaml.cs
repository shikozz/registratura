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
            PersonSpecializations personSpecialization = _db.PersonSpecializations.FirstOrDefault();
            _currentPersonSpecialization = personSpecialization.id;
            SetDoctorData(personSpecialization);
        }

        private void OnApplyDoctorButtonClick(object sender, RoutedEventArgs e)
        {
            Orders order = new Orders
            {
                docId = _currentPersonSpecialization
            };

            try
            {
                _db.Orders.Add(order);
                _db.SaveChanges();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Something went wrong!\n\n{err}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            NavigationService.Navigate(new ChoiceAppointmentDatePage(order.id));
        }

        private void OnNextDoctorButtonClick(object sender, RoutedEventArgs e)
        {
            PersonSpecializations personSpecialization = _db.PersonSpecializations.FirstOrDefault(ps => ps.id > _currentPersonSpecialization);
            if (personSpecialization == null) personSpecialization = _db.PersonSpecializations.FirstOrDefault();

            _currentPersonSpecialization = personSpecialization.id;
            SetDoctorData(personSpecialization);
        }

        private void OnPreviousDoctorButtonClick(object sender, RoutedEventArgs e)
        {
            PersonSpecializations personSpecialization = _db.PersonSpecializations.OrderByDescending(ps => ps.id).FirstOrDefault(ps => ps.id < _currentPersonSpecialization);
            if (personSpecialization == null) personSpecialization = _db.PersonSpecializations.OrderByDescending(ps => ps.id).FirstOrDefault();

            _currentPersonSpecialization = personSpecialization.id;
            SetDoctorData(personSpecialization);
        }

        private void SetDoctorData(PersonSpecializations personSpecialization)
        {
            Persons doctor = personSpecialization.Persons;
            int workTime = personSpecialization.workTime;
            string specializationName = personSpecialization.Specializations.name;

            DoctorNameTextBlock.Text = doctor.fullName;
            DoctorSpecializationTextBlock.Text = specializationName[0] + specializationName.ToLower().Substring(1);
            DoctorWorkTimeTextBlock.Text = "Опыт работы " + (workTime == 0 ? "менее 1 года" : (workTime < 5 ? $"{workTime} года" : $"{workTime} лет"));

            if (doctor.photo != null)
            {
                DoctorImageRectangle.Visibility = Visibility.Visible;
                DoctorImage.ImageSource = ImageConverter.Instance.ConvertToImage(doctor.photo);
                NoPhotoBlock.Visibility = Visibility.Collapsed;
            }
            else
            {
                DoctorImageRectangle.Visibility = Visibility.Collapsed;
                NoPhotoBlock.Visibility = Visibility.Visible;
            }
        }

        private void OnBackButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ServicesPage());
        }
    }
}
