using System;
using System.Runtime.InteropServices;
using SAPFEWSELib;

namespace SAP_API
{
  public class MyGuiConnection
  {
    public interface ISapConnectionTarget
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

      [DispId(33000)]
      GuiComponentCollection Sessions { get; }

      [DispId(33001)]
      bool DisabledByServer { get; }

      [DispId(33002)]
      string Description { get; }

      [DispId(33003)]
      string ConnectionString { get; }

      [DispId(34500)]
      GuiComponentCollection ChildrenForNWBC { get; }

      [DispId(32811)]
      void CloseSession(string Id);

      [DispId(32831)]
      void CloseConnection();

      [DispId(32029)]
      GuiComponent FindById(string Id, object Raise = null);
    }
  }
}
