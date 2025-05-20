using System;
using System.Runtime.InteropServices;
using SAPFEWSELib;

namespace SAP_API
{
  public class MyGuiComponentCollection
  {
    public interface ISapCollectionTarget
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

      [DispId(0)]
      GuiComponent Item(object Index);

      [DispId(33102)]
      GuiComponent ElementAt(int Index);
    }
  }
}
