
using System.Windows;
using System.Windows.Controls;

namespace DemoUI
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            MainPageFrame.Content = new DataPage();
        }

        private void DashboardButton_Click(object sender, RoutedEventArgs e)
        {
            MainPageFrame.Content = new DataPage();
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            MainPageFrame.Content = new AboutPage();
        }

        private void SettingButton_Click(object sender, RoutedEventArgs e)
        {
            MainPageFrame.Content = new SettingsPage();
        }

        private void ConfigurationButton_Click(object sender, RoutedEventArgs e)
        {
            MainPageFrame.Content = new ConfigurationControl();
        }
    }
}
