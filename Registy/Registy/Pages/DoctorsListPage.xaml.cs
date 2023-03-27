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
    /// <summary>
    /// Логика взаимодействия для DoctorsListPage.xaml
    /// </summary>
    public partial class DoctorsListPage : Page
    {
        private List<List<string>> RoomList = new List<List<string>>();
        public DoctorsListPage()
        {
            InitializeComponent();
            RoomList.Add(new List<string>() { "Волкова Елена Александровна", { "37" } });
            RoomList.Add(new List<string>() { "Смирнов Василий Борисович", { "42" } });
            RoomList.Add(new List<string>() { "Лобанова Екатерина Александровна", { "41" } });
            PersonListBox.ItemsSource = RoomList.ToList();
        }

    }
}
