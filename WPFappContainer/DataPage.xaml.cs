

using System.Windows;
using System.Windows.Controls;


namespace DemoUI
{
    /// <summary>
    /// Interaction logic for DatasendPage.xaml
    /// </summary>
    public partial class DataPage : Page
    {
        public DataViewModel viewmodel;
        public DataPage()
        {
            InitializeComponent();
            viewmodel = new DataViewModel();
            DataContext = viewmodel;
        }

        private void Send_button_Click(object sender, RoutedEventArgs e)
        {
            if (SecondBlock.IsChecked == true)
            { 
                if ((string)Second_button.Content == "Send")
                    Second_button.Content = "Stop";

                else
                    Second_button.Content = "Send";
            }
        }

        private void Refresh_Button_Click(object sender, RoutedEventArgs e)
        {
            DataEntriesGrid.Items.Refresh();
        }
    }
}
