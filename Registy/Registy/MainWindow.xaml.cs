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
using System.Windows.Shell;

namespace Registy
{
    public partial class MainWindow : Window
    {
        private bool _isFullScreen = false;
        private WindowState _windowState;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnMinimizeButtonClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void OnCloseButtonClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OnWindowLoad(object sender, RoutedEventArgs e)
        {
            RootFrame.Navigate(new BeginPage());
            OnWindowStateChanged(null, null);
        }

        // Деформация окна под полноэкранный режим
        private void OnWindowStateChanged(object sender, EventArgs e)
        {
            if (!_isFullScreen)
            {
                if (WindowState == WindowState.Maximized)
                {
                    MainBorder.Padding = new Thickness(8);
                    WinChrome.CaptionHeight = 40;
                }
                else
                {
                    MainBorder.Padding = new Thickness(0);
                    WinChrome.CaptionHeight = 32;
                }
            }
        }

        // Полноэкранный режим на F11
        private void OnWindowKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F11)
            {
                _isFullScreen = !_isFullScreen;

                if (_isFullScreen)
                {
                    _windowState = WindowState;
                    MainBorder.Padding = new Thickness(0);
                    WindowStyle = WindowStyle.None;
                    WindowState = WindowState.Minimized;
                    WindowState = WindowState.Maximized;
                    WindowChrome.SetWindowChrome(this, null);
                }
                else
                {
                    WindowChrome NewWindowChrome = new WindowChrome
                    {
                        CaptionHeight = 32,
                        UseAeroCaptionButtons = false,
                        GlassFrameThickness = new Thickness(1),
                        CornerRadius = new CornerRadius(0)
                    };

                    WindowState = WindowState.Normal;
                    WindowState = _windowState;
                    WindowChrome.SetWindowChrome(this, NewWindowChrome);
                    WindowStyle = WindowStyle.SingleBorderWindow;
                }
            }
        }

        private void OnRootFrameLoadCompleted(object sender, NavigationEventArgs e)
        {

        }
    }
}
