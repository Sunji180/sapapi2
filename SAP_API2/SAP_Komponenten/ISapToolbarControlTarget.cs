using System;
using System.Runtime.InteropServices;
using SAPFEWSELib;

namespace SAP_API
{
  public class MyGuiToolbarControl
  {
    public interface ISapToolbarControlTarget
    {
      [DispId(32025)]
      string Id { get; }

      [DispId(32000)]
      string Text { get; set; }

      [DispId(32003)]
      int Left { get; }

      [DispId(32004)]
      int Top { get; }

      [DispId(32005)]
      int Width { get; }

      [DispId(32006)]
      int Height { get; }

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

      [DispId(32044)]
      string AccText { get; }

      [DispId(32045)]
      string AccTextOnRequest { get; }

      [DispId(32050)]
      GuiComponent ParentFrame { get; }

      [DispId(32061)]
      bool IsSymbolFont { get; }

      [DispId(32069)]
      string DefaultTooltip { get; }

      [DispId(32019)]
      GuiComponentCollection Children { get; }

      [DispId(33401)]
      GuiTableSelectionType ColSelectMode { get; }

      [DispId(33403)]
      GuiTableSelectionType RowSelectMode { get; }

      [DispId(33404)]
      GuiCollection Rows { get; }

      [DispId(32601)]
      GuiScrollbar VerticalScrollbar { get; }

      [DispId(32600)]
      GuiScrollbar HorizontalScrollbar { get; }

      [DispId(33409)]
      string TableFieldName { get; }

      [DispId(33410)]
      int CurrentCol { get; }

      [DispId(33411)]
      int CurrentRow { get; }

      [DispId(33412)]
      int RowCount { get; }

      [DispId(33413)]
      int VisibleRowCount { get; }

      [DispId(32070)]
      int CharLeft { get; }

      [DispId(32071)]
      int CharTop { get; }

      [DispId(33402)]
      GuiCollection Columns { get; }

      [DispId(32072)]
      int CharWidth { get; }

      [DispId(32073)]
      int CharHeight { get; }

      // Duplicate properties (Height, Width, Top, Left) already declared above

      [DispId(32038)]
      GuiComponent Parent { get; }

      [DispId(32033)]
      bool ContainerType { get; }

      [DispId(32032)]
      int TypeAsNumber { get; }

      [DispId(32015)]
      string Type { get; }

      [DispId(32001)]
      string Name { get; }

      [DispId(32068)]
      void ShowContextMenu();

      [DispId(34100)]
      void SelectContextMenuItem(string FunctionCode);

      [DispId(34101)]
      void SelectContextMenuItemByText(string Text);

      [DispId(34102)]
      void SelectContextMenuItemByPosition(string PositionDesc);

      [DispId(1)]
      void PressButton(string Id);

      [DispId(3)]
      void SelectMenuItem(string Id);

      [DispId(2)]
      void PressContextButton(string Id);

      [DispId(32024)]
      void SetFocus();

      [DispId(6)]
      void SelectMenuItemByText(string strText);

      [DispId(32039)]
      bool Visualize(bool On, object InnerObject = null);

      [DispId(31194)]
      GuiCollection DumpState(string InnerObject);

      [DispId(14)]
      string GetButtonTooltip(int ButtonPos);

      [DispId(32029)]
      GuiComponent FindById(string Id, object Raise = null);

      [DispId(32026)]
      GuiComponent FindByName(string Name, string Type);

      [DispId(32034)]
      GuiComponent FindByNameEx(string Name, int Type);

      [DispId(32035)]
      GuiComponentCollection FindAllByName(string Name, string Type);

      [DispId(13)]
      bool GetButtonChecked(int ButtonPos);

      [DispId(12)]
      string GetButtonText(int ButtonPos);

      [DispId(11)]
      bool GetButtonEnabled(int ButtonPos);

      [DispId(10)]
      string GetButtonType(int ButtonPos);

      [DispId(9)]
      string GetButtonIcon(int ButtonPos);

      [DispId(8)]
      string GetButtonId(int ButtonPos);

      [DispId(32036)]
      GuiComponentCollection FindAllByNameEx(string Name, int Type);

      [DispId(5)]
      string GetMenuItemIdFromPosition(int Pos);
    }
  }
}
