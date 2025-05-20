using System;
using System.Globalization;
using System.Windows.Data;
using System.Activities;
using System.Activities.Expressions;
using System.Activities.Presentation.Model;
using System.Windows.Controls;
using Microsoft.VisualBasic.Activities;

namespace SAP_API
{
  public class ComboBoxItemConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      // Cast the input object to ModelItem
      if (value != null)
      {
        ModelItem modelItem = value as ModelItem;
        if (modelItem != null)
        {
          InArgument<string> inArgument = modelItem.GetCurrentValue() as InArgument<string>;
          if (inArgument != null)
          {
            Activity<string> expression = inArgument.Expression;
            VisualBasicValue<string> vbexpression = expression as VisualBasicValue<string>;
            Literal<string> literal = expression as Literal<string>;

            if (literal != null)
            {
              // Return literal value wrapped in quotes
              return "\"" + literal.Value + "\"";
            }
            else if (vbexpression != null)
            {
              return vbexpression.ExpressionText;
            }
          }
        }
      }
      return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      // Get the string content from the ComboBoxItem
      ComboBoxItem comboBoxItem = value as ComboBoxItem;
      string itemContent = comboBoxItem?.Content as string;

      // Create a VisualBasicValue<string> using the item's content
      VisualBasicValue<string> vbArgument = new VisualBasicValue<string>(itemContent);
      InArgument<string> inArgument = new InArgument<string>(vbArgument);

      return inArgument;
    }
  }
}
