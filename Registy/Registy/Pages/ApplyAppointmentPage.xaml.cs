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
        RegEntities _db = SourceCore.DataBase;

        public ApplyAppointmentPage(int scheduleId)
        {
            InitializeComponent();
            //AppointmentDateTextBlock.Text
            Schedule schedule = _db.Schedule.FirstOrDefault(s => s.id == scheduleId);


            PersonSpecializations personSpecializations = schedule.Orders.PersonSpecializations;

            // Room number;
            long pipn = personSpecializations.Persons.pipn;
            CabinetTextBlock.Text = _db.PersonRooms.FirstOrDefault(pr => pr.personId == pipn).Rooms.number.ToString();

            // Specialization
            string specializationName = personSpecializations.Specializations.name;
            DoctorSpecializationTextBlock.Text = specializationName[0] + specializationName.ToLower().Substring(1);

            // Doctor name
            DoctorNameTextBlock.Text = personSpecializations.Persons.fullName;
        }
    }
}
