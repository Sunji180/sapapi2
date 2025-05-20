using System;
using System.Runtime.InteropServices;
using SAPFEWSELib;

namespace SAP_API
{
  public class MyGuiTableRow
  {
    public interface ISapTableRowTarget
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

      [DispId(33430)]
      bool Selected { get; set; }

      [DispId(33431)]
      bool Selectable { get; set; }

      [DispId(0)]
      GuiComponent Item(object Index);

      [DispId(33102)]
      GuiComponent ElementAt(int Index);
    }
  }
}
