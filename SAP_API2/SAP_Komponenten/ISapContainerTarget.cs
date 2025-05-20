using System;
using System.Runtime.InteropServices;
using SAPFEWSELib;

namespace SAP_API
{
  public class MyGuiContainer
  {
    public interface ISapContainerTarget
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
      GuiComponent Parent { get; }

      [DispId(32019)]
      GuiComponentCollection Children { get; }

      [DispId(32029)]
      GuiComponent FindById(string Id, object Raise = null);
    }
  }
}
