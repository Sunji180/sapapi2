using System;
using System.Runtime.InteropServices;

namespace SAP_API
{
  public class MyGuiComponent
  {
    public interface ISapComponentTarget
    {
      [DispId(32001)]
      string Name { get; }

      [DispId(32015)]
      string Type { get; }

      [DispId(32032)]
      int TypeAsNumber { get; }

      [DispId(32033)]
      bool ContainerType { get; }

      [DispId(32025)]
      string Id { get; }

      [DispId(32038)]
      object Parent { get; }
    }
  }
}
