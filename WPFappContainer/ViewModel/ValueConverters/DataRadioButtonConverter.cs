using System;
using System.Globalization;
using System.Windows;

namespace DemoUI
{
    public enum RadioOptions
    {
        FirstRadioButton, SecondRadioButton, ThirdRadioButton
    }

    class DataRadioButtonConverter : BaseValueConverter<DataRadioButtonConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.Equals(parameter);
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.Equals(false))
                return DependencyProperty.UnsetValue;
            else
                return parameter;
        }
    }
}
