using System;
using System.Runtime.InteropServices;

namespace SAP_API
{
  public class MyGuiCollection
  {
    public interface ISapGenericCollection
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

      [DispId(33103)]
      void Add(object Item);

      [DispId(0)]
      object Item(object Index);

      [DispId(33102)]
      object ElementAt(int Index);
    }
  }
}
