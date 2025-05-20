using System;
using System.Globalization;
using System.Windows.Data;
using System.Activities;
using System.Activities.Expressions;
using System.Activities.Presentation.Model;
using Microsoft.VisualBasic.Activities;

namespace SAP_API
{
  public class ArgumentToStringConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      object convertedValue = null;
      if (value != null)
      {
        ModelItem argumentModelItem = value as ModelItem;
        if (argumentModelItem != null &&
            argumentModelItem.Properties["Expression"] != null &&
            argumentModelItem.Properties["Expression"].Value != null)
        {
          // Check if the computed value is of type Literal<string>
          if (argumentModelItem.Properties["Expression"].ComputedValue.GetType() == typeof(Literal<string>))
          {
            convertedValue = ((Literal<string>)argumentModelItem.Properties["Expression"].ComputedValue).Value;
          }
          else
          {
            // Otherwise assume it is a VisualBasicValue<string>
            convertedValue = ((VisualBasicValue<string>)argumentModelItem.Properties["Expression"].ComputedValue).ExpressionText;
          }
        }
      }
      return convertedValue;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      string itemContent = value as string;
      VisualBasicValue<string> vbArgument = new VisualBasicValue<string>(itemContent);
      InArgument<string> inArgument = new InArgument<string>(vbArgument);
      return inArgument;
    }
  }
}
