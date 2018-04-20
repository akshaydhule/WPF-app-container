using System;
using System.Diagnostics;
using System.Globalization;

namespace DemoUI
{
    /// <summary>
    /// Converts the <see cref="ApplicationPage"/> to an actual vpage 
    /// </summary>
    class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ApplicationPage)value)
            {
                //Find appropriate page
                case ApplicationPage.Login:
                    return new LoginPage();

                case ApplicationPage.Dashboard:
                    return new MainPage();

                case ApplicationPage.Settings:
                    return new SettingsPage();

                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}