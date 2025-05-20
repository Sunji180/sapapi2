using System;
using System.Runtime.InteropServices;

namespace SAP_API
{
  public class MyGuiComboBoxEntry
  {
    public interface ISapComboBoxEntryTarget
    {
      [DispId(33800)]
      string Key { get; }

      [DispId(33801)]
      string Value { get; }

      [DispId(33802)]
      int Pos { get; }
    }
  }
}
