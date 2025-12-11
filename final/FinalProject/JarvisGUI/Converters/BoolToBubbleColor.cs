using Avalonia.Data.Converters;
using System;
using System.Globalization;

namespace JarvisGUI.Converters
{
public class BoolToBubbleColor : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        bool isUser = (bool)value;
        return isUser ? "#4C6EF5" : "#2B2B2B"; // blue vs dark gray bubble
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
}
