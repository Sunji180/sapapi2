using System;
using System.Runtime.InteropServices;
using SAPFEWSELib;

namespace SAP_API
{
  public class MyGuiShell
  {
    public interface ISapShell
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

      [DispId(33700)]
      string SubType { get; }

      [DispId(33701)]
      GuiContextMenu CurrentContextMenu { get; }

      [DispId(33702)]
      int Handle { get; }

      [DispId(33703)]
      string AccDescription { get; }

      [DispId(32045)]
      string AccTextOnRequest { get; }

      [DispId(33705)]
      GuiCollection OcxEvents { get; }

      [DispId(33706)]
      bool DragDropSupported { get; }

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

      [DispId(34100)]
      void SelectContextMenuItem(string FunctionCode);

      [DispId(34102)]
      void SelectContextMenuItemByPosition(string PositionDesc);

      [DispId(34101)]
      void SelectContextMenuItemByText(string Text);

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
