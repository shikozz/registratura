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
using System.Windows.Shapes;

namespace Registy
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void fio_GotFocus(object sender, RoutedEventArgs e)
        {
            if (fio.Text.Equals("Введите ФИО"))
            {
                fio.Text = "";
                fio.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void fio_LostFocus(object sender, RoutedEventArgs e)
        {
            if(fio.Text.Equals(""))
            {
                fio.Text = "Введите ФИО";
                fio.Foreground = new SolidColorBrush(Colors.Gray);
            }    
        }

        private void snils_GotFocus(object sender, RoutedEventArgs e)
        {
            if (snils.Text.Equals("Введите СНИЛС"))
            {
                snils.Text = "";
                snils.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void snils_LostFocus(object sender, RoutedEventArgs e)
        {
            if (snils.Text.Equals(""))
            {
                snils.Text = "Введите СНИЛС";
                snils.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void pass_GotFocus(object sender, RoutedEventArgs e)
        {
            if (pass.Text.Equals("Введите пароль"))
            {
                pass.Text = "";
                pass.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void pass_LostFocus(object sender, RoutedEventArgs e)
        {
            if (pass.Text.Equals(""))
            {
                pass.Text = "Введите пароль";
                pass.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
