using System;
using System.Runtime.InteropServices;
using SAPFEWSELib;

namespace SAP_API
{
  public class MyGuiCalendar
  {
    public interface ISapCalendar
    {
      [DispId(32000)]
      string Text { get; set; }

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

      [DispId(33700)]
      string SubType { get; }

      [DispId(33701)]
      GuiContextMenu CurrentContextMenu { get; }

      [DispId(33702)]
      int Handle { get; }

      [DispId(33703)]
      string AccDescription { get; }

      [DispId(33705)]
      GuiCollection OcxEvents { get; }

      [DispId(33706)]
      bool DragDropSupported { get; }

      [DispId(1)]
      string FocusDate { get; set; }

      [DispId(2)]
      string FirstVisibleDate { get; set; }

      [DispId(3)]
      string SelectionInterval { get; set; }

      [DispId(17)]
      int horizontal { get; }

      [DispId(18)]
      string startSelection { get; }

      [DispId(19)]
      string endSelection { get; }

      [DispId(22)]
      string Today { get; }

      [DispId(32004)]
      int Top { get; }

      [DispId(32003)]
      int Left { get; }

      [DispId(25)]
      int FocusedElement { get; set; }

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

      [DispId(24)]
      string LastVisibleDate { get; set; }

      [DispId(32068)]
      void ShowContextMenu();

      [DispId(34100)]
      void SelectContextMenuItem(string FunctionCode);

      [DispId(34101)]
      void SelectContextMenuItemByText(string Text);

      [DispId(34102)]
      void SelectContextMenuItemByPosition(string PositionDesc);

      [DispId(5)]
      void ContextMenu(int CtxMenuId, int CtxMenuCellRow, int CtxMenuCellCol, string DateBegin, string DateEnd);

      [DispId(32024)]
      void SetFocus();

      [DispId(14)]
      void SelectWeek(int week, int year);

      [DispId(15)]
      void SelectRange(string from, string to);

      [DispId(13)]
      void SelectMonth(int month, int year);

      [DispId(12)]
      string CreateDate(int day, int month, int year);

      [DispId(32039)]
      bool Visualize(bool On, object InnerObject = null);

      [DispId(31194)]
      GuiCollection DumpState(string InnerObject);

      [DispId(23)]
      string GetDateTooltip(string date);

      [DispId(32029)]
      GuiComponent FindById(string Id, object Raise = null);

      [DispId(32026)]
      GuiComponent FindByName(string Name, string Type);

      [DispId(32034)]
      GuiComponent FindByNameEx(string Name, int Type);

      [DispId(32035)]
      GuiComponentCollection FindAllByName(string Name, string Type);

      [DispId(21)]
      string GetColorInfo(int Color);

      [DispId(20)]
      int IsWeekend(string date);

      [DispId(16)]
      int GetColor(string from);

      [DispId(7)]
      int GetWeekNumber(string date);

      [DispId(8)]
      int GetDay(string date);

      [DispId(10)]
      int GetYear(string date);

      [DispId(11)]
      string GetWeekday(string date);

      [DispId(32036)]
      GuiComponentCollection FindAllByNameEx(string Name, int Type);

      [DispId(9)]
      int GetMonth(string date);
    }
  }
}
