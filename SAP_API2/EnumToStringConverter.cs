using System;
using System.Globalization;
using System.Windows.Data;

namespace SAP_API
{
  public class EnumToStringConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      try
      {
        string enumString = Enum.GetName(value.GetType(), value);
        return enumString;
      }
      catch
      {
        return string.Empty;
      }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
