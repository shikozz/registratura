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

namespace Registy.Pages
{
    public partial class FinishedAppointmentPage : Page
    {
        public FinishedAppointmentPage(bool isSuccess = true)
        {
            InitializeComponent();

            if (!isSuccess)
            {
                HeaderTextBlock.Text = "Запись отклонена";
                InformationTextBlock.Text = "Нам жаль, что Вы передумали записываться на приём. Обращайтесь, если это потребуется!";
                ExitButton.Content = "Досвидания";
            }
        }

        private void OnCloseButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ServicesPage());
        }
    }
}
