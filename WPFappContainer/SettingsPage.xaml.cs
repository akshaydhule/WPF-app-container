using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoUI
{
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
            DataContext = new SettingViewModel();
        }

        private void ConfigurationsButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new ConfigurationControl();
        }

        /*
                /// <summary>
                /// Load custom setting page
                /// </summary>
                public void LoadExternalXaml()
                {
                    if (File.Exists(@"CustomSettings.xaml"))
                    {
                        using (FileStream stream = new FileStream(@"C:\CustomSettings.xaml", FileMode.Open))
                        {
                            this.Content = XamlReader.Load(stream);
                        }
                    }
                }

                /// <summary>
                /// Load custom setting page
                /// </summary>
                public void SaveCustomXaml()
                {
                    using (FileStream stream = new FileStream(@"CustomSettings.xaml", FileMode.Create))
                    {
                        XamlWriter.Save(this.Content, stream);
                    }
                }

                private void SubmitButton_Click(object sender, RoutedEventArgs e)
                {
                    //populate the HashSet for all Toggle values
                    MessageBoxResult result = MessageBox.Show("Are you sure you want to save the custom settings?", "Notification", MessageBoxButton.OKCancel, MessageBoxImage.Question);
                    switch (result)

                    {
                        //Accept save settings 
                        case MessageBoxResult.OK:
                            //Function call to iterate through list of settings to collect Trigger On/Off values
                            //Setupdate();
                            SaveCustomXaml();
                            //Function call to save list of custom triggers in a file
                            //SaveCustomTriggers();

                            break;

                        //Cancel save settings
                        case MessageBoxResult.Cancel:
                            MessageBox.Show("You pressed Cancel button!");
                            break;

                    }
                }*/
    }
}
