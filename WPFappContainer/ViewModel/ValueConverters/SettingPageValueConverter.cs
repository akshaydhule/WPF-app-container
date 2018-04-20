using System;
using System.Diagnostics;
using System.Globalization;

namespace DemoUI
{
    /// <summary>
    /// Converts the <see cref="SettingsPage"/> to an actual vpage 
    /// </summary>
    class SettingPageValueConverter : BaseValueConverter<SettingPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((SettingPage)value)
            {
                //Find appropriate page
                case SettingPage.Second:
                    return new FieldTriggersControl();

                case SettingPage.First:
                    return new FieldTriggersControl();

                case SettingPage.Third:
                    return new FieldTriggersControl();

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