using System;
using System.Runtime.InteropServices;
using SAPFEWSELib;

namespace SAP_API
{
  public class MyGuiStatusbar
  {
    public interface ISapStatusbarTarget
    {
      [DispId(32005)]
      int Width { get; }

      [DispId(32046)]
      int ScreenLeft { get; }

      [DispId(32047)]
      int ScreenTop { get; }

      [DispId(32008)]
      string Tooltip { get; }

      [DispId(32009)]
      bool Changeable { get; }

      [DispId(32030)]
      bool Modified { get; }

      [DispId(32037)]
      string IconName { get; }

      [DispId(32042)]
      string AccTooltip { get; }

      [DispId(32043)]
      GuiComponentCollection AccLabelCollection { get; }

      [DispId(32006)]
      int Height { get; }

      [DispId(32044)]
      string AccText { get; }

      [DispId(32050)]
      GuiComponent ParentFrame { get; }

      [DispId(32061)]
      bool IsSymbolFont { get; }

      [DispId(32069)]
      string DefaultTooltip { get; }

      [DispId(32019)]
      GuiComponentCollection Children { get; }

      [DispId(34000)]
      string MessageType { get; }

      [DispId(34001)]
      string MessageId { get; }

      [DispId(34002)]
      string MessageNumber { get; }

      [DispId(34004)]
      bool MessageAsPopup { get; }

      [DispId(32045)]
      string AccTextOnRequest { get; }

      [DispId(32420)]
      int Handle { get; }

      // VB indexed property "MessageParameter(Index As Integer) As String"
      // is converted as a method returning a string for a given index.
      [DispId(34003)]
      string MessageParameter(int index);

      [DispId(32003)]
      int Left { get; }

      [DispId(32000)]
      string Text { get; set; }

      [DispId(32038)]
      GuiComponent Parent { get; }

      [DispId(32025)]
      string Id { get; }

      [DispId(32033)]
      bool ContainerType { get; }

      [DispId(32032)]
      int TypeAsNumber { get; }

      [DispId(32015)]
      string Type { get; }

      [DispId(32001)]
      string Name { get; }

      [DispId(32004)]
      int Top { get; }

      [DispId(32068)]
      void ShowContextMenu();

      [DispId(32750)]
      void DoubleClick();

      [DispId(32752)]
      void CreateSupportMessageClick();

      [DispId(32751)]
      void ServiceRequestClick();

      [DispId(32024)]
      void SetFocus();

      [DispId(32036)]
      GuiComponentCollection FindAllByNameEx(string Name, int Type);

      [DispId(32035)]
      GuiComponentCollection FindAllByName(string Name, string Type);

      [DispId(32034)]
      GuiComponent FindByNameEx(string Name, int Type);

      [DispId(32026)]
      GuiComponent FindByName(string Name, string Type);

      [DispId(32029)]
      GuiComponent FindById(string Id, object Raise = null);

      [DispId(31194)]
      GuiCollection DumpState(string InnerObject);

      [DispId(32039)]
      bool Visualize(bool On, object InnerObject = null);
    }
  }
}
