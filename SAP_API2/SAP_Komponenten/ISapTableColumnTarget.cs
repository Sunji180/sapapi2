using System;
using System.Runtime.InteropServices;
using SAPFEWSELib;

namespace SAP_API
{
  public class MyGuiTableColumn
  {
    public interface ISapTableColumnTarget
    {
      [DispId(-4)]
      object NewEnum { get; }

      [DispId(33100)]
      int Count { get; }

      [DispId(33101)]
      int Length { get; }

      [DispId(32015)]
      string Type { get; }

      [DispId(32032)]
      int TypeAsNumber { get; }

      [DispId(33420)]
      string Title { get; }

      [DispId(33421)]
      bool Fixed { get; }

      [DispId(33422)]
      bool Selected { get; set; }

      [DispId(32005)]
      int Width { get; set; }

      [DispId(32008)]
      string Tooltip { get; }

      [DispId(32037)]
      string IconName { get; }

      [DispId(32069)]
      string DefaultTooltip { get; }

      [DispId(0)]
      GuiComponent Item(object Index);

      [DispId(33102)]
      GuiComponent ElementAt(int Index);
    }
  }
}
