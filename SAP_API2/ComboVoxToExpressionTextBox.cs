using System;
using System.Globalization;
using System.Windows.Data;

namespace SAP_API
{
  public class ComboBoxToExpressionTextBox : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return value.ToString();
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      if (value is bool boolValue)
      {
        return boolValue ? "yes" : "no";
      }
      else
      {
        return "no";
      }
    }
  }
}